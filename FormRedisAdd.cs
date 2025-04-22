using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RedisGuiManager
{
    public partial class FormRedisAdd : Form
    {
        private RedisSettings settings = null;
        public RedisSettings Settings
        {
            get { return settings; }
        }

        public FormRedisAdd(RedisSettings redisSettings)
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            settings = redisSettings ?? new RedisSettings()
            {
                host = "127.0.0.1",
                port = 6379,
                auth = string.Empty
            };

            if (redisSettings != null)
            {
                textBox_name.ReadOnly = true;
            }
        }

        private void FormRedisAdd_Load(object sender, EventArgs e)
        {
            Icon = Icon.FromHandle(Properties.Resources.action_add_16xLG.GetHicon());

            textBox_name.Text = settings.name;
            textBox_ip.Text = settings.host;
            textBox_port.Text = settings.port.ToString();
            textBox_password.Text = settings.auth;
            checkBox_use_tunnel.Checked = settings.use_tunnel;
            textBox_tunnel_ip.Text = settings.ssh_host;
            textBox_tunnel_port.Text = settings.ssh_port.ToString();
            textBox_tunnel_id.Text = settings.ssh_user;
            textBox_tunnel_pw.Text = settings.ssh_password;
            checkBox_use_ssh_key.Checked = settings.use_ssh_key;
            textBox_tunnel_key.Text = settings.ssh_key;

            groupBox_tunnel.Enabled = checkBox_use_tunnel.Checked;
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                textBox_password.PasswordChar = (char)0;
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Server name can not be empty!");

                return false;
            }

            if (IPAddress.TryParse(textBox_ip.Text, out IPAddress address) == false)
            {
                MessageBox.Show("Invalid IP address");

                return false;
            }

            if (int.TryParse(textBox_port.Text, out int port) == false)
            {
                MessageBox.Show("Invalid port");

                return false;
            }

            if (int.TryParse(textBox_tunnel_port.Text, out int tunnel_port) == false)
            {
                MessageBox.Show("Invalid tunnel port");

                return false;
            }

            return true;
        }

        private void button_connection_test_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                return;
            }

            settings.name = textBox_name.Text;
            settings.host = textBox_ip.Text;
            settings.port = int.Parse(textBox_port.Text);
            settings.auth = textBox_password.Text;
            settings.use_tunnel = checkBox_use_tunnel.Checked;
            settings.ssh_host = textBox_tunnel_ip.Text;
            settings.ssh_port = int.Parse(textBox_tunnel_port.Text);
            settings.ssh_user = textBox_tunnel_id.Text;
            settings.ssh_password = textBox_tunnel_pw.Text;
            settings.use_ssh_key = checkBox_use_ssh_key.Checked;
            settings.ssh_key = textBox_tunnel_key.Text;

            RedisClient redis = new RedisClient(settings);
            OperateResult connect = redis.Connect();
            if (connect.IsSuccess)
            {
                MessageBox.Show("Connect Success!");
            }
            else
            {
                MessageBox.Show("Connect Failed\r\n" + connect.Message);
            }

            redis.Close();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                return;
            }

            settings.name = textBox_name.Text;
            settings.host = textBox_ip.Text;
            settings.port = int.Parse(textBox_port.Text);
            settings.auth = textBox_password.Text;
            settings.use_tunnel = checkBox_use_tunnel.Checked;
            settings.ssh_host = textBox_tunnel_ip.Text;
            settings.ssh_port = int.Parse(textBox_tunnel_port.Text);
            settings.ssh_user = textBox_tunnel_id.Text;
            settings.ssh_password = textBox_tunnel_pw.Text;
            settings.use_ssh_key = checkBox_use_ssh_key.Checked;
            settings.ssh_key = textBox_tunnel_key.Text;

            DialogResult = DialogResult.OK;
        }

        private void FormRedisAdd_Shown(object sender, EventArgs e)
        {
            textBox_name.Focus();
        }

        private void checkBox_use_tunnel_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_tunnel.Enabled = checkBox_use_tunnel.Checked;
        }

		private void checkBox_show_ssh_password_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_show_ssh_password.Checked)
			{
				textBox_tunnel_pw.PasswordChar = (char)0;
			}
			else
			{
                textBox_tunnel_pw.PasswordChar = '*';
			}
		}
	}
}
