using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.App
{
	[Serializable]
	public partial class State
	{
		public static readonly FileInfo FILE = new FileInfo("Data/AppState.bin");

		public static event EventHandler OnLoad;

		public static State Data { get; private set; }
		public static TaskCompletionSource<bool> LoadTask { get; private set; } = new TaskCompletionSource<bool>();
		public static bool Loaded { get; private set; } = false;

		// general
		public byte[] Key { get; set; }
		public byte[] IV { get; set; }

		// MarketsUIModule
		public Dictionary<string, List<string>> MarketsUIModule_Watchlist { get; set; } = new Dictionary<string, List<string>>();
		public string SelectedExchangeId { get; set; } = null;
		public string SelectedMarket { get; set; } = null;
		public int MarketsUIModule_SelectedWatchlistId { get; set; } = -1;

		// ChartUIModule
		public int ChartUIModule_SelectedTimeframeIndex { get; set; } = 0;

		// Settings



		public static Task LoadAsync()
		{
			return Task.Run(async () =>
			{
				if (!File.Exists(FILE.FullName))
				{
					Data = new State();
					LoadTask.SetResult(true);
					return;
				}
				Stream stream = File.Open(FILE.FullName, FileMode.Open);
				try
				{
					BinaryFormatter bf = new BinaryFormatter();
					Data = (State)bf.Deserialize(stream);
				}
				catch (Exception)
				{
					Data = new State();
					await SaveAsync();
				}
				finally
				{
					stream.Close();
					Loaded = true;
					LoadTask.SetResult(true);
					InvokeOnLoad();
				}
			});
		}

		public static Task SaveAsync()
		{
			return Task.Run(() =>
			{
				if (!Directory.Exists(FILE.Directory.FullName))
					Directory.CreateDirectory(FILE.Directory.FullName);
				Stream stream = File.Open(FILE.FullName, FileMode.Create);
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(stream, Data);
				stream.Close();
			});
		}

		public static void InvokeOnLoad()
		{
			OnLoad?.Invoke(Data, new EventArgs());
		}
	}
}
