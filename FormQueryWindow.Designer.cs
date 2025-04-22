
namespace RedisGuiManager
{
    partial class FormQueryWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueryWindow));
            this.label_server_info = new System.Windows.Forms.Label();
            this.textBox_server_info = new System.Windows.Forms.TextBox();
            this.label_keys_filter = new System.Windows.Forms.Label();
            this.textBox_keys_filter = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_query = new System.Windows.Forms.SplitContainer();
            this.richTextBox_query = new RedisGuiManager.SyntaxRichTextBox();
            this.checkBox_reuse_table = new System.Windows.Forms.CheckBox();
            this.label_query = new System.Windows.Forms.Label();
            this.button_query_execute = new System.Windows.Forms.Button();
            this.treeView_field_names = new System.Windows.Forms.TreeView();
            this.label_field_names = new System.Windows.Forms.Label();
            this.dataGridView_query_result = new System.Windows.Forms.DataGridView();
            this.button_col_row_count = new System.Windows.Forms.Button();
            this.statusStrip_status = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_status = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_table_name = new System.Windows.Forms.Label();
            this.textBox_table = new System.Windows.Forms.TextBox();
            this.label_keys_type = new System.Windows.Forms.Label();
            this.comboBox_keys_type = new System.Windows.Forms.ComboBox();
            this.autocompleteMenu = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_query)).BeginInit();
            this.splitContainer_query.Panel1.SuspendLayout();
            this.splitContainer_query.Panel2.SuspendLayout();
            this.splitContainer_query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_query_result)).BeginInit();
            this.statusStrip_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_server_info
            // 
            this.label_server_info.AutoSize = true;
            this.label_server_info.Location = new System.Drawing.Point(15, 14);
            this.label_server_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_server_info.Name = "label_server_info";
            this.label_server_info.Size = new System.Drawing.Size(63, 19);
            this.label_server_info.TabIndex = 0;
            this.label_server_info.Text = "Server";
            // 
            // textBox_server_info
            // 
            this.textBox_server_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenu.SetAutocompleteMenu(this.textBox_server_info, null);
            this.textBox_server_info.Location = new System.Drawing.Point(85, 11);
            this.textBox_server_info.MaxLength = 0;
            this.textBox_server_info.Name = "textBox_server_info";
            this.textBox_server_info.ReadOnly = true;
            this.textBox_server_info.Size = new System.Drawing.Size(741, 26);
            this.textBox_server_info.TabIndex = 1;
            this.textBox_server_info.TabStop = false;
            // 
            // label_keys_filter
            // 
            this.label_keys_filter.AutoSize = true;
            this.label_keys_filter.Location = new System.Drawing.Point(16, 46);
            this.label_keys_filter.Name = "label_keys_filter";
            this.label_keys_filter.Size = new System.Drawing.Size(108, 19);
            this.label_keys_filter.TabIndex = 2;
            this.label_keys_filter.Text = "Keys filter";
            // 
            // textBox_keys_filter
            // 
            this.textBox_keys_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenu.SetAutocompleteMenu(this.textBox_keys_filter, null);
            this.textBox_keys_filter.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox_keys_filter.Location = new System.Drawing.Point(130, 43);
            this.textBox_keys_filter.MaxLength = 0;
            this.textBox_keys_filter.Name = "textBox_keys_filter";
            this.textBox_keys_filter.Size = new System.Drawing.Size(487, 26);
            this.textBox_keys_filter.TabIndex = 3;
            this.textBox_keys_filter.TabStop = false;
            this.textBox_keys_filter.Text = "*";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 107);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer_query);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_query_result);
            this.splitContainer1.Panel2.Controls.Add(this.button_col_row_count);
            this.splitContainer1.Size = new System.Drawing.Size(837, 516);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer_query
            // 
            this.splitContainer_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_query.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_query.Name = "splitContainer_query";
            // 
            // splitContainer_query.Panel1
            // 
            this.splitContainer_query.Panel1.Controls.Add(this.richTextBox_query);
            this.splitContainer_query.Panel1.Controls.Add(this.checkBox_reuse_table);
            this.splitContainer_query.Panel1.Controls.Add(this.label_query);
            this.splitContainer_query.Panel1.Controls.Add(this.button_query_execute);
            // 
            // splitContainer_query.Panel2
            // 
            this.splitContainer_query.Panel2.Controls.Add(this.treeView_field_names);
            this.splitContainer_query.Panel2.Controls.Add(this.label_field_names);
            this.splitContainer_query.Size = new System.Drawing.Size(837, 233);
            this.splitContainer_query.SplitterDistance = 672;
            this.splitContainer_query.TabIndex = 9;
            // 
            // richTextBox_query
            // 
            this.richTextBox_query.AcceptsTab = true;
            this.richTextBox_query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenu.SetAutocompleteMenu(this.richTextBox_query, this.autocompleteMenu);
            this.richTextBox_query.HideSelection = false;
            this.richTextBox_query.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.richTextBox_query.Location = new System.Drawing.Point(3, 37);
            this.richTextBox_query.MaxLength = 0;
            this.richTextBox_query.Name = "richTextBox_query";
            this.richTextBox_query.Size = new System.Drawing.Size(666, 193);
            this.richTextBox_query.TabIndex = 4;
            this.richTextBox_query.Text = "";
            this.richTextBox_query.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_query_KeyUp);
            // 
            // checkBox_reuse_table
            // 
            this.checkBox_reuse_table.AutoSize = true;
            this.checkBox_reuse_table.Location = new System.Drawing.Point(106, 8);
            this.checkBox_reuse_table.Name = "checkBox_reuse_table";
            this.checkBox_reuse_table.Size = new System.Drawing.Size(127, 23);
            this.checkBox_reuse_table.TabIndex = 6;
            this.checkBox_reuse_table.TabStop = false;
            this.checkBox_reuse_table.Text = "Reuse table";
            this.checkBox_reuse_table.UseVisualStyleBackColor = true;
            this.checkBox_reuse_table.CheckedChanged += new System.EventHandler(this.checkBox_reuse_table_CheckedChanged);
            // 
            // label_query
            // 
            this.label_query.AutoSize = true;
            this.label_query.Location = new System.Drawing.Point(7, 9);
            this.label_query.Name = "label_query";
            this.label_query.Size = new System.Drawing.Size(54, 19);
            this.label_query.TabIndex = 3;
            this.label_query.Text = "Query";
            // 
            // button_query_execute
            // 
            this.button_query_execute.Location = new System.Drawing.Point(67, 4);
            this.button_query_execute.Name = "button_query_execute";
            this.button_query_execute.Size = new System.Drawing.Size(33, 29);
            this.button_query_execute.TabIndex = 5;
            this.button_query_execute.TabStop = false;
            this.button_query_execute.Text = "▶";
            this.button_query_execute.UseVisualStyleBackColor = true;
            this.button_query_execute.Click += new System.EventHandler(this.button_query_go_Click);
            // 
            // treeView_field_names
            // 
            this.treeView_field_names.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_field_names.FullRowSelect = true;
            this.treeView_field_names.HideSelection = false;
            this.treeView_field_names.Location = new System.Drawing.Point(3, 37);
            this.treeView_field_names.Name = "treeView_field_names";
            this.treeView_field_names.Size = new System.Drawing.Size(155, 193);
            this.treeView_field_names.TabIndex = 7;
            this.treeView_field_names.TabStop = false;
            this.treeView_field_names.DoubleClick += new System.EventHandler(this.treeView_field_names_DoubleClick);
            // 
            // label_field_names
            // 
            this.label_field_names.AutoSize = true;
            this.label_field_names.Location = new System.Drawing.Point(3, 9);
            this.label_field_names.Name = "label_field_names";
            this.label_field_names.Size = new System.Drawing.Size(108, 19);
            this.label_field_names.TabIndex = 8;
            this.label_field_names.Text = "Field names";
            // 
            // dataGridView_query_result
            // 
            this.dataGridView_query_result.AllowUserToAddRows = false;
            this.dataGridView_query_result.AllowUserToDeleteRows = false;
            this.dataGridView_query_result.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dataGridView_query_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_query_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_query_result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_query_result.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_query_result.Name = "dataGridView_query_result";
            this.dataGridView_query_result.ReadOnly = true;
            this.dataGridView_query_result.RowHeadersVisible = false;
            this.dataGridView_query_result.RowTemplate.Height = 23;
            this.dataGridView_query_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_query_result.Size = new System.Drawing.Size(837, 258);
            this.dataGridView_query_result.TabIndex = 0;
            this.dataGridView_query_result.TabStop = false;
            this.dataGridView_query_result.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_query_result_CellFormatting);
            this.dataGridView_query_result.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_query_result_CellMouseUp);
            // 
            // button_col_row_count
            // 
            this.button_col_row_count.Font = new System.Drawing.Font("Consolas", 9F);
            this.button_col_row_count.Location = new System.Drawing.Point(-1, 0);
            this.button_col_row_count.Name = "button_col_row_count";
            this.button_col_row_count.Size = new System.Drawing.Size(182, 22);
            this.button_col_row_count.TabIndex = 1;
            this.button_col_row_count.TabStop = false;
            this.button_col_row_count.Text = "(0r x 0c)";
            this.button_col_row_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_col_row_count.UseVisualStyleBackColor = true;
            // 
            // statusStrip_status
            // 
            this.statusStrip_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_status,
            this.toolStripStatusLabel_status});
            this.statusStrip_status.Location = new System.Drawing.Point(0, 626);
            this.statusStrip_status.Name = "statusStrip_status";
            this.statusStrip_status.Size = new System.Drawing.Size(838, 22);
            this.statusStrip_status.TabIndex = 1;
            this.statusStrip_status.Text = "statusStrip1";
            // 
            // toolStripProgressBar_status
            // 
            this.toolStripProgressBar_status.Name = "toolStripProgressBar_status";
            this.toolStripProgressBar_status.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel_status
            // 
            this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
            this.toolStripStatusLabel_status.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel_status.Text = "Done";
            // 
            // label_table_name
            // 
            this.label_table_name.AutoSize = true;
            this.label_table_name.Location = new System.Drawing.Point(15, 78);
            this.label_table_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_table_name.Name = "label_table_name";
            this.label_table_name.Size = new System.Drawing.Size(54, 19);
            this.label_table_name.TabIndex = 5;
            this.label_table_name.Text = "Table";
            // 
            // textBox_table
            // 
            this.textBox_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenu.SetAutocompleteMenu(this.textBox_table, null);
            this.textBox_table.Location = new System.Drawing.Point(85, 75);
            this.textBox_table.MaxLength = 0;
            this.textBox_table.Name = "textBox_table";
            this.textBox_table.ReadOnly = true;
            this.textBox_table.Size = new System.Drawing.Size(741, 26);
            this.textBox_table.TabIndex = 6;
            this.textBox_table.TabStop = false;
            // 
            // label_keys_type
            // 
            this.label_keys_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_keys_type.AutoSize = true;
            this.label_keys_type.Location = new System.Drawing.Point(623, 46);
            this.label_keys_type.Name = "label_keys_type";
            this.label_keys_type.Size = new System.Drawing.Size(90, 19);
            this.label_keys_type.TabIndex = 7;
            this.label_keys_type.Text = "Keys type";
            // 
            // comboBox_keys_type
            // 
            this.comboBox_keys_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_keys_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_keys_type.FormattingEnabled = true;
            this.comboBox_keys_type.Items.AddRange(new object[] {
            "String",
            "List",
            "Set",
            "Zset",
            "Hash"});
            this.comboBox_keys_type.Location = new System.Drawing.Point(717, 43);
            this.comboBox_keys_type.Name = "comboBox_keys_type";
            this.comboBox_keys_type.Size = new System.Drawing.Size(109, 27);
            this.comboBox_keys_type.TabIndex = 8;
            this.comboBox_keys_type.TabStop = false;
            // 
            // autocompleteMenu
            // 
            this.autocompleteMenu.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu.Colors")));
            this.autocompleteMenu.Font = new System.Drawing.Font("Consolas", 12F);
            this.autocompleteMenu.ImageList = null;
            this.autocompleteMenu.Items = new string[0];
            this.autocompleteMenu.TargetControlWrapper = null;
            // 
            // FormQueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 648);
            this.Controls.Add(this.comboBox_keys_type);
            this.Controls.Add(this.label_keys_type);
            this.Controls.Add(this.textBox_table);
            this.Controls.Add(this.label_table_name);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox_keys_filter);
            this.Controls.Add(this.label_keys_filter);
            this.Controls.Add(this.textBox_server_info);
            this.Controls.Add(this.label_server_info);
            this.Controls.Add(this.statusStrip_status);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQueryWindow";
            this.Text = "Query window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQueryWindow_FormClosing);
            this.Shown += new System.EventHandler(this.FormQueryWindow_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer_query.Panel1.ResumeLayout(false);
            this.splitContainer_query.Panel1.PerformLayout();
            this.splitContainer_query.Panel2.ResumeLayout(false);
            this.splitContainer_query.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_query)).EndInit();
            this.splitContainer_query.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_query_result)).EndInit();
            this.statusStrip_status.ResumeLayout(false);
            this.statusStrip_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_server_info;
        private System.Windows.Forms.TextBox textBox_server_info;
        private System.Windows.Forms.Label label_keys_filter;
        private System.Windows.Forms.TextBox textBox_keys_filter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SyntaxRichTextBox richTextBox_query;
        private System.Windows.Forms.Label label_query;
        private System.Windows.Forms.DataGridView dataGridView_query_result;
        private System.Windows.Forms.Button button_query_execute;
        private System.Windows.Forms.StatusStrip statusStrip_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
        private System.Windows.Forms.Label label_table_name;
        private System.Windows.Forms.TextBox textBox_table;
        private System.Windows.Forms.CheckBox checkBox_reuse_table;
        private System.Windows.Forms.Label label_keys_type;
        private System.Windows.Forms.ComboBox comboBox_keys_type;
        private System.Windows.Forms.TreeView treeView_field_names;
        private System.Windows.Forms.Label label_field_names;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu;
        private System.Windows.Forms.Button button_col_row_count;
        private System.Windows.Forms.SplitContainer splitContainer_query;
    }
}