using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisGuiManager
{
    public class WordSelectTextBox : System.Windows.Forms.TextBox
    {
        private char[] delimiterList = new[] { '\n', '\t', '\'', '\"', ',', '.', ';', ':', ' ', '(', ')', '/', '<', '>' };

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 0x0203) // WM_LBUTTONDBLCLK
            {
                int start = SelectionStart;
                if (start < 1) start = 1;

                int left = -1;
                int right = Text.Length;
                int pos;

                foreach (char c in delimiterList)
                {
                    pos = Text.LastIndexOf(c, start - 1);
                    if (pos > left) left = pos;

                    pos = Text.IndexOf(c, start);
                    if (pos < right && pos != -1) right = pos;
                }

                SelectionStart = left + 1;
                SelectionLength = right - left - 1;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                Message m = new Message();
                m.Msg = 0x0203;
                WndProc(ref m);
            }
            else
            {
                base.OnMouseClick(e);
            }
        }
    }
}
