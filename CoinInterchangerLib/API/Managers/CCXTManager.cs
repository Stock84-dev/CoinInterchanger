using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCXTSharp;

/*
	have a loop where api calls are made after specified amount of seconds
	if api with higher priority is getting called then stop loop until finished

*/

namespace CoinInterchangerLib.API.Managers
{
	public static class CCXTManager
	{
		//TODO: will caching improve peformance? (will use more ram for sure)

		public static Task InitAsync()
		{
			return Task.Run(async () =>
			{
				// NOTE: this method takes about 5s to finish
				Stopwatch sw = new Stopwatch();
				sw.Start();
				Ccxt = new CcxtAPI(@"ccxt\ccxtAPI.exe");
				//Ccxt = new CcxtAPI(@"D:\Documents\Visual Studio 2017\Projects\Crypto-Watcher\Crypto Watcher\ccxt\scripts\ccxtAPI.py", @"c:\Python36\python.exe", true);
				_initTask.SetResult(true);
				Console.WriteLine("constructed ccxt:" + sw.ElapsedMilliseconds);
			});
		}

		public static CcxtAPI Ccxt { get; private set; }
		private static Dictionary<string, string> _exchangeNames = new Dictionary<string, string>();

		private static TaskCompletionSource<bool> _exchangeIdsTask = new TaskCompletionSource<bool>();
		private static TaskCompletionSource<bool> _exchangeNamesTask = new TaskCompletionSource<bool>();
		private static TaskCompletionSource<bool> _initTask = new TaskCompletionSource<bool>();

		private static bool _exchangeIdsTaskStarted = false;
		private static bool _exchangeNamesTaskStarted = false;

		public static async Task<List<string>> GetExchangeIds()
		{
			if (!_exchangeIdsTaskStarted)
			{
				_exchangeIdsTaskStarted = true;
				await _initTask.Task;
				List<string> ids = await Ccxt.GetExchangeIds();
				foreach (var id in ids)
				{
					if(id != "coinmarketcap")
						_exchangeNames.Add(id, null);
				}
				_exchangeIdsTask.SetResult(true);
			}
			await _exchangeIdsTask.Task;
			return _exchangeNames.Keys.ToList();
		}

		public static async Task<Dictionary<string, string>> GetExchangeNames()
		{
			if (!_exchangeNamesTaskStarted)
			{
				_exchangeNamesTaskStarted = true;
				List<string> ids = await GetExchangeIds();
				foreach (var id in ids)
				{
					_exchangeNames[id] = await Ccxt.GetExchangeName(id);
				}
				_exchangeNamesTask.SetResult(true);
			}
			await _exchangeNamesTask.Task;
			return _exchangeNames;
		}

		public static async Task Close()
		{
			await Ccxt.Close();
		}
	}
}
