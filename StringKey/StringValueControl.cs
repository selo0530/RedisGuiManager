using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RedisGuiManager
{
    public partial class StringValueControl : UserControl
    {
        private string stringKeyName = string.Empty;
        private RedisClient redisClient = null;

        [Browsable(false)]
        public FormMain MainForm
        {
            set
            {
                keyOperateControl.MainForm = value;
            }
        }

        [Browsable(false)]
        public TreeNode TargetNode
        {
            set
            {
                keyOperateControl.TargetNode = value;
            }
        }

        public StringValueControl()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeControl(this);
            }
        }

        private void StringValueControl_Load(object sender, EventArgs e)
        {
            keyOperateControl.LoadValue.Click += LoadValue_Click;
        }

        public void SetNewKey(RedisClient client, string key)
        {
            redisClient = client;
            stringKeyName = key;

            keyOperateControl.SetRedisClient(redisClient, key);
            RefreshKey();
        }

        private void LoadValue_Click(object sender, EventArgs e)
        {
            RefreshKey();
        }

        private void RefreshKey()
        {
            if (redisClient == null)
            {
                MessageBox.Show("Redis connection error");
                return;
            }

            if (redisClient.Redis == null)
            {
                MessageBox.Show("Redis connection error");
                return;
            }

            var read = redisClient.Redis.StringGet(stringKeyName);
            valueControl.SetValue(read.ToString());
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string save_text = valueControl.EditedValue();
            if (ValueControl.GetDisplayType() == ValueControl.DisplayType.Json)
            {
                try
                {
                    save_text = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(save_text), Formatting.None);
                }
                catch (JsonReaderException)
                {
                }
            }

            redisClient.Redis.StringSet(stringKeyName, save_text);
            RefreshKey();
        }
    }
}
