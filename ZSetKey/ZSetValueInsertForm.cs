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
    public partial class ZSetValueInsertForm : Form
    {
        private RedisClient redisClient = null;
        private string key = string.Empty;

        public ZSetValueInsertForm(RedisClient client, string key)
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            redisClient = client;
            this.key = key;
        }

        private void ZSetValueInsertForm_Load(object sender, EventArgs e)
        {
            textBox_server.Text = string.Format("{0}[{1}:{2}]", redisClient.Settings.name, redisClient.Settings.host, redisClient.Settings.port);
            textBox_key.Text = key;
            textBox_db_num.Text = redisClient.DBBlock.ToString();
            textBox_score.Text = "0";

            Icon = Icon.FromHandle(Properties.Resources.zset.GetHicon());
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_score.Text, out double sco) == false)
            {
                MessageBox.Show("Invalid score");
                return;
            }

            if (redisClient.Redis.SortedSetAdd(key, textBox_value.Text, sco))
            {
                Close();
                return;
            }
            else
            {
                MessageBox.Show("Save fail");
            }
        }

        private void ZSetValueInsertForm_Shown(object sender, EventArgs e)
        {
            textBox_value.Focus();
        }
	}
}
