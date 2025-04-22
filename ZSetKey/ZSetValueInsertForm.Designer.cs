namespace RedisGuiManager
{
    partial class ZSetValueInsertForm
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
			this.label_server = new System.Windows.Forms.Label();
			this.textBox_server = new System.Windows.Forms.TextBox();
			this.textBox_key = new System.Windows.Forms.TextBox();
			this.label_key = new System.Windows.Forms.Label();
			this.textBox_value = new System.Windows.Forms.TextBox();
			this.label_value = new System.Windows.Forms.Label();
			this.button_save = new System.Windows.Forms.Button();
			this.label_db_num = new System.Windows.Forms.Label();
			this.textBox_db_num = new System.Windows.Forms.TextBox();
			this.textBox_score = new System.Windows.Forms.TextBox();
			this.label_score = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_server
			// 
			this.label_server.AutoSize = true;
			this.label_server.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_server.Location = new System.Drawing.Point(12, 16);
			this.label_server.Name = "label_server";
			this.label_server.Size = new System.Drawing.Size(63, 19);
			this.label_server.TabIndex = 0;
			this.label_server.Text = "Server";
			// 
			// textBox_server
			// 
			this.textBox_server.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_server.Location = new System.Drawing.Point(87, 13);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.ReadOnly = true;
			this.textBox_server.Size = new System.Drawing.Size(332, 26);
			this.textBox_server.TabIndex = 99;
			this.textBox_server.TabStop = false;
			// 
			// textBox_key
			// 
			this.textBox_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_key.Location = new System.Drawing.Point(87, 56);
			this.textBox_key.Name = "textBox_key";
			this.textBox_key.ReadOnly = true;
			this.textBox_key.Size = new System.Drawing.Size(531, 26);
			this.textBox_key.TabIndex = 99;
			this.textBox_key.TabStop = false;
			// 
			// label_key
			// 
			this.label_key.AutoSize = true;
			this.label_key.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_key.Location = new System.Drawing.Point(12, 59);
			this.label_key.Name = "label_key";
			this.label_key.Size = new System.Drawing.Size(36, 19);
			this.label_key.TabIndex = 2;
			this.label_key.Text = "Key";
			// 
			// textBox_value
			// 
			this.textBox_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_value.Location = new System.Drawing.Point(87, 132);
			this.textBox_value.Multiline = true;
			this.textBox_value.Name = "textBox_value";
			this.textBox_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_value.Size = new System.Drawing.Size(531, 201);
			this.textBox_value.TabIndex = 2;
			// 
			// label_value
			// 
			this.label_value.AutoSize = true;
			this.label_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_value.Location = new System.Drawing.Point(12, 132);
			this.label_value.Name = "label_value";
			this.label_value.Size = new System.Drawing.Size(54, 19);
			this.label_value.TabIndex = 4;
			this.label_value.Text = "Value";
			// 
			// button_save
			// 
			this.button_save.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_save.Location = new System.Drawing.Point(256, 346);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(163, 47);
			this.button_save.TabIndex = 3;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// label_db_num
			// 
			this.label_db_num.AutoSize = true;
			this.label_db_num.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_db_num.Location = new System.Drawing.Point(434, 16);
			this.label_db_num.Name = "label_db_num";
			this.label_db_num.Size = new System.Drawing.Size(63, 19);
			this.label_db_num.TabIndex = 7;
			this.label_db_num.Text = "DB Num";
			// 
			// textBox_db_num
			// 
			this.textBox_db_num.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_db_num.Location = new System.Drawing.Point(500, 13);
			this.textBox_db_num.Name = "textBox_db_num";
			this.textBox_db_num.ReadOnly = true;
			this.textBox_db_num.Size = new System.Drawing.Size(118, 26);
			this.textBox_db_num.TabIndex = 99;
			this.textBox_db_num.TabStop = false;
			// 
			// textBox_score
			// 
			this.textBox_score.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_score.Location = new System.Drawing.Point(87, 93);
			this.textBox_score.Name = "textBox_score";
			this.textBox_score.Size = new System.Drawing.Size(531, 26);
			this.textBox_score.TabIndex = 1;
			// 
			// label_score
			// 
			this.label_score.AutoSize = true;
			this.label_score.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_score.Location = new System.Drawing.Point(12, 96);
			this.label_score.Name = "label_score";
			this.label_score.Size = new System.Drawing.Size(54, 19);
			this.label_score.TabIndex = 11;
			this.label_score.Text = "Score";
			// 
			// ZSetValueInsertForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(652, 407);
			this.Controls.Add(this.textBox_score);
			this.Controls.Add(this.label_score);
			this.Controls.Add(this.textBox_db_num);
			this.Controls.Add(this.label_db_num);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.textBox_value);
			this.Controls.Add(this.label_value);
			this.Controls.Add(this.textBox_key);
			this.Controls.Add(this.label_key);
			this.Controls.Add(this.textBox_server);
			this.Controls.Add(this.label_server);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ZSetValueInsertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ZSetValueInsertForm";
			this.Load += new System.EventHandler(this.ZSetValueInsertForm_Load);
			this.Shown += new System.EventHandler(this.ZSetValueInsertForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_db_num;
        private System.Windows.Forms.TextBox textBox_db_num;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Label label_score;
    }
}