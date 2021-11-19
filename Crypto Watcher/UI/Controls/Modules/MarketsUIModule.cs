using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinInterchanger.Utilities;
using System.Text.RegularExpressions;
using System.Diagnostics;
using CoinInterchangerLib.Environment;
using CoinInterchangerLib.Utilities;
using CoinInterchangerLib.App;

namespace CoinInterchanger.UI.Controls.Modules
{
	public partial class MarketsUIModule : UIModule
	{
		private MarketsModule _marketsModule;
		private List<ListViewItem> _hiddenTickers = new List<ListViewItem>();
		private string _searchText = "Search...";

		public MarketsUIModule()
		{
			InitializeComponent();
			//TODO: load stored watchlists
			//TODO: load last selected watchlist
			//cBoxExchange.Items.AddRange(APIManager.Ccxt.);
			//APIManager.Ccxt.GetExchangeName
			lstMarkets.Columns.Add("Market");
			lstMarkets.Columns.Add("Price");
			lstMarkets.Columns.Add("Volume");
			lstMarkets.Columns.Add("Change");
			lstMarkets.View = View.Details;
			lstMarkets.FullRowSelect = true;
			lstMarkets.ListViewItemSorter = null;
			lstMarkets.SelectedIndexChanged += LstMarkets_SelectedIndexChanged;
			lstMarkets.MouseClick += LstMarkets_MouseClick;
			lstMarkets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			lstMarkets.Sorting = SortOrder.Ascending;
			circularProgressBar1.Visible = true;
			cBoxExchange.SelectedIndexChanged += CBoxExchange_SelectedIndexChanged;
			cBoxWatchlist.Visible = false;
			btnFilter.Visible = false;
		}

