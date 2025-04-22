using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RedisGuiManager
{
    public partial class FormJsonViewer : Form
    {
        public string JsonText
        {
            set
            {
                richTextBox_text.Text = value;
                parse();
            }
            get
            {
                return richTextBox_text.Text;
            }
        }
        public FormJsonViewer()
        {
            InitializeComponent();

            if (Config.darkmode > 0)
            {
                Utils.DarkThemeForm(this);
            }

            ImageList imageList = new ImageList();
            imageList.Images.Add("json_object", Properties.Resources.json_object);
            imageList.Images.Add("json_array", Properties.Resources.json_array);
            imageList.Images.Add("json_num", Properties.Resources.json_num);
            imageList.Images.Add("json_string", Properties.Resources.json_string);
            imageList.Images.Add("json_bool", Properties.Resources.json_bool);
            imageList.Images.Add("json_null", Properties.Resources.json_null);

            treeView_json.ImageList = imageList;
        }

        private void button_parse_Click(object sender, EventArgs e)
        {
            parse();
        }

        public void parse()
        {
            treeView_json.Nodes.Clear();

            try
            {
                JToken jtok = JToken.Parse(richTextBox_text.Text);
                if (jtok.Type == JTokenType.Object)
                {
                    LoadTree(jtok as JObject);
                }
                else if (jtok.Type == JTokenType.Array)
                {
                    LoadTree(jtok as JArray);
                }
                else
                {
                    AddNode(null, "", jtok);
                }

                richTextBox_text.Text = jtok.ToString();
            }
            catch (JsonReaderException jr_ex)
            {
                MessageBox.Show(jr_ex.Message, "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTree(JObject jobj)
        {
            TreeNode root = new TreeNode(string.Format("Object{{{0}}}", jobj.Count));
            root.ImageKey = "json_object";
            root.SelectedImageKey = "json_object";
            treeView_json.Nodes.Add(root);

            LoadObject(jobj, root);

            root.Expand();
        }

        private void LoadTree(JArray jarr)
        {
            TreeNode root = new TreeNode(string.Format("Array[{0}]", jarr.Count));
            root.ImageKey = "json_array";
            root.SelectedImageKey = "json_array";
            treeView_json.Nodes.Add(root);

            LoadArray(jarr, root);

            root.Expand();
        }

        private TreeNode CreateNode(string property, JToken item)
        {
            string text = "";
            string ImageKey = "";

            switch (item.Type)
            {
                case JTokenType.Object:
                    {
                        text = string.Format("{0} : Object{{{1}}}", property, item.Children().Count());
                        ImageKey = "json_object";
                    }
                    break;
                case JTokenType.Array:
                    {
                        text = string.Format("{0} : Array[{1}]", property, ((JArray)item).Count);
                        ImageKey = "json_array";
                    }
                    break;
                case JTokenType.String:
                    {
                        text = string.Format("{0} : \"{1}\"", property, item.ToString());
                        ImageKey = "json_string";
                    }
                    break;
                case JTokenType.Integer:
                case JTokenType.Float:
                    {
                        text = string.Format("{0} : {1}", property, item.ToString());
                        ImageKey = "json_num";
                    }
                    break;
                case JTokenType.Boolean:
                    {
                        text = string.Format("{0} : {1}", property, item.ToString());
                        ImageKey = "json_bool";
                    }
                    break;
                case JTokenType.Null:
                    {
                        text = string.Format("{0} : null", property);
                        ImageKey = "json_null";
                    }
                    break;
                default:
                    {
                        text = string.Format("{0} : \"{1}\"", property, item.ToString());
                        ImageKey = "json_string";
                    }
                    break;
            }

            var node = new TreeNode(text);
            node.ImageKey = ImageKey;
            node.SelectedImageKey = ImageKey;

            return node;
        }

        private void AddNode(TreeNode parentNode, string property, JToken item)
        {
            var node = CreateNode(property, item);
            if (parentNode != null)
            {
                parentNode.Nodes.Add(node);
            }
            else
            {
                treeView_json.Nodes.Add(node);
            }

            if (item.Type == JTokenType.Array)
            {
                LoadArray(item, node);
            }

            if (item.Type == JTokenType.Object)
            {
                LoadObject(item as JObject, node);
            }
        }

        private void LoadArray(JToken value, TreeNode node)
        {
            JArray arr = value as JArray;
            for (int i = 0; i < arr.Count; ++i)
            {
                var item = arr[i];
                AddNode(node, i.ToString(), item);
            }
        }

        private void LoadObject(JObject obj, TreeNode node)
        {
            foreach (var item in obj)
            {
                AddNode(node, $"\"{item.Key}\"", item.Value);
            }
        }

        private void treeView_json_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeNode node = treeView_json.GetNodeAt(e.Location);
                if (treeView_json.SelectedNode != node)
                {
                    treeView_json.SelectedNode = node;
                }

                TreeNode select = treeView_json.SelectedNode;
                if (select == null)
                {
                    return;
                }

                if (select.IsExpanded)
                {
                    select.Collapse();
                }
                else
                {
                    select.Expand();
                }
            }
        }
    }
}
