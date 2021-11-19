using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchanger.UI.Controls
{
	interface IOrder
	{
		List<OrderData> GetOrders();
	}

	public class OrderData
	{
		public float Amount { get; set; }
		public float Price { get; set; }
	}
}
