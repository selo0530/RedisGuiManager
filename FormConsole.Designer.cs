namespace RedisGuiManager
{
	partial class FormConsole
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
			this.consoleControl = new RedisGuiManager.ConsoleControl();
			this.SuspendLayout();
			// 
			// consoleControl
			// 
			this.consoleControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.consoleControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.consoleControl.Location = new System.Drawing.Point(0, 0);
			this.consoleControl.Name = "consoleControl";
			this.consoleControl.Size = new System.Drawing.Size(1009, 713);
			this.consoleControl.TabIndex = 0;
			// 
			// FormConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 713);
			this.Controls.Add(this.consoleControl);
			this.Name = "FormConsole";
			this.Text = "Console";
			this.ResumeLayout(false);

		}

		#endregion

		private ConsoleControl consoleControl;
	}
}