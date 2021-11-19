using CCXTSharp;
using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinInterchanger.UI.Controls.Modules
{
	// NOTE: function names must start lowercase if used by js
	class JsGateway
	{
		private Func<long?, int?, Task<List<Candlestick>>> _fetchOHLCV;

		public JsGateway(Func<long?, int?, Task<List<Candlestick>>> fetchOHLCV)
		{
			_fetchOHLCV = fetchOHLCV;
		}
		
		public async Task getOHLCVAsync(IJavascriptCallback resolve, IJavascriptCallback reject)
		{
			await Promisify(resolve, reject, async () =>
			{
				List<Candlestick> data = await _fetchOHLCV(null, 2000);
				// structuring data as .tsv because I don't know how to change parser/data type in js
				string d = TSV.CreateTSV(data);
				return d;
			});
		}

		private static async Task Promisify(IJavascriptCallback resolve, IJavascriptCallback reject, Func<Task> action)
		{
			try
			{
				if (!resolve.IsDisposed)
					await action();

				if (!resolve.IsDisposed)
					await resolve.ExecuteAsync();
			}
			catch (Exception e)
			{
				if (!reject.IsDisposed)
					await reject.ExecuteAsync(e.ToString());
			}
		}

		private static async Task Promisify<T>(IJavascriptCallback resolve, IJavascriptCallback reject, Func<Task<T>> action)
		{
			try
			{
				var result = default(T);

				if (!resolve.IsDisposed)
					result = await action();

				if (!resolve.IsDisposed)
					await resolve.ExecuteAsync(result);
			}
			catch (Exception e)
			{
				if (!reject.IsDisposed)
					await reject.ExecuteAsync(e.ToString());
			}
		}
	}
}
