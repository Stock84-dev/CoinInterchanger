using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	public partial class SettingsPane : UserControl
	{
		public SettingsPane()
		{
			InitializeComponent();
			Visible = false;
		}

		public virtual void ShowPane(Control button, Size? offset = null)
		{
			if (!Visible)
			{
				Form buttonForm = button.FindForm();
				if (!buttonForm.Controls.Contains(this))
					Parent = buttonForm;
				Size ofset = offset ?? new Size(0, 0);
				Point locationOnForm = buttonForm.PointToClient(button.Parent.PointToScreen(button.Location));
				Location = new Point(locationOnForm.X - Width + button.Width, locationOnForm.Y + button.Height) + ofset;

				BringToFront();
				Visible = true;
			}
			else
			{
				Visible = false;
			}
		}
	}
}
