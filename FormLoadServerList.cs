using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisGuiManager
{
    public partial class FormLoadServerList : Form
    {
        private const string recent_json_filename = "recent.json";
        private const int ItemMargin = 5;

        public string SelectedPath { get; set; }

        public class workspace_desc
        {
            public workspace_desc(string path)
			{
                WorkspacePath = path;
			}

            public string WorkspacePath { get; set; }
            public string Name
            {
                get
                {
                    return Path.GetFileNameWithoutExtension(WorkspacePath);
                }
            }

            public override string ToString()
            {
                return $"{Name}\r\n  {WorkspacePath}\r\n\r\n";
            }
        }

        public FormLoadServerList()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
                checkBox_darkmode.Checked = true;
            }

            this.DialogResult = DialogResult.Cancel;
        }

		private void FormLoadServerList_Load(object sender, EventArgs e)
		{
            LoadRecent();
        }

        public void LoadRecent()
		{
			if (File.Exists(recent_json_filename) == false)
			{
				return;
			}

			string json_file = File.ReadAllText(recent_json_filename, Encoding.UTF8);
			var json_parsed = JArray.Parse(json_file);
			foreach (var j in json_parsed)
			{
                if (File.Exists(j.ToString()))
				{
                    listBox_recent.Items.Add(new workspace_desc(j.ToString()));
                }
			}
		}

        public void SaveRecent(string selected_path)
		{
            selected_path = Path.GetFullPath(selected_path);
            foreach (var item in listBox_recent.Items)
			{
                var wd_temp = item as workspace_desc;
                if (wd_temp.WorkspacePath == selected_path)
				{
                    listBox_recent.Items.Remove(wd_temp);
                    break;
				}
			}

            var wd = new workspace_desc(selected_path.ToString());
            listBox_recent.Items.Insert(0, wd);

            List<string> recent_list = new List<string>();
            foreach (var item in listBox_recent.Items)
			{
                var wd_temp = item as workspace_desc;
                recent_list.Add(wd_temp.WorkspacePath);
            }

			try
			{
				string save_string = JsonConvert.SerializeObject(recent_list).ToString();
				save_string = JsonConvert.DeserializeObject(save_string).ToString();

				File.WriteAllText(recent_json_filename, save_string);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void button_open_json_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("connections") == false)
            {
                Directory.CreateDirectory("connections");
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Redis server list (*.json)|*.json";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Application.StartupPath + "\\connections";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            SelectedPath = ofd.FileName;

            this.DialogResult = DialogResult.OK;

            SaveRecent(SelectedPath);

            this.Close();
        }

        private void button_new_server_list_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("connections") == false)
            {
                Directory.CreateDirectory("connections");
            }

            using (FormInputString formInput = new FormInputString())
            {
                formInput.TextInfo = "Insert new workspace name";
                formInput.InputValue = "";

                if (formInput.ShowDialog() == DialogResult.OK &&
                    formInput.InputValue != "")
                {
                    SelectedPath = $"connections/{formInput.InputValue}.json";

                    if (File.Exists(SelectedPath))
					{
                        MessageBox.Show($"{formInput.InputValue} is already exist");
                        return;
					}

                    foreach (var c in System.IO.Path.GetInvalidPathChars())
					{
                        if (SelectedPath.Contains(c))
						{
                            MessageBox.Show($"{formInput.InputValue} is invalid filename");
                            return;
						}
                    }

                    try
                    {
                        File.WriteAllText(SelectedPath, "[\n]\n", Encoding.UTF8);
                    }
                    catch (Exception ex)
					{
                        MessageBox.Show(ex.Message);
                        return;
					}

                    this.DialogResult = DialogResult.OK;

                    SaveRecent(SelectedPath);

                    this.Close();
                }
            }
        }

        private void checkBox_darkmode_CheckedChanged(object sender, EventArgs e)
        {
            Config.darkmode = checkBox_darkmode.Checked ? 1 : 0;
        }

		private void listBox_recent_DoubleClick(object sender, EventArgs e)
		{
			if (listBox_recent.SelectedItems.Count == 0)
			{
				return;
			}

			workspace_desc wd = listBox_recent.SelectedItems[0] as workspace_desc;
			SelectedPath = wd.WorkspacePath;

			this.DialogResult = DialogResult.OK;

			SaveRecent(SelectedPath);

			this.Close();
		}

		private void listBox_recent_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			if (e.Index == -1)
			{
				return;
			}

			ListBox lst = sender as ListBox;
			string txt = (string)lst.Items[e.Index].ToString();

			SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

			e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
			e.ItemWidth = (int)txt_size.Width;
		}

		private void listBox_recent_DrawItem(object sender, DrawItemEventArgs e)
		{
            if (e.Index == -1)
			{
                return;
			}

			ListBox lst = sender as ListBox;
			string txt = (string)lst.Items[e.Index].ToString();

			e.DrawBackground();

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e.Graphics.DrawString(txt, lst.Font, SystemBrushes.HighlightText, e.Bounds.Left, e.Bounds.Top + ItemMargin);
			}
			else
			{
				using (SolidBrush br = new SolidBrush(e.ForeColor))
				{
					e.Graphics.DrawString(txt, lst.Font, br, e.Bounds.Left, e.Bounds.Top + ItemMargin);
				}
			}

			e.DrawFocusRectangle();
		}
	}
}
