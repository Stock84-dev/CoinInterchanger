using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using CoinInterchangerLib.Utilities;

namespace CoinInterchangerLib.Environment
{
	public class MarketsModule : EnvironmentModule
	{
		private Has _apiCapabiliy;
		private Dictionary<string, Ticker> _tickers;

		public MarketsModule(ExchangeEnvironment e) : base(e)
		{
			//AppState.OnLoad += AppState_OnLoad;
			SelectedExchangeIdChanged += MarketsModule_SelectedExchangeIdChanged;
			SelectedMarketChanged += MarketsModule_SelectedMarketChanged;
		}

		public delegate void TickerUpdatedEventHandler(object sender, TickerEventArgs e);

		public event TickerUpdatedEventHandler TickerUpdated;

		public string SelectedExchangeName { set { SetExchangeId(value); } }
		new public string SelectedExchangeId { get { return base.SelectedExchangeId; } set { base.SelectedExchangeId = value; } }
		new public string SelectedMarket { get { return base.SelectedMarket; } set { base.SelectedMarket = value; } }

		public async Task<Dictionary<string, string>> GetExchangeNames()
		{
			return await CCXTManager.GetExchangeNames();
		}
		
		private async void MarketsModule_SelectedExchangeIdChanged(object sender, EventArgs e)
		{
			Console.WriteLine($"exchangeId: {SelectedExchangeId}");
			_apiCapabiliy = await CCXTManager.Ccxt.GetExchangeHas(SelectedExchangeId);
			//AddCoroutineToLoop(InvokeUpdate, true);
			OnTickerUpdated();
		}

		private void MarketsModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			Console.WriteLine($"market: {SelectedMarket}");
		}

		private async void SetExchangeId(string exchangeName)
		{
			Dictionary<string, string> exchangeNames = await CCXTManager.GetExchangeNames();
			SelectedExchangeId = exchangeNames.First(x => x.Value == exchangeName).Key;
		}

		private async void OnTickerUpdated()
		{
			_tickers = await GetTickers();

			TickerUpdated?.Invoke(this, new TickerEventArgs(_tickers, SelectedExchangeId, SelectedMarket));
		}

		private async Task<Dictionary<string, Ticker>> GetTickers()
		{
			if (_apiCapabiliy.fetchTickers == Has.Capability.Emulated || _apiCapabiliy.fetchTickers == Has.Capability.True)
			{
				if (_apiCapabiliy.fetchTickers == Has.Capability.Emulated)
					Console.WriteLine("fetch ticker emulated");
				return await /*ExecuteInLoop(async () => { return await */CCXTManager.Ccxt.FetchTickers(SelectedExchangeId);// });
			}
			else if (_apiCapabiliy.fetchTicker == Has.Capability.Emulated || _apiCapabiliy.fetchTicker == Has.Capability.True)
			{
				if (_apiCapabiliy.fetchTicker == Has.Capability.Emulated)
					Console.WriteLine("fetch ticker emulated");
				Dictionary<string, Ticker> tickers = new Dictionary<string, Ticker>();
				Dictionary<string, Market> markets = /*await ExecuteInLoop(async () => { return*/ await CCXTManager.Ccxt.LoadMarkets(SelectedExchangeId); //});
				foreach (var market in markets.Keys)
					tickers.Add(market, /*await ExecuteInLoop(async () => { return*/ await CCXTManager.Ccxt.FetchTicker(SelectedExchangeId, market)); //}));
				return tickers;
			}
			return null;
		}

		public class TickerEventArgs : EventArgs
		{
			public TickerEventArgs(Dictionary<string, Ticker> tickers, string selectedExchangeId, string selectedMarket)
			{
				Tickers = tickers;
				SelectedExchangeId = selectedExchangeId;
				SelectedMarket = selectedMarket;
			}

			public Dictionary<string, Ticker> Tickers { get; set; }
			public string SelectedExchangeId { get; set; }
			public string SelectedMarket { get; set; }
		}
	}
}
