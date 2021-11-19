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
using CoinInterchangerLib.API.Managers;

namespace CoinInterchanger.UI.Controls.Modules
{
	public partial class OrdersUIModule : UIModule
	{
		private OrdersModule _ordersModule;

		public OrdersUIModule()
		{
			InitializeComponent();
			columnFilledOfTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			columnCancel.UseColumnTextForButtonValue = true;
			columnCancel.FlatStyle = FlatStyle.Flat;
			columnCancel.Text = "Cancel";
			dgvOpenOrders.RowHeadersVisible = false;
			dgvOpenOrders.ReadOnly = true;
			dgvOpenOrders.AllowUserToAddRows = false;
			dgvOpenOrders.AllowUserToDeleteRows = false;
			dgvOpenOrders.AllowUserToResizeRows = false;
		}

		public OrdersModule OrdersModule {
			get { return _ordersModule; }
			set {
				if (value == null)
					return;
				_ordersModule = value;
				_ordersModule.SelectedMarketChanged += OrdersModule_SelectedMarketChanged;
				_ordersModule.OrderPlaced += OrdersModule_OrderPlaced;
				_ordersModule.OpenOrdersChanged += OrdersModule_OpenOrdersChanged;
				_ordersModule.OnError += OrdersModule_OnError;
			}
		}

		private void OrdersModule_OnError(object sender, EnvironmentModule.ErrorEventArgs e)
		{
			MessageBox.Show($"Orders error: {e.Message}", "Coin Interchanger", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void OrdersModule_OpenOrdersChanged(object sender, OrdersModule.OpenOrdersChangedEventArgs e)
		{
			dgvOpenOrders.SuspendLayout();
			foreach (DataGridViewRow row in dgvOpenOrders.Rows)
				dgvOpenOrders.Rows.Remove(row);
			foreach (var order in e.OpenOrders)
				AddOrder(order);

			dgvOpenOrders.ResumeLayout();
		}

		private void OrdersModule_OrderPlaced(object sender, ExchangeEnvironment.OrderPlacedEventArgs e)
		{
			AddOrder(e.Order);
		}

		private void OrdersModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			dgvOpenOrders.Rows.Clear();
			header.Text = $"{_ordersModule.SelectedMarket} orders";
		}

		private async void dgvOpenOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != dgvOpenOrders.Columns["columnCancel"].Index)
				return;
			var cells = dgvOpenOrders.Rows[e.RowIndex].Cells;
			await _ordersModule.CancelOrder((string)cells["columnOrderId"].Value, (string)cells["columnMarket"].Value);
			dgvOpenOrders.Rows.RemoveAt(e.RowIndex);
		}

		private void AddOrder(CCXTSharp.Order order)
		{
			float total = order.amount.Value * order.price.Value;
			string filledOfTotal = $"{order.filled.ToString()}/{total.ToString()}";
			dgvOpenOrders.Rows.Add(order.datetime, order.symbol, order.type, order.side, order.price, order.amount, filledOfTotal, total, new DataGridViewButtonCell(), order.id);
		}
	}
}
