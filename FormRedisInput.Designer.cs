namespace RedisGuiManager
{
    partial class FormRedisInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.tabControl_type = new System.Windows.Forms.TabControl();
			this.tabPage_string = new System.Windows.Forms.TabPage();
			this.button_string_save = new System.Windows.Forms.Button();
			this.textBox_string_value = new System.Windows.Forms.TextBox();
			this.label_string_value = new System.Windows.Forms.Label();
			this.textBox_string_key = new System.Windows.Forms.TextBox();
			this.label_string_key = new System.Windows.Forms.Label();
			this.tabPage_hash = new System.Windows.Forms.TabPage();
			this.textBox_hash_hash_key = new System.Windows.Forms.TextBox();
			this.label_hash_hash_key = new System.Windows.Forms.Label();
			this.button_hash_save = new System.Windows.Forms.Button();
			this.textBox_hash_value = new System.Windows.Forms.TextBox();
			this.label_hash_value = new System.Windows.Forms.Label();
			this.textBox_hash_key = new System.Windows.Forms.TextBox();
			this.label_hash_key = new System.Windows.Forms.Label();
			this.tabPage_list = new System.Windows.Forms.TabPage();
			this.button_list_save = new System.Windows.Forms.Button();
			this.textBox_list_value = new System.Windows.Forms.TextBox();
			this.label_list_value = new System.Windows.Forms.Label();
			this.textBox_list_key = new System.Windows.Forms.TextBox();
			this.label_list_key = new System.Windows.Forms.Label();
			this.radioButton_list_right_push = new System.Windows.Forms.RadioButton();
			this.radioButton_list_left_push = new System.Windows.Forms.RadioButton();
			this.tabPage_set = new System.Windows.Forms.TabPage();
			this.button_set_save = new System.Windows.Forms.Button();
			this.textBox_set_value = new System.Windows.Forms.TextBox();
			this.label_set_value = new System.Windows.Forms.Label();
			this.textBox_set_key = new System.Windows.Forms.TextBox();
			this.label_set_key = new System.Windows.Forms.Label();
			this.tabPage_zset = new System.Windows.Forms.TabPage();
			this.textBox_zset_score = new System.Windows.Forms.TextBox();
			this.label_zset_score = new System.Windows.Forms.Label();
			this.button_zset_save = new System.Windows.Forms.Button();
			this.textBox_zset_value = new System.Windows.Forms.TextBox();
			this.label_zset_value = new System.Windows.Forms.Label();
			this.textBox_zset_key = new System.Windows.Forms.TextBox();
			this.label_zset_key = new System.Windows.Forms.Label();
			this.tabControl_type.SuspendLayout();
			this.tabPage_string.SuspendLayout();
			this.tabPage_hash.SuspendLayout();
			this.tabPage_list.SuspendLayout();
			this.tabPage_set.SuspendLayout();
			this.tabPage_zset.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl_type
			// 
			this.tabControl_type.Controls.Add(this.tabPage_string);
			this.tabControl_type.Controls.Add(this.tabPage_hash);
			this.tabControl_type.Controls.Add(this.tabPage_list);
			this.tabControl_type.Controls.Add(this.tabPage_set);
			this.tabControl_type.Controls.Add(this.tabPage_zset);
			this.tabControl_type.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_type.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabControl_type.Location = new System.Drawing.Point(0, 0);
			this.tabControl_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabControl_type.Name = "tabControl_type";
			this.tabControl_type.SelectedIndex = 0;
			this.tabControl_type.Size = new System.Drawing.Size(501, 231);
			this.tabControl_type.TabIndex = 0;
			this.tabControl_type.SelectedIndexChanged += new System.EventHandler(this.tabControl_type_SelectedIndexChanged);
			// 
			// tabPage_string
			// 
			this.tabPage_string.Controls.Add(this.button_string_save);
			this.tabPage_string.Controls.Add(this.textBox_string_value);
			this.tabPage_string.Controls.Add(this.label_string_value);
			this.tabPage_string.Controls.Add(this.textBox_string_key);
			this.tabPage_string.Controls.Add(this.label_string_key);
			this.tabPage_string.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabPage_string.Location = new System.Drawing.Point(4, 28);
			this.tabPage_string.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage_string.Name = "tabPage_string";
			this.tabPage_string.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage_string.Size = new System.Drawing.Size(493, 199);
			this.tabPage_string.TabIndex = 0;
			this.tabPage_string.Text = "String";
			this.tabPage_string.UseVisualStyleBackColor = true;
			// 
			// button_string_save
			// 
			this.button_string_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_string_save.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_string_save.Location = new System.Drawing.Point(182, 155);
			this.button_string_save.Name = "button_string_save";
			this.button_string_save.Size = new System.Drawing.Size(140, 31);
			this.button_string_save.TabIndex = 2;
			this.button_string_save.Text = "Save";
			this.button_string_save.UseVisualStyleBackColor = true;
			this.button_string_save.Click += new System.EventHandler(this.button_string_save_Click);
			// 
			// textBox_string_value
			// 
			this.textBox_string_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_string_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_string_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_string_value.Location = new System.Drawing.Point(98, 63);
			this.textBox_string_value.MaxLength = 0;
			this.textBox_string_value.Multiline = true;
			this.textBox_string_value.Name = "textBox_string_value";
			this.textBox_string_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_string_value.Size = new System.Drawing.Size(387, 75);
			this.textBox_string_value.TabIndex = 1;
			// 
			// label_string_value
			// 
			this.label_string_value.AutoSize = true;
			this.label_string_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_string_value.Location = new System.Drawing.Point(33, 66);
			this.label_string_value.Name = "label_string_value";
			this.label_string_value.Size = new System.Drawing.Size(54, 19);
			this.label_string_value.TabIndex = 2;
			this.label_string_value.Text = "Value";
			// 
			// textBox_string_key
			// 
			this.textBox_string_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_string_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_string_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_string_key.Location = new System.Drawing.Point(98, 24);
			this.textBox_string_key.Name = "textBox_string_key";
			this.textBox_string_key.Size = new System.Drawing.Size(387, 26);
			this.textBox_string_key.TabIndex = 0;
			// 
			// label_string_key
			// 
			this.label_string_key.AutoSize = true;
			this.label_string_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_string_key.Location = new System.Drawing.Point(33, 27);
			this.label_string_key.Name = "label_string_key";
			this.label_string_key.Size = new System.Drawing.Size(36, 19);
			this.label_string_key.TabIndex = 0;
			this.label_string_key.Text = "Key";
			// 
			// tabPage_hash
			// 
			this.tabPage_hash.Controls.Add(this.textBox_hash_hash_key);
			this.tabPage_hash.Controls.Add(this.label_hash_hash_key);
			this.tabPage_hash.Controls.Add(this.button_hash_save);
			this.tabPage_hash.Controls.Add(this.textBox_hash_value);
			this.tabPage_hash.Controls.Add(this.label_hash_value);
			this.tabPage_hash.Controls.Add(this.textBox_hash_key);
			this.tabPage_hash.Controls.Add(this.label_hash_key);
			this.tabPage_hash.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabPage_hash.Location = new System.Drawing.Point(4, 28);
			this.tabPage_hash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage_hash.Name = "tabPage_hash";
			this.tabPage_hash.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage_hash.Size = new System.Drawing.Size(493, 199);
			this.tabPage_hash.TabIndex = 1;
			this.tabPage_hash.Text = "Hash";
			this.tabPage_hash.UseVisualStyleBackColor = true;
			// 
			// textBox_hash_hash_key
			// 
			this.textBox_hash_hash_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_hash_hash_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_hash_hash_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_hash_hash_key.Location = new System.Drawing.Point(102, 48);
			this.textBox_hash_hash_key.Name = "textBox_hash_hash_key";
			this.textBox_hash_hash_key.Size = new System.Drawing.Size(383, 26);
			this.textBox_hash_hash_key.TabIndex = 1;
			// 
			// label_hash_hash_key
			// 
			this.label_hash_hash_key.AutoSize = true;
			this.label_hash_hash_key.Location = new System.Drawing.Point(10, 51);
			this.label_hash_hash_key.Name = "label_hash_hash_key";
			this.label_hash_hash_key.Size = new System.Drawing.Size(81, 19);
			this.label_hash_hash_key.TabIndex = 10;
			this.label_hash_hash_key.Text = "Hash key";
			// 
			// button_hash_save
			// 
			this.button_hash_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_hash_save.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_hash_save.Location = new System.Drawing.Point(182, 155);
			this.button_hash_save.Name = "button_hash_save";
			this.button_hash_save.Size = new System.Drawing.Size(140, 31);
			this.button_hash_save.TabIndex = 3;
			this.button_hash_save.Text = "Save";
			this.button_hash_save.UseVisualStyleBackColor = true;
			this.button_hash_save.Click += new System.EventHandler(this.button_hash_save_Click);
			// 
			// textBox_hash_value
			// 
			this.textBox_hash_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_hash_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_hash_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_hash_value.Location = new System.Drawing.Point(102, 80);
			this.textBox_hash_value.MaxLength = 0;
			this.textBox_hash_value.Multiline = true;
			this.textBox_hash_value.Name = "textBox_hash_value";
			this.textBox_hash_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_hash_value.Size = new System.Drawing.Size(383, 66);
			this.textBox_hash_value.TabIndex = 2;
			// 
			// label_hash_value
			// 
			this.label_hash_value.AutoSize = true;
			this.label_hash_value.Location = new System.Drawing.Point(37, 80);
			this.label_hash_value.Name = "label_hash_value";
			this.label_hash_value.Size = new System.Drawing.Size(54, 19);
			this.label_hash_value.TabIndex = 7;
			this.label_hash_value.Text = "Value";
			// 
			// textBox_hash_key
			// 
			this.textBox_hash_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_hash_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_hash_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_hash_key.Location = new System.Drawing.Point(102, 14);
			this.textBox_hash_key.Name = "textBox_hash_key";
			this.textBox_hash_key.Size = new System.Drawing.Size(383, 26);
			this.textBox_hash_key.TabIndex = 0;
			// 
			// label_hash_key
			// 
			this.label_hash_key.AutoSize = true;
			this.label_hash_key.Location = new System.Drawing.Point(53, 17);
			this.label_hash_key.Name = "label_hash_key";
			this.label_hash_key.Size = new System.Drawing.Size(36, 19);
			this.label_hash_key.TabIndex = 5;
			this.label_hash_key.Text = "Key";
			// 
			// tabPage_list
			// 
			this.tabPage_list.Controls.Add(this.button_list_save);
			this.tabPage_list.Controls.Add(this.textBox_list_value);
			this.tabPage_list.Controls.Add(this.label_list_value);
			this.tabPage_list.Controls.Add(this.textBox_list_key);
			this.tabPage_list.Controls.Add(this.label_list_key);
			this.tabPage_list.Controls.Add(this.radioButton_list_right_push);
			this.tabPage_list.Controls.Add(this.radioButton_list_left_push);
			this.tabPage_list.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabPage_list.Location = new System.Drawing.Point(4, 28);
			this.tabPage_list.Name = "tabPage_list";
			this.tabPage_list.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_list.Size = new System.Drawing.Size(493, 199);
			this.tabPage_list.TabIndex = 2;
			this.tabPage_list.Text = "List";
			this.tabPage_list.UseVisualStyleBackColor = true;
			// 
			// button_list_save
			// 
			this.button_list_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_list_save.Location = new System.Drawing.Point(182, 155);
			this.button_list_save.Name = "button_list_save";
			this.button_list_save.Size = new System.Drawing.Size(140, 31);
			this.button_list_save.TabIndex = 4;
			this.button_list_save.Text = "Save";
			this.button_list_save.UseVisualStyleBackColor = true;
			this.button_list_save.Click += new System.EventHandler(this.button_list_save_Click);
			// 
			// textBox_list_value
			// 
			this.textBox_list_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_list_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_list_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_list_value.Location = new System.Drawing.Point(99, 76);
			this.textBox_list_value.MaxLength = 0;
			this.textBox_list_value.Multiline = true;
			this.textBox_list_value.Name = "textBox_list_value";
			this.textBox_list_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_list_value.Size = new System.Drawing.Size(386, 61);
			this.textBox_list_value.TabIndex = 1;
			// 
			// label_list_value
			// 
			this.label_list_value.AutoSize = true;
			this.label_list_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_list_value.Location = new System.Drawing.Point(34, 79);
			this.label_list_value.Name = "label_list_value";
			this.label_list_value.Size = new System.Drawing.Size(54, 19);
			this.label_list_value.TabIndex = 7;
			this.label_list_value.Text = "Value";
			// 
			// textBox_list_key
			// 
			this.textBox_list_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_list_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_list_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_list_key.Location = new System.Drawing.Point(99, 37);
			this.textBox_list_key.Name = "textBox_list_key";
			this.textBox_list_key.Size = new System.Drawing.Size(386, 26);
			this.textBox_list_key.TabIndex = 0;
			// 
			// label_list_key
			// 
			this.label_list_key.AutoSize = true;
			this.label_list_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_list_key.Location = new System.Drawing.Point(34, 40);
			this.label_list_key.Name = "label_list_key";
			this.label_list_key.Size = new System.Drawing.Size(36, 19);
			this.label_list_key.TabIndex = 5;
			this.label_list_key.Text = "Key";
			// 
			// radioButton_list_right_push
			// 
			this.radioButton_list_right_push.AutoSize = true;
			this.radioButton_list_right_push.Checked = true;
			this.radioButton_list_right_push.Location = new System.Drawing.Point(225, 6);
			this.radioButton_list_right_push.Name = "radioButton_list_right_push";
			this.radioButton_list_right_push.Size = new System.Drawing.Size(117, 23);
			this.radioButton_list_right_push.TabIndex = 3;
			this.radioButton_list_right_push.TabStop = true;
			this.radioButton_list_right_push.Text = "Right Push";
			this.radioButton_list_right_push.UseVisualStyleBackColor = true;
			// 
			// radioButton_list_left_push
			// 
			this.radioButton_list_left_push.AutoSize = true;
			this.radioButton_list_left_push.Location = new System.Drawing.Point(68, 6);
			this.radioButton_list_left_push.Name = "radioButton_list_left_push";
			this.radioButton_list_left_push.Size = new System.Drawing.Size(108, 23);
			this.radioButton_list_left_push.TabIndex = 2;
			this.radioButton_list_left_push.Text = "Left Push";
			this.radioButton_list_left_push.UseVisualStyleBackColor = true;
			// 
			// tabPage_set
			// 
			this.tabPage_set.Controls.Add(this.button_set_save);
			this.tabPage_set.Controls.Add(this.textBox_set_value);
			this.tabPage_set.Controls.Add(this.label_set_value);
			this.tabPage_set.Controls.Add(this.textBox_set_key);
			this.tabPage_set.Controls.Add(this.label_set_key);
			this.tabPage_set.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabPage_set.Location = new System.Drawing.Point(4, 28);
			this.tabPage_set.Name = "tabPage_set";
			this.tabPage_set.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_set.Size = new System.Drawing.Size(493, 199);
			this.tabPage_set.TabIndex = 3;
			this.tabPage_set.Text = "Set";
			this.tabPage_set.UseVisualStyleBackColor = true;
			// 
			// button_set_save
			// 
			this.button_set_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_set_save.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_set_save.Location = new System.Drawing.Point(182, 155);
			this.button_set_save.Name = "button_set_save";
			this.button_set_save.Size = new System.Drawing.Size(140, 31);
			this.button_set_save.TabIndex = 2;
			this.button_set_save.Text = "Save";
			this.button_set_save.UseVisualStyleBackColor = true;
			this.button_set_save.Click += new System.EventHandler(this.button_set_save_Click);
			// 
			// textBox_set_value
			// 
			this.textBox_set_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_set_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_set_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_set_value.Location = new System.Drawing.Point(97, 68);
			this.textBox_set_value.MaxLength = 0;
			this.textBox_set_value.Multiline = true;
			this.textBox_set_value.Name = "textBox_set_value";
			this.textBox_set_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_set_value.Size = new System.Drawing.Size(388, 71);
			this.textBox_set_value.TabIndex = 1;
			// 
			// label_set_value
			// 
			this.label_set_value.AutoSize = true;
			this.label_set_value.Location = new System.Drawing.Point(32, 71);
			this.label_set_value.Name = "label_set_value";
			this.label_set_value.Size = new System.Drawing.Size(54, 19);
			this.label_set_value.TabIndex = 12;
			this.label_set_value.Text = "Value";
			// 
			// textBox_set_key
			// 
			this.textBox_set_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_set_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_set_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_set_key.Location = new System.Drawing.Point(97, 29);
			this.textBox_set_key.Name = "textBox_set_key";
			this.textBox_set_key.Size = new System.Drawing.Size(388, 26);
			this.textBox_set_key.TabIndex = 0;
			// 
			// label_set_key
			// 
			this.label_set_key.AutoSize = true;
			this.label_set_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_set_key.Location = new System.Drawing.Point(32, 32);
			this.label_set_key.Name = "label_set_key";
			this.label_set_key.Size = new System.Drawing.Size(36, 19);
			this.label_set_key.TabIndex = 10;
			this.label_set_key.Text = "Key";
			// 
			// tabPage_zset
			// 
			this.tabPage_zset.Controls.Add(this.textBox_zset_score);
			this.tabPage_zset.Controls.Add(this.label_zset_score);
			this.tabPage_zset.Controls.Add(this.button_zset_save);
			this.tabPage_zset.Controls.Add(this.textBox_zset_value);
			this.tabPage_zset.Controls.Add(this.label_zset_value);
			this.tabPage_zset.Controls.Add(this.textBox_zset_key);
			this.tabPage_zset.Controls.Add(this.label_zset_key);
			this.tabPage_zset.Font = new System.Drawing.Font("Consolas", 12F);
			this.tabPage_zset.Location = new System.Drawing.Point(4, 28);
			this.tabPage_zset.Name = "tabPage_zset";
			this.tabPage_zset.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_zset.Size = new System.Drawing.Size(493, 199);
			this.tabPage_zset.TabIndex = 4;
			this.tabPage_zset.Text = "Zset";
			this.tabPage_zset.UseVisualStyleBackColor = true;
			// 
			// textBox_zset_score
			// 
			this.textBox_zset_score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_zset_score.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_zset_score.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_zset_score.Location = new System.Drawing.Point(109, 54);
			this.textBox_zset_score.Name = "textBox_zset_score";
			this.textBox_zset_score.Size = new System.Drawing.Size(376, 26);
			this.textBox_zset_score.TabIndex = 1;
			this.textBox_zset_score.Text = "0";
			// 
			// label_zset_score
			// 
			this.label_zset_score.AutoSize = true;
			this.label_zset_score.Location = new System.Drawing.Point(44, 57);
			this.label_zset_score.Name = "label_zset_score";
			this.label_zset_score.Size = new System.Drawing.Size(54, 19);
			this.label_zset_score.TabIndex = 20;
			this.label_zset_score.Text = "Score";
			// 
			// button_zset_save
			// 
			this.button_zset_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_zset_save.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_zset_save.Location = new System.Drawing.Point(182, 155);
			this.button_zset_save.Name = "button_zset_save";
			this.button_zset_save.Size = new System.Drawing.Size(140, 31);
			this.button_zset_save.TabIndex = 3;
			this.button_zset_save.Text = "Save";
			this.button_zset_save.UseVisualStyleBackColor = true;
			this.button_zset_save.Click += new System.EventHandler(this.button_zset_save_Click);
			// 
			// textBox_zset_value
			// 
			this.textBox_zset_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_zset_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_zset_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_zset_value.Location = new System.Drawing.Point(109, 90);
			this.textBox_zset_value.MaxLength = 0;
			this.textBox_zset_value.Multiline = true;
			this.textBox_zset_value.Name = "textBox_zset_value";
			this.textBox_zset_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_zset_value.Size = new System.Drawing.Size(376, 51);
			this.textBox_zset_value.TabIndex = 2;
			// 
			// label_zset_value
			// 
			this.label_zset_value.AutoSize = true;
			this.label_zset_value.Location = new System.Drawing.Point(44, 93);
			this.label_zset_value.Name = "label_zset_value";
			this.label_zset_value.Size = new System.Drawing.Size(54, 19);
			this.label_zset_value.TabIndex = 17;
			this.label_zset_value.Text = "Value";
			// 
			// textBox_zset_key
			// 
			this.textBox_zset_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_zset_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_zset_key.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_zset_key.Location = new System.Drawing.Point(109, 22);
			this.textBox_zset_key.Name = "textBox_zset_key";
			this.textBox_zset_key.Size = new System.Drawing.Size(376, 26);
			this.textBox_zset_key.TabIndex = 0;
			// 
			// label_zset_key
			// 
			this.label_zset_key.AutoSize = true;
			this.label_zset_key.Location = new System.Drawing.Point(44, 25);
			this.label_zset_key.Name = "label_zset_key";
			this.label_zset_key.Size = new System.Drawing.Size(36, 19);
			this.label_zset_key.TabIndex = 15;
			this.label_zset_key.Text = "Key";
			// 
			// FormRedisInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 231);
			this.Controls.Add(this.tabControl_type);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRedisInput";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add new";
			this.Load += new System.EventHandler(this.FormRedisInput_Load);
			this.tabControl_type.ResumeLayout(false);
			this.tabPage_string.ResumeLayout(false);
			this.tabPage_string.PerformLayout();
			this.tabPage_hash.ResumeLayout(false);
			this.tabPage_hash.PerformLayout();
			this.tabPage_list.ResumeLayout(false);
			this.tabPage_list.PerformLayout();
			this.tabPage_set.ResumeLayout(false);
			this.tabPage_set.PerformLayout();
			this.tabPage_zset.ResumeLayout(false);
			this.tabPage_zset.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_type;
        private System.Windows.Forms.TabPage tabPage_string;
        private System.Windows.Forms.TabPage tabPage_hash;
        private System.Windows.Forms.Button button_string_save;
        private System.Windows.Forms.TextBox textBox_string_value;
        private System.Windows.Forms.Label label_string_value;
        private System.Windows.Forms.TextBox textBox_string_key;
        private System.Windows.Forms.Label label_string_key;
        private System.Windows.Forms.TextBox textBox_hash_hash_key;
        private System.Windows.Forms.Label label_hash_hash_key;
        private System.Windows.Forms.Button button_hash_save;
        private System.Windows.Forms.TextBox textBox_hash_value;
        private System.Windows.Forms.Label label_hash_value;
        private System.Windows.Forms.TextBox textBox_hash_key;
        private System.Windows.Forms.Label label_hash_key;
		private System.Windows.Forms.TabPage tabPage_list;
		private System.Windows.Forms.Button button_list_save;
		private System.Windows.Forms.TextBox textBox_list_value;
		private System.Windows.Forms.Label label_list_value;
		private System.Windows.Forms.TextBox textBox_list_key;
		private System.Windows.Forms.Label label_list_key;
		private System.Windows.Forms.RadioButton radioButton_list_right_push;
		private System.Windows.Forms.RadioButton radioButton_list_left_push;
		private System.Windows.Forms.TabPage tabPage_set;
		private System.Windows.Forms.Button button_set_save;
		private System.Windows.Forms.TextBox textBox_set_value;
		private System.Windows.Forms.Label label_set_value;
		private System.Windows.Forms.TextBox textBox_set_key;
		private System.Windows.Forms.Label label_set_key;
		private System.Windows.Forms.TabPage tabPage_zset;
		private System.Windows.Forms.TextBox textBox_zset_score;
		private System.Windows.Forms.Label label_zset_score;
		private System.Windows.Forms.Button button_zset_save;
		private System.Windows.Forms.TextBox textBox_zset_value;
		private System.Windows.Forms.Label label_zset_value;
		private System.Windows.Forms.TextBox textBox_zset_key;
		private System.Windows.Forms.Label label_zset_key;
	}
}