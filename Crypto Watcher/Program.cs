/* Order of items within a class, struct or interface: (SA1201 and SA1203)

Constant Fields
Fields
Constructors
Finalizers (Destructors)
Delegates
Events
Enums
Interfaces
Properties
Indexers
Methods
Structs
Classes

Within each of these groups order by access: (SA1202)
public
internal
protected internal
protected
private

Within each of the access groups, order by static, then non-static: (SA1204)
static
non-static

Within each of the static/non-static groups of fields, order by readonly, then non-readonly : (SA1214 and SA1215)
readonly
non-readonly
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Globalization;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CoinInterchanger.Utilities;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;
using CoinInterchangerLib.Environment;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using CoinInterchangerLib.Utilities;
using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using System.Security.Cryptography;
using CoinInterchangerLib.App;
using CoinInterchanger.UI.Controls.Forms;

// TODO: make trading paired to usd (e.g. buy btc using usd then buy alt)
// TODO: ask for password, hash it and compare results, then use that hash to decrypt sensitive data
namespace CoinInterchanger
{
	public static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Application.Run(new TestForm());
#if DEBUG
			Stopwatch sw = new Stopwatch();
			sw.Start();
#endif
			Task apiTask = ExchangeEnvironment.InitAsync();
			Task loadTask = State.LoadAsync();
			Task privateTask = PrivateData.LoadEncrypted(null);
			Application.SetCompatibleTextRenderingDefault(false);
			Application.EnableVisualStyles();
			//UI.Controls.Modules.CreateWatchlistForm form = new UI.Controls.Modules.CreateWatchlistForm();
			CoinInterchanger.UI.Controls.Forms.FormBase form = new UI.Controls.Forms.FormBase();

			ExchangeEnvironment exchangeEnv = new ExchangeEnvironment();
			MarketsModule marketsModule = new MarketsModule(exchangeEnv);
			ChartModule chartModule = new ChartModule(exchangeEnv);
			TradeModule tradeModule = new TradeModule(exchangeEnv);
			OrdersModule ordersModule = new OrdersModule(exchangeEnv);
#if DEBUG
			Console.WriteLine($"Assemlby: {sw.ElapsedMilliseconds}");
			sw.Restart();
#endif

			CoinInterchanger.UI.Controls.Forms.MainForm mainForm = new CoinInterchanger.UI.Controls.Forms.MainForm();
#if DEBUG
			Console.WriteLine("constructed form: " + sw.ElapsedMilliseconds);
			sw.Restart();
#endif
			apiTask.Wait();
			//Foo();
			loadTask.Wait();
			privateTask.Wait();
			mainForm.Environment = exchangeEnv;

#if DEBUG
			Console.WriteLine("waited for ccxt: " + sw.ElapsedMilliseconds);
#endif
			try
			{
				Application.Run(mainForm);
			}
			catch (System.Reflection.TargetInvocationException e)
			{
				Console.WriteLine(e.InnerException.Message);
			}

			ExchangeEnvironment.Exit().Wait();
			PrivateData.SaveEncrypted(null).Wait();
			State.SaveAsync().Wait();
			//Task.Delay(1000).Wait();
		}

		public static async void Foo()
		{
			Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
			Task t = Task.Run(async ()=>await Task.Delay(1000));
			Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
			await t;
			Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");

		}

		public static async Task<List<Candlestick>> GetCandlesticksAsync(long? since, int? limit, long? lastCandleTimestamp = null)
		{
			string SelectedExchangeId = "binance";
			string SelectedMarket = "BTC/USDT";
			Timeframe timeFrame = Timeframe.d1;
			
			if (since == null)
			{
				long time = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
				since = time - (long)timeFrame * 1000 * (limit + 1);
			}
			Console.WriteLine($"Fetching: {SelectedExchangeId}:{SelectedMarket};{timeFrame};{since};{limit}");
			var candles = /*await ExecuteInLoop(async () => */await CCXTManager.Ccxt.FetchOHLCV(SelectedExchangeId, SelectedMarket, timeFrame, since, limit);//);
																																							 //var candles = /*await ExecuteInLoop(async () => */CCXTManager.Ccxt.FetchOHLCV("binance", "BTC/USDT", Timeframe.d1, since, limit).Result;//);
			Console.WriteLine($"Fetched: {candles.Count};{candles.Last().Timestamp}");
			// some exchanges limit amount of candles to download so we are downloading again until we get desired amount
			try
			{

			if (limit != null && candles.Count != limit)
			{
				since += (long)timeFrame * 1000 * candles.Count;
				if (lastCandleTimestamp != candles.Last().Timestamp)
				{
					var newCandles = await GetCandlesticksAsync(since, limit - candles.Count, candles.Last().Timestamp);
					if (candles.Last().Timestamp != newCandles.Last().Timestamp && candles[candles.Count - 2].Timestamp != newCandles[newCandles.Count - 1].Timestamp)
						candles.AddRange(newCandles);
				}
				else return new List<Candlestick>();
			}
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.InnerException.Message);
				Console.WriteLine(e.InnerException.StackTrace);
			}
			return candles;
		}

		static void load()
		{
			GC.KeepAlive(typeof(CefSettings));
			GC.KeepAlive(typeof(Cef));
			GC.KeepAlive(typeof(ChromiumWebBrowser));
			GC.KeepAlive(typeof(CefSharpSettings));
		}

		//private static void GenerateBinary(List<MyCandle> candles)
		//{
		//	Stream stream = File.Open("serialization.bin", FileMode.Create);
		//	BinaryFormatter bf = new BinaryFormatter();
		//	bf.Serialize(stream, candles);
		//	stream.Close();
		//}

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		[Serializable]
		private class MyCandle
		{
			public float High { get; set; }
			public float Close { get; set; }
			public int Timestamp { get; set; }
			public float Open { get; set; }
			public float Low { get; set; }
			public string Name { get; set; }
			public float Volume { get; set; }

			public Guid InstanceID { get; private set; }
			// Other properties, etc.

			public MyCandle()
			{
				this.InstanceID = Guid.NewGuid();
			}
		}

		[Serializable]
		private class Items
		{
			public Dictionary<Guid, MyCandle> Candle { get; set; } = new Dictionary<Guid, MyCandle>();
		}

	}
}

// class implements IState
// IState has load and save methods which return object

/*
Priority list
1.	Make loop
2.	Frontend markets
3.	Backend markets
4.	Trade backend
5.	Design chart
6.	Chart backend
7.	Api key frontend
8.	ApiKey backend
9.	Balances frontend
10.	Balances backend

	 */
