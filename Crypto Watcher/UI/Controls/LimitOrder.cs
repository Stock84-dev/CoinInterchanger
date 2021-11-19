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
	public partial class LimitOrder : TradeUserInput, IOrder
	{
		public LimitOrder()
		{
			InitializeComponent();
			nTBoxAmount.ValueChanged += ValueChanged;
			nTxtBoxPrice.ValueChanged += ValueChanged;
			nTxtBoxTotal.ReadOnly = true;
		}

		List<OrderData> IOrder.GetOrders()
		{
			if (nTBoxAmount.Value == null || nTxtBoxPrice.Value == null)
				return null;
			OrderData orderData = new OrderData();
			orderData.Amount = nTBoxAmount.Value.Value;
			orderData.Price = nTxtBoxPrice.Value.Value;
			List<OrderData> orders = new List<OrderData>();
			orders.Add(orderData);
			return orders;
		}

		public override string MarketBaseSymbol {
			get => base.MarketBaseSymbol;
			set {
				if (base.MarketBaseSymbol == value)
					return;
				base.MarketBaseSymbol = value;
				nTBoxAmount.Symbol = value;
			}
		}

		public override string MarketQuoteSymbol {
			get => base.MarketQuoteSymbol;
			set {
				if (base.MarketQuoteSymbol == value)
					return;
				base.MarketQuoteSymbol = value;
				nTxtBoxPrice.Symbol = value;
				nTxtBoxTotal.Symbol = value;
			}
		}

		private void ValueChanged(object sender, NumberTextBox.ValueChangedEventArgs e)
		{
			nTxtBoxTotal.Value = nTBoxAmount.Value * nTxtBoxPrice.Value;
		}
	}
}
