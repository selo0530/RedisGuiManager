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
    public partial class HashValueInsertForm : Form
    {
        private RedisClient redisClient = null;
        private string key = string.Empty;
        private string field = string.Empty;
        private string value = string.Empty;

        public HashValueInsertForm(RedisClient client, string key, string field, string value)
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            this.redisClient = client;
            this.key = key;
            this.field = field;
            this.value = value;
        }

        private void HashValueInsertForm_Load(object sender, EventArgs e)
        {
            textBox_server.Text = string.Format("{0} [{1}:{2}]", redisClient.Settings.name, redisClient.Settings.host, redisClient.Settings.port);
            textBox_key.Text = this.key;
            textBox_value.Text = this.value;
            textBox_db_num.Text = this.redisClient.DBBlock.ToString();
            textBox_hash_key.Text = this.field;

            Icon = Icon.FromHandle(Properties.Resources.Table_748.GetHicon());
            HashValueInsertForm_SizeChanged(null, null);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            redisClient.Redis.HashSet(this.key, textBox_hash_key.Text, textBox_value.Text);
            Close();
        }

        private void HashValueInsertForm_Shown(object sender, EventArgs e)
        {
            textBox_hash_key.Focus();
        }

        private void HashValueInsertForm_SizeChanged(object sender, EventArgs e)
        {
            button_save.Location = new Point(this.Width / 2 - button_save.Width / 2, this.Height - 100);
        }
	}
}
