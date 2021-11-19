using CCXTSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinInterchangerLib.API.Managers;

namespace CoinInterchangerLib.Environment
{
	public class ChartModule : EnvironmentModule
	{
		private Candlestick _lastCandle;
		private Timeframe _timeframe;
		private TaskCompletionSource<bool> _selectedMarkedId = new TaskCompletionSource<bool>();

		public ChartModule(ExchangeEnvironment environment) : base(environment)
		{
			SelectedMarketChanged += ChartModule_SelectedMarketChanged;
		}

		public delegate void OnCandleUpdateEventHandler(object sender, CandleEventArgs e);
		public delegate void OnChartUpdateEventHandler(object sender, EventArgs e);

		public event OnCandleUpdateEventHandler OnCandleUpdate;
		public event OnChartUpdateEventHandler OnChartUpdateRequested;

		public Timeframe Timeframe {
			get { return _timeframe; }
			set {
				if (_timeframe != value)
				{
					_timeframe = value;
					OnChartUpdateRequested?.Invoke(this, new EventArgs());
				}
			}
		}
		//public List<Candlestick> Candles { get; private set; } = null;

		public async Task<List<Candlestick>> GetCandlesticksAsync(long? since, int? limit, long? lastCandleTimestamp = null)
		{
			try
			{
				if (SelectedMarket == null)
					await _selectedMarkedId.Task;
				if (since == null)
				{
					long time = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
					since = time - (long)Timeframe * 1000 * (limit + 1);
				}
				Console.WriteLine($"Fetching: {SelectedExchangeId}:{SelectedMarket};{Timeframe};{since};{limit}");
				var candles = /*await ExecuteInLoop(async () => */await CCXTManager.Ccxt.FetchOHLCV(SelectedExchangeId, SelectedMarket, Timeframe, since, limit);//);
																																								 //var candles = /*await ExecuteInLoop(async () => */CCXTManager.Ccxt.FetchOHLCV("binance", "BTC/USDT", Timeframe.d1, since, limit).Result;//);
				Console.WriteLine($"Fetched: {candles.Count};{candles.Last().Timestamp}");
				// some exchanges limit amount of candles to download so we are downloading again until we get desired amount
				if (limit != null && candles.Count != limit)
				{
					since += (long)Timeframe * 1000 * candles.Count;
					if (lastCandleTimestamp != candles.Last().Timestamp)
					{
						var newCandles = await GetCandlesticksAsync(since, limit - candles.Count, candles.Last().Timestamp);
						if (newCandles.Count != 0 && candles.Last().Timestamp != newCandles.Last().Timestamp && candles[candles.Count - 2].Timestamp != newCandles[newCandles.Count - 1].Timestamp)
							candles.AddRange(newCandles);
					}
					else return new List<Candlestick>();
				}
				return candles;
			}
			catch (CCXTException e)
			{
				InvokeOnError(e.Message);
			}
			return null;
		}

		private void ChartModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			if (!_selectedMarkedId.Task.IsCompleted)
				_selectedMarkedId.SetResult(true);
			OnChartUpdateRequested?.Invoke(this, new EventArgs());
			//AddCoroutineToLoop(CandleUpdate, false);
		}
		// todo make ghost to not waste time
		private async void CandleUpdate()
		{
			if (Timeframe == Timeframe.NONE)
			{
				Console.WriteLine(Timeframe);
				return;
			}
			long time = (long)((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds * 1000);
			Candlestick candle = (await CCXTManager.Ccxt.FetchOHLCV(SelectedExchangeId, SelectedMarket, Timeframe, time - (long)Timeframe * 1000, 1)).Last();
			if (_lastCandle == candle)
				return;
			if (_lastCandle == null)
			{
				_lastCandle = candle;
				OnCandleUpdate?.Invoke(this, new CandleEventArgs(candle, false));
				return;
			}

			if (_lastCandle.Timestamp != candle.Timestamp)
				OnCandleUpdate?.Invoke(this, new CandleEventArgs(candle, true));
			else
				OnCandleUpdate?.Invoke(this, new CandleEventArgs(candle, false));
			_lastCandle = candle;
		}
	}

	public class CandleEventArgs : EventArgs
	{
		public CandleEventArgs(Candlestick candle, bool append)
		{
			Candle = candle;
			Append = append;
		}

		public Candlestick Candle { get; set; }
		public bool Append { get; set; }
	}
}
