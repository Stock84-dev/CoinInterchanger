using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.Environment
{
	public class TradeModule : EnvironmentModule
	{
		public TradeModule(ExchangeEnvironment environment) : base(environment)
		{

		}

		public async Task<Order> PlaceOrder(OrderSide side, OrderType type, float amount, float price)
		{
			Order order = await CCXTManager.Ccxt.CreateOrder(SelectedExchangeId, SelectedMarket, type, side, amount, price);
			env.InvokeOrderPlaced(this, new ExchangeEnvironment.OrderPlacedEventArgs(order));
			return order;
		}
	}
}
