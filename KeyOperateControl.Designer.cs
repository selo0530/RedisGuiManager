namespace RedisGuiManager
{
	partial class KeyOperateControl
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
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_rename = new System.Windows.Forms.Button();
            this.button_ttl = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label_type.Location = new System.Drawing.Point(3, 7);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(56, 14);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "String:";
            // 
            // textBox_key
            // 
            this.textBox_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_key.BackColor = System.Drawing.Color.White;
            this.textBox_key.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_key.Location = new System.Drawing.Point(57, 2);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.ReadOnly = true;
            this.textBox_key.Size = new System.Drawing.Size(351, 26);
            this.textBox_key.TabIndex = 1;
            // 
            // button_rename
            // 
            this.button_rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rename.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_rename.Location = new System.Drawing.Point(414, 1);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(108, 25);
            this.button_rename.TabIndex = 2;
            this.button_rename.Text = "Rename Key";
            this.button_rename.UseVisualStyleBackColor = true;
            this.button_rename.Click += new System.EventHandler(this.button_rename_Click);
            // 
            // button_ttl
            // 
            this.button_ttl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ttl.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_ttl.Location = new System.Drawing.Point(528, 1);
            this.button_ttl.Name = "button_ttl";
            this.button_ttl.Size = new System.Drawing.Size(102, 25);
            this.button_ttl.TabIndex = 3;
            this.button_ttl.Text = "TTL:-1";
            this.button_ttl.UseVisualStyleBackColor = true;
            this.button_ttl.Click += new System.EventHandler(this.button_ttl_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_delete.Location = new System.Drawing.Point(636, 1);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(74, 25);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_reload.Location = new System.Drawing.Point(716, 1);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(76, 25);
            this.button_reload.TabIndex = 6;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            // 
            // KeyOperateControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_ttl);
            this.Controls.Add(this.button_rename);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label_type);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "KeyOperateControl";
            this.Size = new System.Drawing.Size(796, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_type;
		private System.Windows.Forms.TextBox textBox_key;
		private System.Windows.Forms.Button button_rename;
		private System.Windows.Forms.Button button_ttl;
		private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.Button button_reload;
	}
}
