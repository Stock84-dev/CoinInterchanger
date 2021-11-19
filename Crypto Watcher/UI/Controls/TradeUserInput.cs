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
	public partial class TradeUserInput : UserControl
	{
		public TradeUserInput()
		{
			InitializeComponent();
		}

		public virtual string MarketBaseSymbol { get; set; }
		public virtual string MarketQuoteSymbol { get; set; }
	}
}
