using Newtonsoft.Json.Linq;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using AutocompleteMenuNS;

namespace RedisGuiManager
{
    public partial class FormQueryWindow : Form
    {
        public enum RedisKeyType
        {
            String = 0,
            List,
            Set,
            Zset,
            Hash,
        }
        private SQLiteConnection sqlite_con;
        private string table_name = "";
        private DataSet ds;
        private RedisClient redis_client;
        private int db_num;
        private bool is_querying = false;
        private bool is_stop_query = false;
        private List<AutocompleteItem> list_auto_complete_static = new List<AutocompleteItem>();

        public FormQueryWindow()
        {
            InitializeComponent();
            setting_richtextbox();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            comboBox_keys_type.SelectedIndex = (int)RedisKeyType.Hash;
            dataGridView_query_result.DoubleBuffered(true);

            sqlite_con = new SQLiteConnection($"Data Source=:memory:;Version=3;");
            sqlite_con.Open();
            sqlite_con.EnableExtensions(true);
            sqlite_con.LoadExtension("SQLite.Interop.dll", "sqlite3_json_init");

            table_name = "t_" + Guid.NewGuid().ToString().Replace("-", "");
            textBox_table.Text = table_name;

            richTextBox_query.Text = $"SELECT *\nFROM {table_name}\n";
            richTextBox_query.ProcessAllLines();

            list_auto_complete_static = new List<AutocompleteItem>();
            foreach (var item in Utils.Sql_keyword_list)
            {
                list_auto_complete_static.Add(new AutocompleteItem(item, 2));
            }
            foreach (var item in Utils.Sql_json_func_list)
            {
                list_auto_complete_static.Add(new AutocompleteItem(item, 1));
            }
            list_auto_complete_static.Add(new AutocompleteItem("a_key", 3));
            list_auto_complete_static.Add(new AutocompleteItem("a_index", 3));
            list_auto_complete_static.Add(new AutocompleteItem("a_value", 3));
            list_auto_complete_static.Add(new AutocompleteItem("a_score", 3));
            list_auto_complete_static.Add(new AutocompleteItem(table_name, 0));

            ImageList imageList = new ImageList();
            imageList.Images.Add("Table_748", Properties.Resources.Table_748);
            imageList.Images.Add("Method_636", Properties.Resources.Method_636);
            imageList.Images.Add("keyword", Properties.Resources.keyword);
            imageList.Images.Add("Structure_507", Properties.Resources.Structure_507);

            autocompleteMenu.SetAutocompleteItems(list_auto_complete_static);
            autocompleteMenu.AppearInterval = 200;
            autocompleteMenu.MinFragmentLength = 1;
            autocompleteMenu.ImageList = imageList;
        }

        private void FormQueryWindow_Shown(object sender, EventArgs e)
        {
            richTextBox_query.Select(richTextBox_query.Text.Length, 0);
            richTextBox_query.Focus();
        }

        private void setting_richtextbox()
        {
            richTextBox_query.Settings.Keywords = Utils.Sql_keyword_list;
            richTextBox_query.Settings.Comment = "--";
            richTextBox_query.Settings.KeywordColor = Color.Blue;
            richTextBox_query.Settings.CommentColor = Color.Gray;
            richTextBox_query.Settings.StringColor = Color.Green;
            richTextBox_query.Settings.IntegerColor = Color.Purple;
            richTextBox_query.Settings.EnableStrings = true;
            richTextBox_query.Settings.EnableIntegers = true;

            if (Config.darkmode > 0)
            {
                richTextBox_query.Settings.KeywordColor = Color.LightSkyBlue;
                richTextBox_query.Settings.CommentColor = Color.Gray;
                richTextBox_query.Settings.StringColor = Color.LightGreen;
                richTextBox_query.Settings.IntegerColor = Color.MediumPurple;
            }

            richTextBox_query.CompileKeywords();
        }

