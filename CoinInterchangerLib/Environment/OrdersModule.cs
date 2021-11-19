using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.Environment
{
	public class OrdersModule : EnvironmentModule
	{
		public OrdersModule(ExchangeEnvironment environment) : base(environment)
		{
			environment.SelectedMarketChanged += (s, e) => TryFetchOrders();
		}

		public delegate void OpenOrdersChangedEventHandler(object sender, OpenOrdersChangedEventArgs e);

		public event OpenOrdersChangedEventHandler OpenOrdersChanged;
		public event ExchangeEnvironment.OrderPlacedEventHandler OrderPlaced {
			add { env.OrderPlaced += value; }
			remove { env.OrderPlaced -= value; }
		}

		public async Task<Order> CancelOrder(string orderId, string symbol)
		{
			await env.AuthenticationTask.Task;
			return await CCXTManager.Ccxt.CancelOrder(SelectedExchangeId, orderId, symbol);
		}

		private async void TryFetchOrders()
		{
			// if authentication failed we don't fetch orders
			if (!await env.AuthenticationTask.Task)
				return;
			try
			{
			List<Order> openOrders = await CCXTManager.Ccxt.FetchOpenOrders(SelectedExchangeId, SelectedMarket, null, null);
			OpenOrdersChanged?.Invoke(this, new OpenOrdersChangedEventArgs(openOrders));
			}
			catch (CCXTException ex)
			{
				if (ex.Message == "Incorrect padding")
					InvokeOnError("Invalid credentials.");
			}
		}

		public class OpenOrdersChangedEventArgs : EventArgs
		{
			public OpenOrdersChangedEventArgs(List<Order> openOrders)
			{
				OpenOrders = openOrders;
			}

			public List<Order> OpenOrders { get; set; }
		}
	}
}
