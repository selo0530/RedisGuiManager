
namespace RedisGuiManager
{
    partial class FormJsonViewer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lineNumbers_For_RichTextBox = new RedisGuiManager.LineNumbers_For_RichTextBox();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.button_parse = new System.Windows.Forms.Button();
            this.treeView_json = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lineNumbers_For_RichTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.button_parse);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox_text);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView_json);
            this.splitContainer1.Size = new System.Drawing.Size(980, 644);
            this.splitContainer1.SplitterDistance = 509;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lineNumbers_For_RichTextBox
            // 
            this.lineNumbers_For_RichTextBox._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox.AutoSizing = true;
            this.lineNumbers_For_RichTextBox.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox.DockSide = RedisGuiManager.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox.LineNrs_LeadingZeroes = true;
            this.lineNumbers_For_RichTextBox.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox.Location = new System.Drawing.Point(-3, 0);
            this.lineNumbers_For_RichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox.MarginLines_Side = RedisGuiManager.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox.Name = "lineNumbers_For_RichTextBox";
            this.lineNumbers_For_RichTextBox.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_RichTextBox.ParentRichTextBox = this.richTextBox_text;
            this.lineNumbers_For_RichTextBox.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox.Size = new System.Drawing.Size(28, 642);
            this.lineNumbers_For_RichTextBox.TabIndex = 2;
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_text.Location = new System.Drawing.Point(26, 0);
            this.richTextBox_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_text.MaxLength = 0;
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(427, 642);
            this.richTextBox_text.TabIndex = 0;
            this.richTextBox_text.Text = "";
            // 
            // button_parse
            // 
            this.button_parse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_parse.Location = new System.Drawing.Point(461, 5);
            this.button_parse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_parse.Name = "button_parse";
            this.button_parse.Size = new System.Drawing.Size(45, 43);
            this.button_parse.TabIndex = 1;
            this.button_parse.Text = "▶";
            this.button_parse.UseVisualStyleBackColor = true;
            this.button_parse.Click += new System.EventHandler(this.button_parse_Click);
            // 
            // treeView_json
            // 
            this.treeView_json.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_json.Location = new System.Drawing.Point(0, 0);
            this.treeView_json.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView_json.Name = "treeView_json";
            this.treeView_json.ShowPlusMinus = false;
            this.treeView_json.Size = new System.Drawing.Size(466, 644);
            this.treeView_json.TabIndex = 0;
            this.treeView_json.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_json_MouseUp);
            // 
            // FormJsonViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 644);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormJsonViewer";
            this.ShowIcon = false;
            this.Text = "Json viewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_parse;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private System.Windows.Forms.TreeView treeView_json;
        private LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox;
    }
}