using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using StackExchange.Redis;
using Microsoft.VisualBasic.CompilerServices;
using System.Net;

namespace RedisGuiManager
{
    public partial class FormMain : Form
    {
        private List<RedisGroup> redis_group = new List<RedisGroup>();
        private List<RedisSettings> redis_settings = new List<RedisSettings>();
        private UserControl userControl = null;
        private string ServerListPath = "";
        private bool is_shown = false;

        public FormMain()
        {
            InitializeComponent();

            contextMenuStrip_redis.Items.Remove(remove_keys_from_registered_dbs_ToolStripMenuItem);

			Config.Load();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreateRedisShowTagControl<StartControl>();

            FormLoadServerList flsl = new FormLoadServerList();
            if (flsl.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }

            LoadRedisServerList(flsl.SelectedPath);
        }

        private void ClearAll()
        {
            foreach (TreeNode item in treeView_server.Nodes)
            {
                if (item != null)
                {
                    if (item.Tag is RedisClient client)
                    {
                        if (client.Redis != null)
                        {
                            client.Close();
                        }
                    }
                }
            }

            redis_group.Clear();
            redis_settings.Clear();
            treeView_server.Nodes.Clear();
        }

        private void LoadRedisServerList(string path)
        {
            ClearAll();

            ServerListPath = path;
            this.Text = string.Format("Redis Gui Manager ({0})", Path.GetFileNameWithoutExtension(ServerListPath));

            string json_file = File.ReadAllText(ServerListPath, Encoding.UTF8);
            var json_parsed = JArray.Parse(json_file);
            foreach (var j in json_parsed)
            {
                if (j.SelectToken("$.type") != null)
                {
                    RedisGroup group = j.ToObject<RedisGroup>();
                    redis_group.Add(group);
                }
                else
                {
                    RedisSettings setting = j.ToObject<RedisSettings>();
                    redis_settings.Add(setting);
                }
            }

            foreach (var group in redis_group)
            {
                foreach (var settings in group.connections)
                {
                    settings.redis_client = new RedisClient(settings);
                }
            }

            foreach (var settings in redis_settings)
            {
                settings.redis_client = new RedisClient(settings);
            }

            LoadRedisSettings();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            int x = Config.mainform_pos_x;
            int y = Config.mainform_pos_y;
            int wt = Screen.FromPoint(this.Location).WorkingArea.Top;
            int wr = Screen.FromPoint(this.Location).WorkingArea.Right;
            int wb = Screen.FromPoint(this.Location).WorkingArea.Bottom;
            int wl = Screen.FromPoint(this.Location).WorkingArea.Left;

            foreach (Screen screen in Screen.AllScreens)
            {
                wl = screen.WorkingArea.Left < wl ? screen.WorkingArea.Left : wl;
                wr = screen.WorkingArea.Right > wr ? screen.WorkingArea.Right : wr;
                wt = screen.WorkingArea.Top < wt ? screen.WorkingArea.Top : wt;
                wb = screen.WorkingArea.Bottom > wb ? screen.WorkingArea.Bottom : wb;
            }

            if (x < wl)
            {
                x = wl;
            }
            else if (x > wr - this.Width)
            {
                x = wr - this.Width;
            }

            if (y < wt)
            {
                y = wt;
            }
            else if (y > wb - this.Height)
            {
                y = wb - this.Height;
            }

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            this.Width = Config.mainform_width;
            this.Height = Config.mainform_height;
            if (Config.mainform_is_maximized > 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            is_shown = true;

            treeView_server.SelectedNode = null;

            treeView_server.AfterSelect += treeView_server_AfterSelect;
            treeView_server.MouseDown += treeView_server_MouseDown;
            treeView_server.MouseUp += treeView_server_MouseUp;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.mainform_is_maximized = (WindowState == FormWindowState.Maximized) ? 1 : 0;

            if (WindowState == FormWindowState.Normal)
            {
                Config.mainform_pos_x = Location.X;
                Config.mainform_pos_y = Location.Y;
                Config.mainform_width = Width;
                Config.mainform_height = Height;
            }

            Config.Save();

            ClearAll();
        }

        private void add_db_to_list_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is not RedisClient)
			{
				return;
			}

			using (FormInputString formInput = new FormInputString())
			{
				formInput.TextInfo = "Add DB";
				formInput.InputValue = "";

				if (formInput.ShowDialog() == DialogResult.OK)
				{
                    string[] seps = formInput.InputValue.Split(' ');
                    List<int> db_nums = new List<int>();

                    foreach (string s in seps)
					{
                        if (int.TryParse(s, out int dbNum))
                        {
                            db_nums.Add(dbNum);
                        }
                    }

                    if (db_nums.Count > 0)
					{
                        add_dbs_to_list(db_nums, select);
                    }
				}
			}
		}

