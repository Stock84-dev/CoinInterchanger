using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoinInterchangerLib.Environment;
using CoinInterchanger.UI;

namespace CoinInterchanger.UI.Controls.Forms
{
	public partial class MainForm : FormBase
	{
		private int _borderWidth = 2;
		public MainForm()
		{
			InitializeComponent();
			//UIUtility.DefaultBackColor = Color.FromArgb(45, 45, 48);
			//UIUtility.DefaultClickColor = Color.FromArgb(0, 122, 180);
			//UIUtility.DefaultSelectColor = Color.FromArgb(0, 122, 204);
			header.Text = "Coin Interchanger";

			BottomBorderPanel.Location = new Point(_borderWidth, Height - _borderWidth);
			BottomBorderPanel.Width = Width - _borderWidth * 2;
			BottomBorderPanel.BringToFront();

			RightBorderPanel.Location = new Point(Width - _borderWidth, _borderWidth);
			RightBorderPanel.Height = Height - _borderWidth * 2;

			TopRightCornerPanel.Location = new Point(Width - _borderWidth, 0);
			BottomRightCornerPanel.Location = new Point(Width - _borderWidth, Height - _borderWidth);
			BottomLeftCornerPanel.Location = new Point(0, Height - _borderWidth);
		}

		private ExchangeEnvironment _environment;
		public ExchangeEnvironment Environment { get { return _environment; }
			set {
				_environment = value;
				marketsUIModule1.MarketsModule = (MarketsModule)_environment.Modules[typeof(MarketsModule)];
				chartUIModule1.ChartModule = (ChartModule)_environment.Modules[typeof(ChartModule)];
				tradeUIModule1.TradeModule = (TradeModule)_environment.Modules[typeof(TradeModule)];
				ordersUIModule1.OrdersModule = (OrdersModule)_environment.Modules[typeof(OrdersModule)];
				_environment.Update();
				//chartUIModule1.Parent = null;
			//chartUIModule1 = null;
			}
		}



		private async void MainForm_Load(object sender, EventArgs e)
		{
		}

		private void tabMarkets_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			chartUIModule1.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void advancedButton2_Click(object sender, EventArgs e)
		{

		}

		private void advancedButton3_Click(object sender, EventArgs e)
		{

		}

		private void dgvAPI_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void chartUIModule1_Load(object sender, EventArgs e)
		{

		}
	}
}
