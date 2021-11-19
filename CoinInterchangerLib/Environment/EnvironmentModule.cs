using CoinInterchangerLib.APIManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchangerLib.Environment
{
	public abstract class EnvironmentModule
	{
		public EnvironmentModule(ExchangeEnvironment environment)
		{
			environment.Modules.Add(GetType(), this);
			env = environment;
			//environment.OnSelectedExchangeIdChanged += OnSelectedExchangeIdChanged;
			//environment.OnSelectedMarketChanged += OnSelectedMarketChanged;
		}

		public delegate void OnErrorEventHandler(object sender, ErrorEventArgs e);

		public event OnErrorEventHandler OnError;

		public event ExchangeEnvironment.SelectedExchangeIdChangedEventHandler SelectedExchangeIdChanged {
			add { env.SelectedExchangeIdChanged += value; }
			remove { env.SelectedExchangeIdChanged -= value; }
		}

		public event EventHandler SelectedMarketChanged {
			add { env.SelectedMarketChanged += value; }
			remove { env.SelectedMarketChanged -= value; }
		}

		protected ExchangeEnvironment env;
		private List<RESTLoop.LoopCoroutine> _loopCoroutines = new List<RESTLoop.LoopCoroutine>();

		public string SelectedMarket { get { return env.SelectedMarket; } protected set { env.SelectedMarket = value; } }
		public string SelectedExchangeId {
			get {
				return env.SelectedExchangeId;
			}
			protected set {
				// automatically removing all corutines that this object is using when exchangeId changes
				if (env.SelectedExchangeId == value)
					return;
				_loopCoroutines.ForEach(c => RemoveCorutineFromLoop(c.Corutine, c.Ghost));
				env.SelectedExchangeId = value;
			}
		}

		protected void InvokeOnError(string message)
		{
			OnError?.Invoke(this, new ErrorEventArgs(message));
		}

		//protected virtual void OnSelectedExchangeIdChanged(object sender, EventArgs e) { }
		//protected virtual void OnSelectedMarketChanged(object sender, EventArgs e) { }
		/// <summary>
		/// Adds function that executes in loop.
		/// </summary>
		/// <param name="coroutine"></param>
		/// <param name="ghost">Don't sleep after executing this corutine.</param>
		protected void AddCoroutineToLoop(Action coroutine, bool ghost)
		{
			Console.WriteLine("Adding corutine to loop");
			RESTLoop.LoopCoroutine loopCorutine = new RESTLoop.LoopCoroutine(coroutine, ghost);
			_loopCoroutines.Add(loopCorutine);
			ExchangeEnvironment.loops[SelectedExchangeId].AddCorutine(loopCorutine);
		}
		/// <summary>
		/// Removes function that executes in loop.
		/// </summary>
		/// <param name="coroutine"></param>
		/// <param name="ghost">Don't sleep after executing this corutine.</param>
		protected void RemoveCorutineFromLoop(Action coroutine, bool ghost)
		{
			Console.WriteLine("Removing corutine from loop");
			RESTLoop.LoopCoroutine loopCorutine = new RESTLoop.LoopCoroutine(coroutine, ghost);
			_loopCoroutines.Remove(loopCorutine);
			ExchangeEnvironment.loops[SelectedExchangeId].RemoveCorutine(loopCorutine);
		}

		/// <summary>
		/// Executes provided function and ratelimits it.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="corutine"></param>
		/// <returns></returns>
		protected async Task<T> ExecuteInLoop<T>(Func<Task<T>> corutine)
		{
			return (T)await ExchangeEnvironment.loops[env.SelectedExchangeId].Execute(async () => { return await corutine(); });
		}

		public class ErrorEventArgs : EventArgs
		{
			public ErrorEventArgs(string message)
			{
				Message = message;
			}

			public string Message { get; set; }
		}
	}
}
