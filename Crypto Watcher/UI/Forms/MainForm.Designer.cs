using System.Diagnostics;

namespace BorderlessForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TopLeftCornerPanel = new System.Windows.Forms.Panel();
			this.TopRightCornerPanel = new System.Windows.Forms.Panel();
			this.BottomLeftCornerPanel = new System.Windows.Forms.Panel();
			this.BottomRightCornerPanel = new System.Windows.Forms.Panel();
			this.TopBorderPanel = new System.Windows.Forms.Panel();
			this.BottomBorderPanel = new System.Windows.Forms.Panel();
			this.LeftBorderPanel = new System.Windows.Forms.Panel();
			this.RightBorderPanel = new System.Windows.Forms.Panel();
			this.MinimizeLabel = new System.Windows.Forms.Label();
			this.MaximizeLabel = new System.Windows.Forms.Label();
			this.CloseLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.SystemLabel = new System.Windows.Forms.Label();
			this.DecorationToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControlUI1 = new CoinInterchanger.UI.Controls.TabControlUI();
			this.tabMarkets = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			Stopwatch sw = new Stopwatch();
			sw.Start();
			this.moduleChart2 = new CoinInterchanger.UI.Controls.Modules.ChartUIModule();
			this.moduleMarkets1 = new CoinInterchanger.UI.Controls.Modules.MarketsUIModule();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cBox2 = new CoinInterchanger.UI.Controls.CBox();
			this.cBox1 = new CoinInterchanger.UI.Controls.CBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.moduleTrade1 = new CoinInterchanger.UI.Controls.Modules.TradeUIModule();
			this.tabExchange = new System.Windows.Forms.TabPage();
			this.tabAlerts = new System.Windows.Forms.TabPage();
			this.tabScreener = new System.Windows.Forms.TabPage();
			this.tabNotifications = new System.Windows.Forms.TabPage();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.tabAbout = new System.Windows.Forms.TabPage();
			this.headerPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControlUI1.SuspendLayout();
			this.tabMarkets.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.headerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopLeftCornerPanel
			// 
			this.TopLeftCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.TopLeftCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.TopLeftCornerPanel.Location = new System.Drawing.Point(0, 0);
			this.TopLeftCornerPanel.Name = "TopLeftCornerPanel";
			this.TopLeftCornerPanel.Size = new System.Drawing.Size(1, 1);
			this.TopLeftCornerPanel.TabIndex = 0;
			// 
			// TopRightCornerPanel
			// 
			this.TopRightCornerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TopRightCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.TopRightCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.TopRightCornerPanel.Location = new System.Drawing.Point(1263, 0);
			this.TopRightCornerPanel.Name = "TopRightCornerPanel";
			this.TopRightCornerPanel.Size = new System.Drawing.Size(1, 1);
			this.TopRightCornerPanel.TabIndex = 1;
			// 
			// BottomLeftCornerPanel
			// 
			this.BottomLeftCornerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BottomLeftCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.BottomLeftCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.BottomLeftCornerPanel.Location = new System.Drawing.Point(0, 681);
			this.BottomLeftCornerPanel.Name = "BottomLeftCornerPanel";
			this.BottomLeftCornerPanel.Size = new System.Drawing.Size(1, 1);
			this.BottomLeftCornerPanel.TabIndex = 1;
			// 
			// BottomRightCornerPanel
			// 
			this.BottomRightCornerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BottomRightCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.BottomRightCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.BottomRightCornerPanel.Location = new System.Drawing.Point(1263, 681);
			this.BottomRightCornerPanel.Name = "BottomRightCornerPanel";
			this.BottomRightCornerPanel.Size = new System.Drawing.Size(1, 1);
			this.BottomRightCornerPanel.TabIndex = 1;
			// 
			// TopBorderPanel
			// 
			this.TopBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.TopBorderPanel.Location = new System.Drawing.Point(1, 0);
			this.TopBorderPanel.Name = "TopBorderPanel";
			this.TopBorderPanel.Size = new System.Drawing.Size(470, 1);
			this.TopBorderPanel.TabIndex = 2;
			// 
			// BottomBorderPanel
			// 
			this.BottomBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.BottomBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorderPanel.Location = new System.Drawing.Point(1, 681);
			this.BottomBorderPanel.Name = "BottomBorderPanel";
			this.BottomBorderPanel.Size = new System.Drawing.Size(1262, 1);
			this.BottomBorderPanel.TabIndex = 3;
			// 
			// LeftBorderPanel
			// 
			this.LeftBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LeftBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.LeftBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorderPanel.Location = new System.Drawing.Point(0, 1);
			this.LeftBorderPanel.Name = "LeftBorderPanel";
			this.LeftBorderPanel.Size = new System.Drawing.Size(1, 680);
			this.LeftBorderPanel.TabIndex = 4;
			// 
			// RightBorderPanel
			// 
			this.RightBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RightBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
			this.RightBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RightBorderPanel.Location = new System.Drawing.Point(1263, 1);
			this.RightBorderPanel.Name = "RightBorderPanel";
			this.RightBorderPanel.Size = new System.Drawing.Size(1, 680);
			this.RightBorderPanel.TabIndex = 5;
			// 
			// MinimizeLabel
			// 
			this.MinimizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MinimizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.MinimizeLabel.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimizeLabel.Location = new System.Drawing.Point(1192, 0);
			this.MinimizeLabel.Name = "MinimizeLabel";
			this.MinimizeLabel.Size = new System.Drawing.Size(24, 24);
			this.MinimizeLabel.TabIndex = 7;
			this.MinimizeLabel.Text = "0";
			this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DecorationToolTip.SetToolTip(this.MinimizeLabel, "Minimize");
			// 
			// MaximizeLabel
			// 
			this.MaximizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MaximizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.MaximizeLabel.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeLabel.Location = new System.Drawing.Point(1216, 0);
			this.MaximizeLabel.Name = "MaximizeLabel";
			this.MaximizeLabel.Size = new System.Drawing.Size(24, 24);
			this.MaximizeLabel.TabIndex = 8;
			this.MaximizeLabel.Text = "1";
			this.MaximizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DecorationToolTip.SetToolTip(this.MaximizeLabel, "Maximize");
			// 
			// CloseLabel
			// 
			this.CloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.CloseLabel.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseLabel.Location = new System.Drawing.Point(1240, 0);
			this.CloseLabel.Name = "CloseLabel";
			this.CloseLabel.Size = new System.Drawing.Size(24, 24);
			this.CloseLabel.TabIndex = 9;
			this.CloseLabel.Text = "r";
			this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DecorationToolTip.SetToolTip(this.CloseLabel, "Close");
			// 
			// TitleLabel
			// 
			this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.TitleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(21, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(1175, 24);
			this.TitleLabel.TabIndex = 10;
			this.TitleLabel.Text = "Crypto Watcher";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SystemLabel
			// 
			this.SystemLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.SystemLabel.Enabled = false;
			this.SystemLabel.Location = new System.Drawing.Point(1172, 0);
			this.SystemLabel.Name = "SystemLabel";
			this.SystemLabel.Size = new System.Drawing.Size(24, 24);
			this.SystemLabel.TabIndex = 11;
			this.SystemLabel.Text = "g";
			this.SystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SystemLabel.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.pictureBox1.BackgroundImage = global::CoinInterchanger.Properties.Resources.AlarmIcon1;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// tabControlUI1
			// 
			this.tabControlUI1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUI1.AllowDrop = true;
			this.tabControlUI1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabControlUI1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.tabControlUI1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.tabControlUI1.ClosingMessage = null;
			this.tabControlUI1.Controls.Add(this.tabMarkets);
			this.tabControlUI1.Controls.Add(this.tabExchange);
			this.tabControlUI1.Controls.Add(this.tabAlerts);
			this.tabControlUI1.Controls.Add(this.tabScreener);
			this.tabControlUI1.Controls.Add(this.tabNotifications);
			this.tabControlUI1.Controls.Add(this.tabSettings);
			this.tabControlUI1.Controls.Add(this.tabAbout);
			this.tabControlUI1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlUI1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.tabControlUI1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.tabControlUI1.ItemSize = new System.Drawing.Size(240, 16);
			this.tabControlUI1.Location = new System.Drawing.Point(0, 24);
			this.tabControlUI1.Name = "tabControlUI1";
			this.tabControlUI1.SelectedIndex = 0;
			this.tabControlUI1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabControlUI1.ShowClosingButton = false;
			this.tabControlUI1.ShowClosingMessage = false;
			this.tabControlUI1.Size = new System.Drawing.Size(1264, 658);
			this.tabControlUI1.TabIndex = 1;
			this.tabControlUI1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// tabMarkets
			// 
			this.tabMarkets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabMarkets.Controls.Add(this.comboBox1);
			this.tabMarkets.Controls.Add(this.moduleChart2);
			this.tabMarkets.Controls.Add(this.moduleMarkets1);
			this.tabMarkets.Controls.Add(this.panel1);
			this.tabMarkets.Controls.Add(this.moduleTrade1);
			this.tabMarkets.Location = new System.Drawing.Point(4, 20);
			this.tabMarkets.Name = "tabMarkets";
			this.tabMarkets.Padding = new System.Windows.Forms.Padding(3);
			this.tabMarkets.Size = new System.Drawing.Size(1256, 634);
			this.tabMarkets.TabIndex = 0;
			this.tabMarkets.Text = "Markets";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.DimGray;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "eney",
            "miney",
            "tiny",
            "tiney"});
			this.comboBox1.Location = new System.Drawing.Point(1062, 426);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// moduleChart2
			// 
			this.moduleChart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.moduleChart2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.moduleChart2.CanMove = true;
			this.moduleChart2.CanResize = true;
			this.moduleChart2.Location = new System.Drawing.Point(443, 6);
			this.moduleChart2.ModuleHeaderText = "Module name";
			this.moduleChart2.Name = "moduleChart2";
			this.moduleChart2.SelectedExchangeId = null;
			this.moduleChart2.SelectedMarket = null;
			this.moduleChart2.SettingsButtonVisible = true;
			this.moduleChart2.SettingsPane = null;
			this.moduleChart2.Size = new System.Drawing.Size(605, 492);
			this.moduleChart2.TabIndex = 9;
			// 
			// moduleMarkets1
			// 
			this.moduleMarkets1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.moduleMarkets1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.moduleMarkets1.CanMove = true;
			this.moduleMarkets1.CanResize = true;
			this.moduleMarkets1.Location = new System.Drawing.Point(228, 3);
			this.moduleMarkets1.ModuleHeaderText = "Module name";
			this.moduleMarkets1.Name = "moduleMarkets1";
			this.moduleMarkets1.SettingsButtonVisible = false;
			this.moduleMarkets1.SettingsPane = null;
			this.moduleMarkets1.Size = new System.Drawing.Size(200, 628);
			this.moduleMarkets1.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.circularProgressBar1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.cBox2);
			this.panel1.Controls.Add(this.cBox1);
			this.panel1.Controls.Add(this.listView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 628);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::CoinInterchanger.Properties.Resources.filter;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(174, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// circularProgressBar1
			// 
			this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circularProgressBar1.AnimationSpeed = 500;
			this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
			this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
			this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.InnerMargin = 1;
			this.circularProgressBar1.InnerWidth = 1;
			this.circularProgressBar1.Location = new System.Drawing.Point(174, 0);
			this.circularProgressBar1.MarqueeAnimationSpeed = 4000;
			this.circularProgressBar1.Name = "circularProgressBar1";
			this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.OuterMargin = -1;
			this.circularProgressBar1.OuterWidth = 1;
			this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.circularProgressBar1.ProgressWidth = 2;
			this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
			this.circularProgressBar1.Size = new System.Drawing.Size(24, 24);
			this.circularProgressBar1.StartAngle = 270;
			this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.circularProgressBar1.SubscriptText = ".23";
			this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.circularProgressBar1.SuperscriptText = "°C";
			this.circularProgressBar1.TabIndex = 6;
			this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circularProgressBar1.Value = 68;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(0, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(173, 26);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Search...";
			// 
			// cBox2
			// 
			this.cBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.cBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cBox2.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cBox2.Items")));
			this.cBox2.Location = new System.Drawing.Point(86, -1);
			this.cBox2.Name = "cBox2";
			this.cBox2.SelectedIndex = -1;
			this.cBox2.Size = new System.Drawing.Size(87, 24);
			this.cBox2.TabIndex = 4;
			// 
			// cBox1
			// 
			this.cBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.cBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cBox1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cBox1.Items")));
			this.cBox1.Location = new System.Drawing.Point(0, -1);
			this.cBox1.Name = "cBox1";
			this.cBox1.SelectedIndex = -1;
			this.cBox1.Size = new System.Drawing.Size(87, 24);
			this.cBox1.TabIndex = 3;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listView1.Location = new System.Drawing.Point(0, 50);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(198, 576);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// moduleTrade1
			// 
			this.moduleTrade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.moduleTrade1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.moduleTrade1.CanMove = true;
			this.moduleTrade1.CanResize = true;
			this.moduleTrade1.Location = new System.Drawing.Point(1062, 29);
			this.moduleTrade1.ModuleHeaderText = "Trade";
			this.moduleTrade1.Name = "moduleTrade1";
			this.moduleTrade1.SettingsButtonVisible = false;
			this.moduleTrade1.SettingsPane = null;
			this.moduleTrade1.Size = new System.Drawing.Size(194, 391);
			this.moduleTrade1.TabIndex = 1;
			// 
			// tabExchange
			// 
			this.tabExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabExchange.Location = new System.Drawing.Point(4, 20);
			this.tabExchange.Name = "tabExchange";
			this.tabExchange.Padding = new System.Windows.Forms.Padding(3);
			this.tabExchange.Size = new System.Drawing.Size(1256, 634);
			this.tabExchange.TabIndex = 1;
			this.tabExchange.Text = "Exchange";
			// 
			// tabAlerts
			// 
			this.tabAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabAlerts.Location = new System.Drawing.Point(4, 20);
			this.tabAlerts.Name = "tabAlerts";
			this.tabAlerts.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlerts.Size = new System.Drawing.Size(1256, 634);
			this.tabAlerts.TabIndex = 2;
			this.tabAlerts.Text = "Alerts";
			// 
			// tabScreener
			// 
			this.tabScreener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabScreener.Location = new System.Drawing.Point(4, 20);
			this.tabScreener.Name = "tabScreener";
			this.tabScreener.Size = new System.Drawing.Size(1256, 634);
			this.tabScreener.TabIndex = 3;
			this.tabScreener.Text = "Screener";
			// 
			// tabNotifications
			// 
			this.tabNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabNotifications.Location = new System.Drawing.Point(4, 20);
			this.tabNotifications.Name = "tabNotifications";
			this.tabNotifications.Size = new System.Drawing.Size(1256, 634);
			this.tabNotifications.TabIndex = 4;
			this.tabNotifications.Text = "Notifications";
			// 
			// tabSettings
			// 
			this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabSettings.Location = new System.Drawing.Point(4, 20);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new System.Drawing.Size(1256, 634);
			this.tabSettings.TabIndex = 5;
			this.tabSettings.Text = "Settings";
			// 
			// tabAbout
			// 
			this.tabAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.tabAbout.Location = new System.Drawing.Point(4, 20);
			this.tabAbout.Name = "tabAbout";
			this.tabAbout.Size = new System.Drawing.Size(1256, 634);
			this.tabAbout.TabIndex = 6;
			this.tabAbout.Text = "About";
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.pictureBox1);
			this.headerPanel.Controls.Add(this.SystemLabel);
			this.headerPanel.Controls.Add(this.TitleLabel);
			this.headerPanel.Controls.Add(this.MinimizeLabel);
			this.headerPanel.Controls.Add(this.CloseLabel);
			this.headerPanel.Controls.Add(this.MaximizeLabel);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(1264, 24);
			this.headerPanel.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.ClientSize = new System.Drawing.Size(1264, 682);
			this.Controls.Add(this.tabControlUI1);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.RightBorderPanel);
			this.Controls.Add(this.LeftBorderPanel);
			this.Controls.Add(this.BottomBorderPanel);
			this.Controls.Add(this.TopRightCornerPanel);
			this.Controls.Add(this.BottomLeftCornerPanel);
			this.Controls.Add(this.BottomRightCornerPanel);
			this.Controls.Add(this.TopLeftCornerPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "MainForm";
			this.Text = "Crypto Watcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControlUI1.ResumeLayout(false);
			this.tabMarkets.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.headerPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TopLeftCornerPanel;
		private System.Windows.Forms.Panel TopRightCornerPanel;
		private System.Windows.Forms.Panel BottomLeftCornerPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
		private System.Windows.Forms.Panel BottomRightCornerPanel;
		private System.Windows.Forms.Panel BottomBorderPanel;
		private System.Windows.Forms.Panel LeftBorderPanel;
		private System.Windows.Forms.Panel RightBorderPanel;
		private System.Windows.Forms.Label MinimizeLabel;
		private System.Windows.Forms.Label MaximizeLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label SystemLabel;
		private System.Windows.Forms.Label CloseLabel;
		private System.Windows.Forms.ToolTip DecorationToolTip;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel headerPanel;
		private CoinInterchanger.UI.Controls.TabControlUI tabControlUI1;
		private System.Windows.Forms.TabPage tabMarkets;
		private System.Windows.Forms.TabPage tabExchange;
		private System.Windows.Forms.TabPage tabAlerts;
		private System.Windows.Forms.TabPage tabScreener;
		private System.Windows.Forms.TabPage tabNotifications;
		private System.Windows.Forms.TabPage tabSettings;
		private System.Windows.Forms.TabPage tabAbout;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listView1;
		private CoinInterchanger.UI.Controls.Modules.TradeUIModule moduleTrade1;
		private System.Windows.Forms.TextBox textBox1;
		private CoinInterchanger.UI.Controls.CBox cBox2;
		private CoinInterchanger.UI.Controls.CBox cBox1;
		private CircularProgressBar.CircularProgressBar circularProgressBar1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private CoinInterchanger.UI.Controls.Modules.MarketsUIModule moduleMarkets1;
		private CoinInterchanger.UI.Controls.Modules.ChartUIModule moduleChart1;
		private CoinInterchanger.UI.Controls.Modules.ChartUIModule moduleChart2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

