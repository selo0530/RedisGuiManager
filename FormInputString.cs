using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisGuiManager
{
    public partial class FormInputString : Form
    {
        public FormInputString()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }
        }

        public string TextInfo
        {
            get { return label_input.Text; }
            set { label_input.Text = value; }
        }

        public string InputValue
        {
            get { return textBox_input.Text; }
            set
            {
                textBox_input.Text = value;
                textBox_input.SelectionStart = textBox_input.Text.Length;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBox_input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_ok_Click(null, null);
                return;
            }
        }
    }
}
