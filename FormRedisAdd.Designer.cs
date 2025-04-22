namespace RedisGuiManager
{
	partial class FormRedisAdd
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
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_connection_test = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.checkBox_use_tunnel = new System.Windows.Forms.CheckBox();
            this.groupBox_tunnel = new System.Windows.Forms.GroupBox();
            this.checkBox_show_ssh_password = new System.Windows.Forms.CheckBox();
            this.textBox_tunnel_pw = new System.Windows.Forms.TextBox();
            this.label_tunnel_pw = new System.Windows.Forms.Label();
            this.textBox_tunnel_id = new System.Windows.Forms.TextBox();
            this.label_tunnel_id = new System.Windows.Forms.Label();
            this.textBox_tunnel_port = new System.Windows.Forms.TextBox();
            this.label_tunnel_port = new System.Windows.Forms.Label();
            this.textBox_tunnel_ip = new System.Windows.Forms.TextBox();
            this.label_tunnel_ip = new System.Windows.Forms.Label();
            this.label_tunnel_key = new System.Windows.Forms.Label();
            this.textBox_tunnel_key = new System.Windows.Forms.TextBox();
            this.checkBox_use_ssh_key = new System.Windows.Forms.CheckBox();
            this.groupBox_tunnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Consolas", 12F);
            this.label_ip.Location = new System.Drawing.Point(32, 54);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(27, 19);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_ip.Location = new System.Drawing.Point(122, 51);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(246, 26);
            this.textBox_ip.TabIndex = 1;
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_port.Location = new System.Drawing.Point(122, 86);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(246, 26);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "6379";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Consolas", 12F);
            this.label_port.Location = new System.Drawing.Point(32, 89);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(45, 19);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_password.Location = new System.Drawing.Point(122, 121);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(182, 26);
            this.textBox_password.TabIndex = 5;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Consolas", 12F);
            this.label_password.Location = new System.Drawing.Point(32, 124);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(81, 19);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // button_connection_test
            // 
            this.button_connection_test.Location = new System.Drawing.Point(12, 469);
            this.button_connection_test.Name = "button_connection_test";
            this.button_connection_test.Size = new System.Drawing.Size(175, 30);
            this.button_connection_test.TabIndex = 6;
            this.button_connection_test.Text = "Connection Test";
            this.button_connection_test.UseVisualStyleBackColor = true;
            this.button_connection_test.Click += new System.EventHandler(this.button_connection_test_Click);
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(206, 469);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(180, 30);
            this.button_finish.TabIndex = 7;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_name.Location = new System.Drawing.Point(122, 15);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(246, 26);
            this.textBox_name.TabIndex = 9;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Consolas", 12F);
            this.label_name.Location = new System.Drawing.Point(32, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 19);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name";
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.Location = new System.Drawing.Point(310, 123);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(64, 23);
            this.checkBox_show_password.TabIndex = 10;
            this.checkBox_show_password.Text = "Show";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // checkBox_use_tunnel
            // 
            this.checkBox_use_tunnel.AutoSize = true;
            this.checkBox_use_tunnel.Location = new System.Drawing.Point(36, 168);
            this.checkBox_use_tunnel.Name = "checkBox_use_tunnel";
            this.checkBox_use_tunnel.Size = new System.Drawing.Size(118, 23);
            this.checkBox_use_tunnel.TabIndex = 11;
            this.checkBox_use_tunnel.Text = "SSH Tunnel";
            this.checkBox_use_tunnel.UseVisualStyleBackColor = true;
            this.checkBox_use_tunnel.CheckedChanged += new System.EventHandler(this.checkBox_use_tunnel_CheckedChanged);
            // 
            // groupBox_tunnel
            // 
            this.groupBox_tunnel.Controls.Add(this.checkBox_use_ssh_key);
            this.groupBox_tunnel.Controls.Add(this.textBox_tunnel_key);
            this.groupBox_tunnel.Controls.Add(this.label_tunnel_key);
            this.groupBox_tunnel.Controls.Add(this.checkBox_show_ssh_password);
            this.groupBox_tunnel.Controls.Add(this.textBox_tunnel_pw);
            this.groupBox_tunnel.Controls.Add(this.label_tunnel_pw);
            this.groupBox_tunnel.Controls.Add(this.textBox_tunnel_id);
            this.groupBox_tunnel.Controls.Add(this.label_tunnel_id);
            this.groupBox_tunnel.Controls.Add(this.textBox_tunnel_port);
            this.groupBox_tunnel.Controls.Add(this.label_tunnel_port);
            this.groupBox_tunnel.Controls.Add(this.textBox_tunnel_ip);
            this.groupBox_tunnel.Controls.Add(this.label_tunnel_ip);
            this.groupBox_tunnel.Location = new System.Drawing.Point(12, 197);
            this.groupBox_tunnel.Name = "groupBox_tunnel";
            this.groupBox_tunnel.Size = new System.Drawing.Size(374, 191);
            this.groupBox_tunnel.TabIndex = 12;
            this.groupBox_tunnel.TabStop = false;
            // 
            // checkBox_show_ssh_password
            // 
            this.checkBox_show_ssh_password.AutoSize = true;
            this.checkBox_show_ssh_password.Location = new System.Drawing.Point(298, 115);
            this.checkBox_show_ssh_password.Name = "checkBox_show_ssh_password";
            this.checkBox_show_ssh_password.Size = new System.Drawing.Size(64, 23);
            this.checkBox_show_ssh_password.TabIndex = 17;
            this.checkBox_show_ssh_password.Text = "Show";
            this.checkBox_show_ssh_password.UseVisualStyleBackColor = true;
            this.checkBox_show_ssh_password.CheckedChanged += new System.EventHandler(this.checkBox_show_ssh_password_CheckedChanged);
            // 
            // textBox_tunnel_pw
            // 
            this.textBox_tunnel_pw.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_tunnel_pw.Location = new System.Drawing.Point(110, 113);
            this.textBox_tunnel_pw.Name = "textBox_tunnel_pw";
            this.textBox_tunnel_pw.PasswordChar = '*';
            this.textBox_tunnel_pw.Size = new System.Drawing.Size(182, 26);
            this.textBox_tunnel_pw.TabIndex = 16;
            // 
            // label_tunnel_pw
            // 
            this.label_tunnel_pw.AutoSize = true;
            this.label_tunnel_pw.Location = new System.Drawing.Point(20, 116);
            this.label_tunnel_pw.Name = "label_tunnel_pw";
            this.label_tunnel_pw.Size = new System.Drawing.Size(27, 19);
            this.label_tunnel_pw.TabIndex = 15;
            this.label_tunnel_pw.Text = "PW";
            // 
            // textBox_tunnel_id
            // 
            this.textBox_tunnel_id.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_tunnel_id.Location = new System.Drawing.Point(110, 81);
            this.textBox_tunnel_id.Name = "textBox_tunnel_id";
            this.textBox_tunnel_id.Size = new System.Drawing.Size(246, 26);
            this.textBox_tunnel_id.TabIndex = 14;
            // 
            // label_tunnel_id
            // 
            this.label_tunnel_id.AutoSize = true;
            this.label_tunnel_id.Location = new System.Drawing.Point(20, 84);
            this.label_tunnel_id.Name = "label_tunnel_id";
            this.label_tunnel_id.Size = new System.Drawing.Size(27, 19);
            this.label_tunnel_id.TabIndex = 13;
            this.label_tunnel_id.Text = "ID";
            // 
            // textBox_tunnel_port
            // 
            this.textBox_tunnel_port.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_tunnel_port.Location = new System.Drawing.Point(110, 49);
            this.textBox_tunnel_port.Name = "textBox_tunnel_port";
            this.textBox_tunnel_port.Size = new System.Drawing.Size(246, 26);
            this.textBox_tunnel_port.TabIndex = 12;
            // 
            // label_tunnel_port
            // 
            this.label_tunnel_port.AutoSize = true;
            this.label_tunnel_port.Location = new System.Drawing.Point(20, 52);
            this.label_tunnel_port.Name = "label_tunnel_port";
            this.label_tunnel_port.Size = new System.Drawing.Size(45, 19);
            this.label_tunnel_port.TabIndex = 11;
            this.label_tunnel_port.Text = "Port";
            // 
            // textBox_tunnel_ip
            // 
            this.textBox_tunnel_ip.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_tunnel_ip.Location = new System.Drawing.Point(110, 17);
            this.textBox_tunnel_ip.Name = "textBox_tunnel_ip";
            this.textBox_tunnel_ip.Size = new System.Drawing.Size(246, 26);
            this.textBox_tunnel_ip.TabIndex = 10;
            // 
            // label_tunnel_ip
            // 
            this.label_tunnel_ip.AutoSize = true;
            this.label_tunnel_ip.Location = new System.Drawing.Point(20, 20);
            this.label_tunnel_ip.Name = "label_tunnel_ip";
            this.label_tunnel_ip.Size = new System.Drawing.Size(27, 19);
            this.label_tunnel_ip.TabIndex = 0;
            this.label_tunnel_ip.Text = "IP";
            // 
            // label_tunnel_key
            // 
            this.label_tunnel_key.AutoSize = true;
            this.label_tunnel_key.Location = new System.Drawing.Point(20, 148);
            this.label_tunnel_key.Name = "label_tunnel_key";
            this.label_tunnel_key.Size = new System.Drawing.Size(36, 19);
            this.label_tunnel_key.TabIndex = 18;
            this.label_tunnel_key.Text = "Key";
            // 
            // textBox_tunnel_key
            // 
            this.textBox_tunnel_key.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_tunnel_key.Location = new System.Drawing.Point(110, 145);
            this.textBox_tunnel_key.Name = "textBox_tunnel_key";
            this.textBox_tunnel_key.Size = new System.Drawing.Size(182, 26);
            this.textBox_tunnel_key.TabIndex = 19;
            // 
            // checkBox_use_ssh_key
            // 
            this.checkBox_use_ssh_key.AutoSize = true;
            this.checkBox_use_ssh_key.Location = new System.Drawing.Point(298, 147);
            this.checkBox_use_ssh_key.Name = "checkBox_use_ssh_key";
            this.checkBox_use_ssh_key.Size = new System.Drawing.Size(55, 23);
            this.checkBox_use_ssh_key.TabIndex = 20;
            this.checkBox_use_ssh_key.Text = "Use";
            this.checkBox_use_ssh_key.UseVisualStyleBackColor = true;
            // 
            // FormRedisAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 511);
            this.Controls.Add(this.groupBox_tunnel);
            this.Controls.Add(this.checkBox_use_tunnel);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_connection_test);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_ip);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 550);
            this.Name = "FormRedisAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Edit server";
            this.Load += new System.EventHandler(this.FormRedisAdd_Load);
            this.Shown += new System.EventHandler(this.FormRedisAdd_Shown);
            this.groupBox_tunnel.ResumeLayout(false);
            this.groupBox_tunnel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_ip;
		private System.Windows.Forms.TextBox textBox_ip;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.Label label_port;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.Button button_connection_test;
		private System.Windows.Forms.Button button_finish;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.CheckBox checkBox_show_password;
        private System.Windows.Forms.CheckBox checkBox_use_tunnel;
        private System.Windows.Forms.GroupBox groupBox_tunnel;
        private System.Windows.Forms.Label label_tunnel_ip;
        private System.Windows.Forms.TextBox textBox_tunnel_port;
        private System.Windows.Forms.Label label_tunnel_port;
        private System.Windows.Forms.TextBox textBox_tunnel_ip;
        private System.Windows.Forms.TextBox textBox_tunnel_pw;
        private System.Windows.Forms.Label label_tunnel_pw;
        private System.Windows.Forms.TextBox textBox_tunnel_id;
        private System.Windows.Forms.Label label_tunnel_id;
		private System.Windows.Forms.CheckBox checkBox_show_ssh_password;
        private System.Windows.Forms.CheckBox checkBox_use_ssh_key;
        private System.Windows.Forms.TextBox textBox_tunnel_key;
        private System.Windows.Forms.Label label_tunnel_key;
    }
}