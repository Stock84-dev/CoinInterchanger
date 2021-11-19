using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoinInterchangerLib.APIManagers
{
	public class RESTLoop
	{
		private readonly object _coroutineQueueLock = new object();
		private readonly object _coroutinesLock = new object();
		private Queue<CoroutineTask> _coroutineQueue = new Queue<CoroutineTask>();
		private CancellationTokenSource _tokenSource;
		private bool _autostart, _autoBreak;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="autostart"></param>
		/// <param name="autoBreak">Breaks loop if there are no corutines to execute.</param>
		public RESTLoop(bool autostart, bool autoBreak)
		{
			_autostart = autostart;
			_autoBreak = autoBreak;
			if (autostart)
				Run();
		}

		/// <summary>
		/// Time to sleep between executing each function.
		/// </summary>
		public int SleepTime { get; set; } = 10000;
		public bool AutoAdjustSleepTime { get; set; } = true;
		public List<LoopCoroutine> Coroutines { get; set; } = new List<LoopCoroutine>();

		/// <summary>
		/// Adds function that executes in loop.
		/// </summary>
		public void AddCorutine(LoopCoroutine loopCoroutine)
		{
			lock (_coroutinesLock)
			{
				Coroutines.Add(loopCoroutine);
				if (_tokenSource.IsCancellationRequested && _autostart)
					Run();
			}
		}
		
		/// <summary>
		/// Removes function that executes in loop.
		/// </summary>
		public void RemoveCorutine(LoopCoroutine loopCoroutine)
		{
			lock (_coroutinesLock)
			{
				Coroutines.Remove(loopCoroutine);
				if (_autoBreak && _coroutineQueue.Count == 0 && Coroutines.Count == 0)
					Break();
			}
		}
		/// <summary>
		/// Starts running loop.
		/// </summary>
		public void Run()
		{
			_tokenSource = new CancellationTokenSource();
			Task loop = new Task(LoopTask, _tokenSource.Token);
			loop.Start();
		}
		/// <summary>
		/// Breaks loop.
		/// </summary>
		public void Break()
		{
			_tokenSource.Cancel();
		}
		/// <summary>
		/// On next function call in loop, executes provided method.
		/// </summary>
		/// <param name="action"></param>
		public async Task<object> Execute(Func<Task<object>> coroutine)
		{
			CoroutineTask actionTask = new CoroutineTask();
			actionTask.Function = coroutine;
			lock (_coroutineQueueLock)
				_coroutineQueue.Enqueue(actionTask);
			await actionTask.TaskCompleted.Task;

			return actionTask.ReturnValue;
		}

		private async void LoopTask()
		{
			int i = 0;
			while (true)
			{
				CoroutineTask prioritizedCoroutine = null;
				bool isGhost = false;
				lock (_coroutineQueueLock)
				{
					if (_coroutineQueue.Count != 0)
						prioritizedCoroutine = _coroutineQueue.Peek();
				}
				if (prioritizedCoroutine == null && Coroutines.Count != 0)
				{
					Action coroutine;
					lock (_coroutinesLock) coroutine = Coroutines[i].Corutine;
					Console.WriteLine($"Update call: {DateTime.Now}");
					Task.Run(() => { Call(coroutine); });
					isGhost = Coroutines[i].Ghost;
					if (i == Coroutines.Count - 1)
						i = 0;
					else
						i++;
				}
				else if(prioritizedCoroutine != null)
				{
					CoroutineTask coroutineTask = _coroutineQueue.Dequeue();
					Console.WriteLine($"Prioritized call: {DateTime.Now}");
					isGhost = true;
					Task.Run(async () =>
					{
						coroutineTask.ReturnValue = await Call(async () => { return await prioritizedCoroutine.Function(); });
						coroutineTask.TaskCompleted.SetResult(true);
					});
					
				}

				if (_tokenSource.IsCancellationRequested)
					return;
				if(!isGhost || Coroutines.Count == 1)
					await Task.Delay(SleepTime);
				if (_tokenSource.IsCancellationRequested)
					return;
				
			}
		}

		private void Call(Action coroutine)
		{
			try
			{
				coroutine();
			}
			catch (CCXTSharp.CCXTException e)
			{
				if (AutoAdjustSleepTime)
					SleepTime = (int)(SleepTime * 1.1);
				throw;
			}
		}

		private async Task<object> Call(Func<Task<object>> coroutine)
		{
			try
			{
				return await coroutine();
			}
			catch (CCXTSharp.CCXTException e)
			{
				if (AutoAdjustSleepTime)
					SleepTime = (int)(SleepTime * 1.1);
				throw;
			}
		}

		public class LoopCoroutine
		{
			
			/// <summary>
			/// 
			/// </summary>
			/// <param name="coroutine"></param>
			/// <param name="ghost">Don't sleep after executing this corutine.</param>
			public LoopCoroutine(Action coroutine, bool ghost)
			{
				Corutine = coroutine;
				Ghost = ghost;
			}

			public Action Corutine { get; set; }
			/// <summary>
			/// Don't sleep after executing this corutine.
			/// </summary>
			public bool Ghost { get; set; }
		}

		private class CoroutineTask
		{
			public object ReturnValue { get; set; }
			public Func<Task<object>> Function { get; set; }
			public TaskCompletionSource<bool> TaskCompleted { get; set; } = new TaskCompletionSource<bool>();
		}
	}
}
