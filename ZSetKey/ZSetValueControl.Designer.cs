namespace RedisGuiManager
{
    partial class ZSetValueControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button_save = new System.Windows.Forms.Button();
			this.textBox_score = new System.Windows.Forms.TextBox();
			this.label_score = new System.Windows.Forms.Label();
			this.checkBox_search_grep = new System.Windows.Forms.CheckBox();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.label_search = new System.Windows.Forms.Label();
			this.button_refresh = new System.Windows.Forms.Button();
			this.label_length_val = new System.Windows.Forms.Label();
			this.label_length = new System.Windows.Forms.Label();
			this.label_size = new System.Windows.Forms.Label();
			this.label_total = new System.Windows.Forms.Label();
			this.button_delete_row = new System.Windows.Forms.Button();
			this.button_insert_row = new System.Windows.Forms.Button();
			this.dataGridView_zset = new System.Windows.Forms.DataGridView();
			this.Column_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueControl = new RedisGuiManager.ValueControl();
			this.keyOperateControl = new RedisGuiManager.KeyOperateControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_zset)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(3, 37);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button_save);
			this.splitContainer1.Panel1.Controls.Add(this.textBox_score);
			this.splitContainer1.Panel1.Controls.Add(this.label_score);
			this.splitContainer1.Panel1.Controls.Add(this.checkBox_search_grep);
			this.splitContainer1.Panel1.Controls.Add(this.textBox_search);
			this.splitContainer1.Panel1.Controls.Add(this.label_search);
			this.splitContainer1.Panel1.Controls.Add(this.button_refresh);
			this.splitContainer1.Panel1.Controls.Add(this.label_length_val);
			this.splitContainer1.Panel1.Controls.Add(this.label_length);
			this.splitContainer1.Panel1.Controls.Add(this.label_size);
			this.splitContainer1.Panel1.Controls.Add(this.label_total);
			this.splitContainer1.Panel1.Controls.Add(this.button_delete_row);
			this.splitContainer1.Panel1.Controls.Add(this.button_insert_row);
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView_zset);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.valueControl);
			this.splitContainer1.Size = new System.Drawing.Size(841, 573);
			this.splitContainer1.SplitterDistance = 259;
			this.splitContainer1.TabIndex = 1;
			// 
			// button_save
			// 
			this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_save.Enabled = false;
			this.button_save.Location = new System.Drawing.Point(738, 199);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(100, 26);
			this.button_save.TabIndex = 27;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// textBox_score
			// 
			this.textBox_score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_score.Location = new System.Drawing.Point(77, 230);
			this.textBox_score.Name = "textBox_score";
			this.textBox_score.Size = new System.Drawing.Size(761, 26);
			this.textBox_score.TabIndex = 26;
			// 
			// label_score
			// 
			this.label_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label_score.AutoSize = true;
			this.label_score.Location = new System.Drawing.Point(5, 233);
			this.label_score.Name = "label_score";
			this.label_score.Size = new System.Drawing.Size(72, 19);
			this.label_score.TabIndex = 25;
			this.label_score.Text = "Score :";
			// 
			// checkBox_search_grep
			// 
			this.checkBox_search_grep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_search_grep.AutoSize = true;
			this.checkBox_search_grep.Location = new System.Drawing.Point(747, 171);
			this.checkBox_search_grep.Name = "checkBox_search_grep";
			this.checkBox_search_grep.Size = new System.Drawing.Size(73, 23);
			this.checkBox_search_grep.TabIndex = 24;
			this.checkBox_search_grep.Text = "Grep?";
			this.checkBox_search_grep.UseVisualStyleBackColor = true;
			// 
			// textBox_search
			// 
			this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_search.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_search.Location = new System.Drawing.Point(738, 139);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(100, 26);
			this.textBox_search.TabIndex = 23;
			this.textBox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyUp);
			// 
			// label_search
			// 
			this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_search.AutoSize = true;
			this.label_search.Font = new System.Drawing.Font("Consolas", 10F);
			this.label_search.Location = new System.Drawing.Point(738, 117);
			this.label_search.Name = "label_search";
			this.label_search.Size = new System.Drawing.Size(56, 17);
			this.label_search.TabIndex = 22;
			this.label_search.Text = "Search";
			// 
			// button_refresh
			// 
			this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_refresh.Font = new System.Drawing.Font("Consolas", 11F);
			this.button_refresh.Location = new System.Drawing.Point(738, 88);
			this.button_refresh.Name = "button_refresh";
			this.button_refresh.Size = new System.Drawing.Size(100, 25);
			this.button_refresh.TabIndex = 11;
			this.button_refresh.Text = "Refresh";
			this.button_refresh.UseVisualStyleBackColor = true;
			this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
			// 
			// label_length_val
			// 
			this.label_length_val.AutoSize = true;
			this.label_length_val.ForeColor = System.Drawing.Color.Silver;
			this.label_length_val.Location = new System.Drawing.Point(282, 6);
			this.label_length_val.Name = "label_length_val";
			this.label_length_val.Size = new System.Drawing.Size(18, 19);
			this.label_length_val.TabIndex = 10;
			this.label_length_val.Text = "0";
			// 
			// label_length
			// 
			this.label_length.AutoSize = true;
			this.label_length.Location = new System.Drawing.Point(205, 6);
			this.label_length.Name = "label_length";
			this.label_length.Size = new System.Drawing.Size(81, 19);
			this.label_length.TabIndex = 9;
			this.label_length.Text = "Length :";
			// 
			// label_size
			// 
			this.label_size.AutoSize = true;
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
			this.label_total.Location = new System.Drawing.Point(3, 6);
			this.label_total.Name = "label_total";
			this.label_total.Size = new System.Drawing.Size(72, 19);
			this.label_total.TabIndex = 7;
			this.label_total.Text = "Total :";
			// 
			// button_delete_row
			// 
			this.button_delete_row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete_row.Font = new System.Drawing.Font("Consolas", 11F);
			this.button_delete_row.Location = new System.Drawing.Point(738, 57);
			this.button_delete_row.Name = "button_delete_row";
			this.button_delete_row.Size = new System.Drawing.Size(100, 25);
			this.button_delete_row.TabIndex = 3;
			this.button_delete_row.Text = "Delete Row";
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
			this.button_insert_row.Text = "Insert Row";
			this.button_insert_row.UseVisualStyleBackColor = true;
			this.button_insert_row.Click += new System.EventHandler(this.button_insert_row_Click);
			// 
			// dataGridView_zset
			// 
			this.dataGridView_zset.AllowUserToAddRows = false;
			this.dataGridView_zset.AllowUserToDeleteRows = false;
			this.dataGridView_zset.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.dataGridView_zset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_zset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_zset.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_zset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_zset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_index,
            this.Column_value,
            this.Column_score});
			this.dataGridView_zset.Location = new System.Drawing.Point(3, 26);
			this.dataGridView_zset.MultiSelect = false;
			this.dataGridView_zset.Name = "dataGridView_zset";
			this.dataGridView_zset.ReadOnly = true;
			this.dataGridView_zset.RowHeadersVisible = false;
			this.dataGridView_zset.RowTemplate.Height = 23;
			this.dataGridView_zset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_zset.Size = new System.Drawing.Size(729, 199);
			this.dataGridView_zset.TabIndex = 0;
			this.dataGridView_zset.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_zset_CellFormatting);
			this.dataGridView_zset.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_zset_CellMouseUp);
			// 
			// Column_index
			// 
			this.Column_index.HeaderText = "Index";
			this.Column_index.Name = "Column_index";
			this.Column_index.ReadOnly = true;
			// 
			// Column_value
			// 
			this.Column_value.HeaderText = "Value";
			this.Column_value.Name = "Column_value";
			this.Column_value.ReadOnly = true;
			this.Column_value.Width = 400;
			// 
			// Column_score
			// 
			this.Column_score.HeaderText = "Score";
			this.Column_score.Name = "Column_score";
			this.Column_score.ReadOnly = true;
			this.Column_score.Width = 150;
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
			// keyOperateControl
			// 
			this.keyOperateControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.keyOperateControl.BackColor = System.Drawing.Color.White;
			this.keyOperateControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.keyOperateControl.KeyType = "ZSet:";
			this.keyOperateControl.Location = new System.Drawing.Point(0, 3);
			this.keyOperateControl.MainForm = null;
			this.keyOperateControl.Name = "keyOperateControl";
			this.keyOperateControl.Size = new System.Drawing.Size(847, 28);
			this.keyOperateControl.TabIndex = 2;
			this.keyOperateControl.TargetNode = null;
			// 
			// ZSetValueControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.keyOperateControl);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.Name = "ZSetValueControl";
			this.Size = new System.Drawing.Size(847, 610);
			this.Load += new System.EventHandler(this.ZSetValueControl_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_zset)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button_delete_row;
		private System.Windows.Forms.Button button_insert_row;
		private System.Windows.Forms.DataGridView dataGridView_zset;
		private ValueControl valueControl;
		private System.Windows.Forms.Label label_length_val;
		private System.Windows.Forms.Label label_length;
		private System.Windows.Forms.Label label_size;
		private System.Windows.Forms.Label label_total;
		private KeyOperateControl keyOperateControl;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_score;
        private System.Windows.Forms.CheckBox checkBox_search_grep;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Label label_score;
		private System.Windows.Forms.Button button_save;
	}
}
