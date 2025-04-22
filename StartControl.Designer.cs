namespace RedisGuiManager
{
    partial class StartControl
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
			this.panel_main = new System.Windows.Forms.Panel();
			this.label_version = new System.Windows.Forms.Label();
			this.label_app_name = new System.Windows.Forms.Label();
			this.pictureBox_redis = new System.Windows.Forms.PictureBox();
			this.panel_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_redis)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_main
			// 
			this.panel_main.Controls.Add(this.label_version);
			this.panel_main.Controls.Add(this.label_app_name);
			this.panel_main.Controls.Add(this.pictureBox_redis);
			this.panel_main.Location = new System.Drawing.Point(134, 161);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(365, 116);
			this.panel_main.TabIndex = 0;
			this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
			// 
			// label_version
			// 
			this.label_version.AutoSize = true;
			this.label_version.Font = new System.Drawing.Font("Consolas", 11F);
			this.label_version.ForeColor = System.Drawing.Color.Gray;
			this.label_version.Location = new System.Drawing.Point(73, 49);
			this.label_version.Name = "label_version";
			this.label_version.Size = new System.Drawing.Size(128, 18);
			this.label_version.TabIndex = 2;
			this.label_version.Text = "Version : 1.0.0";
			// 
			// label_app_name
			// 
			this.label_app_name.AutoSize = true;
			this.label_app_name.Font = new System.Drawing.Font("Consolas", 22F);
			this.label_app_name.Location = new System.Drawing.Point(73, 5);
			this.label_app_name.Name = "label_app_name";
			this.label_app_name.Size = new System.Drawing.Size(287, 36);
			this.label_app_name.TabIndex = 1;
			this.label_app_name.Text = "Redis Gui Manager";
			// 
			// pictureBox_redis
			// 
			this.pictureBox_redis.Image = global::RedisGuiManager.Properties.Resources.redis1;
			this.pictureBox_redis.Location = new System.Drawing.Point(3, 3);
			this.pictureBox_redis.Name = "pictureBox_redis";
			this.pictureBox_redis.Size = new System.Drawing.Size(64, 64);
			this.pictureBox_redis.TabIndex = 0;
			this.pictureBox_redis.TabStop = false;
			// 
			// StartControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel_main);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "StartControl";
			this.Size = new System.Drawing.Size(612, 440);
			this.Load += new System.EventHandler(this.StartControl_Load);
			this.SizeChanged += new System.EventHandler(this.StartControl_SizeChanged);
			this.panel_main.ResumeLayout(false);
			this.panel_main.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_redis)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox_redis;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_app_name;
	}
}
