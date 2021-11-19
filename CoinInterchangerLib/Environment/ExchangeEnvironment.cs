using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using CoinInterchangerLib.APIManagers;
using CoinInterchangerLib.App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.Environment
{
	public class ExchangeEnvironment
	{
		public static Dictionary<string, RESTLoop> loops = new Dictionary<string, RESTLoop>();

		private string _selectedExchangeId = null;
		private string _selectedMarket = null;

		public ExchangeEnvironment()
		{
			GetSavedDataAsync();
		}

		public delegate void SelectedExchangeIdChangedEventHandler(object sender, OnSelectedExchangeIdChangedEventArgs e);
		public delegate void OrderPlacedEventHandler(object sender, OrderPlacedEventArgs e);

		public event SelectedExchangeIdChangedEventHandler SelectedExchangeIdChanged;
		public event EventHandler SelectedMarketChanged;
		public event OrderPlacedEventHandler OrderPlaced;

		public string SelectedExchangeId {
			get {
				return _selectedExchangeId;
			}
			set {
				if (_selectedExchangeId == value)
					return;
				string oldId = _selectedExchangeId;
				AuthenticationTask = new TaskCompletionSource<bool>();
				SelectedMarket = null;
				_selectedExchangeId = value;
				if (!loops.ContainsKey(_selectedExchangeId))
					loops.Add(_selectedExchangeId, new RESTLoop(true, true));
				SelectedExchangeIdChanged?.Invoke(this, new OnSelectedExchangeIdChangedEventArgs(oldId));
				TryAuthenticate();
			}
		}

		public string SelectedMarket {
			get {
				return _selectedMarket;
			}
			set {
				if (_selectedMarket == value)
					return;
				_selectedMarket = value;
				SelectedMarketChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		public Dictionary<Type, EnvironmentModule> Modules { get; private set; } = new Dictionary<Type, EnvironmentModule>();
		public TaskCompletionSource<bool> AuthenticationTask { get; private set; } = new TaskCompletionSource<bool>();

		public static Task InitAsync()
		{
			return CCXTManager.InitAsync();
		}

		public static async Task Exit()
		{
			await CCXTManager.Close();
		}

		public void InvokeOrderPlaced(object sender, OrderPlacedEventArgs e)
		{
			OrderPlaced?.Invoke(sender, e);
		}

		public void Update()
		{
			if(SelectedExchangeId != null)
				SelectedExchangeIdChanged?.Invoke(this, new OnSelectedExchangeIdChangedEventArgs(SelectedExchangeId));
			if(SelectedMarket != null)
				SelectedMarketChanged?.Invoke(this, EventArgs.Empty);
		}

		private async void GetSavedDataAsync()
		{
			await State.LoadTask.Task;
			SelectedExchangeId = State.Data.SelectedExchangeId;
			SelectedMarket = State.Data.SelectedMarket;
		}

		private async void TryAuthenticate()
		{
			// TODO: BUG something is null here when running without vs
			await Task.Delay(1000);
			await PrivateData.LoadTask.Task;
			Debug.Indent();
			Debug.WriteLine(PrivateData.Data.ExchangeAPIs);
			Debug.WriteLine(SelectedExchangeId);
			Debug.WriteLine(CCXTManager.Ccxt);
			Debug.WriteLine(PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Key);
			Debug.WriteLine(PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Secret);
			Debug.Unindent();
			if (PrivateData.Data.ExchangeAPIs == null || string.IsNullOrEmpty(PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Key) || string.IsNullOrEmpty(PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Secret))
			{
				AuthenticationTask.SetResult(false);
				return;
			}
			await CCXTManager.Ccxt.ExchangeApiKey(SelectedExchangeId, PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Key);
			await CCXTManager.Ccxt.ExchangeSecret(SelectedExchangeId, PrivateData.Data.ExchangeAPIs[SelectedExchangeId].Secret);
			AuthenticationTask.SetResult(true);
		}

		public class OnSelectedExchangeIdChangedEventArgs : EventArgs
		{
			public OnSelectedExchangeIdChangedEventArgs(string oldExchangeId)
			{
				OldExchangeId = oldExchangeId;
			}

			public string OldExchangeId { get; set; }
		}

		public class OrderPlacedEventArgs : EventArgs
		{
			public OrderPlacedEventArgs(Order order)
			{
				Order = order;
			}

			public Order Order { get; set; }
		}
	}
}
