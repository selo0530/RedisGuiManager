namespace RedisGuiManager
{
	partial class FormMigrateKey
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
			this.label_host = new System.Windows.Forms.Label();
			this.textBox_host = new System.Windows.Forms.TextBox();
			this.button_ok = new System.Windows.Forms.Button();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.label_port = new System.Windows.Forms.Label();
			this.textBox_db_num = new System.Windows.Forms.TextBox();
			this.label_db_num = new System.Windows.Forms.Label();
			this.textBox_key_pattern = new System.Windows.Forms.TextBox();
			this.label_key_pattern = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_host
			// 
			this.label_host.AutoSize = true;
			this.label_host.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_host.Location = new System.Drawing.Point(12, 7);
			this.label_host.Name = "label_host";
			this.label_host.Size = new System.Drawing.Size(45, 19);
			this.label_host.TabIndex = 0;
			this.label_host.Text = "Host";
			// 
			// textBox_host
			// 
			this.textBox_host.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_host.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_host.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_host.Location = new System.Drawing.Point(12, 29);
			this.textBox_host.Name = "textBox_host";
			this.textBox_host.Size = new System.Drawing.Size(316, 26);
			this.textBox_host.TabIndex = 1;
			this.textBox_host.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyUp);
			// 
			// button_ok
			// 
			this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_ok.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_ok.Location = new System.Drawing.Point(128, 266);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 25);
			this.button_ok.TabIndex = 5;
			this.button_ok.Text = "OK";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// textBox_port
			// 
			this.textBox_port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_port.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_port.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_port.Location = new System.Drawing.Point(12, 84);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(316, 26);
			this.textBox_port.TabIndex = 2;
			this.textBox_port.Text = "6379";
			this.textBox_port.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyUp);
			// 
			// label_port
			// 
			this.label_port.AutoSize = true;
			this.label_port.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_port.Location = new System.Drawing.Point(12, 62);
			this.label_port.Name = "label_port";
			this.label_port.Size = new System.Drawing.Size(45, 19);
			this.label_port.TabIndex = 4;
			this.label_port.Text = "Port";
			// 
			// textBox_db_num
			// 
			this.textBox_db_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_db_num.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_db_num.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_db_num.Location = new System.Drawing.Point(12, 146);
			this.textBox_db_num.Name = "textBox_db_num";
			this.textBox_db_num.Size = new System.Drawing.Size(316, 26);
			this.textBox_db_num.TabIndex = 3;
			this.textBox_db_num.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyUp);
			// 
			// label_db_num
			// 
			this.label_db_num.AutoSize = true;
			this.label_db_num.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_db_num.Location = new System.Drawing.Point(12, 124);
			this.label_db_num.Name = "label_db_num";
			this.label_db_num.Size = new System.Drawing.Size(90, 19);
			this.label_db_num.TabIndex = 6;
			this.label_db_num.Text = "DB Number";
			// 
			// textBox_key_pattern
			// 
			this.textBox_key_pattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_key_pattern.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_key_pattern.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_key_pattern.Location = new System.Drawing.Point(12, 212);
			this.textBox_key_pattern.Name = "textBox_key_pattern";
			this.textBox_key_pattern.Size = new System.Drawing.Size(316, 26);
			this.textBox_key_pattern.TabIndex = 4;
			this.textBox_key_pattern.Visible = false;
			this.textBox_key_pattern.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyUp);
			// 
			// label_key_pattern
			// 
			this.label_key_pattern.AutoSize = true;
			this.label_key_pattern.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_key_pattern.Location = new System.Drawing.Point(12, 190);
			this.label_key_pattern.Name = "label_key_pattern";
			this.label_key_pattern.Size = new System.Drawing.Size(108, 19);
			this.label_key_pattern.TabIndex = 8;
			this.label_key_pattern.Text = "Key pattern";
			this.label_key_pattern.Visible = false;
			// 
			// FormMigrateKey
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(340, 302);
			this.Controls.Add(this.textBox_key_pattern);
			this.Controls.Add(this.label_key_pattern);
			this.Controls.Add(this.textBox_db_num);
			this.Controls.Add(this.label_db_num);
			this.Controls.Add(this.textBox_port);
			this.Controls.Add(this.label_port);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.textBox_host);
			this.Controls.Add(this.label_host);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMigrateKey";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Migrate key";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_host;
		private System.Windows.Forms.TextBox textBox_host;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.Label label_port;
		private System.Windows.Forms.TextBox textBox_db_num;
		private System.Windows.Forms.Label label_db_num;
		private System.Windows.Forms.TextBox textBox_key_pattern;
		private System.Windows.Forms.Label label_key_pattern;
	}
}