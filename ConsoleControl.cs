using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using System.Text.RegularExpressions;

namespace RedisGuiManager
{
    public partial class ConsoleControl : UserControl
    {
        private RedisClient client;
        private IDatabase redis;
        private int db_num = 0;
        private List<string> cmd_history = new List<string>();
        private int cmd_history_cursor = 0;

        public ConsoleControl()
        {
            InitializeComponent();
        }

        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
			{
                e.Handled = true;

                if (cmd_history.Count > 0 &&
                    cmd_history_cursor > 0)
				{
                    cmd_history_cursor--;
                    textBox_input.Text = cmd_history[cmd_history_cursor];
                    textBox_input.SelectionStart = textBox_input.Text.Length;
                }
			}
            else if (e.KeyCode == Keys.Down)
			{
                e.Handled = true;

                cmd_history_cursor++;
                if (cmd_history_cursor >= cmd_history.Count)
				{
                    cmd_history_cursor = cmd_history.Count;
                }

                if (cmd_history_cursor == cmd_history.Count)
				{
                    textBox_input.Text = "";
				}
                else
				{
                    textBox_input.Text = cmd_history[cmd_history_cursor];
                    textBox_input.SelectionStart = textBox_input.Text.Length;
                    e.Handled = true;
                }
			}
            else if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox_input.Text))
                {
                    return;
                }

                cmd_history.Add(textBox_input.Text);
                cmd_history_cursor = cmd_history.Count;

                if (this.client == null)
				{
					return;
				}

				if (client.Redis == null)
				{
					OperateResult connect = client.Connect();
					if (connect.IsSuccess == false)
					{
						textBox_output.AppendText("Connection failed" + "\r\n");
						return;
					}

                    redis = client.GetDB(db_num);
                }

				textBox_output.AppendText($"{client.Settings.name}:{db_num}> " + textBox_input.Text + Environment.NewLine);

				var args = Regex.Matches(textBox_input.Text, @"[\""](?<value>.+?)[\""]|(?<value>[^\s]+)")
                    .Cast<Match>()
                    .Select(m => m.Groups["value"].Value)
                    .ToArray();
				var cmd = args[0];
				args = args.Skip(1).ToArray();

				try
				{
                    var result = redis.Execute(cmd, args);
                    if (result.IsNull)
					{
                        textBox_output.AppendText($"(nil)\r\n");
                    }

                    switch (result.Type)
					{
                        case ResultType.None:
							{
                                textBox_output.AppendText($"(none)\r\n");
                            }
                            break;

                        case ResultType.SimpleString:
							{
                                textBox_output.AppendText($"{result}\r\n");
                            }
                            break;

                        case ResultType.Error:
							{
                                textBox_output.AppendText($"ERROR : {result}\r\n");
                            }
                            break;

                        case ResultType.Integer:
							{
                                textBox_output.AppendText($"(integer) {result}\r\n");
                            }
                            break;

                        case ResultType.BulkString:
							{
                                textBox_output.AppendText($"{result}\r\n");
                            }
                            break;

                        case ResultType.MultiBulk:
							{
                                int idx = 0;
								var results = (RedisResult[])result;

                                if (results.Count() > 0)
                                {
                                    foreach (var item in results)
                                    {
                                        if (item.Type != ResultType.MultiBulk)
										{
                                            if (item.IsNull)
											{
                                                textBox_output.AppendText($" {++idx}) (nil)\r\n");
                                            }
                                            else
											{
                                                textBox_output.AppendText($" {++idx}) \"{item}\"\r\n");
                                            }
                                        }
                                        else
										{
                                            textBox_output.AppendText($" {++idx})");
                                            print_sub_multi_value(item);
                                        }
                                    }
                                }
                                else
								{
                                    textBox_output.AppendText("(empty list or set)\r\n");
								}
							}
                            break;
					}

                    textBox_output.AppendText($"\r\n");
                }
                catch (RedisServerException ex)
				{
                    textBox_output.AppendText(ex.Message + "\r\n");
                }

                check_change_db(textBox_input.Text);

                textBox_input.Text = "";
            }
        }

        private void print_sub_multi_value(RedisResult val)
		{
            bool is_first = true;
			int idx = 0;
			var results = (RedisResult[])val;

			if (results.Count() > 0)
			{
				foreach (var item in results)
				{
                    if (is_first)
					{
                        is_first = false;
                        textBox_output.AppendText($" {++idx}) \"{item}\"\r\n");
                    }
                    else
					{
                        textBox_output.AppendText($"    {++idx}) \"{item}\"\r\n");
                    }
				}
			}
		}

        private void check_change_db(string text)
		{
            var m = Regex.Match(text, "^select (?<db_num>[\\d]+)");
            if (m.Success)
			{
                db_num = int.Parse(m.Groups["db_num"].Value);
                redis = client.GetDB(db_num);
                label_cur.Text = $"{client.Settings.name}:{db_num}>";
            }
		}

        public void SetRedis(RedisClient client)
        {
            this.client = client;
            db_num = 0;

			if (client.Redis == null)
			{
				OperateResult connect = client.Connect();
				if (connect.IsSuccess == false)
				{
					textBox_output.AppendText("Connection failed" + "\r\n");
					return;
				}
			}

            redis = client.GetDB(db_num);
            label_cur.Text = $"{client.Settings.name}:{db_num}>";
            textBox_input.Location = new Point(label_cur.Left + label_cur.Width + 2, textBox_input.Location.Y);
        }

        private void ConsoleControl_Load(object sender, EventArgs e)
        {
            textBox_input.Focus();
        }

		private void label_cur_TextChanged(object sender, EventArgs e)
		{
            label_cur.Width = TextRenderer.MeasureText(label_cur.Text, label_cur.Font).Width;
            textBox_input.Location = new Point(label_cur.Left + label_cur.Width + 2, textBox_input.Location.Y);
		}
	}
}
