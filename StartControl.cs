using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisGuiManager
{
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeControl(this);
            }
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.LightGray, new Point(0, 78), new Point(panel_main.Width, 78));
        }

        private void StartControl_Load(object sender, EventArgs e)
        {
            label_version.Text = "Version : " + Utils.Version.ToString();
            StartControl_SizeChanged(null, null);
        }

        private void StartControl_SizeChanged(object sender, EventArgs e)
        {
            panel_main.Location = new Point(this.Width / 2 - panel_main.Width / 2, this.Height / 2 - panel_main.Height / 2);
        }
    }
}
