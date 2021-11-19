using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	class UIUtility
	{
		public static Color DefaultBackColor { get; set; }
		public static Color DefaultSelectColor { get; set; }
		public static Color DefaultClickColor { get; set; }

		public static void MakeButton(Control control, Action<object, EventArgs> action, Color? backColor = null, Color? selectColor = null, Color? clickColor = null)
		{
			control.MouseEnter += (s, e) => { ((Control)s).BackColor = selectColor == null ? DefaultSelectColor : selectColor.Value; };
			control.MouseLeave += (s, e) => { ((Control)s).BackColor = backColor == null ? DefaultBackColor : backColor.Value; };
			control.MouseUp += (s, e) =>
			{
				if(e.Button == MouseButtons.Left)
				{
					((Control)s).BackColor = selectColor == null ? DefaultSelectColor : selectColor.Value;
					action(s, e);
				}
			};
			control.MouseDown += (s, e) => 
			{
				if(e.Button == MouseButtons.Left)
					((Control)s).BackColor = clickColor == null ? DefaultClickColor : clickColor.Value;
			};
		}
	}
}