        public void SetServerInfo(RedisClient redis_client, int db_num)
        {
            textBox_server_info.Text = string.Format("[{0}] ({1}:{2} DB_{3})"
                , redis_client.Settings.name
                , redis_client.Settings.host
                , redis_client.Settings.port
                , db_num == -1 ? $"All [0 ~ {redis_client.RedisServer.DatabaseCount - 1}]" : db_num.ToString()
                );

            this.redis_client = redis_client;
            this.db_num = db_num;
        }

        public void SetRedisKeysFilter(string keys_filter)
        {
            textBox_keys_filter.Text = keys_filter;
        }
        public void SetRedisKeysType(RedisType type)
        {
            RedisKeyType my_type = RedisKeyType.Hash;
            switch(type)
            {
                case RedisType.String:
                {
                    my_type = RedisKeyType.String;
                }
                break;
                case RedisType.List:
                {
                    my_type = RedisKeyType.List;
                }
                break;
                case RedisType.Set:
                {
                    my_type = RedisKeyType.Set;
                }
                break;
                case RedisType.SortedSet:
                {
                    my_type = RedisKeyType.Zset;
                }
                break;
                case RedisType.Hash:
                {
                    my_type = RedisKeyType.Hash;
                }
                break;
            }

            comboBox_keys_type.SelectedIndex = (int)my_type;
        }

        public void SetRedisKeysType(RedisKeyType type)
        {
            comboBox_keys_type.SelectedIndex = (int)type;
        }

