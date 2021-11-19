using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	class AdvancedButton : Button
	{
		public AdvancedButton()
		{
			BackColor = Color.DimGray;
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderColor = Color.Gray;
		}
	}
}
