using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RedisGuiManager
{
    public partial class SetValueControl : UserControl
    {
        private DataGridViewRow selectRow = null;
        private string stringKeyName = string.Empty;
        private RedisClient redisClient = null;

        private int lastSearchIndex = -1;
        private string searchCondition = string.Empty;

        [Browsable(false)]
        public FormMain MainForm
        {
            set
            {
                keyOperateControl.MainForm = value;
            }
        }

        [Browsable(false)]
        public TreeNode TargetNode
        {
            set
            {
                keyOperateControl.TargetNode = value;
            }
        }

        public SetValueControl()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeControl(this);
            }
        }

        private void SetValueControl_Load(object sender, EventArgs e)
        {
            keyOperateControl.LoadValue.Click += LoadValue_Click;
            dataGridView_set.SelectionChanged += dataGridView_set_SelectionChanged;
            dataGridView_set.SizeChanged += dataGridView_set_SizeChanged;
            dataGridView_set_SizeChanged(null, null);
        }

        private void dataGridView_set_SizeChanged(object sender, EventArgs e)
        {
            dataGridView_set.Columns[1].Width = dataGridView_set.Width - 104;
        }

        private void LoadValue_Click(object sender, EventArgs e)
        {
            RefreshKey();
        }

        private void RefreshKey()
        {
            if (redisClient == null)
            {
                MessageBox.Show("Redis connection error");
                return;
            }

            var read = redisClient.Redis.SetMembers(stringKeyName);

            int size = 0;
            for (int i = 0; i < read.Length; i++)
            {
                size += Encoding.UTF8.GetBytes(read[i].ToString()).Length;
            }

            label_size.Text = "Size : " + Utils.GetSizeDescription(size);
            label_length_val.Text = read.Length.ToString();

            Utils.ControlDataGridViewRow(dataGridView_set, read.Length);
            for (int i = 0; i < read.Length; i++)
            {
                dataGridView_set.Rows[i].Cells[0].Value = i;
                dataGridView_set.Rows[i].Cells[1].Value = read[i].ToString();
            }
        }

        private void dataGridView_set_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_set.SelectedRows.Count > 0)
            {
                if (dataGridView_set.SelectedRows[0].Cells[1].Value != null)
                {
                    selectRow = dataGridView_set.SelectedRows[0];
                    string value = selectRow.Cells[1].Value.ToString();

                    valueControl.SetValue(value);
                    button_save.Enabled = true;
                }
            }
            else
            {
                valueControl.SetValue(string.Empty);
                button_save.Enabled = false;
            }
        }

        public void SetNewKey(RedisClient redisClient, string key)
        {
            if (key != stringKeyName)
            {
                valueControl.SetValue(string.Empty);
            }

            this.redisClient = redisClient;
            stringKeyName = key;

            dataGridView_set.SelectionChanged -= dataGridView_set_SelectionChanged;

            keyOperateControl.SetRedisClient(redisClient, key);
            RefreshKey();

            dataGridView_set.SelectionChanged += dataGridView_set_SelectionChanged;
        }

        private void button_insert_row_Click(object sender, EventArgs e)
        {
            using (SetValueInsertForm form = new SetValueInsertForm(redisClient, stringKeyName))
            {
                form.ShowDialog();
                RefreshKey();
            }
        }

        private void button_delete_row_Click(object sender, EventArgs e)
        {
            if (dataGridView_set.SelectedRows.Count > 0)
            {
                if (dataGridView_set.SelectedRows[0].Cells[1].Value != null)
                {
                    if (MessageBox.Show(string.Format("Delete Key:{0}", stringKeyName), "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (redisClient.Redis.SetRemove(stringKeyName, dataGridView_set.SelectedRows[0].Cells[1].Value.ToString()))
                        {
                            MessageBox.Show("Delete row success");
                            RefreshKey();
                        }
                        else
                        {
                            MessageBox.Show("Delete row fail");
                        }
                    }
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshKey();
        }

        private void dataGridView_set_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value.ToString().Length > 10000)
                {
                    e.Value = e.Value.ToString().Substring(0, 10000);
                }
            }
        }

        private void dataGridView_set_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                dataGridView_set.Rows[e.RowIndex].Selected = true;

                Rectangle cellRect = dataGridView_set.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point ptLoc = new Point(cellRect.Left + e.Location.X, cellRect.Top + e.Location.Y);

                show_context_menu(dataGridView_set, ptLoc);
            }
        }

        private void show_context_menu(Control c, Point p)
        {
            ContextMenu contextMenu = new ContextMenu();
            Menu.MenuItemCollection m = contextMenu.MenuItems;
            m.Add(new MenuItem("Json viewer", new EventHandler(this.CM_json_viewer)));

            contextMenu.Show(c, p);
        }

        private void CM_json_viewer(object o, EventArgs e)
        {
            FormJsonViewer fjv = new FormJsonViewer();
            fjv.Show();
            fjv.JsonText = dataGridView_set.SelectedRows[0].Cells[1].Value.ToString();
        }

		private void button_save_Click(object sender, EventArgs e)
		{
			if (dataGridView_set.SelectedRows.Count <= 0)
			{
				return;
			}

			string save_text = valueControl.EditedValue();
			if (ValueControl.GetDisplayType() == ValueControl.DisplayType.Json)
			{
				try
				{
					save_text = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(save_text), Formatting.None);
				}
				catch (JsonReaderException)
				{
				}
			}

            redisClient.Redis.SetRemove(stringKeyName, selectRow.Cells[1].Value.ToString());
            redisClient.Redis.SetAdd(stringKeyName, save_text);

            RefreshKey();
        }

		private void search_field_loop()
        {
            string search_text = textBox_search.Text;

            if (string.IsNullOrEmpty(search_text))
            {
                return;
            }

            if (string.IsNullOrEmpty(searchCondition))
            {
                searchCondition = search_text;
            }
            else
            {
                if (searchCondition != search_text)
                {
                    lastSearchIndex = -1;
                    searchCondition = search_text;
                }
            }

            foreach (DataGridViewRow row in dataGridView_set.Rows)
            {
                row.Visible = true;
            }

            for (int i = lastSearchIndex + 1; i < dataGridView_set.Rows.Count; ++i)
            {
                foreach (DataGridViewCell cell in dataGridView_set.Rows[i].Cells)
                {
                    if (cell.Value.ToString().ToLower().Contains(search_text.ToLower()))
                    {
                        dataGridView_set.Rows[i].Selected = true;
                        dataGridView_set.CurrentCell = dataGridView_set.Rows[i].Cells[0];
                        lastSearchIndex = i;

                        return;
                    }
                }
            }

            // 못 찾으면 처음 부터 한번더 돌아 봄
            for (int i = 0; i < dataGridView_set.Rows.Count; ++i)
            {
                foreach (DataGridViewCell cell in dataGridView_set.Rows[i].Cells)
                {
                    if (cell.Value.ToString().ToLower().Contains(search_text.ToLower()))
                    {
                        dataGridView_set.Rows[i].Selected = true;
                        dataGridView_set.CurrentCell = dataGridView_set.Rows[i].Cells[0];

                        if (lastSearchIndex == i)
                        {
                            dataGridView_set.CurrentCell = dataGridView_set.Rows[i].Cells[1];
                            dataGridView_set.CurrentCell = dataGridView_set.Rows[i].Cells[0];
                        }

                        lastSearchIndex = i;

                        return;
                    }
                }
            }
        }

        private void search_field_grep()
        {
            string search_text = textBox_search.Text;

            if (string.IsNullOrEmpty(search_text))
            {
                foreach (DataGridViewRow row in dataGridView_set.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView_set.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().ToLower().Contains(search_text.ToLower()))
                        {
                            row.Visible = true;
                            break;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

                dataGridView_set.ClearSelection();
            }
        }

        private void textBox_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (dataGridView_set.Rows.Count <= 0)
            {
                return;
            }

            if (checkBox_search_grep.Checked)
            {
                search_field_grep();
            }
            else
            {
                search_field_loop();
            }
        }
	}
}
