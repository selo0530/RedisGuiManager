namespace RedisGuiManager
{
    partial class StringValueControl
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
            this.valueControl = new RedisGuiManager.ValueControl();
            this.keyOperateControl = new RedisGuiManager.KeyOperateControl();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueControl
            // 
            this.valueControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueControl.BackColor = System.Drawing.Color.White;
            this.valueControl.Font = new System.Drawing.Font("Consolas", 12F);
            this.valueControl.Location = new System.Drawing.Point(3, 70);
            this.valueControl.Name = "valueControl";
            this.valueControl.Size = new System.Drawing.Size(863, 519);
            this.valueControl.TabIndex = 1;
            // 
            // keyOperateControl
            // 
            this.keyOperateControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyOperateControl.BackColor = System.Drawing.Color.White;
            this.keyOperateControl.Font = new System.Drawing.Font("Consolas", 12F);
            this.keyOperateControl.KeyType = "String:";
            this.keyOperateControl.Location = new System.Drawing.Point(3, 3);
            this.keyOperateControl.Name = "keyOperateControl";
            this.keyOperateControl.Size = new System.Drawing.Size(865, 28);
            this.keyOperateControl.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Consolas", 12F);
            this.button_save.Location = new System.Drawing.Point(766, 37);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 26);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // StringValueControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.valueControl);
            this.Controls.Add(this.keyOperateControl);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "StringValueControl";
            this.Size = new System.Drawing.Size(869, 592);
            this.Load += new System.EventHandler(this.StringValueControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KeyOperateControl keyOperateControl;
        private ValueControl valueControl;
        private System.Windows.Forms.Button button_save;
    }
}
