using CoinInterchangerLib.Environment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCXTSharp;

namespace CoinInterchanger.UI.Controls.Modules
{
	public partial class TradeUIModule : UIModule
	{
		private TradeModule _tradeModule;
		bool _hideStats;

		public TradeUIModule()
		{
			InitializeComponent();
			cBoxType.Items.AddRange(new string[] { "Limit" });//, "Market", "Scaled" };
			cBoxType.SelectedIndexChanged += (s, e) => ChangeTradeUI(((AdvancedComboBox)s).SelectedItem.ToString());
			cBoxType.SelectedIndex = 0;
			CanResize = true;
			SetMinSize = new Size(195, 388);
			HideStats = true;
			tradeUserInput1.Location = new Point(tradeUserInput1.Location.X, 63);
			tradeUserInput1.Height = btnAction.Location.Y - tradeUserInput1.Location.Y - 5;
			tradeUserInput1.SizeChanged += TradeUIModule_SizeChanged;
			//GripLocation = new Point(10, 10);
			//GripLocation = new Point(moduleWorkspace.Width - GetGripSize.Width, moduleWorkspace.Height - GetGripSize.Height);
		}

		private void TradeUIModule_SizeChanged(object sender, EventArgs e)
		{
			Console.WriteLine($"trade user input size: {tradeUserInput1.Size}, location: {tradeUserInput1.Location}");
			Console.WriteLine($"parent size: {tradeUserInput1.Parent.Size}, location: {tradeUserInput1.Parent.Location}");
			Console.WriteLine($"module size: {Size}, location: {Location}");
		}

		public bool HideStats {
			get => _hideStats;
			set {
				if (value == _hideStats)
					return;
				if (value == true)
				{
					lblBalanceName.Visible = false;
					lblBalance.Visible = false;
					lblInOrdersName.Visible = false;
					lblTotalName.Visible = false;
					lblTotal.Visible = false;
					lblInOrders.Visible = false;
					lblBestPriceName.Visible = false;
					lblBestPrice.Visible = false;
					//AnchorStyles anchor = tradeUserInput1.Anchor;
					//tradeUserInput1.Anchor = AnchorStyles.None;
					//int bottomBorder = tradeUserInput1.Location.Y + tradeUserInput1.Height;
					//bottomBorder = btnAction.Location.Y - 5;
					//tradeUserInput1.Location = new Point(tradeUserInput1.Location.X, 63);
					//tradeUserInput1.Height = bottomBorder - tradeUserInput1.Location.X;
					//tradeUserInput1.Anchor = anchor;
					//tradeUserInput1.BorderStyle = BorderStyle.FixedSingle;
					//BringToFront();
				}
				else
				{
					lblBalanceName.Visible = true;
					lblBalance.Visible = true;
					lblInOrdersName.Visible = true;
					lblTotalName.Visible = true;
					lblTotal.Visible = true;
					lblInOrders.Visible = true;
					lblBestPriceName.Visible = true;
					lblBestPrice.Visible = true;
					tradeUserInput1.Location = new Point(tradeUserInput1.Location.X, 152);
				}

				_hideStats = value;
			}
		}

		public TradeModule TradeModule {
			get => _tradeModule;
			set {
				if (value == null)
					return;
				_tradeModule = value;
				_tradeModule.SelectedMarketChanged += TradeModule_SelectedMarketChanged;
			}
		}

		private void ChangeTradeUI(string type)
		{
			Point tradeUserInputLocation = tradeUserInput1.Location;
			AnchorStyles oldAnchor = tradeUserInput1.Anchor;
			Size oldSize = tradeUserInput1.Size;
			tradeUserInput1.Parent = null;
			switch (type)
			{
				case "Limit":
					tradeUserInput1 = new LimitOrder();
					break;
				case "Market":
					tradeUserInput1 = new MarketOrder();
					break;
				case "Scaled":
					tradeUserInput1 = new ScaledOrder();
					break;
				default:
					throw new ArgumentException("Order not implemented.");
			}
			tradeUserInput1.Parent = workspacePanel;
			tradeUserInput1.Location = tradeUserInputLocation;
			tradeUserInput1.Size = oldSize;
			tradeUserInput1.Anchor = oldAnchor;
			tradeUserInput1.BringToFront();
			tradeUserInput1.SizeChanged += TradeUIModule_SizeChanged;
		}

		private void TradeModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			if (_tradeModule.SelectedMarket == null)
				return;
			header.Text = _tradeModule.SelectedMarket;
			string[] symbols = _tradeModule.SelectedMarket.Split('/');
			tradeUserInput1.MarketBaseSymbol = symbols[0];
			tradeUserInput1.MarketQuoteSymbol = symbols[1];
		}

		private void tabControlSide_SelectedIndexChanged(object sender, EventArgs e)
		{
			TabControlUI tabControlUI = (TabControlUI)sender;
			if (tabControlUI.SelectedIndex == 0)
			{
				tabControlUI.ActiveColor = Color.Green;
				tabControlUI.HorizontalLineColor = Color.Green;
				btnAction.BackColor = Color.Green;
				btnAction.Text = "Buy";
			}
			else
			{
				tabControlUI.ActiveColor = Color.FromArgb(255, 73, 53);
				tabControlUI.HorizontalLineColor = Color.FromArgb(255, 73, 53);
				btnAction.BackColor = Color.FromArgb(255, 73, 53);
				btnAction.Text = "Sell";
			}
			tabControlUI.Refresh();
		}

		private async void btnAction_Click(object sender, EventArgs e)
		{
			OrderSide side = tabControlSide.SelectedIndex == 0 ? OrderSide.buy : OrderSide.sell;
			OrderType type = KeyToOrderType(cBoxType.Text);

			if (tradeUserInput1 is IOrder iOrder)
			{
				List<OrderData> orders = iOrder.GetOrders();
				// some data is invalid so we don't place order
				if (orders == null)
				{
					MessageBox.Show($"Invalid input", "Coin Interchanger", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				foreach (var order in orders)
				{
					try
					{
						await _tradeModule.PlaceOrder(side, type, order.Amount, order.Price);
					}
					catch (CCXTException ex)
					{
						MessageBox.Show($"Trade error message: {ex.Message}", "Coin Interchanger", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private OrderType KeyToOrderType(string type)
		{
			switch (type)
			{
				case "Limit": return OrderType.limit;
				case "Market": return OrderType.market;
			}
			throw new ArgumentException("Invalid order type.");
		}
	}
}
