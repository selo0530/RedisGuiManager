namespace RedisGuiManager
{
    partial class ListValueInsertForm
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
			this.label_order = new System.Windows.Forms.Label();
			this.radioButton_order_default = new System.Windows.Forms.RadioButton();
			this.radioButton_order_reverse = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label_server
			// 
			this.label_server.AutoSize = true;
			this.label_server.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_server.Location = new System.Drawing.Point(12, 16);
			this.label_server.Name = "label_server";
			this.label_server.Size = new System.Drawing.Size(63, 19);
			this.label_server.TabIndex = 0;
			this.label_server.Text = "Server";
			// 
			// textBox_server
			// 
			this.textBox_server.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_server.Location = new System.Drawing.Point(87, 13);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.ReadOnly = true;
			this.textBox_server.Size = new System.Drawing.Size(332, 26);
			this.textBox_server.TabIndex = 99;
			this.textBox_server.TabStop = false;
			// 
			// textBox_key
			// 
			this.textBox_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_key.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.label_key.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_key.Location = new System.Drawing.Point(12, 59);
			this.label_key.Name = "label_key";
			this.label_key.Size = new System.Drawing.Size(36, 19);
			this.label_key.TabIndex = 2;
			this.label_key.Text = "Key";
			// 
			// textBox_value
			// 
			this.textBox_value.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_value.Location = new System.Drawing.Point(87, 136);
			this.textBox_value.Multiline = true;
			this.textBox_value.Name = "textBox_value";
			this.textBox_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_value.Size = new System.Drawing.Size(531, 197);
			this.textBox_value.TabIndex = 3;
			// 
			// label_value
			// 
			this.label_value.AutoSize = true;
			this.label_value.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_value.Location = new System.Drawing.Point(12, 136);
			this.label_value.Name = "label_value";
			this.label_value.Size = new System.Drawing.Size(54, 19);
			this.label_value.TabIndex = 4;
			this.label_value.Text = "Value";
			// 
			// button_save
			// 
			this.button_save.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_save.Location = new System.Drawing.Point(256, 346);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(163, 47);
			this.button_save.TabIndex = 4;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// label_db_num
			// 
			this.label_db_num.AutoSize = true;
			this.label_db_num.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_db_num.Location = new System.Drawing.Point(434, 16);
			this.label_db_num.Name = "label_db_num";
			this.label_db_num.Size = new System.Drawing.Size(63, 19);
			this.label_db_num.TabIndex = 7;
			this.label_db_num.Text = "DB Num";
			// 
			// textBox_db_num
			// 
			this.textBox_db_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_db_num.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_db_num.Location = new System.Drawing.Point(500, 13);
			this.textBox_db_num.Name = "textBox_db_num";
			this.textBox_db_num.ReadOnly = true;
			this.textBox_db_num.Size = new System.Drawing.Size(118, 26);
			this.textBox_db_num.TabIndex = 99;
			this.textBox_db_num.TabStop = false;
			// 
			// label_order
			// 
			this.label_order.AutoSize = true;
			this.label_order.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_order.Location = new System.Drawing.Point(12, 97);
			this.label_order.Name = "label_order";
			this.label_order.Size = new System.Drawing.Size(54, 19);
			this.label_order.TabIndex = 9;
			this.label_order.Text = "Order";
			// 
			// radioButton_order_default
			// 
			this.radioButton_order_default.AutoSize = true;
			this.radioButton_order_default.Checked = true;
			this.radioButton_order_default.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_order_default.Location = new System.Drawing.Point(87, 95);
			this.radioButton_order_default.Name = "radioButton_order_default";
			this.radioButton_order_default.Size = new System.Drawing.Size(90, 23);
			this.radioButton_order_default.TabIndex = 1;
			this.radioButton_order_default.TabStop = true;
			this.radioButton_order_default.Text = "Default";
			this.radioButton_order_default.UseVisualStyleBackColor = true;
			// 
			// radioButton_order_reverse
			// 
			this.radioButton_order_reverse.AutoSize = true;
			this.radioButton_order_reverse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_order_reverse.Location = new System.Drawing.Point(183, 95);
			this.radioButton_order_reverse.Name = "radioButton_order_reverse";
			this.radioButton_order_reverse.Size = new System.Drawing.Size(90, 23);
			this.radioButton_order_reverse.TabIndex = 2;
			this.radioButton_order_reverse.TabStop = true;
			this.radioButton_order_reverse.Text = "Reverse";
			this.radioButton_order_reverse.UseVisualStyleBackColor = true;
			// 
			// ListValueInsertForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(652, 407);
			this.Controls.Add(this.radioButton_order_reverse);
			this.Controls.Add(this.radioButton_order_default);
			this.Controls.Add(this.label_order);
			this.Controls.Add(this.textBox_db_num);
			this.Controls.Add(this.label_db_num);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.textBox_value);
			this.Controls.Add(this.label_value);
			this.Controls.Add(this.textBox_key);
			this.Controls.Add(this.label_key);
			this.Controls.Add(this.textBox_server);
			this.Controls.Add(this.label_server);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListValueInsertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ListValueInsertForm";
			this.Load += new System.EventHandler(this.ListValueInsertForm_Load);
			this.Shown += new System.EventHandler(this.ListValueInsertForm_Shown);
			this.SizeChanged += new System.EventHandler(this.ListValueInsertForm_SizeChanged);
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
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.RadioButton radioButton_order_default;
        private System.Windows.Forms.RadioButton radioButton_order_reverse;
    }
}