        private void add_db_range_to_list_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is not RedisClient)
			{
				return;
			}

			using (FormTwoInputString formInput = new FormTwoInputString())
			{
				formInput.TextInfo = "Add DB Range";
				formInput.InputValue1 = "";
				formInput.InputValue2 = "";

				if (formInput.ShowDialog() == DialogResult.OK)
				{
                    int dbNumStart = 0;
                    int dbNumEnd = 0;

                    if (int.TryParse(formInput.InputValue1, out dbNumStart) == false)
					{
                        MessageBox.Show("Insert value1 number only");
                        return;
					}

					if (int.TryParse(formInput.InputValue2, out dbNumEnd) == false)
					{
						MessageBox.Show("Insert value2 number only");
						return;
					}

                    if (dbNumStart > dbNumEnd)
					{
                        int temp = dbNumStart;
                        dbNumStart = dbNumEnd;
                        dbNumEnd = temp;
					}

                    List<int> db_nums = new List<int>();
                    for (int i = dbNumStart; i <= dbNumEnd; ++i)
					{
                        db_nums.Add(i);
					}

                    add_dbs_to_list(db_nums, select);
                }
			}
		}

        private void add_dbs_to_list(List<int> db_nums, TreeNode select)
		{
			if (select.Tag is RedisClient client)
			{
				foreach (int db_num in db_nums)
				{
					if (AddTreeNode_DB(client, db_num, select, false))
					{
						if (client.Settings.additional_dbs == null)
						{
							client.Settings.additional_dbs = new List<int>();
						}

						client.Settings.additional_dbs.Add(db_num);
					}
				}

				client.Settings.additional_dbs.Sort();

				SaveRedisSettings();
			}
		}

        private void remove_db_range_from_list_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is not RedisClient)
			{
				return;
			}

			using (FormTwoInputString formInput = new FormTwoInputString())
			{
				formInput.TextInfo = "Remove DB Range";
				formInput.InputValue1 = "";
				formInput.InputValue2 = "";

				if (formInput.ShowDialog() == DialogResult.OK)
				{
					int dbNumStart = 0;
					int dbNumEnd = 0;

					if (int.TryParse(formInput.InputValue1, out dbNumStart) == false)
					{
						MessageBox.Show("Insert value1 number only");
						return;
					}

					if (int.TryParse(formInput.InputValue2, out dbNumEnd) == false)
					{
						MessageBox.Show("Insert value2 number only");
						return;
					}

					if (dbNumStart > dbNumEnd)
					{
						int temp = dbNumStart;
						dbNumStart = dbNumEnd;
						dbNumEnd = temp;
					}

					if (select.Tag is RedisClient client)
					{
						for (int i = dbNumStart; i <= dbNumEnd; ++i)
						{
							client.Settings.additional_dbs.Remove(i);
						}

						client.Settings.additional_dbs.Sort();

						SaveRedisSettings();
					}

                    RefreshRedisKey(select, true);
                }
			}
		}

        private void find_db_from_list_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is not RedisClient)
			{
				return;
			}

			using (FormInputString formInput = new FormInputString())
			{
				formInput.TextInfo = "Find DB";
				formInput.InputValue = "";

				if (formInput.ShowDialog() == DialogResult.OK)
				{
					if (int.TryParse(formInput.InputValue, out int dbNum))
					{
						if (select.Tag is RedisClient client)
						{
                            TreeNode node = GetTreeNode_DB(dbNum, select);
                            if (node != null)
							{
                                treeView_server.SelectedNode = node;
							}
						}
					}
					else
					{
						MessageBox.Show("Insert number only");
					}
				}
			}
		}

        private void toggle_show_default_dbs_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

            if (select.Tag is RedisClient client)
			{
                client.Settings.hide_default_dbs = !client.Settings.hide_default_dbs;

				SaveRedisSettings();

				RefreshRedisKey(select, true);
			}
        }

        private void remove_keys_from_registered_dbs_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is RedisClient client)
			{
				if (client.RedisServer == null)
				{
					OperateResult connect = client.Connect();
					if (connect.IsSuccess == false)
					{
						MessageBox.Show("Connection failed");
						return;
					}
				}

				using (FormInputString formInput = new FormInputString())
				{
					formInput.TextInfo = "Delete keys from DBs";
					formInput.InputValue = "";

					if (formInput.ShowDialog() == DialogResult.OK &&
                        formInput.InputValue != "")
					{
                        List<int> db_nums = new List<int>();

						for (int i = 0; i < 16; ++i)
						{
                            db_nums.Add(i);
						}

                        foreach (int i in client.Settings.additional_dbs)
						{
                            db_nums.Add(i);
                        }

                        int deleted_count = 0;
                        foreach (int db_num in db_nums)
						{
                            var reads = client.RedisServer.Keys(db_num, formInput.InputValue, Config.scan_page_count);
                            var database = client.GetDB(db_num);

							foreach (var key in reads)
							{
								database.KeyDelete(key.ToString());
                                ++deleted_count;
                            }
						}

                        RefreshRedisKey(select, true);

                        MessageBox.Show($"Delete keys complete.\r\n\r\nserver : {$"{select.Text} ({client.Settings.host}:{client.Settings.port})"}\r\npattern : {formInput.InputValue}\r\ndeleted count : {deleted_count}");
					}
				}
			}
		}

        private void remove_keys_from_whole_dbs_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is RedisClient client)
			{
                if (client.RedisServer == null)
				{
					OperateResult connect = client.Connect();
					if (connect.IsSuccess == false)
					{
						MessageBox.Show("Connection failed");
						return;
					}
				}

				using (FormInputString formInput = new FormInputString())
				{
					formInput.TextInfo = "Delete keys from DBs";
					formInput.InputValue = "";

					if (formInput.ShowDialog() == DialogResult.OK &&
						formInput.InputValue != "")
					{
						int deleted_count = 0;
						for (int db_num = 0; db_num < client.RedisServer.DatabaseCount; ++db_num)
						{
							var reads = client.RedisServer.Keys(db_num, formInput.InputValue, Config.scan_page_count);
							var database = client.GetDB(db_num);

							foreach (var key in reads)
							{
								database.KeyDelete(key.ToString());
								++deleted_count;
							}
						}

						RefreshRedisKey(select, true);

						MessageBox.Show($"Delete keys complete.\r\n\r\nserver : {$"{select.Text} ({client.Settings.host}:{client.Settings.port})"}\r\ndb range : 0 ~ {client.RedisServer.DatabaseCount - 1}\r\npattern : {formInput.InputValue}\r\ndeleted count : {deleted_count}");
					}
				}
			}
		}

        private void reload_server_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient)
            {
                RefreshRedisKey(select, true);
            }
        }

        private void query_window_all_server_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient client)
            {
				if (client.RedisServer == null)
				{
					OperateResult connect = client.Connect();
					if (connect.IsSuccess == false)
					{
						MessageBox.Show("Connection failed");
						return;
					}
				}

				FormQueryWindow fqw = new FormQueryWindow();
				fqw.SetServerInfo(client, -1);
				fqw.Show();
			}
        }

        private void open_console_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient client)
            {
                FormConsole formConsole = new FormConsole();
                formConsole.SetRedis(client);
                formConsole.Show();
            }
        }

        private void edit_connection_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient client)
            {
                using (FormRedisAdd form = new FormRedisAdd(client.Settings))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (client.Redis != null)
                        {
                            client.Close();
                            client.Redis = null;
                        }

                        client.Settings = form.Settings;

                        SaveRedisSettings();

                        RefreshRedisKey(select, true);
                    }
                }
            }
        }

        private void disconnect_connection_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient client)
            {
                if (client.Redis != null)
                {
                    client.Close();
                }

                client.Redis = null;
                select.Nodes.Clear();
            }
        }

        private void delete_connection_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is RedisClient client)
            {
                if (client != null && client.Redis != null)
                {
                    client.Close();
                }

                RemoveServer(client);

                SaveRedisSettings();

                treeView_server.Nodes.Remove(select);
            }
        }

        private void new_key_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            RedisClient redisClient = select.Parent.Tag as RedisClient;
            if (redisClient == null)
            {
                MessageBox.Show("Invalid redis setting");

                return;
            }

            if (select.Tag is DbSettings dbSettings)
            {
                var db = redisClient.GetDB(dbSettings.DBNumber);
                using (FormRedisInput redisInput = new FormRedisInput(db))
                {
                    redisInput.ShowDialog();
                    RefreshDbKeys(select, true);
                }
            }
        }

        private void reload_keys_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is DbSettings)
            {
                RefreshDbKeys(select, true);
            }
        }

        private void filter_key_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is DbSettings dbSettings)
            {
                using (FormInputString formInput = new FormInputString())
                {
                    formInput.TextInfo = "Filter";
                    formInput.InputValue = dbSettings.Filter;

                    if (formInput.ShowDialog() == DialogResult.OK)
                    {
                        dbSettings.Filter = formInput.InputValue == "" ? "*" : formInput.InputValue;
                        FilterKeys(select);
                        select.ExpandAll();
                    }
                }
            }
        }

        private void unfilter_key_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is DbSettings dbSettings)
            {
                dbSettings.Filter = "*";
                FilterKeys(select);
                select.ExpandAll();
            }
        }

        private void remove_keys_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

            if (select.Tag is DbSettings dbSettings)
			{
				using (FormInputString formInput = new FormInputString())
				{
					formInput.TextInfo = "Delete keys";
					formInput.InputValue = "";

					if (formInput.ShowDialog() == DialogResult.OK &&
                        formInput.InputValue != "")
					{
                        RedisClient redisClient = select.Parent.Tag as RedisClient;
                        var reads = redisClient.RedisServer.Keys(dbSettings.DBNumber, formInput.InputValue, Config.scan_page_count);
                        var database = redisClient.GetDB(dbSettings.DBNumber);

                        int deleted_count = 0;
                        foreach (var key in reads)
						{
                            database.KeyDelete(key.ToString());
                            ++deleted_count;
						}

                        RefreshDbKeys(select, true);

                        MessageBox.Show($"Delete keys complete.\r\n\r\nserver : {$"{select.Parent.Text} ({redisClient.Settings.host}:{redisClient.Settings.port})"}\r\ndb num : {dbSettings.DBNumber}\r\npattern : {formInput.InputValue}\r\ndeleted count : {deleted_count}");
                    }
				}
			}
        }

        private void remove_db_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is DbSettings dbSettings)
			{
                RedisClient redisClient = select.Parent.Tag as RedisClient;
                redisClient.Settings.additional_dbs.Remove(dbSettings.DBNumber);

				SaveRedisSettings();

				RefreshRedisKey(select.Parent, true);
			}
        }

        private void queryWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is DbSettings dbSettings)
            {
                RedisClient redisClient = select.Parent.Tag as RedisClient;

                FormQueryWindow fqw = new FormQueryWindow();
                fqw.SetServerInfo(redisClient, dbSettings.DBNumber);
                fqw.Show();
            }
        }

        // Tree view action
        private void treeView_server_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView_server.AfterSelect -= treeView_server_AfterSelect;

                TreeNode node = treeView_server.GetNodeAt(e.Location);
                if (treeView_server.SelectedNode != node)
                {
                    treeView_server.SelectedNode = node;
                }

                treeView_server.AfterSelect += treeView_server_AfterSelect;

                TreeNode select = treeView_server.SelectedNode;
                if (select == null)
                {
                    return;
                }

                if (select.Tag is DbSettings)
                {
                    contextMenuStrip_db.Show(treeView_server, e.Location);
                }
                else if (select.Tag is RedisClient)
                {
                    contextMenuStrip_redis.Show(treeView_server, e.Location);
                }
                else if (select.Tag is RedisFolder)
                {
                    contextMenuStrip_class.Show(treeView_server, e.Location);
                }
                else if (select.Tag is RedisKey)
                {
                    if (select.Text.Contains("  (Deleted)") == false)
                    {
                        contextMenuStrip_key.Show(treeView_server, e.Location);
                    }
                }
            }
        }

        private void treeView_server_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool is_same_node = false;
                TreeNode node = treeView_server.GetNodeAt(e.Location);
                if (treeView_server.SelectedNode != node)
                {
                    treeView_server.SelectedNode = node;
                }
                else
                {
                    is_same_node = true;
                }

                TreeNode select = treeView_server.SelectedNode;
                if (select == null)
                {
                    return;
                }

                if (is_same_node)
                {
                    treeView_server_AfterSelect(null, null);
                }

                if (select.IsExpanded)
                {
                    select.Collapse();
                }
                else
                {
                    select.Expand();
                }
            }
        }

        private void treeView_server_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;

            if (select.Tag is RedisGroup)
            {
                return;
            }

            var old_imagekey = select.ImageKey;
            select.ImageKey = "loading";
            select.SelectedImageKey = "loading";
            treeView_server.Invalidate(true);
            Application.DoEvents();

            if (select.Tag is RedisClient)
            {
                RefreshRedisKey(select);
            }
            else if (select.Tag is DbSettings)
            {
                RefreshDbKeys(select, false);
            }
            else if (select.Tag is RedisFolder)
            {
                BuildTreeNode_Folder(select);
            }
            else if (select.Tag is RedisKey)
            {
                if (select.Text.Contains("  (Deleted)") == false)
                {
                    TreeNode dbNode = GetDbNode(select);
                    TreeNode redisNode = GetRedisNode(select);

                    if (redisNode.Tag is RedisClient redisClient)
                    {
                        if (dbNode.Tag is DbSettings dbSettings)
                        {
                            if (redisClient.DBBlock != dbSettings.DBNumber)
                            {
                                OperateResult change = redisClient.SelectDB(dbSettings.DBNumber);
                                if (change.IsSuccess == false)
                                {
                                    select.ImageKey = old_imagekey;
                                    select.SelectedImageKey = old_imagekey;
                                    MessageBox.Show(string.Format("Select [{0}] DB {1} fail\r\n", redisClient.Settings.ToString(), dbSettings.DBNumber) + change.Message);

                                    return;
                                }

                                redisClient.DBBlock = dbSettings.DBNumber;
                            }

                            var type = redisClient.Redis.KeyType(select.Text);
                            switch (type)
                            {
                                case StackExchange.Redis.RedisType.String:
                                {
                                    StringKeySelect(redisClient, select);
                                }
                                break;
                                case StackExchange.Redis.RedisType.List:
                                {
                                    ListKeySelect(redisClient, select);
                                }
                                break;
                                case StackExchange.Redis.RedisType.Hash:
                                {
                                    HashKeySelect(redisClient, select);
                                }
                                break;
                                case StackExchange.Redis.RedisType.Set:
                                {
                                    SetKeySelect(redisClient, select);
                                }
                                break;
                                case StackExchange.Redis.RedisType.SortedSet:
                                {
                                    ZSetKeySelect(redisClient, select);
                                }
                                break;
                                default:
                                {
                                    MessageBox.Show($"key {select.Text} is not exist");
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (userControl == null || (userControl as StartControl) == null)
                    {
                        CreateRedisShowTagControl<StartControl>();
                    }
                }
            }

            select.ImageKey = old_imagekey;
            select.SelectedImageKey = old_imagekey;
        }

        private TreeNode GetRedisNode(TreeNode treeNode)
        {
            if (treeNode.Tag is RedisClient)
            {
                return treeNode;
            }

            return GetRedisNode(treeNode.Parent);
        }

        private TreeNode GetDbNode(TreeNode treeNode)
        {
            if (treeNode.Tag is DbSettings)
            {
                return treeNode;
            }

            return GetDbNode(treeNode.Parent);
        }

        private TreeNode GetDbNodeFromRedisNode(TreeNode redisNode, int db_num)
		{
            if (redisNode.Tag is not RedisClient)
			{
                return null;
			}

            foreach (TreeNode node in redisNode.Nodes)
			{
                if (node.Tag is DbSettings dbSettings)
				{
                    if (dbSettings.DBNumber == db_num)
					{
                        return node;
					}
				}
			}

            return null;
		}

        private string GetFullpathFolder(TreeNode treeNode, string path)
        {
            if (treeNode.Tag is DbSettings)
            {
                return path.Substring(1);
            }
			else if (treeNode.Tag is RedisFolder redis_folder)
			{
				path = ":" + redis_folder.path_name + path;
			}

			return GetFullpathFolder(treeNode.Parent, path);
        }

        private void FilterKeys(TreeNode select)
        {
            if (select.Tag is DbSettings dbSettings)
            {
                select.Nodes.Clear();

                var filter_list_keys = dbSettings.Keys.ToList();

                if (dbSettings.Filter != "" &&
                    dbSettings.Filter != "*")
                {
                    filter_list_keys = filter_list_keys.Where(s => Utils.RedisGlobMatch(dbSettings.Filter, s)).ToList();
                    select.Text = string.Format("db{0} ({1}) [{2}]", dbSettings.DBNumber, filter_list_keys.Count(), dbSettings.Filter);
                }
                else
                {
                    select.Text = string.Format("db{0} ({1})", dbSettings.DBNumber, filter_list_keys.Count());
                }

                BuildTreeNode_DB(select, filter_list_keys);
            }
        }

        // Refresh key
        private void RefreshRedisKey(TreeNode select, bool reload = false)
        {
            if (select.Tag is RedisClient redisClient)
            {
                if (reload)
                {
                    select.Nodes.Clear();
                }

                if (redisClient.Redis == null)
                {
                    try
                    {
                        redisClient.Connect();
                        // If connection is successful, ensure the icon is normal
                        select.ImageKey = "VirtualMachine";
                        select.SelectedImageKey = "VirtualMachine";
                    }
                    catch (RedisConnectionFailedException ex)
                    {
                        string errorMessage = string.Format(
                            "Failed to connect to Redis server: {0} ({1}:{2})\r\n\r\nDetails: {3}",
                            redisClient.Settings.name,
                            redisClient.Settings.host,
                            redisClient.Settings.port,
                            ex.InnerException != null ? ex.InnerException.Message : ex.Message
                        );
                        MessageBox.Show(errorMessage, "Redis Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        select.ImageKey = "disconnect"; // Assuming "disconnect" image key
                        select.SelectedImageKey = "disconnect";
                        return; // Exit the method as connection failed
                    }
                    catch (Exception ex) // Catch any other unexpected exceptions during connect
                    {
                        string errorMessage = string.Format(
                            "An unexpected error occurred while connecting to Redis server: {0} ({1}:{2})\r\n\r\nDetails: {3}",
                            redisClient.Settings.name,
                            redisClient.Settings.host,
                            redisClient.Settings.port,
                            ex.Message
                        );
                        MessageBox.Show(errorMessage, "Redis Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        select.ImageKey = "disconnect"; // Assuming "disconnect" image key
                        select.SelectedImageKey = "disconnect";
                        return; // Exit the method
                    }
                }
                else
                {
                    // If already connected, ensure the icon is normal
                    select.ImageKey = "VirtualMachine";
                    select.SelectedImageKey = "VirtualMachine";
                }

                if (select.Nodes.Count == 0 || reload)
                {
                    if (redisClient.Settings.hide_default_dbs == false)
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            AddTreeNode_DB(redisClient, i, select);
                        }
                    }

                    if (redisClient.Settings.additional_dbs != null)
					{
                        redisClient.Settings.additional_dbs.Sort();
                        foreach (int dbNum in redisClient.Settings.additional_dbs)
						{
                            AddTreeNode_DB(redisClient, dbNum, select);
						}
					}

                    if (redisClient.SelectDB(0).IsSuccess)
                    {
                        redisClient.DBBlock = 0;
                    }
                }
            }
        }

        private void RefreshDbKeys(TreeNode select, bool reload = false)
        {
            if (select.Tag is DbSettings dbSettings)
            {
                RedisClient redisClient = select.Parent.Tag as RedisClient;
                int dbBlock = dbSettings.DBNumber;

                if (redisClient == null)
                {
                    MessageBox.Show("Invalid redis setting");

                    return;
                }

                if (redisClient.Redis == null)
                {
                    MessageBox.Show("Redis connection is gone");

                    return;
                }

                if (reload)
                {
                    select.Nodes.Clear();
                }

                if (select.Nodes.Count == 0)
                {
                    int dbBlockOld = redisClient.DBBlock;

                    if (redisClient.DBBlock != dbBlock)
                    {
                        OperateResult selectDb = redisClient.SelectDB(dbBlock);
                        if (selectDb.IsSuccess == false)
                        {
                            MessageBox.Show(string.Format("Select [{0}] DB {1} fail", redisClient.Settings.name, dbBlock));
                            return;
                        }

                        redisClient.DBBlock = dbBlock;
                    }

                    var reads = redisClient.RedisServer.Keys(dbBlock, "*", Config.scan_page_count);
                    int keyCount = reads.Count();

                    List<string> list_keys = new List<string>();
                    foreach (var item in reads)
                    {
                        list_keys.Add(item.ToString());
                    }

                    dbSettings.Keys = list_keys;
                    select.Text = string.Format("db{0} ({1})", dbBlock, keyCount);

                    BuildTreeNode_DB(select, list_keys);

                    if (dbBlockOld != redisClient.DBBlock)
                    {
                        OperateResult selectDb = redisClient.SelectDB(dbBlockOld);
                        if (selectDb.IsSuccess == false)
                        {
                            MessageBox.Show(string.Format("Select [{0}] DB {1} fail", redisClient.Settings.name, dbBlockOld));

                            return;
                        }

                        redisClient.DBBlock = dbBlockOld;
                    }
                }
            }
        }

        private void BuildTreeNode_Folder(TreeNode parent)
        {
            if (parent.Tag is RedisFolder redis_folder)
            {
                if (parent.Nodes.Count > 0)
                {
                    return;
                }

                var qry = redis_folder.sub_items.
                Select(c => new
                {
                    SplitArray = c.Key.Split(':'),
                    Value = c
                }).
                Select(c => new
                {
                    Prefix = c.SplitArray.Length <= 1 ? "" : c.SplitArray.First(),
                    Postfix = c.Value.Key == "" ? "" :
                        (c.Value.Key.Replace(c.SplitArray.First(), "").Length > 0 && c.Value.Key.Replace(c.SplitArray.First(), "")[0] == ':') ?
                        c.Value.Key.Replace(c.SplitArray.First() + ":", "") :
                        c.Value.Key.Replace(c.SplitArray.First(), ""),
                    Value = c
                }).
                GroupBy(r => r.Prefix).
                Select(grp => new
                {
                    FolderName = grp.Key,
                    SubItems = grp.Count() > 1 ? grp.Select(t => new KeyValuePair<string, string>(t.Postfix, t.Value.Value.Value.ToString())) : null,
                    Value = grp.First().Value
                });

                List<TreeNode> list_folder_node = new List<TreeNode>();
                List<TreeNode> list_item_node = new List<TreeNode>();
                foreach (var item in qry)
                {
                    if (item.SubItems != null)
                    {
                        List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
                        foreach (var sub in item.SubItems)
						{
                            if (sub.Key == "")
							{
								TreeNode key_node = new TreeNode(sub.Value.ToString());
                                key_node.ImageKey = "keyword";
                                key_node.SelectedImageKey = "keyword";
                                key_node.Tag = new RedisKey();
								list_item_node.Add(key_node);
							}
                            else
							{
                                items.Add(sub);
							}
						}

                        // 폴더
                        int item_count = items.Count();
                        if (item_count > 0)
                        {
                            string node_name = $"{item.FolderName} ({item_count})";

                            RedisFolder folder = new RedisFolder();
                            folder.path_name = item.FolderName;
                            folder.sub_items = items;
                            folder.display_name = node_name;

                            TreeNode node = new TreeNode(node_name);
                            node.Tag = folder;
                            node.ImageKey = "Class_489";
                            node.SelectedImageKey = "Class_489";
                            list_folder_node.Add(node);
                        }
                    }
                    else
                    {
                        // 키
                        TreeNode node = new TreeNode(item.Value.Value.Value.ToString());
                        node.ImageKey = "keyword";
                        node.SelectedImageKey = "keyword";
                        node.Tag = new RedisKey();
                        list_item_node.Add(node);
                    }
                }

                list_folder_node.Sort((TreeNode x, TreeNode y) => x.Text.CompareTo(y.Text));
                list_item_node.Sort((TreeNode x, TreeNode y) => x.Text.CompareTo(y.Text));

                parent.Nodes.AddRange(list_folder_node.ToArray());
                parent.Nodes.AddRange(list_item_node.ToArray());
            }
        }

        private TreeNode GetTreeNode_DB(int dbNum, TreeNode select)
		{
			foreach (TreeNode node in select.Nodes)
			{
				if (node.Text.Contains($"db{dbNum} "))
				{
					return node;
				}
			}

			return null;
		}

        private bool HasTreeNode_DB(int dbNum, TreeNode select)
		{
            return GetTreeNode_DB(dbNum, select) != null;
		}

        private bool AddTreeNode_DB(RedisClient redisClient, int dbNum, TreeNode select, bool msg_box = true)
		{
            if (HasTreeNode_DB(dbNum, select))
			{
                return false;
			}

            try
            {
                var reads = redisClient.RedisServer.Keys(dbNum, "*", Config.scan_page_count);
                int keyCount = reads.Count();

                List<string> list_keys = new List<string>();
                foreach (var item in reads)
                {
                    if (item == "")
					{
                        continue;
					}

                    list_keys.Add(item.ToString());
                }

                TreeNode dbTree = new TreeNode(string.Format("db{0} ({1})", dbNum, keyCount));
                dbTree.ImageKey = "redis_db";
                dbTree.SelectedImageKey = "redis_db";
                dbTree.Tag = new DbSettings() { DBNumber = dbNum, Keys = list_keys };

                select.Nodes.Add(dbTree);

                BuildTreeNode_DB(dbTree, list_keys);
            }
            catch (RedisCommandException ex)
			{
                if (msg_box)
				{
                    MessageBox.Show(ex.Message);
                }

                return false;
			}

            return true;
		}

        private void BuildTreeNode_DB(TreeNode parent, List<string> keys)
        {
            if (parent.Nodes.Count > 0)
            {
                return;
            }

            var qry = keys.
            Select(c => new
            {
                SplitArray = c.Split(':'),
                Value = c
            }).
            Select(c => new
            {
                Prefix = c.SplitArray.Length <= 1 ? "" : c.SplitArray.First(),
                Postfix = c.Value == "" ? "" :
                    (c.Value.Replace(c.SplitArray.First(), "").Length > 0 && c.Value.Replace(c.SplitArray.First(), "")[0] == ':') ?
                    c.Value.Replace(c.SplitArray.First() + ":", "") :
                    c.Value.Replace(c.SplitArray.First(), ""),
                Value = c
            }).
            GroupBy(r => r.Prefix).
            Select(grp => new
            {
                FolderName = grp.Key,
                SubItems = grp.Count() > 1 ? grp.Select(t => new KeyValuePair<string, string>(t.Postfix, t.Value.Value.ToString())) : null,
                Value = grp.First().Value
            });

            List<TreeNode> list_folder_node = new List<TreeNode>();
            List<TreeNode> list_item_node = new List<TreeNode>();
            foreach (var item in qry)
            {
                if (item.SubItems != null)
                {
					List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
					foreach (var sub in item.SubItems)
					{
						if (sub.Key == "")
						{
							TreeNode key_node = new TreeNode(sub.Value.ToString());
							key_node.ImageKey = "keyword";
							key_node.SelectedImageKey = "keyword";
							key_node.Tag = new RedisKey();
							list_item_node.Add(key_node);
						}
						else
						{
							items.Add(sub);
						}
					}

					// 폴더
					int item_count = items.Count();
                    if (item_count > 0)
                    {
                        string node_name = $"{item.FolderName} ({item_count})";

                        RedisFolder folder = new RedisFolder();
                        folder.path_name = item.FolderName;
                        folder.sub_items = items;
                        folder.display_name = node_name;

                        TreeNode node = new TreeNode(node_name);
                        node.Tag = folder;
                        node.ImageKey = "Class_489";
                        node.SelectedImageKey = "Class_489";
                        list_folder_node.Add(node);
                    }
                }
                else
                {
                    // 키
                    TreeNode node = new TreeNode(item.Value.Value.ToString());
                    node.ImageKey = "keyword";
                    node.SelectedImageKey = "keyword";
                    node.Tag = new RedisKey();
                    list_item_node.Add(node);
                }
            }

            list_folder_node.Sort((TreeNode x, TreeNode y) => x.Text.CompareTo(y.Text));
            list_item_node.Sort((TreeNode x, TreeNode y) => x.Text.CompareTo(y.Text));

            parent.Nodes.AddRange(list_folder_node.ToArray());
            parent.Nodes.AddRange(list_item_node.ToArray());
        }

        // Show value
        private void CreateRedisShowTagControl<T>() where T : UserControl, new()
        {
            T control = new T();
            panel1.Controls.Add(control);
            control.Location = new Point(0, 0);
            control.Size = new Size(panel1.Width - 1, panel1.Height - 1);
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            if (userControl != null)
            {
                panel1.Controls.Remove(userControl);
            }

            if (userControl != null)
            {
                userControl.Dispose();
            }

            userControl = control;
        }

        private void StringKeySelect(RedisClient client, TreeNode key)
        {
            if (userControl == null || (userControl as StringValueControl) == null)
            {
                CreateRedisShowTagControl<StringValueControl>();
            }

            if (userControl is StringValueControl stringValueControl)
            {
                stringValueControl.MainForm = this;
                stringValueControl.TargetNode = key;
                stringValueControl.SetNewKey(client, key.Text);
            }
        }

        private void ListKeySelect(RedisClient client, TreeNode key)
        {
            if (userControl == null || (userControl as ListValueControl) == null)
            {
                CreateRedisShowTagControl<ListValueControl>();
            }

            if (userControl is ListValueControl listValueControl)
            {
                listValueControl.MainForm = this;
                listValueControl.TargetNode = key;
                listValueControl.SetNewKey(client, key.Text);
            }
        }

        private void HashKeySelect(RedisClient client, TreeNode key)
        {
            if (userControl == null || (userControl as HashValueControl) == null)
            {
                CreateRedisShowTagControl<HashValueControl>();
            }

            if (userControl is HashValueControl hashValueControl)
            {
                hashValueControl.MainForm = this;
                hashValueControl.TargetNode = key;
                hashValueControl.SetNewKey(client, key.Text);
            }
        }

        private void SetKeySelect(RedisClient client, TreeNode key)
        {
            if (userControl == null || (userControl as SetValueControl) == null)
            {
                CreateRedisShowTagControl<SetValueControl>();
            }

            if (userControl is SetValueControl setValueControl)
            {
                setValueControl.MainForm = this;
                setValueControl.TargetNode = key;
                setValueControl.SetNewKey(client, key.Text);
            }
        }

        private void ZSetKeySelect(RedisClient client, TreeNode key)
        {
            if (userControl == null || (userControl as ZSetValueControl) == null)
            {
                CreateRedisShowTagControl<ZSetValueControl>();
            }

            if (userControl is ZSetValueControl zsetValueControl)
            {
                zsetValueControl.MainForm = this;
                zsetValueControl.TargetNode = key;
                zsetValueControl.SetNewKey(client, key.Text);
            }
        }

		// Load / Save / Add servers
		private void LoadRedisSettings()
        {
            treeView_server.Nodes.Clear();

            foreach (var group in redis_group)
            {
                TreeNode node = new TreeNode(group.name);
                node.ImageKey = "ListView_687";
                node.SelectedImageKey = "ListView_687";
                node.Tag = group;
                treeView_server.Nodes.Add(node);

                foreach (var settings in group.connections)
                {
                    TreeNode node_con = new TreeNode(settings.name);
                    node_con.ImageKey = "VirtualMachine";
                    node_con.SelectedImageKey = "VirtualMachine";
                    node_con.Tag = settings.redis_client;
                    node.Nodes.Add(node_con);
                }
            }

            foreach (var settings in redis_settings)
            {
                TreeNode node = new TreeNode(settings.name);
                node.ImageKey = "VirtualMachine";
                node.SelectedImageKey = "VirtualMachine";
                node.Tag = settings.redis_client;
                treeView_server.Nodes.Add(node);
            }
        }

        private void SaveRedisSettings()
        {
            JArray json_root = new JArray();

            foreach (var group in redis_group)
            {
                json_root.Add(JObject.FromObject(group));
            }

            foreach (var setting in redis_settings)
            {
                json_root.Add(JObject.FromObject(setting));
            }

            File.WriteAllText(ServerListPath, json_root.ToString(), Encoding.UTF8);
        }

        private void RemoveServer(RedisClient client)
        {
            foreach (var group in redis_group)
            {
                foreach (var settings in group.connections)
                {
                    if (settings.redis_client == client)
                    {
                        group.connections.Remove(settings);
                        break;
                    }
                }
            }

            foreach (var settings in redis_settings)
            {
                if (settings.redis_client == client)
                {
                    redis_settings.Remove(settings);
                    break;
                }
            }
        }

        private void button_add_server_Click(object sender, EventArgs e)
        {
            using (FormRedisAdd form = new FormRedisAdd(null))
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                redis_settings.Add(form.Settings);
                form.Settings.redis_client = new RedisClient(form.Settings);
                SaveRedisSettings();

                TreeNode node = new TreeNode(form.Settings.name);
                node.ImageKey = "VirtualMachine";
                node.SelectedImageKey = "VirtualMachine";
                node.Tag = form.Settings.redis_client;
                treeView_server.Nodes.Add(node);
            }
        }

        private void button_open_server_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Redis server list (*.json)|*.json";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Application.StartupPath + "\\connections";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FormLoadServerList formLoadServerList = new FormLoadServerList();
            formLoadServerList.LoadRecent();
            formLoadServerList.SaveRecent(ofd.FileName);

            LoadRedisServerList(ofd.FileName);
        }

        private void FormMain_Move(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal && is_shown)
            {
                Config.mainform_pos_x = Location.X;
                Config.mainform_pos_y = Location.Y;
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal && is_shown)
            {
                Config.mainform_pos_x = Location.X;
                Config.mainform_pos_y = Location.Y;
                Config.mainform_width = Width;
                Config.mainform_height = Height;
            }
        }

        public void delete_key_operate(TreeNode select, IDatabase database)
        {
            if (MessageBox.Show(string.Format("Delete key [{0}]?", select.Text), "Delete key", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (database.KeyDelete(select.Text))
                {
                    var db_setting_node = get_db_setting_node(select);
                    if (db_setting_node != null &&
                        db_setting_node.Tag is DbSettings dbSettings)
                    {
                        dbSettings.Keys.Remove(select.Text);
						FilterKeys(db_setting_node);
                        db_setting_node.ExpandAll();
					}
                    else
                    {
                        select.Text += "  (Deleted)";
                    }
                }
                else
                {
                    MessageBox.Show("Delete key failed");
                }
            }

            if (userControl == null || (userControl as StartControl) == null)
            {
                CreateRedisShowTagControl<StartControl>();
            }
        }

        private TreeNode get_db_setting_node(TreeNode select)
		{
            if (select.Parent == null)
			{
                return null;
			}

            if (select.Parent.Tag is DbSettings dbSettings)
			{
                return select.Parent;
			}

            return get_db_setting_node(select.Parent);
		}

        private void delete_key_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is not RedisKey)
            {
                return;
            }

            TreeNode dbNode = GetDbNode(select);
            TreeNode redisNode = GetRedisNode(select);

            if (redisNode.Tag is RedisClient redisClient)
            {
                if (dbNode.Tag is DbSettings dbSettings)
                {
                    var database = redisClient.GetDB(dbSettings.DBNumber);

                    delete_key_operate(select, database);
                }
            }
        }

        private void key_query_window_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is not RedisKey)
            {
                return;
            }

            TreeNode dbNode = GetDbNode(select);
            TreeNode redisNode = GetRedisNode(select);

            if (redisNode.Tag is RedisClient redisClient)
            {
                if (dbNode.Tag is DbSettings dbSettings)
                {
                    var database = redisClient.GetDB(dbSettings.DBNumber);
                    var key_type = database.KeyType(select.Text);

                    FormQueryWindow fqw = new FormQueryWindow();
                    fqw.SetServerInfo(redisClient, dbSettings.DBNumber);
                    fqw.SetRedisKeysType(key_type);
                    fqw.SetRedisKeysFilter(select.Text);
                    fqw.Show();
                }
            }
        }

        private void folder_query_window_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode select = treeView_server.SelectedNode;
            if (select == null)
            {
                return;
            }

            if (select.Tag is not RedisFolder)
            {
                return;
            }

            TreeNode dbNode = GetDbNode(select);
            TreeNode redisNode = GetRedisNode(select);
            string key_filter = GetFullpathFolder(select, "") + "*";

            if (redisNode.Tag is RedisClient redisClient)
            {
                if (dbNode.Tag is DbSettings dbSettings)
                {
                    var database = redisClient.GetDB(dbSettings.DBNumber);
                    var key_type = database.KeyType(select.Text);

                    FormQueryWindow fqw = new FormQueryWindow();
                    fqw.SetServerInfo(redisClient, dbSettings.DBNumber);
                    fqw.SetRedisKeysType(key_type);
                    fqw.SetRedisKeysFilter(key_filter);
                    fqw.Show();
                }
            }
        }

        private bool copy_key_in_same_machine(IDatabase src_db, IDatabase dst_db, string src_key, string dst_key)
		{
            if (src_key == "")
			{
                MessageBox.Show("source key is empty", "Copy failed");
                return false;
			}

            if (dst_key == "")
			{
                MessageBox.Show("destination key is empty", "Copy failed");
                return false;
			}

            if (src_db.KeyExists(src_key) == false)
			{
                MessageBox.Show($"{src_key} is not exist", "Copy failed");
                return false;
			}

            if (dst_db.KeyExists(dst_key))
			{
                MessageBox.Show($"{dst_key} is already exist", "Copy failed");
                return false;
			}

			var type = src_db.KeyType(src_key);
			switch (type)
			{
				case StackExchange.Redis.RedisType.String:
				{
					dst_db.StringSet(dst_key, src_db.StringGet(src_key));
				}
				break;
				case StackExchange.Redis.RedisType.List:
				{
                    dst_db.ListRightPush(dst_key, src_db.ListRange(src_key));
				}
				break;
				case StackExchange.Redis.RedisType.Hash:
				{
                    dst_db.HashSet(dst_key, src_db.HashGetAll(src_key));
				}
				break;
				case StackExchange.Redis.RedisType.Set:
				{
                    dst_db.SetAdd(dst_key, src_db.SetMembers(src_key));
				}
				break;
				case StackExchange.Redis.RedisType.SortedSet:
				{
                    dst_db.SortedSetAdd(dst_key, src_db.SortedSetRangeByScoreWithScores(src_key));
				}
				break;
				default:
				{
					MessageBox.Show($"{src_key} is not exist", "Copy failed");
                    return false;
				}
			}

            return true;
		}

		private void copy_key_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is RedisKey)
			{
				using (FormInputString formInput = new FormInputString())
				{
					formInput.TextInfo = "Copy key";
					formInput.InputValue = select.Text;

					if (formInput.ShowDialog() == DialogResult.OK)
					{
						TreeNode dbNode = GetDbNode(select);
						TreeNode redisNode = GetRedisNode(select);
                        var dbSettings = dbNode.Tag as DbSettings;
                        var redisClient = redisNode.Tag as RedisClient;
                        var db = redisClient.GetDB(dbSettings.DBNumber);

                        string src_key = select.Text;
                        string dst_key = formInput.InputValue;

                        if (copy_key_in_same_machine(db, db, src_key, dst_key))
						{
                            RefreshDbKeys(dbNode, true);
                        }
                    }
				}
			}
		}

		private void copy_key_to_db_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is RedisKey)
			{
				using (FormTwoInputString formInput = new FormTwoInputString())
				{
					TreeNode dbNode = GetDbNode(select);
					TreeNode redisNode = GetRedisNode(select);
					var dbSettings = dbNode.Tag as DbSettings;
					var redisClient = redisNode.Tag as RedisClient;

					formInput.TextInfo = "Copy key to other db";
                    formInput.InputValue1 = dbSettings.DBNumber.ToString();
					formInput.InputValue2 = select.Text;

					if (formInput.ShowDialog() == DialogResult.OK)
					{
                        int dst_db_num = -1;
                        if (int.TryParse(formInput.InputValue1, out dst_db_num) == false)
						{
                            MessageBox.Show("insert first input as number", "Copy failed");
                            return;
						}

                        if (dst_db_num < 0)
						{
                            MessageBox.Show("db number is must greater than 0", "Copy failed");
                            return;
						}

                        if (dst_db_num >= redisClient.RedisServer.DatabaseCount)
						{
                            MessageBox.Show($"db number {dst_db_num} is not exist", "Copy failed");
                            return;
						}

						var src_db = redisClient.GetDB(dbSettings.DBNumber);
                        var dst_db = redisClient.GetDB(dst_db_num);

						string src_key = select.Text;
						string dst_key = formInput.InputValue2;

						if (copy_key_in_same_machine(src_db, dst_db, src_key, dst_key))
						{
                            var dst_db_node = GetDbNodeFromRedisNode(redisNode, dst_db_num);
                            if (dst_db_node != null)
							{
                                RefreshDbKeys(dst_db_node, true);
                            }
                        }
					}
				}
			}
		}

		private void copy_key_to_machine_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is RedisKey)
			{
				using (FormMigrateKey formInput = new FormMigrateKey())
				{
					TreeNode dbNode = GetDbNode(select);
					TreeNode redisNode = GetRedisNode(select);
					var dbSettings = dbNode.Tag as DbSettings;
					var redisClient = redisNode.Tag as RedisClient;

					if (formInput.ShowDialog() == DialogResult.OK)
					{
						var db = redisClient.GetDB(dbSettings.DBNumber);
						string src_key = select.Text;

                        IPEndPoint end_point = new IPEndPoint(IPAddress.Parse(formInput.Host), formInput.Port);

                        try
                        {
                            db.KeyMigrate(src_key, end_point, formInput.DBNumber, migrateOptions: MigrateOptions.Copy);

                            MessageBox.Show($"Migrate key complete.\r\n\r\nkey : {src_key}\r\ntarget server : {$"{formInput.Host}:{formInput.Port}"}\r\ndb num : {formInput.DBNumber}");
                        }
                        catch (RedisCommandException ex)
						{
                            MessageBox.Show(ex.Message);
						}
                        catch (RedisTimeoutException ex)
						{
                            MessageBox.Show(ex.Message);
                        }
                    }
				}
			}
		}

		private void migrate_keys_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode select = treeView_server.SelectedNode;
			if (select == null)
			{
				return;
			}

			if (select.Tag is DbSettings dbSettings)
			{
				using (FormMigrateKey formInput = new FormMigrateKey())
				{
                    formInput.UsePattern = true;

					if (formInput.ShowDialog() == DialogResult.OK)
					{
						RedisClient redisClient = select.Parent.Tag as RedisClient;
						var reads = redisClient.RedisServer.Keys(dbSettings.DBNumber, formInput.KeyPattern, Config.scan_page_count);
						var db = redisClient.GetDB(dbSettings.DBNumber);

                        IPEndPoint end_point = new IPEndPoint(IPAddress.Parse(formInput.Host), formInput.Port);

                        int migrate_count = 0;

                        try
                        {
                            foreach (var key in reads)
                            {
                                db.KeyMigrate(key, end_point, formInput.DBNumber, migrateOptions: MigrateOptions.Copy);
                                ++migrate_count;
                            }

							MessageBox.Show($"Migrate key complete.\r\n\r\nkey pattern : {formInput.KeyPattern}\r\ntarget server : {$"{formInput.Host}:{formInput.Port}"}\r\ndb num : {formInput.DBNumber}\r\nmigrate count : {migrate_count}");
						}
						catch (RedisCommandException ex)
						{
							MessageBox.Show(ex.Message);
						}
						catch (RedisTimeoutException ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
			}
		}

		private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = treeView_server.SelectedNode;
			if (selectedNode == null)
			{
				return;
			}

			if (selectedNode.Tag is RedisClient client)
			{
				// Set the icon to loading while attempting to reconnect
				selectedNode.ImageKey = "loading";
				selectedNode.SelectedImageKey = "loading";
				treeView_server.Invalidate(true); // Force redraw
				Application.DoEvents(); // Process UI updates

				RefreshRedisKey(selectedNode, true); // Call with reload = true to force reconnection and UI refresh
			}
		}
	}
}
