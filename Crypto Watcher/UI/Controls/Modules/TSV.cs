using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CCXTSharp;
using System.Threading;
using System.Globalization;

namespace CoinInterchanger.UI.Controls.Modules
{
	static class TSV
	{
		public static string CreateTSV(List<Candlestick> candlesticks)
		{
			StringBuilder tsv = new StringBuilder("date\topen\thigh\tlow\tclose\tvolume\n");
			foreach (var candle in candlesticks)
			{
				tsv.AppendLine(CandleToTSV(candle));
			}

			return tsv.ToString();
		}

		public static string CandleToTSV(Candlestick candle)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			dateTime = dateTime.AddMilliseconds(candle.Timestamp).ToLocalTime();
			var t = dateTime.ToString("yyyy-MM-dd hh:mm");
			return t + "\t" + candle.open.ToString(CultureInfo.InvariantCulture)
				+ "\t" + candle.high.ToString(CultureInfo.InvariantCulture)
				+ "\t" + candle.low.ToString(CultureInfo.InvariantCulture)
				+ "\t" + candle.close.ToString(CultureInfo.InvariantCulture)
				+ "\t" + candle.volume.ToString(CultureInfo.InvariantCulture);
		}
	}
}