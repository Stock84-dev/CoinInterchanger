using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinInterchangerLib.App;
using CoinInterchangerLib.API.Managers;
using System.Diagnostics;

namespace CoinInterchanger.UI.Controls
{
	public partial class TabSettings_APIManagement : UserControl
	{
		public TabSettings_APIManagement()
		{
			InitializeComponent();
			dgvAPI.ScrollBars = ScrollBars.Both;
		}

		private async void btnShow_Click(object sender, EventArgs e)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			dgvAPI.Visible = false;
			if (dgvAPI.Rows.Count == 0)
			{
				if (PrivateData.Data.ExchangeAPIs != null)
					foreach (var api in PrivateData.Data.ExchangeAPIs)
						dgvAPI.Rows.Add(api.Key, api.Value.Key, api.Value.Secret);
				else
				{
					PrivateData.Data.ExchangeAPIs = new Dictionary<string, PrivateData.ExchangeAPI>();
					foreach (var id in await CCXTManager.GetExchangeIds())
						PrivateData.Data.ExchangeAPIs.Add(id, new PrivateData.ExchangeAPI("", ""));
					foreach (var api in PrivateData.Data.ExchangeAPIs)
						dgvAPI.Rows.Add(api.Key, api.Value.Key, api.Value.Secret);
				}
			}
			else
				foreach (DataGridViewRow row in dgvAPI.Rows)
					row.Visible = true;
			dgvAPI.Visible = true;
			Console.WriteLine(sw.ElapsedMilliseconds);
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvAPI.Rows)
				row.Visible = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvAPI.Rows)
				PrivateData.Data.ExchangeAPIs[(string)row.Cells[0].Value] = new PrivateData.ExchangeAPI((string)row.Cells[1].Value, (string)row.Cells[2].Value);
		}
	}
}
