using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using CefSharp.WinForms;
using CefSharp;
using System.Diagnostics;
using CCXTSharp;
using CoinInterchangerLib.API.Managers;
using CoinInterchangerLib.Environment;
using CoinInterchangerLib.Utilities;
using CoinInterchangerLib.App;

namespace CoinInterchanger.UI.Controls.Modules
{
	//[Preload(new Type[] {typeof(CefSettings), typeof(Cef), typeof(ChromiumWebBrowser), typeof(CefSharpSettings)})]
	public partial class ChartUIModule : UIModule
	{
		private const string _HTML_RELATIVE_PATH = "index.html";
		private ChromiumWebBrowser[] _browsers = new ChromiumWebBrowser[2];
		private TaskCompletionSource<bool>[] _browserTasks = new TaskCompletionSource<bool>[2];
		private JsGateway[] _jsGateways = new JsGateway[2];
		private TaskCompletionSource<bool> _mainframeLoad = new TaskCompletionSource<bool>();
		private ChartModule _chartModule;
		private Stopwatch swReload = new Stopwatch();
		private int _currentBrowser = 0;

		static ChartUIModule()
		{
			Application.ApplicationExit += new EventHandler((s, e) => Cef.Shutdown());
		}

		public ChartUIModule()
		{
			InitializeComponent();
			bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
			if (designMode)
				return;
			List<string> items = new List<string>();
			foreach (var value in Enum.GetValues(typeof(Timeframe)))
				if ((Timeframe)value != Timeframe.NONE && (Timeframe)value != Timeframe.min3)
					items.Add(CcxtAPI.TimeframeToKey((Timeframe)value));
			cBoxTimeframe.Items.AddRange(items.ToArray());
			cBoxTimeframe.SelectedIndex = State.Data.ChartUIModule_SelectedTimeframeIndex;
			cBoxTimeframe.SelectedIndexChanged += OnTimeframeChanged;
			Stopwatch sw = new Stopwatch();
			sw.Start();
			InitializeChromium();
			Console.WriteLine($"Initialized cef: {sw.ElapsedMilliseconds}");
		}
		
		public ChartModule ChartModule {
			get { return _chartModule; }
			set {
				if (value == null)
					return;
				_chartModule = value;
				_chartModule.OnChartUpdateRequested += ChartModule_OnChartUpdateRequested;
				_chartModule.SelectedMarketChanged += ChartModule_SelectedMarketChanged;
				_chartModule.Timeframe = CcxtAPI.KeyToTimeframe((string)cBoxTimeframe.SelectedItem);
				_chartModule.OnError += ChartModule_OnError;
			}
		}

		public void Close()
		{
			foreach (var browser in _browsers)
			{
				try
				{
					//  throws exception because website is waiting for c# code
					browser.Dispose();
				}
				catch { }
			}
		}

		private void ChartModule_OnError(object sender, EnvironmentModule.ErrorEventArgs e)
		{
			MessageBox.Show($"Chart error: {e.Message}", "Coin Interchanger", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void ChartModule_SelectedMarketChanged(object sender, EventArgs e)
		{
			if (_chartModule.SelectedMarket == null)
				return;
			header.Text = $"{_chartModule.SelectedMarket} Chart";
		}

		private void ChartModule_OnChartUpdateRequested(object sender, EventArgs e)
		{
			if (_chartModule.SelectedMarket == null)
				return;
			if (InvokeRequired)
			{
				BeginInvoke(new Action(() => ChartModule_OnChartUpdateRequested(null, null)));
				return;
			}
			// Every time we change chart we have to reconstruct browser because communication is working
			// only first time when constructed.
			ReInitializeBrowser();
		}

		private void OnTimeframeChanged(object sender, EventArgs e)
		{
			_chartModule.Timeframe = CcxtAPI.KeyToTimeframe((string)cBoxTimeframe.SelectedItem);
			State.Data.ChartUIModule_SelectedTimeframeIndex = cBoxTimeframe.SelectedIndex;
		}

		private ChromiumWebBrowser ConstructBrowser()
		{
			ChromiumWebBrowser browser = new ChromiumWebBrowser("file://" + Directory.GetCurrentDirectory() + "/index.html");
			//_browser.IsBrowserInitializedChanged += (s, e) => { if (e.IsBrowserInitialized) _browser.ShowDevTools(); };
			// https://github.com/cefsharp/CefSharp/issues/2246
			_jsGateways[_currentBrowser] = new JsGateway(async (since, limit) =>
			{
				await _browserTasks[_currentBrowser].Task;
				return await _chartModule.GetCandlesticksAsync(since, limit);
			});
			// there are multiple ways to register objects, we are using old way
			browser.RegisterAsyncJsObject("cSharpGateway", _jsGateways[_currentBrowser]);
			browser.Visible = false;
			panelBrowser.Controls.Add(browser);
			_browserTasks[_currentBrowser] = new TaskCompletionSource<bool>();
			return browser;
		}

		private void ReInitializeBrowser()
		{
			if (InvokeRequired)
			{
				Invoke(new Action(ReInitializeBrowser));
				return;
			}
			panelBrowser.Controls.Remove(_browsers[_currentBrowser]);
			_browsers[_currentBrowser] = ConstructBrowser();
			_currentBrowser ^= 1;
			_browserTasks[_currentBrowser].SetResult(true);
			swReload.Restart();
			_browsers[_currentBrowser].Visible = true;
		}

		private void InitializeChromium()
		{
			CefSettings cefSettings = new CefSettings();
			// endble debugging in chrome browser on http://localhost:8088/
			//cefSettings.RemoteDebuggingPort = 8088;
			Cef.Initialize(cefSettings);
			CefSharpSettings.LegacyJavascriptBindingEnabled = true;
			CefSharpSettings.SubprocessExitIfParentProcessClosed = true;
			_browsers[_currentBrowser] = ConstructBrowser();
			_currentBrowser ^= 1;
			_browsers[_currentBrowser] = ConstructBrowser();
		}
	}
}
