using System.Diagnostics;

namespace CoinInterchanger.UI.Controls.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlUI1 = new CoinInterchanger.UI.Controls.TabControlUI();
			this.tabExchange = new System.Windows.Forms.TabPage();
			this.tradeUIModule1 = new CoinInterchanger.UI.Controls.Modules.TradeUIModule();
			this.ordersUIModule1 = new CoinInterchanger.UI.Controls.Modules.OrdersUIModule();
			this.marketsUIModule1 = new CoinInterchanger.UI.Controls.Modules.MarketsUIModule();
			this.chartUIModule1 = new CoinInterchanger.UI.Controls.Modules.ChartUIModule();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.tabControlUISettings = new CoinInterchanger.UI.Controls.TabControlUI();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabSettings_APIManagement1 = new CoinInterchanger.UI.Controls.TabSettings_APIManagement();
			this.tabControlUI1.SuspendLayout();
			this.tabExchange.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.tabControlUISettings.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopRightCornerPanel
			// 
			this.TopRightCornerPanel.Location = new System.Drawing.Point(1243, 0);
			// 
			// BottomLeftCornerPanel
			// 
			this.BottomLeftCornerPanel.Location = new System.Drawing.Point(0, 680);
			// 
			// TopBorderPanel
			// 
			this.TopBorderPanel.Size = new System.Drawing.Size(1257, 2);
			// 
			// BottomRightCornerPanel
			// 
			this.BottomRightCornerPanel.Location = new System.Drawing.Point(1243, 680);
			// 
			// BottomBorderPanel
			// 
			this.BottomBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.BottomBorderPanel.Location = new System.Drawing.Point(2, 680);
			this.BottomBorderPanel.Size = new System.Drawing.Size(1245, 2);
			// 
			// LeftBorderPanel
			// 
			this.LeftBorderPanel.Size = new System.Drawing.Size(2, 717);
			// 
			// RightBorderPanel
			// 
			this.RightBorderPanel.Location = new System.Drawing.Point(1243, 2);
			this.RightBorderPanel.Size = new System.Drawing.Size(2, 717);
			// 
			// header
			// 
			this.header.Location = new System.Drawing.Point(2, 2);
			this.header.Size = new System.Drawing.Size(1257, 24);
			// 
			// tabControlUI1
			// 
			this.tabControlUI1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUI1.AllowDrop = true;
			this.tabControlUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlUI1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabControlUI1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.tabControlUI1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.tabControlUI1.ClosingMessage = null;
			this.tabControlUI1.Controls.Add(this.tabExchange);
			this.tabControlUI1.Controls.Add(this.tabSettings);
			this.tabControlUI1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.tabControlUI1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUI1.ItemSize = new System.Drawing.Size(240, 16);
			this.tabControlUI1.Location = new System.Drawing.Point(2, 29);
			this.tabControlUI1.Name = "tabControlUI1";
			this.tabControlUI1.SelectedIndex = 0;
			this.tabControlUI1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabControlUI1.ShowClosingButton = false;
			this.tabControlUI1.ShowClosingMessage = false;
			this.tabControlUI1.Size = new System.Drawing.Size(1257, 693);
			this.tabControlUI1.TabIndex = 1;
			this.tabControlUI1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// tabExchange
			// 
			this.tabExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabExchange.Controls.Add(this.tradeUIModule1);
			this.tabExchange.Controls.Add(this.ordersUIModule1);
			this.tabExchange.Controls.Add(this.marketsUIModule1);
			this.tabExchange.Controls.Add(this.chartUIModule1);
			this.tabExchange.Location = new System.Drawing.Point(4, 20);
			this.tabExchange.Name = "tabExchange";
			this.tabExchange.Padding = new System.Windows.Forms.Padding(3);
			this.tabExchange.Size = new System.Drawing.Size(1268, 669);
			this.tabExchange.TabIndex = 0;
			this.tabExchange.Text = "Exchange";
			this.tabExchange.Click += new System.EventHandler(this.tabMarkets_Click);
			// 
			// tradeUIModule1
			// 
			this.tradeUIModule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.tradeUIModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tradeUIModule1.CanMove = true;
			this.tradeUIModule1.CanResize = true;
			this.tradeUIModule1.HideStats = true;
			this.tradeUIModule1.Location = new System.Drawing.Point(1057, 429);
			this.tradeUIModule1.ModuleHeaderText = "Module name";
			this.tradeUIModule1.Name = "tradeUIModule1";
			this.tradeUIModule1.SettingsButtonVisible = false;
			this.tradeUIModule1.SettingsPane = null;
			this.tradeUIModule1.Size = new System.Drawing.Size(192, 238);
			this.tradeUIModule1.TabIndex = 20;
			this.tradeUIModule1.TradeModule = null;
			// 
			// ordersUIModule1
			// 
			this.ordersUIModule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ordersUIModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ordersUIModule1.CanMove = true;
			this.ordersUIModule1.CanResize = true;
			this.ordersUIModule1.Location = new System.Drawing.Point(342, 429);
			this.ordersUIModule1.ModuleHeaderText = "Module name";
			this.ordersUIModule1.Name = "ordersUIModule1";
			this.ordersUIModule1.OrdersModule = null;
			this.ordersUIModule1.SettingsButtonVisible = false;
			this.ordersUIModule1.SettingsPane = null;
			this.ordersUIModule1.Size = new System.Drawing.Size(710, 238);
			this.ordersUIModule1.TabIndex = 19;
			// 
			// marketsUIModule1
			// 
			this.marketsUIModule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.marketsUIModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.marketsUIModule1.CanMove = true;
			this.marketsUIModule1.CanResize = true;
			this.marketsUIModule1.Location = new System.Drawing.Point(0, 5);
			this.marketsUIModule1.MarketsModule = null;
			this.marketsUIModule1.ModuleHeaderText = "Markets";
			this.marketsUIModule1.Name = "marketsUIModule1";
			this.marketsUIModule1.SettingsButtonVisible = false;
			this.marketsUIModule1.SettingsPane = null;
			this.marketsUIModule1.Size = new System.Drawing.Size(338, 662);
			this.marketsUIModule1.TabIndex = 18;
			// 
			// chartUIModule1
			// 
			this.chartUIModule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.chartUIModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chartUIModule1.CanMove = true;
			this.chartUIModule1.CanResize = true;
			this.chartUIModule1.ChartModule = null;
			this.chartUIModule1.Location = new System.Drawing.Point(342, 5);
			this.chartUIModule1.ModuleHeaderText = "Module name";
			this.chartUIModule1.Name = "chartUIModule1";
			this.chartUIModule1.SettingsButtonVisible = false;
			this.chartUIModule1.SettingsPane = null;
			this.chartUIModule1.Size = new System.Drawing.Size(907, 419);
			this.chartUIModule1.TabIndex = 11;
			this.chartUIModule1.Load += new System.EventHandler(this.chartUIModule1_Load);
			// 
			// tabSettings
			// 
			this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabSettings.Controls.Add(this.tabControlUISettings);
			this.tabSettings.Location = new System.Drawing.Point(4, 20);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new System.Drawing.Size(1268, 669);
			this.tabSettings.TabIndex = 5;
			this.tabSettings.Text = "Settings";
			// 
			// tabControlUISettings
			// 
			this.tabControlUISettings.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUISettings.AllowDrop = true;
			this.tabControlUISettings.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabControlUISettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.tabControlUISettings.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.tabControlUISettings.ClosingMessage = null;
			this.tabControlUISettings.Controls.Add(this.tabPage2);
			this.tabControlUISettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlUISettings.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.tabControlUISettings.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUISettings.ItemSize = new System.Drawing.Size(240, 16);
			this.tabControlUISettings.Location = new System.Drawing.Point(0, 0);
			this.tabControlUISettings.Name = "tabControlUISettings";
			this.tabControlUISettings.SelectedIndex = 0;
			this.tabControlUISettings.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabControlUISettings.ShowClosingButton = false;
			this.tabControlUISettings.ShowClosingMessage = false;
			this.tabControlUISettings.Size = new System.Drawing.Size(1268, 669);
			this.tabControlUISettings.TabIndex = 0;
			this.tabControlUISettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabPage2.Controls.Add(this.tabSettings_APIManagement1);
			this.tabPage2.Location = new System.Drawing.Point(4, 20);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1260, 645);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "API Management";
			// 
			// tabSettings_APIManagement1
			// 
			this.tabSettings_APIManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabSettings_APIManagement1.Location = new System.Drawing.Point(3, 3);
			this.tabSettings_APIManagement1.Name = "tabSettings_APIManagement1";
			this.tabSettings_APIManagement1.Size = new System.Drawing.Size(1254, 639);
			this.tabSettings_APIManagement1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1245, 682);
			this.Controls.Add(this.tabControlUI1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "MainForm";
			this.Text = "Crypto Watcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Controls.SetChildIndex(this.TopLeftCornerPanel, 0);
			this.Controls.SetChildIndex(this.BottomRightCornerPanel, 0);
			this.Controls.SetChildIndex(this.BottomLeftCornerPanel, 0);
			this.Controls.SetChildIndex(this.TopRightCornerPanel, 0);
			this.Controls.SetChildIndex(this.BottomBorderPanel, 0);
			this.Controls.SetChildIndex(this.LeftBorderPanel, 0);
			this.Controls.SetChildIndex(this.TopBorderPanel, 0);
			this.Controls.SetChildIndex(this.RightBorderPanel, 0);
			this.Controls.SetChildIndex(this.tabControlUI1, 0);
			this.Controls.SetChildIndex(this.header, 0);
			this.tabControlUI1.ResumeLayout(false);
			this.tabExchange.ResumeLayout(false);
			this.tabSettings.ResumeLayout(false);
			this.tabControlUISettings.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private CoinInterchanger.UI.Controls.TabControlUI tabControlUI1;
		private System.Windows.Forms.TabPage tabExchange;
		private System.Windows.Forms.TabPage tabSettings;
		private Modules.MarketsUIModule marketsUIModule1;
		private Modules.ChartUIModule chartUIModule1;
		private TabControlUI tabControlUISettings;
		private System.Windows.Forms.TabPage tabPage2;
		private TabSettings_APIManagement tabSettings_APIManagement1;
		private Modules.OrdersUIModule ordersUIModule1;
		private Modules.TradeUIModule tradeUIModule1;
	}
}

