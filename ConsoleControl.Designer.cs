namespace RedisGuiManager
{
    partial class ConsoleControl
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
			this.textBox_output = new System.Windows.Forms.TextBox();
			this.textBox_input = new System.Windows.Forms.TextBox();
			this.label_cur = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox_output
			// 
			this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_output.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_output.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.textBox_output.Location = new System.Drawing.Point(3, 36);
			this.textBox_output.Multiline = true;
			this.textBox_output.Name = "textBox_output";
			this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_output.Size = new System.Drawing.Size(545, 466);
			this.textBox_output.TabIndex = 1;
			// 
			// textBox_input
			// 
			this.textBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_input.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_input.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.textBox_input.Location = new System.Drawing.Point(33, 4);
			this.textBox_input.Name = "textBox_input";
			this.textBox_input.Size = new System.Drawing.Size(515, 26);
			this.textBox_input.TabIndex = 0;
			this.textBox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_KeyDown);
			// 
			// label_cur
			// 
			this.label_cur.AutoSize = true;
			this.label_cur.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_cur.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label_cur.Location = new System.Drawing.Point(5, 7);
			this.label_cur.Name = "label_cur";
			this.label_cur.Size = new System.Drawing.Size(18, 19);
			this.label_cur.TabIndex = 2;
			this.label_cur.Text = ">";
			this.label_cur.TextChanged += new System.EventHandler(this.label_cur_TextChanged);
			// 
			// ConsoleControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.Controls.Add(this.label_cur);
			this.Controls.Add(this.textBox_input);
			this.Controls.Add(this.textBox_output);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "ConsoleControl";
			this.Size = new System.Drawing.Size(551, 505);
			this.Load += new System.EventHandler(this.ConsoleControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.TextBox textBox_input;
		private System.Windows.Forms.Label label_cur;
	}
}