		private void LstMarkets_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (lstMarkets.FocusedItem.Bounds.Contains(e.Location))
					itemContextMenuStrip.Show(Cursor.Position);
			}
		}

		private void LstMarkets_SelectedIndexChanged(object sender, EventArgs e)
		{
			var listView = sender as ListView;
			if (listView.SelectedItems.Count > 0)
			{
				List<string> ids = Utility.SplitString(listView.SelectedItems[0].SubItems[0].Text, ':');
				if (_marketsModule.SelectedExchangeId != ids[0])
				{
					_marketsModule.SelectedExchangeId = ids[0];
					State.Data.SelectedExchangeId = ids[0];
				}
				_marketsModule.SelectedMarket = ids[1];
				State.Data.SelectedMarket = ids[1];
			}
		}

		private void CBoxExchange_SelectedIndexChanged(object sender, EventArgs e)
		{
			_marketsModule.SelectedExchangeId = cBoxExchange.Text;
			State.Data.SelectedExchangeId = cBoxExchange.Text;
			circularProgressBar1.Visible = true;
			_hiddenTickers = new List<ListViewItem>();
			txtSearch.Text = _searchText;
		}

		public MarketsModule MarketsModule {
			get { return _marketsModule; }
			set {
				if (value == null)
					return;
				_marketsModule = value;
				_marketsModule.TickerUpdated += MarketsModule_OnTickerUpdate;
				_marketsModule.SelectedMarketChanged += MarketsModule_SelectedMarketChanged;
				_marketsModule.SelectedExchangeIdChanged += _marketsModule_SelectedExchangeIdChanged;
			}
		}

		private void _marketsModule_SelectedExchangeIdChanged(object sender, ExchangeEnvironment.OnSelectedExchangeIdChangedEventArgs e)
		{
			header.Text = _marketsModule.SelectedExchangeId + ":";
		}

		private void MarketsModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			header.Text = _marketsModule.SelectedExchangeId + ":" + _marketsModule.SelectedMarket;
		}

		private void MarketsModule_OnTickerUpdate(object sender, MarketsModule.TickerEventArgs e)
		{
			Console.WriteLine("updating tickers");
			ListViewItem[] items = new ListViewItem[e.Tickers.Count];
			int i = 0;
			foreach (var ticker in e.Tickers.Values)
			{
				items[i] = new ListViewItem(TickerToString(ticker, $"{e.SelectedExchangeId}:{ticker.symbol}"));
				i++;
			}
			UpdateTickers(items);
		}

		private void UpdateTickers(ListViewItem[] items)
		{
			if (InvokeRequired)
			{
				Invoke(new Action(() => UpdateTickers(items)));
				return;
			}
			bool resize = false;
			lstMarkets.SuspendLayout();
			lstMarkets.BeginUpdate();
			if (lstMarkets.Items.Count == 0)
				resize = true;
			lstMarkets.Items.Clear();
			lstMarkets.Items.AddRange(items);
			if (resize)
				lstMarkets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lstMarkets.EndUpdate();
			lstMarkets.ResumeLayout();
			circularProgressBar1.Visible = false;
		}
		
		// Passing in id because I have used it before so that I don't need to construct it again.
		private string[] TickerToString(CCXTSharp.Ticker ticker, string id)
		{
			string[] items = new string[4];
			items[0] = id;
			items[1] = ticker.last.ToString();
			items[2] = ticker.quoteVolume.ToString();
			items[3] = ticker.percentage.ToString();
			return items;
		}

		private void ModuleMarkets_SizeChanged(object sender, EventArgs e)
		{
			//int width = (Width - circularProgressBar1.Width) / 2;
			//cBoxWatchlist.Left = 0;
			//cBoxWatchlist.Width = width;
			//cBoxExchange.Left = width;

			int width = (Width - circularProgressBar1.Width);
			cBoxExchange.Left = 0;

			cBoxExchange.Width = width;
			if(lstMarkets.Items.Count != 0)
				lstMarkets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private async void ModuleMarkets_Load(object sender, EventArgs e)
		{
			// design mode
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode) {
				Console.WriteLine("design mode");
				return;
			}
			cBoxExchange.Items.AddRange((await _marketsModule.GetExchangeNames()).Keys.ToArray());

			for (int i = 0; i < cBoxExchange.Items.Count; i++)
			{
				if (cBoxExchange.Items[i].ToString() == State.Data.SelectedExchangeId)
				{
					cBoxExchange.SelectedIndex = i;
					break;
				}
			}
			circularProgressBar1.Visible = false;

			cBoxWatchlist.Items.AddRange(State.Data.MarketsUIModule_Watchlist.Keys.ToArray());
			cBoxWatchlist.SelectedIndex = State.Data.MarketsUIModule_SelectedWatchlistId;
			foreach (var watchlist in State.Data.MarketsUIModule_Watchlist)
				itemContextMenuStrip.Items.Add($"Add to {watchlist}");

			if (State.Data.SelectedMarket != null)
				_marketsModule.SelectedMarket = State.Data.SelectedMarket;
			if(State.Data.SelectedExchangeId != null)
				_marketsModule.SelectedExchangeId = State.Data.SelectedExchangeId;
		}

		private void itemContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			// create new watchlist
			if(e.ClickedItem == itemContextMenuStrip.Items[0])
			{

			}
			else
			{
				// adding selected items to watchlist
				string watchlist = e.ClickedItem.Text.Remove(0, 7);
				foreach (ListViewItem item in lstMarkets.SelectedItems)
					State.Data.MarketsUIModule_Watchlist[watchlist].Add(item.Text);
			}
		}

		private void txtSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
		
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text == "")
			{
				lstMarkets.BeginUpdate();
				lstMarkets.Items.AddRange(_hiddenTickers.ToArray());
				lstMarkets.EndUpdate();
				_hiddenTickers = new List<ListViewItem>();
				return;
			}
			else if (txtSearch.Text ==_searchText)
				return;
			lstMarkets.BeginUpdate();
			foreach (ListViewItem ticker in lstMarkets.Items)
			{
				if (!ticker.Text.Contains(txtSearch.Text))
				{
					_hiddenTickers.Add(ticker);
					ticker.Remove();
				}
			}
			lstMarkets.EndUpdate();
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			if (txtSearch.Text == "")
				txtSearch.Text = _searchText;
		}
	}
}
