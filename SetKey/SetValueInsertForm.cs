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
    public partial class SetValueInsertForm : Form
    {
        private RedisClient redisClient = null;
        private string key = string.Empty;

        public SetValueInsertForm(RedisClient client, string key)
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            redisClient = client;
            this.key = key;
        }

        private void SetValueInsertForm_Load(object sender, EventArgs e)
        {
            textBox_server.Text = string.Format("{0}[{1}:{2}]", redisClient.Settings.name, redisClient.Settings.host, redisClient.Settings.port);
            textBox_key.Text = key;
            textBox_db_num.Text = redisClient.DBBlock.ToString();

            Icon = Icon.FromHandle(Properties.Resources.docview_xaml_on_16x16.GetHicon());
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (redisClient.Redis.SetAdd(key, textBox_value.Text))
            {
                Close();
                return;
            }
            else
            {
                MessageBox.Show($"{textBox_value.Text} is already exist");
            }
        }

        private void SetValueInsertForm_Shown(object sender, EventArgs e)
        {
            textBox_value.Focus();
        }
	}
}