        private async Task query_string()
        {
            treeView_field_names.Nodes.Add("a_db");
			treeView_field_names.Nodes.Add("a_key");
			treeView_field_names.Nodes.Add("a_value");

            string sql = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT, a_value TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

            int db_num_start = db_num == -1 ? 0 : db_num;
            int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
                IDatabase redis = redis_client.GetDB(i);
				toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
				Application.DoEvents();

				var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

				toolStripProgressBar_status.Value = 0;
				toolStripProgressBar_status.Maximum = keys.Count();

				foreach (var key in keys)
                {
                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";
                    Application.DoEvents();

                    try
                    {
                        var val = await redis.StringGetAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }

                        sql = $"INSERT INTO {table_name} (a_db, a_key, a_value) VALUES (@Db, @Key, @Value);";
                        command = new SQLiteCommand(sql, sqlite_con);
                        command.Parameters.AddWithValue("Db", i);
						command.Parameters.AddWithValue("Key", key.ToString());
						command.Parameters.AddWithValue("Value", val.ToString());

                        command.ExecuteNonQuery();
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }
                }
            }
        }

        private async Task query_list()
        {
            treeView_field_names.Nodes.Add("a_db");
            treeView_field_names.Nodes.Add("a_key");
            treeView_field_names.Nodes.Add("a_index");
            treeView_field_names.Nodes.Add("a_value");

            string sql = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT, a_index INTEGER, a_value TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

			int db_num_start = db_num == -1 ? 0 : db_num;
			int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
				IDatabase redis = redis_client.GetDB(i);
				toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
				Application.DoEvents();

				var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

				toolStripProgressBar_status.Value = 0;
				toolStripProgressBar_status.Maximum = keys.Count();

				foreach (var key in keys)
                {
                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";
                    Application.DoEvents();

                    try
                    {
                        var vals = await redis.ListRangeAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }

                        int index = 0;
                        foreach (var val in vals)
                        {
                            sql = $"INSERT INTO {table_name} (a_db, a_key, a_index, a_value) VALUES (@Db, @Key, @Index, @Value);";
                            command = new SQLiteCommand(sql, sqlite_con);
                            command.Parameters.AddWithValue("Db", i);
							command.Parameters.AddWithValue("Key", key.ToString());
							command.Parameters.AddWithValue("Index", index);
                            command.Parameters.AddWithValue("Value", val.ToString());

                            command.ExecuteNonQuery();
                            ++index;
                        }
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }
                }
            }
        }

        private async Task query_set()
        {
            treeView_field_names.Nodes.Add("a_db");
			treeView_field_names.Nodes.Add("a_key");
			treeView_field_names.Nodes.Add("a_index");
            treeView_field_names.Nodes.Add("a_value");

            string sql = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT, a_index INTEGER, a_value TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

			int db_num_start = db_num == -1 ? 0 : db_num;
			int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
				IDatabase redis = redis_client.GetDB(i);
				toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
				Application.DoEvents();

				var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

				toolStripProgressBar_status.Value = 0;
				toolStripProgressBar_status.Maximum = keys.Count();

				foreach (var key in keys)
                {
                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";

                    try
                    {
                        var vals = await redis.SetMembersAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }

                        int index = 0;
                        foreach (var val in vals)
                        {
                            sql = $"INSERT INTO {table_name} (a_db, a_key, a_index, a_value) VALUES (@Db, @Key, @Index, @Value);";
                            command = new SQLiteCommand(sql, sqlite_con);
                            command.Parameters.AddWithValue("Db", i);
                            command.Parameters.AddWithValue("Key", key.ToString());
                            command.Parameters.AddWithValue("Index", index);
                            command.Parameters.AddWithValue("Value", val.ToString());

                            command.ExecuteNonQuery();
                            ++index;
                        }
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }
                }
            }
        }

        private async Task query_zset()
        {
            treeView_field_names.Nodes.Add("a_db");
			treeView_field_names.Nodes.Add("a_key");
			treeView_field_names.Nodes.Add("a_index");
            treeView_field_names.Nodes.Add("a_value");
            treeView_field_names.Nodes.Add("a_score");

            string sql = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT, a_index INTEGER, a_value TEXT, a_score INTEGER)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

			int db_num_start = db_num == -1 ? 0 : db_num;
			int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
				IDatabase redis = redis_client.GetDB(i);
				toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
				Application.DoEvents();

				var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

				toolStripProgressBar_status.Value = 0;
				toolStripProgressBar_status.Maximum = keys.Count();

				foreach (var key in keys)
                {
                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";

                    try
                    {
                        var vals = await redis.SortedSetRangeByRankWithScoresAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }

                        int index = 0;
                        foreach (var val in vals)
                        {
                            sql = $"INSERT INTO {table_name} (a_db, a_key, a_index, a_value, a_score) VALUES (@Db, @Key, @Index, @Value, @Score);";
                            command = new SQLiteCommand(sql, sqlite_con);
                            command.Parameters.AddWithValue("Db", i);
							command.Parameters.AddWithValue("Key", key.ToString());
							command.Parameters.AddWithValue("Index", index);
                            command.Parameters.AddWithValue("Value", val.ToString());
                            command.Parameters.AddWithValue("Score", Convert.ToInt64(val.Score));

                            command.ExecuteNonQuery();
                            ++index;
                        }
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }
                }
            }
        }

        private async Task query_hash()
        {
            treeView_field_names.Nodes.Add("a_db");
			treeView_field_names.Nodes.Add("a_key");
			var field_tree = treeView_field_names.Nodes.Add("a_field");
            treeView_field_names.Nodes.Add("a_value");

            string sql = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT, a_field TEXT, a_value TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

			int db_num_start = db_num == -1 ? 0 : db_num;
			int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
				IDatabase redis = redis_client.GetDB(i);
				toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
				Application.DoEvents();

				var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

				toolStripProgressBar_status.Value = 0;
				toolStripProgressBar_status.Maximum = keys.Count();

				HashSet<string> field_name_set = new HashSet<string>();
                foreach (var key in keys)
                {
                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";

                    try
                    {
                        var hashes = await redis.HashGetAllAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }

                        foreach (var hash in hashes)
                        {
                            sql = $"INSERT INTO {table_name} (a_db, a_key, a_field, a_value) VALUES (@Db, @Key, @Field, @Value);";
                            command = new SQLiteCommand(sql, sqlite_con);
                            command.Parameters.AddWithValue("Db", i);
                            command.Parameters.AddWithValue("Key", key.ToString());
                            command.Parameters.AddWithValue("Field", hash.Name.ToString());
                            command.Parameters.AddWithValue("Value", hash.Value.ToString());

                            command.ExecuteNonQuery();

                            field_name_set.Add(hash.Name.ToString());
                        }
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }

                    List<string> field_name_list = field_name_set.ToList();
                    field_name_list.Sort();
                    List<TreeNode> field_name_nodes = new List<TreeNode>();
                    var list_auto_complete_total = list_auto_complete_static.ToList();
                    foreach (var field_name in field_name_list)
                    {
                        field_name_nodes.Add(new TreeNode(field_name));
                        list_auto_complete_total.Add(new AutocompleteItem(field_name, 3));
                    }

                    autocompleteMenu.SetAutocompleteItems(list_auto_complete_total);
                    field_tree.Nodes.AddRange(field_name_nodes.ToArray());
                }
            }
        }

        private async Task query_hash_ex()
        {
            treeView_field_names.Nodes.Add("a_db");
			treeView_field_names.Nodes.Add("a_key");

			HashSet<string> field_name_set = new HashSet<string>();
            Dictionary<string, List<KeyValuePair<string, string>>> dic_data = new Dictionary<string, List<KeyValuePair<string, string>>>();

            int db_num_start = db_num == -1 ? 0 : db_num;
			int db_num_end = db_num == -1 ? redis_client.RedisServer.DatabaseCount - 1 : db_num;
            string db_n_key = "";

            for (int i = db_num_start; i <= db_num_end; ++i)
            {
                IDatabase redis = redis_client.GetDB(i);
                toolStripStatusLabel_status.Text = $"Getting DB_{i} keys...";
                Application.DoEvents();

                var keys = redis_client.RedisServer.Keys(i, textBox_keys_filter.Text, Config.scan_page_count);

                toolStripProgressBar_status.Value = 0;
                toolStripProgressBar_status.Maximum = keys.Count();

                foreach (var key in keys)
                {
                    db_n_key = $"{i} {key}";

                    ++toolStripProgressBar_status.Value;
                    toolStripStatusLabel_status.Text = $"Getting DB_{i} values...({toolStripProgressBar_status.Value} / {toolStripProgressBar_status.Maximum})";
                    Application.DoEvents();

                    try
                    {
                        var hashes = await redis.HashGetAllAsync(key);
                        if (is_stop_query)
                        {
                            return;
                        }


						if (dic_data.ContainsKey(db_n_key.ToString()) == false)
						{
							dic_data.Add(db_n_key, new List<KeyValuePair<string, string>>());
                        }

						foreach (var hash in hashes)
                        {
                            dic_data[db_n_key].Add(new KeyValuePair<string, string>(hash.Name.ToString(), hash.Value.ToString()));

                            field_name_set.Add(hash.Name.ToString());
                        }
                    }
                    catch (RedisServerException redis_ex)
                    {
                        if (redis_ex.HResult != -2146233088)
                        {
                            // Log 출력
                        }

                        if (is_stop_query)
                        {
                            return;
                        }
                    }
                }
            }

            ////////////////////////////////
            // create table
            string sql_create_table = "";
            StringBuilder sb_create_table = new StringBuilder();
            foreach (var field_name in field_name_set)
            {
                sb_create_table.Append($",`{field_name}` TEXT DEFAULT NULL");
            }

            sql_create_table = $"CREATE TABLE {table_name} (a_db INTEGER, a_key TEXT{sb_create_table.ToString()})";

            //string sql = $"CREATE TABLE {table_name} (a_key TEXT, a_field TEXT, a_value TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql_create_table, sqlite_con);
            int result = command.ExecuteNonQuery();
            //
            ////////////////////////////////

            ////////////////////////////////
            // insert data
            foreach (var row in dic_data)
            {
                StringBuilder sb_insert_key = new StringBuilder();
                StringBuilder sb_insert_val = new StringBuilder();
                foreach (var field_n_val in row.Value)
                {
                    sb_insert_key.Append($",`{field_n_val.Key}`");
                    sb_insert_val.Append($",@{field_n_val.Key}");
                }

                string sql = $"INSERT INTO {table_name} (a_db, a_key{sb_insert_key.ToString()}) VALUES (@Db, @Key{sb_insert_val.ToString()});";
                command = new SQLiteCommand(sql, sqlite_con);
				command.Parameters.AddWithValue("Db", row.Key.Split(' ')[0]);
				command.Parameters.AddWithValue("Key", row.Key.Split(' ')[1]);
				foreach (var field_n_val in row.Value)
                {
                    command.Parameters.AddWithValue(field_n_val.Key, field_n_val.Value);
                }

                command.ExecuteNonQuery();
            }
            //
            ////////////////////////////////


            List<string> field_name_list = field_name_set.ToList();
            field_name_list.Sort();
            List<TreeNode> field_name_nodes = new List<TreeNode>();
            var list_auto_complete_total = list_auto_complete_static.ToList();
            foreach (var field_name in field_name_list)
            {
                field_name_nodes.Add(new TreeNode(field_name));
                list_auto_complete_total.Add(new AutocompleteItem(field_name, 3));
            }

            autocompleteMenu.SetAutocompleteItems(list_auto_complete_total);
            treeView_field_names.Nodes.AddRange(field_name_nodes.ToArray());
        }

        private async Task execute_query(string select_sql)
        {
            button_query_execute.Text = "■";
            is_querying = true;
            dataGridView_query_result.Columns.Clear();
            button_col_row_count.Text = "(0r x 0c)";

            if (ds != null)
            {
                ds.Clear();
            }

            if (checkBox_reuse_table.Checked == false)
            {
                string sql = $"DROP TABLE IF EXISTS {table_name};";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
                int result = command.ExecuteNonQuery();

                if (textBox_keys_filter.Text == "")
                {
                    textBox_keys_filter.Text = "*";
                }

                toolStripProgressBar_status.Maximum = 0;
                toolStripProgressBar_status.Value = 0;

                command = new SQLiteCommand("BEGIN;", sqlite_con);
                result = command.ExecuteNonQuery();

                treeView_field_names.Nodes.Clear();
                autocompleteMenu.SetAutocompleteItems(list_auto_complete_static);

                switch ((RedisKeyType)comboBox_keys_type.SelectedIndex)
                {
                    case RedisKeyType.String:
                    {
                        await query_string();
                    }
                    break;
                    case RedisKeyType.List:
                    {
                        await query_list();
                    }
                    break;
                    case RedisKeyType.Set:
                    {
                        await query_set();
                    }
                    break;
                    case RedisKeyType.Zset:
                    {
                        await query_zset();
                    }
                    break;
                    case RedisKeyType.Hash:
                    {
                        await query_hash_ex();
                    }
                    break;
                }

                if (is_stop_query)
                {
                    is_querying = false;
                    is_stop_query = false;
                    button_query_execute.Text = "▶";
                    toolStripStatusLabel_status.Text = "User canceled";
                    toolStripProgressBar_status.Value = 0;
                    command = new SQLiteCommand("ROLLBACK;", sqlite_con);
                    result = command.ExecuteNonQuery();
                    return;
                }

                toolStripStatusLabel_status.Text = "Querying...";
                Application.DoEvents();

                command = new SQLiteCommand("COMMIT;", sqlite_con);
                result = command.ExecuteNonQuery();

                checkBox_reuse_table.Checked = true;
            }

            try
            {
                toolStripStatusLabel_status.Text = "Making data grid view...";
                Application.DoEvents();

                var adapter = new SQLiteDataAdapter(select_sql, sqlite_con);
                ds = new DataSet();
                adapter.Fill(ds);

                dataGridView_query_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView_query_result.ColumnHeadersVisible = false;
                dataGridView_query_result.DataSource = ds.Tables[0];
                dataGridView_query_result.ColumnHeadersVisible = true;
                dataGridView_query_result.AllowUserToResizeColumns = true;
                List<int> widths = new List<int>();
                foreach (DataGridViewColumn col in dataGridView_query_result.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    widths.Add(col.Width > 550 ? 550 : col.Width);
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }

                for (int i = 0; i < widths.Count; ++i)
                {
                    dataGridView_query_result.Columns[i].Width = widths[i];
                }
            }
            catch (SQLiteException sqlite_ex)
            {
                MessageBox.Show(sqlite_ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button_col_row_count.Text = $"({dataGridView_query_result.Rows.Count}r x {dataGridView_query_result.Columns.Count}c)";
            toolStripStatusLabel_status.Text = "Done";

            is_querying = false;
            button_query_execute.Text = "▶";
        }

        private async void button_query_go_Click(object sender, EventArgs e)
        {
            if (is_querying)
            {
                is_stop_query = true;
            }
            else
            {
                string sql = richTextBox_query.Text;
                await execute_query(sql);
            }
        }

        private void dataGridView_query_result_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value.ToString().Length > 10000)
                {
                    e.Value = e.Value.ToString().Substring(0, 10000);
                }
            }
        }

        private void FormQueryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = $"DROP TABLE IF EXISTS {table_name};";
            SQLiteCommand command = new SQLiteCommand(sql, sqlite_con);
            int result = command.ExecuteNonQuery();

            is_stop_query = true;
        }

        private async void richTextBox_query_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F9)
            {
                string sql = richTextBox_query.SelectedText;
                await execute_query(sql);

                return;
            }
            else if (e.KeyCode == Keys.F9)
            {
                string sql = richTextBox_query.Text;
                await execute_query(sql);

                return;
            }
        }

        private void dataGridView_query_result_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
            {
                if (dataGridView_query_result.SelectedCells.Count == 1)
                {
                    dataGridView_query_result.ClearSelection();
                    dataGridView_query_result.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }

                Rectangle cellRect = dataGridView_query_result.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point ptLoc = new Point(cellRect.Left + e.Location.X, cellRect.Top + e.Location.Y);

                show_context_menu(dataGridView_query_result, ptLoc);
            }
        }

        private void show_context_menu(Control c, Point p)
        {
            ContextMenu contextMenu = new ContextMenu();
            Menu.MenuItemCollection m = contextMenu.MenuItems;
            m.Add(new MenuItem("Json viewer", new EventHandler(this.CM_json_viewer)));
			m.Add(new MenuItem("Remove selected keys", new EventHandler(this.CM_remove_selected_keys)));

			contextMenu.Show(c, p);
        }

        private void CM_json_viewer(object o, EventArgs e)
        {
            FormJsonViewer fjv = new FormJsonViewer();
            fjv.Show();
            fjv.JsonText = dataGridView_query_result.SelectedCells[0].Value.ToString();
        }

        private void CM_remove_selected_keys(object o, EventArgs e)
		{
            if (db_num != -1)
            {
                IDatabase redis = redis_client.GetDB(db_num);

                foreach (DataGridViewCell cell in dataGridView_query_result.SelectedCells)
                {
                    if (dataGridView_query_result.Columns[cell.ColumnIndex].Name == "a_key")
                    {
                        redis.KeyDelete(cell.Value.ToString());
                        cell.Value = cell.Value.ToString() + "  (Removed)";
                    }
                }
            }
            else
			{
                if (dataGridView_query_result.Columns.Contains("a_db") == false)
				{
                    MessageBox.Show("a_db field required");
                    return;
				}

                IDatabase redis = null;

                foreach (DataGridViewCell cell in dataGridView_query_result.SelectedCells)
				{
					if (dataGridView_query_result.Columns[cell.ColumnIndex].Name == "a_key")
					{
                        int a_db = int.Parse(dataGridView_query_result.Rows[cell.RowIndex].Cells["a_db"].Value.ToString());
                        redis = redis_client.GetDB(a_db);
                        redis.KeyDelete(cell.Value.ToString());
						cell.Value = cell.Value.ToString() + "  (Removed)";
					}
				}
			}

            checkBox_reuse_table.Checked = false;
		}

        private void checkBox_reuse_table_CheckedChanged(object sender, EventArgs e)
        {
            textBox_keys_filter.Enabled = !checkBox_reuse_table.Checked;
            comboBox_keys_type.Enabled = !checkBox_reuse_table.Checked;
        }

        private void treeView_field_names_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(treeView_field_names.SelectedNode.Text);
            }
            catch (Exception)
            {
            }
            richTextBox_query.SelectedText = treeView_field_names.SelectedNode.Text;
            richTextBox_query.Focus();
        }
    }
}
