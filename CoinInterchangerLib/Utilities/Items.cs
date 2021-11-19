using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcher.Utilities
{
	class Items<T> : List<T>
	{
		public event EventHandler OnAdd;

		public new void Add(T item)
		{
			base.Add(item);
			OnAdd?.Invoke(this, null);
		}
	}
}
