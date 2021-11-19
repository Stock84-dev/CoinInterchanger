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
	public partial class ScaledOrder : TradeUserInput
	{
		public ScaledOrder()
		{
			InitializeComponent();
			UIUtility.MakeButton(btnSettings, (s, e) => SettingsPane.ShowPane((Control)s, new Size(0, - btnSettings.Height - SettingsPane.Height)));
		}

		public SettingsPane SettingsPane { get; set; } = new SettingsPane();
	}
}
