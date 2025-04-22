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
    public partial class KeyOperateControl : UserControl
    {
        private string keyType = string.Empty;                          // Current key type
        private string keyName = string.Empty;                          // Current key name
        private RedisClient redisClient = null;

        [Browsable(true)]
        [Description("Get or set the type expression of the current key value")]
        [DefaultValue("String")]
        public string KeyType
        {
            get { return label_type.Text; }
            set { label_type.Text = value; }
        }

        [Browsable(false)]
        public Button LoadValue
        {
            get { return button_reload; }
        }

        [Browsable(false)]
        public FormMain MainForm
        {
            set; get;
        }

        [Browsable(false)]
        public TreeNode TargetNode
        {
            set; get;
        }

        public KeyOperateControl()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeControl(this);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            MainForm.delete_key_operate(TargetNode, redisClient.Redis);
        }

        private void button_ttl_Click(object sender, EventArgs e)
        {
            if (redisClient != null)
            {
                using (FormInputString formInput = new FormInputString())
                {
                    formInput.TextInfo = "New ttl(seconds), -1 means permanent";
                    if (formInput.ShowDialog() == DialogResult.OK)
                    {
                        if (formInput.InputValue == "-1")
                        {
                            if (redisClient.Redis.KeyPersist(keyName))
                            {
                                MessageBox.Show("Set ttl success");
                            }
                            else
                            {
                                MessageBox.Show("Set ttl failed");
                            }
                        }
                        else
                        {
                            if (int.TryParse(formInput.InputValue, out int seconds))
                            {
                                if (redisClient.Redis.KeyExpire(keyName, new TimeSpan(0, 0, seconds)))
                                {
                                    MessageBox.Show("Set ttl success");
                                }
                                else
                                {
                                    MessageBox.Show("Set ttl failed");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter the number. not text");
                            }
                        }
                    }
                }
            }
        }

        private void button_rename_Click(object sender, EventArgs e)
        {
            if (redisClient != null)
            {
                using (FormInputString formInput = new FormInputString())
                {
                    formInput.TextInfo = string.Format("Rename key [{0}]", keyName);
                    if (formInput.ShowDialog() == DialogResult.OK)
                    {
                        if (redisClient.Redis.KeyRename(keyName, formInput.InputValue))
                        {
                            MessageBox.Show("Rename success");
                        }
                        else
                        {
                            MessageBox.Show("Rename failed");
                        }
                    }
                }
            }
        }


        public void SetRedisClient(RedisClient client, string keyName)
        {
            this.redisClient = client;
            this.textBox_key.Text = keyName;
            this.keyName = keyName;

            if (client != null)
            {
                var ttl = client.Redis.Execute("TTL", keyName);
                button_ttl.Text = "TTL:" + ttl.ToString();
            }
        }
    }
}
