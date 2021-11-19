using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI
{
	public partial class MyMainForm : Form
	{
	
		public MyMainForm()
		{
			
			InitializeComponent();
			
			//module1.SetParentForm = this;
			//module1.SettingsPane = new SettingsPane();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			Console.WriteLine(Size);
			if(WindowState == FormWindowState.Normal)
			{
				////var rectangle = Screen.FromControl(this).Bounds;
				////Size = new Size(rectangle.Width, rectangle.Height);
				////Location = new Point(0, 0);
				//Width = Screen.AllScreens[0].WorkingArea.Width;
				//Width = Screen.AllScreens[0].WorkingArea.Height;
				//Location = Screen.AllScreens[0].WorkingArea.Location;


				WindowState = FormWindowState.Maximized;
				btnMaximize.BackgroundImage = Properties.Resources.restoreDown;
				Console.WriteLine(Size);
			}
			else
			{
				WindowState = FormWindowState.Normal;
				btnMaximize.BackgroundImage = Properties.Resources.maximize512;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		}
	}
}
