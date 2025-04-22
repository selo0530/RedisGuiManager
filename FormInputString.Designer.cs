namespace RedisGuiManager
{
	partial class FormInputString
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
            this.label_input = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Consolas", 12F);
            this.label_input.Location = new System.Drawing.Point(12, 7);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(54, 19);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "input";
            // 
            // textBox_input
            // 
            this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox_input.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox_input.Location = new System.Drawing.Point(12, 29);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(316, 26);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyUp);
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Consolas", 12F);
            this.button_ok.Location = new System.Drawing.Point(128, 64);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 25);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FormInputString
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 100);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label_input);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputString";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_input;
		private System.Windows.Forms.TextBox textBox_input;
		private System.Windows.Forms.Button button_ok;
	}
}