using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
	public class TreeViewEx : TreeView
	{
		private const int TVM_SETEXTENDEDSTYLE = 0x1100 + 44;
		private const int TVS_EX_DOUBLEBUFFER = 0x0004;

		[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr SendMessage(IntPtr HWnd, int Msg, IntPtr Wp, IntPtr Lp);

		protected override void OnHandleCreated(EventArgs e)
		{
			SendMessage(this.Handle, TVM_SETEXTENDEDSTYLE, (IntPtr)TVS_EX_DOUBLEBUFFER, (IntPtr)TVS_EX_DOUBLEBUFFER);
			base.OnHandleCreated(e);
		}
	}
}
