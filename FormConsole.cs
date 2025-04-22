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
	public partial class FormConsole : Form
	{
		public FormConsole()
		{
			InitializeComponent();
			this.Icon = Icon.FromHandle(Properties.Resources.console.GetHicon());
		}

		public void SetRedis(RedisClient client)
		{
			this.Text = $"Console - {client.Settings.name}";

			consoleControl.SetRedis(client);
		}
	}
}
