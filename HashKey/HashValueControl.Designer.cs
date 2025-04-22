namespace RedisGuiManager
{
    partial class HashValueControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer_hash = new System.Windows.Forms.SplitContainer();
			this.checkBox_search_only_field = new System.Windows.Forms.CheckBox();
			this.textBox_field = new System.Windows.Forms.TextBox();
			this.label_field = new System.Windows.Forms.Label();
			this.button_save = new System.Windows.Forms.Button();
			this.checkBox_search_grep = new System.Windows.Forms.CheckBox();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.label_search = new System.Windows.Forms.Label();
			this.label_length_val = new System.Windows.Forms.Label();
			this.label_length = new System.Windows.Forms.Label();
			this.label_size = new System.Windows.Forms.Label();
			this.label_total = new System.Windows.Forms.Label();
			this.button_refresh = new System.Windows.Forms.Button();
			this.button_delete_row = new System.Windows.Forms.Button();
			this.button_insert_row = new System.Windows.Forms.Button();
			this.dataGridView_hash = new System.Windows.Forms.DataGridView();
			this.Column_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.keyOperateControl = new RedisGuiManager.KeyOperateControl();
			this.valueControl = new RedisGuiManager.ValueControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_hash)).BeginInit();
			this.splitContainer_hash.Panel1.SuspendLayout();
			this.splitContainer_hash.Panel2.SuspendLayout();
			this.splitContainer_hash.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_hash)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer_hash
			// 
			this.splitContainer_hash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer_hash.Location = new System.Drawing.Point(3, 37);
			this.splitContainer_hash.Name = "splitContainer_hash";
			this.splitContainer_hash.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer_hash.Panel1
			// 
			this.splitContainer_hash.Panel1.Controls.Add(this.checkBox_search_only_field);
			this.splitContainer_hash.Panel1.Controls.Add(this.textBox_field);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_field);
			this.splitContainer_hash.Panel1.Controls.Add(this.button_save);
			this.splitContainer_hash.Panel1.Controls.Add(this.checkBox_search_grep);
			this.splitContainer_hash.Panel1.Controls.Add(this.textBox_search);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_search);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_length_val);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_length);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_size);
			this.splitContainer_hash.Panel1.Controls.Add(this.label_total);
			this.splitContainer_hash.Panel1.Controls.Add(this.button_refresh);
			this.splitContainer_hash.Panel1.Controls.Add(this.button_delete_row);
			this.splitContainer_hash.Panel1.Controls.Add(this.button_insert_row);
			this.splitContainer_hash.Panel1.Controls.Add(this.dataGridView_hash);
			// 
			// splitContainer_hash.Panel2
			// 
			this.splitContainer_hash.Panel2.Controls.Add(this.valueControl);
			this.splitContainer_hash.Size = new System.Drawing.Size(841, 573);
			this.splitContainer_hash.SplitterDistance = 259;
			this.splitContainer_hash.TabIndex = 1;
			// 
			// checkBox_search_only_field
			// 
			this.checkBox_search_only_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_search_only_field.AutoSize = true;
			this.checkBox_search_only_field.Checked = true;
			this.checkBox_search_only_field.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_search_only_field.Font = new System.Drawing.Font("Consolas", 9F);
			this.checkBox_search_only_field.Location = new System.Drawing.Point(747, 194);
			this.checkBox_search_only_field.Name = "checkBox_search_only_field";
			this.checkBox_search_only_field.Size = new System.Drawing.Size(96, 18);
			this.checkBox_search_only_field.TabIndex = 29;
			this.checkBox_search_only_field.Text = "Only field";
			this.checkBox_search_only_field.UseVisualStyleBackColor = true;
			// 
			// textBox_field
			// 
			this.textBox_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_field.Location = new System.Drawing.Point(76, 230);
			this.textBox_field.Name = "textBox_field";
			this.textBox_field.ReadOnly = true;
			this.textBox_field.Size = new System.Drawing.Size(656, 26);
			this.textBox_field.TabIndex = 28;
			// 
			// label_field
			// 
			this.label_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_field.AutoSize = true;
			this.label_field.Location = new System.Drawing.Point(4, 233);
			this.label_field.Name = "label_field";
			this.label_field.Size = new System.Drawing.Size(72, 19);
			this.label_field.TabIndex = 27;
			this.label_field.Text = "Field :";
			// 
			// button_save
			// 
			this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_save.Enabled = false;
			this.button_save.Location = new System.Drawing.Point(738, 230);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(100, 26);
			this.button_save.TabIndex = 14;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// checkBox_search_grep
			// 
			this.checkBox_search_grep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_search_grep.AutoSize = true;
			this.checkBox_search_grep.Location = new System.Drawing.Point(747, 170);
			this.checkBox_search_grep.Name = "checkBox_search_grep";
			this.checkBox_search_grep.Size = new System.Drawing.Size(73, 23);
			this.checkBox_search_grep.TabIndex = 13;
			this.checkBox_search_grep.Text = "Grep?";
			this.checkBox_search_grep.UseVisualStyleBackColor = true;
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_search.Location = new System.Drawing.Point(738, 138);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(100, 26);
			this.textBox_search.TabIndex = 12;
			this.textBox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyUp);
			// 
			// label_search
			// 
			this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_search.AutoSize = true;
			this.label_search.Font = new System.Drawing.Font("Consolas", 10F);
			this.label_search.Location = new System.Drawing.Point(738, 116);
			this.label_search.Name = "label_search";
			this.label_search.Size = new System.Drawing.Size(56, 17);
			this.label_search.TabIndex = 11;
			this.label_search.Text = "Search";
			// 
			// label_length_val
			// 
			this.label_length_val.AutoSize = true;
			this.label_length_val.ForeColor = System.Drawing.Color.Silver;
			this.label_length_val.Location = new System.Drawing.Point(289, 6);
			this.label_length_val.Name = "label_length_val";
			this.label_length_val.Size = new System.Drawing.Size(18, 19);
			this.label_length_val.TabIndex = 10;
			this.label_length_val.Text = "0";
			// 
			// label_length
			// 
			this.label_length.AutoSize = true;
			this.label_length.Location = new System.Drawing.Point(211, 6);
			this.label_length.Name = "label_length";
			this.label_length.Size = new System.Drawing.Size(90, 19);
			this.label_length.TabIndex = 9;
			this.label_length.Text = "Length : ";
			// 
			// label_size
			// 
			this.label_size.AutoSize = true;
			this.label_size.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_size.ForeColor = System.Drawing.Color.Silver;
			this.label_size.Location = new System.Drawing.Point(72, 6);
			this.label_size.Name = "label_size";
			this.label_size.Size = new System.Drawing.Size(108, 19);
			this.label_size.TabIndex = 8;
			this.label_size.Text = "Size : 0 KB";
			// 
			// label_total
			// 
			this.label_total.AutoSize = true;
			this.label_total.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_total.Location = new System.Drawing.Point(3, 6);
			this.label_total.Name = "label_total";
			this.label_total.Size = new System.Drawing.Size(81, 19);
			this.label_total.TabIndex = 7;
			this.label_total.Text = "Total : ";
			// 
			// button_refresh
			// 
			this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_refresh.Font = new System.Drawing.Font("Consolas", 11F);
			this.button_refresh.Location = new System.Drawing.Point(738, 88);
			this.button_refresh.Name = "button_refresh";
			this.button_refresh.Size = new System.Drawing.Size(100, 25);
			this.button_refresh.TabIndex = 4;
			this.button_refresh.Text = "Refresh row";
			this.button_refresh.UseVisualStyleBackColor = true;
			this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
			// 
			// button_delete_row
			// 
			this.button_delete_row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete_row.Font = new System.Drawing.Font("Consolas", 11F);
			this.button_delete_row.Location = new System.Drawing.Point(738, 57);
			this.button_delete_row.Name = "button_delete_row";
			this.button_delete_row.Size = new System.Drawing.Size(100, 25);
			this.button_delete_row.TabIndex = 3;
			this.button_delete_row.Text = "Delete row";
			this.button_delete_row.UseVisualStyleBackColor = true;
			this.button_delete_row.Click += new System.EventHandler(this.button_delete_row_Click);
			// 
			// button_insert_row
			// 
			this.button_insert_row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_insert_row.Font = new System.Drawing.Font("Consolas", 11F);
			this.button_insert_row.Location = new System.Drawing.Point(738, 26);
			this.button_insert_row.Name = "button_insert_row";
			this.button_insert_row.Size = new System.Drawing.Size(100, 25);
			this.button_insert_row.TabIndex = 1;
			this.button_insert_row.Text = "Insert row";
			this.button_insert_row.UseVisualStyleBackColor = true;
			this.button_insert_row.Click += new System.EventHandler(this.button_insert_row_Click);
			// 
			// dataGridView_hash
			// 
			this.dataGridView_hash.AllowUserToAddRows = false;
			this.dataGridView_hash.AllowUserToDeleteRows = false;
			this.dataGridView_hash.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.dataGridView_hash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_hash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_hash.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_hash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_hash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_field,
            this.Column_value});
			this.dataGridView_hash.Location = new System.Drawing.Point(3, 26);
			this.dataGridView_hash.MultiSelect = false;
			this.dataGridView_hash.Name = "dataGridView_hash";
			this.dataGridView_hash.ReadOnly = true;
			this.dataGridView_hash.RowHeadersVisible = false;
			this.dataGridView_hash.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView_hash.RowTemplate.Height = 23;
			this.dataGridView_hash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_hash.Size = new System.Drawing.Size(729, 198);
			this.dataGridView_hash.TabIndex = 0;
			this.dataGridView_hash.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_hash_CellFormatting);
			this.dataGridView_hash.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_hash_CellMouseUp);
			this.dataGridView_hash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_hash_KeyUp);
			// 
			// Column_field
			// 
			this.Column_field.HeaderText = "Field";
			this.Column_field.Name = "Column_field";
			this.Column_field.ReadOnly = true;
			this.Column_field.Width = 200;
			// 
			// Column_value
			// 
			this.Column_value.HeaderText = "Value";
			this.Column_value.Name = "Column_value";
			this.Column_value.ReadOnly = true;
			this.Column_value.Width = 400;
			// 
			// keyOperateControl
			// 
			this.keyOperateControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.keyOperateControl.BackColor = System.Drawing.Color.White;
			this.keyOperateControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.keyOperateControl.KeyType = "Hash:";
			this.keyOperateControl.Location = new System.Drawing.Point(0, 3);
			this.keyOperateControl.MainForm = null;
			this.keyOperateControl.Name = "keyOperateControl";
			this.keyOperateControl.Size = new System.Drawing.Size(847, 28);
			this.keyOperateControl.TabIndex = 2;
			this.keyOperateControl.TargetNode = null;
			// 
			// valueControl
			// 
			this.valueControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.valueControl.BackColor = System.Drawing.Color.White;
			this.valueControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.valueControl.Location = new System.Drawing.Point(3, 3);
			this.valueControl.Name = "valueControl";
			this.valueControl.Size = new System.Drawing.Size(835, 307);
			this.valueControl.TabIndex = 0;
			// 
			// HashValueControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.keyOperateControl);
			this.Controls.Add(this.splitContainer_hash);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.Name = "HashValueControl";
			this.Size = new System.Drawing.Size(847, 610);
			this.Load += new System.EventHandler(this.HashValueControl_Load);
			this.splitContainer_hash.Panel1.ResumeLayout(false);
			this.splitContainer_hash.Panel1.PerformLayout();
			this.splitContainer_hash.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer_hash)).EndInit();
			this.splitContainer_hash.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_hash)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer_hash;
		private System.Windows.Forms.Button button_refresh;
		private System.Windows.Forms.Button button_delete_row;
		private System.Windows.Forms.Button button_insert_row;
		private System.Windows.Forms.DataGridView dataGridView_hash;
		private ValueControl valueControl;
		private System.Windows.Forms.Label label_length_val;
		private System.Windows.Forms.Label label_length;
		private System.Windows.Forms.Label label_size;
		private System.Windows.Forms.Label label_total;
		private KeyOperateControl keyOperateControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_value;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.CheckBox checkBox_search_grep;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_field;
        private System.Windows.Forms.Label label_field;
        private System.Windows.Forms.CheckBox checkBox_search_only_field;
    }
}
