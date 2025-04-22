namespace RedisGuiManager
{
	partial class ValueControl
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
			this.label_value = new System.Windows.Forms.Label();
			this.label_size = new System.Windows.Forms.Label();
			this.label_display = new System.Windows.Forms.Label();
			this.panel_display_type = new System.Windows.Forms.Panel();
			this.radioButton_display_type_hex = new System.Windows.Forms.RadioButton();
			this.radioButton_display_type_xml = new System.Windows.Forms.RadioButton();
			this.radioButton_display_type_json = new System.Windows.Forms.RadioButton();
			this.radioButton_display_type_text = new System.Windows.Forms.RadioButton();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.linkLabel_search = new System.Windows.Forms.LinkLabel();
			this.checkBox_case_sensitive = new System.Windows.Forms.CheckBox();
			this.elementHost_hex = new System.Windows.Forms.Integration.ElementHost();
			this.hexEditor_value = new WpfHexaEditor.HexEditor();
			this.numericUpDown_byte_per_line = new System.Windows.Forms.NumericUpDown();
			this.textBox_value = new RedisGuiManager.WordSelectTextBox();
			this.label_byte_per_line = new System.Windows.Forms.Label();
			this.panel_display_type.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_byte_per_line)).BeginInit();
			this.SuspendLayout();
			// 
			// label_value
			// 
			this.label_value.AutoSize = true;
			this.label_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_value.Location = new System.Drawing.Point(3, 3);
			this.label_value.Name = "label_value";
			this.label_value.Size = new System.Drawing.Size(72, 19);
			this.label_value.TabIndex = 0;
			this.label_value.Text = "Value :";
			// 
			// label_size
			// 
			this.label_size.AutoSize = true;
			this.label_size.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_size.ForeColor = System.Drawing.Color.Silver;
			this.label_size.Location = new System.Drawing.Point(75, 3);
			this.label_size.Name = "label_size";
			this.label_size.Size = new System.Drawing.Size(108, 19);
			this.label_size.TabIndex = 1;
			this.label_size.Text = "Size : 0 KB";
			// 
			// label_display
			// 
			this.label_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_display.AutoSize = true;
			this.label_display.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_display.Location = new System.Drawing.Point(564, 3);
			this.label_display.Name = "label_display";
			this.label_display.Size = new System.Drawing.Size(90, 19);
			this.label_display.TabIndex = 2;
			this.label_display.Text = "Display :";
			// 
			// panel_display_type
			// 
			this.panel_display_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_display_type.Controls.Add(this.radioButton_display_type_hex);
			this.panel_display_type.Controls.Add(this.radioButton_display_type_xml);
			this.panel_display_type.Controls.Add(this.radioButton_display_type_json);
			this.panel_display_type.Controls.Add(this.radioButton_display_type_text);
			this.panel_display_type.Location = new System.Drawing.Point(649, 3);
			this.panel_display_type.Name = "panel_display_type";
			this.panel_display_type.Size = new System.Drawing.Size(214, 19);
			this.panel_display_type.TabIndex = 3;
			// 
			// radioButton_display_type_hex
			// 
			this.radioButton_display_type_hex.AutoSize = true;
			this.radioButton_display_type_hex.Font = new System.Drawing.Font("Consolas", 12F);
			this.radioButton_display_type_hex.Location = new System.Drawing.Point(165, -2);
			this.radioButton_display_type_hex.Name = "radioButton_display_type_hex";
			this.radioButton_display_type_hex.Size = new System.Drawing.Size(54, 23);
			this.radioButton_display_type_hex.TabIndex = 3;
			this.radioButton_display_type_hex.TabStop = true;
			this.radioButton_display_type_hex.Text = "Hex";
			this.radioButton_display_type_hex.UseVisualStyleBackColor = true;
			this.radioButton_display_type_hex.CheckedChanged += new System.EventHandler(this.radioButton_display_type_hex_CheckedChanged);
			// 
			// radioButton_display_type_xml
			// 
			this.radioButton_display_type_xml.AutoSize = true;
			this.radioButton_display_type_xml.Font = new System.Drawing.Font("Consolas", 12F);
			this.radioButton_display_type_xml.Location = new System.Drawing.Point(117, -2);
			this.radioButton_display_type_xml.Name = "radioButton_display_type_xml";
			this.radioButton_display_type_xml.Size = new System.Drawing.Size(54, 23);
			this.radioButton_display_type_xml.TabIndex = 2;
			this.radioButton_display_type_xml.TabStop = true;
			this.radioButton_display_type_xml.Text = "Xml";
			this.radioButton_display_type_xml.UseVisualStyleBackColor = true;
			this.radioButton_display_type_xml.CheckedChanged += new System.EventHandler(this.radioButton_display_type_xml_CheckedChanged);
			// 
			// radioButton_display_type_json
			// 
			this.radioButton_display_type_json.AutoSize = true;
			this.radioButton_display_type_json.Font = new System.Drawing.Font("Consolas", 12F);
			this.radioButton_display_type_json.Location = new System.Drawing.Point(59, -2);
			this.radioButton_display_type_json.Name = "radioButton_display_type_json";
			this.radioButton_display_type_json.Size = new System.Drawing.Size(63, 23);
			this.radioButton_display_type_json.TabIndex = 1;
			this.radioButton_display_type_json.TabStop = true;
			this.radioButton_display_type_json.Text = "Json";
			this.radioButton_display_type_json.UseVisualStyleBackColor = true;
			this.radioButton_display_type_json.CheckedChanged += new System.EventHandler(this.radioButton_display_type_json_CheckedChanged);
			// 
			// radioButton_display_type_text
			// 
			this.radioButton_display_type_text.AutoSize = true;
			this.radioButton_display_type_text.Font = new System.Drawing.Font("Consolas", 12F);
			this.radioButton_display_type_text.Location = new System.Drawing.Point(3, -2);
			this.radioButton_display_type_text.Name = "radioButton_display_type_text";
			this.radioButton_display_type_text.Size = new System.Drawing.Size(63, 23);
			this.radioButton_display_type_text.TabIndex = 0;
			this.radioButton_display_type_text.Text = "Text";
			this.radioButton_display_type_text.UseVisualStyleBackColor = true;
			this.radioButton_display_type_text.CheckedChanged += new System.EventHandler(this.radioButton_display_type_text_CheckedChanged);
			// 
			// textBox_search
			// 
			this.textBox_search.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_search.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_search.Location = new System.Drawing.Point(217, 1);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(139, 26);
			this.textBox_search.TabIndex = 5;
			this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
			// 
			// linkLabel_search
			// 
			this.linkLabel_search.AutoSize = true;
			this.linkLabel_search.Font = new System.Drawing.Font("Consolas", 12F);
			this.linkLabel_search.Location = new System.Drawing.Point(356, 4);
			this.linkLabel_search.Name = "linkLabel_search";
			this.linkLabel_search.Size = new System.Drawing.Size(63, 19);
			this.linkLabel_search.TabIndex = 6;
			this.linkLabel_search.TabStop = true;
			this.linkLabel_search.Text = "Search";
			this.linkLabel_search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_search_LinkClicked);
			// 
			// checkBox_case_sensitive
			// 
			this.checkBox_case_sensitive.AutoSize = true;
			this.checkBox_case_sensitive.Font = new System.Drawing.Font("Consolas", 8F);
			this.checkBox_case_sensitive.Location = new System.Drawing.Point(425, 2);
			this.checkBox_case_sensitive.Name = "checkBox_case_sensitive";
			this.checkBox_case_sensitive.Size = new System.Drawing.Size(80, 30);
			this.checkBox_case_sensitive.TabIndex = 7;
			this.checkBox_case_sensitive.Text = "Case\r\nsensitive";
			this.checkBox_case_sensitive.UseVisualStyleBackColor = true;
			// 
			// elementHost_hex
			// 
			this.elementHost_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.elementHost_hex.Location = new System.Drawing.Point(3, 33);
			this.elementHost_hex.Name = "elementHost_hex";
			this.elementHost_hex.Size = new System.Drawing.Size(864, 508);
			this.elementHost_hex.TabIndex = 8;
			this.elementHost_hex.Text = "elementHost_hex";
			this.elementHost_hex.Child = this.hexEditor_value;
			// 
			// numericUpDown_byte_per_line
			// 
			this.numericUpDown_byte_per_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_byte_per_line.Font = new System.Drawing.Font("Consolas", 12F);
			this.numericUpDown_byte_per_line.Location = new System.Drawing.Point(780, 35);
			this.numericUpDown_byte_per_line.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDown_byte_per_line.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_byte_per_line.Name = "numericUpDown_byte_per_line";
			this.numericUpDown_byte_per_line.Size = new System.Drawing.Size(65, 26);
			this.numericUpDown_byte_per_line.TabIndex = 9;
			this.numericUpDown_byte_per_line.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.numericUpDown_byte_per_line.ValueChanged += new System.EventHandler(this.numericUpDown_byte_per_line_ValueChanged);
			// 
			// textBox_value
			// 
			this.textBox_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_value.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBox_value.HideSelection = false;
			this.textBox_value.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.textBox_value.Location = new System.Drawing.Point(3, 33);
			this.textBox_value.MaxLength = 0;
			this.textBox_value.Multiline = true;
			this.textBox_value.Name = "textBox_value";
			this.textBox_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_value.Size = new System.Drawing.Size(864, 508);
			this.textBox_value.TabIndex = 4;
			// 
			// label_byte_per_line
			// 
			this.label_byte_per_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_byte_per_line.AutoSize = true;
			this.label_byte_per_line.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_byte_per_line.Location = new System.Drawing.Point(648, 38);
			this.label_byte_per_line.Name = "label_byte_per_line";
			this.label_byte_per_line.Size = new System.Drawing.Size(126, 19);
			this.label_byte_per_line.TabIndex = 10;
			this.label_byte_per_line.Text = "Byte per line";
			// 
			// ValueControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label_byte_per_line);
			this.Controls.Add(this.numericUpDown_byte_per_line);
			this.Controls.Add(this.elementHost_hex);
			this.Controls.Add(this.checkBox_case_sensitive);
			this.Controls.Add(this.linkLabel_search);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.panel_display_type);
			this.Controls.Add(this.label_display);
			this.Controls.Add(this.label_size);
			this.Controls.Add(this.label_value);
			this.Controls.Add(this.textBox_value);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "ValueControl";
			this.Size = new System.Drawing.Size(870, 544);
			this.Load += new System.EventHandler(this.ValueControl_Load);
			this.panel_display_type.ResumeLayout(false);
			this.panel_display_type.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_byte_per_line)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_value;
		private System.Windows.Forms.Label label_size;
		private System.Windows.Forms.Label label_display;
		private System.Windows.Forms.Panel panel_display_type;
		private System.Windows.Forms.RadioButton radioButton_display_type_xml;
		private System.Windows.Forms.RadioButton radioButton_display_type_json;
		private System.Windows.Forms.RadioButton radioButton_display_type_text;
		private WordSelectTextBox textBox_value;
		private WpfHexaEditor.HexEditor hexEditor_value;
		private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.LinkLabel linkLabel_search;
        private System.Windows.Forms.CheckBox checkBox_case_sensitive;
		private System.Windows.Forms.RadioButton radioButton_display_type_hex;
		private System.Windows.Forms.Integration.ElementHost elementHost_hex;
		private System.Windows.Forms.NumericUpDown numericUpDown_byte_per_line;
		private System.Windows.Forms.Label label_byte_per_line;
	}
}
