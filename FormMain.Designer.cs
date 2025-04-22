namespace RedisGuiManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button_open_server = new System.Windows.Forms.Button();
			this.button_add_server = new System.Windows.Forms.Button();
			this.imageList_main = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip_db = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.new_key_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reload_keys_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filter_key_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unfilter_key_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.queryWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.remove_keys_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.remove_db_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_redis = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.add_db_to_list_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.add_db_range_to_list_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.remove_db_range_from_list_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.find_db_from_list_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggle_show_default_dbs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.remove_keys_from_registered_dbs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.remove_keys_from_whole_dbs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.query_window_all_server_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.open_console_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reload_server_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.edit_connection_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnect_connection_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delete_connection_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_class = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.folder_query_window_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip_key = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copy_key_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.delete_key_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.key_query_window_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copy_key_to_db_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copy_key_to_machine_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.migrate_keys_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeView_server = new System.Windows.Forms.TreeViewEx();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip_db.SuspendLayout();
			this.contextMenuStrip_redis.SuspendLayout();
			this.contextMenuStrip_class.SuspendLayout();
			this.contextMenuStrip_key.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 648);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1143, 25);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
			this.toolStripStatusLabel1.Text = "Ready";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button_open_server);
			this.splitContainer1.Panel1.Controls.Add(this.button_add_server);
			this.splitContainer1.Panel1.Controls.Add(this.treeView_server);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(1143, 648);
			this.splitContainer1.SplitterDistance = 330;
			this.splitContainer1.TabIndex = 3;
			// 
			// button_open_server
			// 
			this.button_open_server.Image = global::RedisGuiManager.Properties.Resources.folder_open;
			this.button_open_server.Location = new System.Drawing.Point(3, 3);
			this.button_open_server.Name = "button_open_server";
			this.button_open_server.Size = new System.Drawing.Size(32, 23);
			this.button_open_server.TabIndex = 3;
			this.button_open_server.UseVisualStyleBackColor = true;
			this.button_open_server.Click += new System.EventHandler(this.button_open_server_Click);
			// 
			// button_add_server
			// 
			this.button_add_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_add_server.Image = global::RedisGuiManager.Properties.Resources.action_add_16xLG;
			this.button_add_server.Location = new System.Drawing.Point(296, 5);
			this.button_add_server.Name = "button_add_server";
			this.button_add_server.Size = new System.Drawing.Size(32, 23);
			this.button_add_server.TabIndex = 2;
			this.button_add_server.UseVisualStyleBackColor = true;
			this.button_add_server.Click += new System.EventHandler(this.button_add_server_Click);
			// 
			// imageList_main
			// 
			this.imageList_main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_main.ImageStream")));
			this.imageList_main.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList_main.Images.SetKeyName(0, "loading");
			this.imageList_main.Images.SetKeyName(1, "VirtualMachine");
			this.imageList_main.Images.SetKeyName(2, "redis_db");
			this.imageList_main.Images.SetKeyName(3, "ListView_687");
			this.imageList_main.Images.SetKeyName(4, "Class_489");
			this.imageList_main.Images.SetKeyName(5, "keyword");
			this.imageList_main.Images.SetKeyName(6, "sql");
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(809, 648);
			this.panel1.TabIndex = 0;
			// 
			// contextMenuStrip_db
			// 
			this.contextMenuStrip_db.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_key_ToolStripMenuItem,
            this.reload_keys_ToolStripMenuItem,
            this.filter_key_ToolStripMenuItem,
            this.unfilter_key_ToolStripMenuItem,
            this.queryWindowToolStripMenuItem,
            this.toolStripSeparator3,
            this.migrate_keys_ToolStripMenuItem,
            this.remove_keys_ToolStripMenuItem,
            this.toolStripSeparator4,
            this.remove_db_ToolStripMenuItem});
			this.contextMenuStrip_db.Name = "contextMenuStrip1";
			this.contextMenuStrip_db.Size = new System.Drawing.Size(219, 208);
			// 
			// new_key_ToolStripMenuItem
			// 
			this.new_key_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.action_add_16xLG;
			this.new_key_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.new_key_ToolStripMenuItem.Name = "new_key_ToolStripMenuItem";
			this.new_key_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.new_key_ToolStripMenuItem.Text = "Add Key";
			this.new_key_ToolStripMenuItem.Click += new System.EventHandler(this.new_key_ToolStripMenuItem_Click);
			// 
			// reload_keys_ToolStripMenuItem
			// 
			this.reload_keys_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Activity_16xLG;
			this.reload_keys_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.reload_keys_ToolStripMenuItem.Name = "reload_keys_ToolStripMenuItem";
			this.reload_keys_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.reload_keys_ToolStripMenuItem.Text = "Reload keys";
			this.reload_keys_ToolStripMenuItem.Click += new System.EventHandler(this.reload_keys_ToolStripMenuItem_Click);
			// 
			// filter_key_ToolStripMenuItem
			// 
			this.filter_key_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.filter;
			this.filter_key_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.filter_key_ToolStripMenuItem.Name = "filter_key_ToolStripMenuItem";
			this.filter_key_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.filter_key_ToolStripMenuItem.Text = "Filter Key";
			this.filter_key_ToolStripMenuItem.Click += new System.EventHandler(this.filter_key_ToolStripMenuItem_Click);
			// 
			// unfilter_key_ToolStripMenuItem
			// 
			this.unfilter_key_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.unfilter;
			this.unfilter_key_ToolStripMenuItem.Name = "unfilter_key_ToolStripMenuItem";
			this.unfilter_key_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.unfilter_key_ToolStripMenuItem.Text = "Unfilter Key";
			this.unfilter_key_ToolStripMenuItem.Click += new System.EventHandler(this.unfilter_key_ToolStripMenuItem_Click);
			// 
			// queryWindowToolStripMenuItem
			// 
			this.queryWindowToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.sql;
			this.queryWindowToolStripMenuItem.Name = "queryWindowToolStripMenuItem";
			this.queryWindowToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.queryWindowToolStripMenuItem.Text = "Query Window";
			this.queryWindowToolStripMenuItem.Click += new System.EventHandler(this.queryWindowToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
			// 
			// remove_keys_ToolStripMenuItem
			// 
			this.remove_keys_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.action_Cancel_16xLG;
			this.remove_keys_ToolStripMenuItem.Name = "remove_keys_ToolStripMenuItem";
			this.remove_keys_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.remove_keys_ToolStripMenuItem.Text = "Delete Keys";
			this.remove_keys_ToolStripMenuItem.Click += new System.EventHandler(this.remove_keys_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
			// 
			// remove_db_ToolStripMenuItem
			// 
			this.remove_db_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.redis_db_minus;
			this.remove_db_ToolStripMenuItem.Name = "remove_db_ToolStripMenuItem";
			this.remove_db_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.remove_db_ToolStripMenuItem.Text = "Remove DB from list";
			this.remove_db_ToolStripMenuItem.Click += new System.EventHandler(this.remove_db_ToolStripMenuItem_Click);
			// 
			// contextMenuStrip_redis
			// 
			this.contextMenuStrip_redis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_db_to_list_ToolStripMenuItem,
            this.add_db_range_to_list_ToolStripMenuItem,
            this.remove_db_range_from_list_ToolStripMenuItem,
            this.find_db_from_list_ToolStripMenuItem,
            this.toggle_show_default_dbs_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.remove_keys_from_registered_dbs_ToolStripMenuItem,
            this.remove_keys_from_whole_dbs_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.query_window_all_server_ToolStripMenuItem,
            this.open_console_ToolStripMenuItem,
            this.reload_server_ToolStripMenuItem,
            this.edit_connection_ToolStripMenuItem,
            this.disconnect_connection_ToolStripMenuItem,
            this.delete_connection_ToolStripMenuItem});
			this.contextMenuStrip_redis.Name = "contextMenuStrip_redis";
			this.contextMenuStrip_redis.Size = new System.Drawing.Size(297, 350);
			// 
			// add_db_to_list_ToolStripMenuItem
			// 
			this.add_db_to_list_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.redis_db_add;
			this.add_db_to_list_ToolStripMenuItem.Name = "add_db_to_list_ToolStripMenuItem";
			this.add_db_to_list_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.add_db_to_list_ToolStripMenuItem.Text = "Add DB to list";
			this.add_db_to_list_ToolStripMenuItem.Click += new System.EventHandler(this.add_db_to_list_ToolStripMenuItem_Click);
			// 
			// add_db_range_to_list_ToolStripMenuItem
			// 
			this.add_db_range_to_list_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.redis_db_add;
			this.add_db_range_to_list_ToolStripMenuItem.Name = "add_db_range_to_list_ToolStripMenuItem";
			this.add_db_range_to_list_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.add_db_range_to_list_ToolStripMenuItem.Text = "Add DB range to list";
			this.add_db_range_to_list_ToolStripMenuItem.Click += new System.EventHandler(this.add_db_range_to_list_ToolStripMenuItem_Click);
			// 
			// remove_db_range_from_list_ToolStripMenuItem
			// 
			this.remove_db_range_from_list_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.redis_db_minus;
			this.remove_db_range_from_list_ToolStripMenuItem.Name = "remove_db_range_from_list_ToolStripMenuItem";
			this.remove_db_range_from_list_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.remove_db_range_from_list_ToolStripMenuItem.Text = "Remove DB range from list";
			this.remove_db_range_from_list_ToolStripMenuItem.Click += new System.EventHandler(this.remove_db_range_from_list_ToolStripMenuItem_Click);
			// 
			// find_db_from_list_ToolStripMenuItem
			// 
			this.find_db_from_list_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.search;
			this.find_db_from_list_ToolStripMenuItem.Name = "find_db_from_list_ToolStripMenuItem";
			this.find_db_from_list_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.find_db_from_list_ToolStripMenuItem.Text = "Find DB from list";
			this.find_db_from_list_ToolStripMenuItem.Click += new System.EventHandler(this.find_db_from_list_ToolStripMenuItem_Click);
			// 
			// toggle_show_default_dbs_ToolStripMenuItem
			// 
			this.toggle_show_default_dbs_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.redis_db_check;
			this.toggle_show_default_dbs_ToolStripMenuItem.Name = "toggle_show_default_dbs_ToolStripMenuItem";
			this.toggle_show_default_dbs_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.toggle_show_default_dbs_ToolStripMenuItem.Text = "Toggle show default DBs";
			this.toggle_show_default_dbs_ToolStripMenuItem.Click += new System.EventHandler(this.toggle_show_default_dbs_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(303, 6);
			// 
			// remove_keys_from_registered_dbs_ToolStripMenuItem
			// 
			this.remove_keys_from_registered_dbs_ToolStripMenuItem.Name = "remove_keys_from_registered_dbs_ToolStripMenuItem";
			this.remove_keys_from_registered_dbs_ToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
			this.remove_keys_from_registered_dbs_ToolStripMenuItem.Text = "Delete keys from registered DBs";
			this.remove_keys_from_registered_dbs_ToolStripMenuItem.Click += new System.EventHandler(this.remove_keys_from_registered_dbs_ToolStripMenuItem_Click);
			// 
			// remove_keys_from_whole_dbs_ToolStripMenuItem
			// 
			this.remove_keys_from_whole_dbs_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.action_Cancel_16xLG;
			this.remove_keys_from_whole_dbs_ToolStripMenuItem.Name = "remove_keys_from_whole_dbs_ToolStripMenuItem";
			this.remove_keys_from_whole_dbs_ToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
			this.remove_keys_from_whole_dbs_ToolStripMenuItem.Text = "Delete keys from whole DBs";
			this.remove_keys_from_whole_dbs_ToolStripMenuItem.Click += new System.EventHandler(this.remove_keys_from_whole_dbs_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(303, 6);
			// 
			// query_window_all_server_ToolStripMenuItem
			// 
			this.query_window_all_server_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.sql;
			this.query_window_all_server_ToolStripMenuItem.Name = "query_window_all_server_ToolStripMenuItem";
			this.query_window_all_server_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.query_window_all_server_ToolStripMenuItem.Text = "Query Window";
			this.query_window_all_server_ToolStripMenuItem.Click += new System.EventHandler(this.query_window_all_server_ToolStripMenuItem_Click);
			// 
			// open_console_ToolStripMenuItem
			// 
			this.open_console_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.console;
			this.open_console_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.open_console_ToolStripMenuItem.Name = "open_console_ToolStripMenuItem";
			this.open_console_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.open_console_ToolStripMenuItem.Text = "Open console";
			this.open_console_ToolStripMenuItem.Click += new System.EventHandler(this.open_console_ToolStripMenuItem_Click);
			// 
			// reload_server_ToolStripMenuItem
			// 
			this.reload_server_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Activity_16xLG;
			this.reload_server_ToolStripMenuItem.Name = "reload_server_ToolStripMenuItem";
			this.reload_server_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.reload_server_ToolStripMenuItem.Text = "Refresh server";
			this.reload_server_ToolStripMenuItem.Click += new System.EventHandler(this.reload_server_ToolStripMenuItem_Click);
			// 
			// edit_connection_ToolStripMenuItem
			// 
			this.edit_connection_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.settings;
			this.edit_connection_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.edit_connection_ToolStripMenuItem.Name = "edit_connection_ToolStripMenuItem";
			this.edit_connection_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.edit_connection_ToolStripMenuItem.Text = "Edit connection settings";
			this.edit_connection_ToolStripMenuItem.Click += new System.EventHandler(this.edit_connection_ToolStripMenuItem_Click);
			// 
			// disconnect_connection_ToolStripMenuItem
			// 
			this.disconnect_connection_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.disconnect;
			this.disconnect_connection_ToolStripMenuItem.Name = "disconnect_connection_ToolStripMenuItem";
			this.disconnect_connection_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.disconnect_connection_ToolStripMenuItem.Text = "Unload all data";
			this.disconnect_connection_ToolStripMenuItem.Click += new System.EventHandler(this.disconnect_connection_ToolStripMenuItem_Click);
			// 
			// delete_connection_ToolStripMenuItem
			// 
			this.delete_connection_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.action_minus_16LG;
			this.delete_connection_ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.delete_connection_ToolStripMenuItem.Name = "delete_connection_ToolStripMenuItem";
			this.delete_connection_ToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
			this.delete_connection_ToolStripMenuItem.Text = "Delete connection";
			this.delete_connection_ToolStripMenuItem.Click += new System.EventHandler(this.delete_connection_ToolStripMenuItem_Click);
			// 
			// contextMenuStrip_class
			// 
			this.contextMenuStrip_class.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folder_query_window_toolStripMenuItem});
			this.contextMenuStrip_class.Name = "contextMenuStrip_class";
			this.contextMenuStrip_class.Size = new System.Drawing.Size(178, 28);
			// 
			// folder_query_window_toolStripMenuItem
			// 
			this.folder_query_window_toolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.sql;
			this.folder_query_window_toolStripMenuItem.Name = "folder_query_window_toolStripMenuItem";
			this.folder_query_window_toolStripMenuItem.Size = new System.Drawing.Size(177, 24);
			this.folder_query_window_toolStripMenuItem.Text = "Query window";
			this.folder_query_window_toolStripMenuItem.Click += new System.EventHandler(this.folder_query_window_toolStripMenuItem_Click);
			// 
			// contextMenuStrip_key
			// 
			this.contextMenuStrip_key.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_key_ToolStripMenuItem,
            this.copy_key_to_db_ToolStripMenuItem,
            this.copy_key_to_machine_ToolStripMenuItem,
            this.delete_key_toolStripMenuItem,
            this.key_query_window_toolStripMenuItem});
			this.contextMenuStrip_key.Name = "contextMenuStrip_class";
			this.contextMenuStrip_key.Size = new System.Drawing.Size(186, 124);
			// 
			// copy_key_ToolStripMenuItem
			// 
			this.copy_key_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Copy_6524;
			this.copy_key_ToolStripMenuItem.Name = "copy_key_ToolStripMenuItem";
			this.copy_key_ToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
			this.copy_key_ToolStripMenuItem.Text = "Copy key";
			this.copy_key_ToolStripMenuItem.Click += new System.EventHandler(this.copy_key_ToolStripMenuItem_Click);
			// 
			// delete_key_toolStripMenuItem
			// 
			this.delete_key_toolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.action_Cancel_16xLG;
			this.delete_key_toolStripMenuItem.Name = "delete_key_toolStripMenuItem";
			this.delete_key_toolStripMenuItem.Size = new System.Drawing.Size(185, 24);
			this.delete_key_toolStripMenuItem.Text = "Delete key";
			this.delete_key_toolStripMenuItem.Click += new System.EventHandler(this.delete_key_toolStripMenuItem_Click);
			// 
			// key_query_window_toolStripMenuItem
			// 
			this.key_query_window_toolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.sql;
			this.key_query_window_toolStripMenuItem.Name = "key_query_window_toolStripMenuItem";
			this.key_query_window_toolStripMenuItem.Size = new System.Drawing.Size(185, 24);
			this.key_query_window_toolStripMenuItem.Text = "Query window";
			this.key_query_window_toolStripMenuItem.Click += new System.EventHandler(this.key_query_window_toolStripMenuItem_Click);
			// 
			// copy_key_to_db_ToolStripMenuItem
			// 
			this.copy_key_to_db_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Copy_6524;
			this.copy_key_to_db_ToolStripMenuItem.Name = "copy_key_to_db_ToolStripMenuItem";
			this.copy_key_to_db_ToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
			this.copy_key_to_db_ToolStripMenuItem.Text = "Copy key to DB";
			this.copy_key_to_db_ToolStripMenuItem.Click += new System.EventHandler(this.copy_key_to_db_ToolStripMenuItem_Click);
			// 
			// copy_key_to_machine_ToolStripMenuItem
			// 
			this.copy_key_to_machine_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Copy_6524;
			this.copy_key_to_machine_ToolStripMenuItem.Name = "copy_key_to_machine_ToolStripMenuItem";
			this.copy_key_to_machine_ToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
			this.copy_key_to_machine_ToolStripMenuItem.Text = "Migrate key";
			this.copy_key_to_machine_ToolStripMenuItem.Click += new System.EventHandler(this.copy_key_to_machine_ToolStripMenuItem_Click);
			// 
			// migrate_keys_ToolStripMenuItem
			// 
			this.migrate_keys_ToolStripMenuItem.Image = global::RedisGuiManager.Properties.Resources.Copy_6524;
			this.migrate_keys_ToolStripMenuItem.Name = "migrate_keys_ToolStripMenuItem";
			this.migrate_keys_ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
			this.migrate_keys_ToolStripMenuItem.Text = "Migrate Keys";
			this.migrate_keys_ToolStripMenuItem.Click += new System.EventHandler(this.migrate_keys_ToolStripMenuItem_Click);
			// 
			// treeView_server
			// 
			this.treeView_server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView_server.CausesValidation = false;
			this.treeView_server.Font = new System.Drawing.Font("Consolas", 12F);
			this.treeView_server.ImageIndex = 0;
			this.treeView_server.ImageList = this.imageList_main;
			this.treeView_server.Location = new System.Drawing.Point(3, 29);
			this.treeView_server.Name = "treeView_server";
			this.treeView_server.SelectedImageIndex = 0;
			this.treeView_server.ShowPlusMinus = false;
			this.treeView_server.Size = new System.Drawing.Size(324, 616);
			this.treeView_server.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1143, 673);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Redis Gui Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.Move += new System.EventHandler(this.FormMain_Move);
			this.Resize += new System.EventHandler(this.FormMain_Resize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip_db.ResumeLayout(false);
			this.contextMenuStrip_redis.ResumeLayout(false);
			this.contextMenuStrip_class.ResumeLayout(false);
			this.contextMenuStrip_key.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeViewEx treeView_server;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_db;
        private System.Windows.Forms.ToolStripMenuItem reload_keys_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_key_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filter_key_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_redis;
        private System.Windows.Forms.ToolStripMenuItem open_console_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reload_server_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_connection_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delete_connection_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_class;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add_server;
        private System.Windows.Forms.ToolStripMenuItem disconnect_connection_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryWindowToolStripMenuItem;
        private System.Windows.Forms.Button button_open_server;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_key;
        private System.Windows.Forms.ToolStripMenuItem delete_key_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem key_query_window_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folder_query_window_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unfilter_key_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem add_db_to_list_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem find_db_from_list_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggle_show_default_dbs_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem remove_db_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem add_db_range_to_list_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem remove_db_range_from_list_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem remove_keys_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem remove_keys_from_registered_dbs_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem remove_keys_from_whole_dbs_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem query_window_all_server_ToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList_main;
		private System.Windows.Forms.ToolStripMenuItem copy_key_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copy_key_to_db_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copy_key_to_machine_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem migrate_keys_ToolStripMenuItem;
	}
}

