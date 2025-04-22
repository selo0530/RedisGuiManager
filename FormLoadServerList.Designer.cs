
namespace RedisGuiManager
{
    partial class FormLoadServerList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadServerList));
			this.button_open_json = new System.Windows.Forms.Button();
			this.button_new_server_list = new System.Windows.Forms.Button();
			this.checkBox_darkmode = new System.Windows.Forms.CheckBox();
			this.label_recent = new System.Windows.Forms.Label();
			this.listBox_recent = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// button_open_json
			// 
			this.button_open_json.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_open_json.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_open_json.Location = new System.Drawing.Point(12, 313);
			this.button_open_json.Name = "button_open_json";
			this.button_open_json.Size = new System.Drawing.Size(422, 55);
			this.button_open_json.TabIndex = 0;
			this.button_open_json.Text = "Open workspace";
			this.button_open_json.UseVisualStyleBackColor = true;
			this.button_open_json.Click += new System.EventHandler(this.button_open_json_Click);
			// 
			// button_new_server_list
			// 
			this.button_new_server_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_new_server_list.Font = new System.Drawing.Font("Consolas", 12F);
			this.button_new_server_list.Location = new System.Drawing.Point(440, 313);
			this.button_new_server_list.Name = "button_new_server_list";
			this.button_new_server_list.Size = new System.Drawing.Size(187, 55);
			this.button_new_server_list.TabIndex = 1;
			this.button_new_server_list.Text = "New";
			this.button_new_server_list.UseVisualStyleBackColor = true;
			this.button_new_server_list.Click += new System.EventHandler(this.button_new_server_list_Click);
			// 
			// checkBox_darkmode
			// 
			this.checkBox_darkmode.AutoSize = true;
			this.checkBox_darkmode.Font = new System.Drawing.Font("Consolas", 12F);
			this.checkBox_darkmode.Location = new System.Drawing.Point(12, 284);
			this.checkBox_darkmode.Name = "checkBox_darkmode";
			this.checkBox_darkmode.Size = new System.Drawing.Size(253, 23);
			this.checkBox_darkmode.TabIndex = 2;
			this.checkBox_darkmode.Text = "Dark mode (Need relaunch)";
			this.checkBox_darkmode.UseVisualStyleBackColor = true;
			this.checkBox_darkmode.CheckedChanged += new System.EventHandler(this.checkBox_darkmode_CheckedChanged);
			// 
			// label_recent
			// 
			this.label_recent.AutoSize = true;
			this.label_recent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_recent.Location = new System.Drawing.Point(8, 9);
			this.label_recent.Name = "label_recent";
			this.label_recent.Size = new System.Drawing.Size(162, 19);
			this.label_recent.TabIndex = 3;
			this.label_recent.Text = "Recent workspaces";
			// 
			// listBox_recent
			// 
			this.listBox_recent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox_recent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listBox_recent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox_recent.FormattingEnabled = true;
			this.listBox_recent.Location = new System.Drawing.Point(12, 31);
			this.listBox_recent.Name = "listBox_recent";
			this.listBox_recent.Size = new System.Drawing.Size(615, 251);
			this.listBox_recent.TabIndex = 4;
			this.listBox_recent.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_recent_DrawItem);
			this.listBox_recent.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox_recent_MeasureItem);
			this.listBox_recent.DoubleClick += new System.EventHandler(this.listBox_recent_DoubleClick);
			// 
			// FormLoadServerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 380);
			this.Controls.Add(this.listBox_recent);
			this.Controls.Add(this.label_recent);
			this.Controls.Add(this.checkBox_darkmode);
			this.Controls.Add(this.button_new_server_list);
			this.Controls.Add(this.button_open_json);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLoadServerList";
			this.Text = "Load workspace";
			this.Load += new System.EventHandler(this.FormLoadServerList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open_json;
        private System.Windows.Forms.Button button_new_server_list;
        private System.Windows.Forms.CheckBox checkBox_darkmode;
		private System.Windows.Forms.Label label_recent;
		private System.Windows.Forms.ListBox listBox_recent;
	}
}