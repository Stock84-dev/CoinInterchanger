namespace CoinInterchanger.UI.Controls.Modules
{
	partial class MarketsUIModule
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnFilter = new System.Windows.Forms.PictureBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lstMarkets = new System.Windows.Forms.ListView();
			this.cBoxWatchlist = new CoinInterchanger.UI.Controls.AdvancedComboBox();
			this.cBoxExchange = new CoinInterchanger.UI.Controls.AdvancedComboBox();
			this.itemContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToNewWatchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFilter)).BeginInit();
			this.itemContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// moduleSettings
			// 
			this.moduleSettings.FlatAppearance.BorderSize = 0;
			// 
			// modulePopup
			// 
			this.modulePopup.FlatAppearance.BorderSize = 0;
			// 
			// moduleLabel
			// 
			this.moduleLabel.Text = "Markets";
			// 
			// moduleExpand
			// 
			this.moduleExpand.FlatAppearance.BorderSize = 0;
			// 
			// moduleGripResize
			// 
			this.moduleGripResize.Location = new System.Drawing.Point(183, 615);
			// 
			// header
			// 
			this.header.Size = new System.Drawing.Size(200, 24);
			// 
			// btnFilter
			// 
			this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFilter.BackgroundImage = global::CoinInterchanger.Properties.Resources.filter;
			this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFilter.Location = new System.Drawing.Point(175, 47);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(24, 24);
			this.btnFilter.TabIndex = 12;
			this.btnFilter.TabStop = false;
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.ForeColor = System.Drawing.Color.White;
			this.txtSearch.Location = new System.Drawing.Point(0, 46);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(201, 26);
			this.txtSearch.TabIndex = 10;
			this.txtSearch.Text = "Search...";
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// lstMarkets
			// 
			this.lstMarkets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstMarkets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lstMarkets.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstMarkets.ForeColor = System.Drawing.Color.White;
			this.lstMarkets.Location = new System.Drawing.Point(-1, 77);
			this.lstMarkets.Name = "lstMarkets";
			this.lstMarkets.Size = new System.Drawing.Size(200, 532);
			this.lstMarkets.TabIndex = 13;
			this.lstMarkets.UseCompatibleStateImageBehavior = false;
			// 
			// cBoxWatchlist
			// 
			this.cBoxWatchlist.BackColor = System.Drawing.Color.DimGray;
			this.cBoxWatchlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxWatchlist.FormattingEnabled = true;
			this.cBoxWatchlist.HighlightedForeColor = System.Drawing.Color.White;
			this.cBoxWatchlist.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.cBoxWatchlist.Location = new System.Drawing.Point(0, 26);
			this.cBoxWatchlist.Name = "cBoxWatchlist";
			this.cBoxWatchlist.Size = new System.Drawing.Size(88, 21);
			this.cBoxWatchlist.TabIndex = 14;
			// 
			// cBoxExchange
			// 
			this.cBoxExchange.BackColor = System.Drawing.Color.DimGray;
			this.cBoxExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxExchange.FormattingEnabled = true;
			this.cBoxExchange.HighlightedForeColor = System.Drawing.Color.White;
			this.cBoxExchange.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.cBoxExchange.Location = new System.Drawing.Point(87, 26);
			this.cBoxExchange.Name = "cBoxExchange";
			this.cBoxExchange.Size = new System.Drawing.Size(88, 21);
			this.cBoxExchange.TabIndex = 15;
			// 
			// itemContextMenuStrip
			// 
			this.itemContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToNewWatchlistToolStripMenuItem});
			this.itemContextMenuStrip.Name = "itemContextMenuStrip";
			this.itemContextMenuStrip.Size = new System.Drawing.Size(186, 26);
			this.itemContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.itemContextMenuStrip_ItemClicked);
			// 
			// addToNewWatchlistToolStripMenuItem
			// 
			this.addToNewWatchlistToolStripMenuItem.Name = "addToNewWatchlistToolStripMenuItem";
			this.addToNewWatchlistToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.addToNewWatchlistToolStripMenuItem.Text = "Add to new watchlist";
			// 
			// circularProgressBar1
			// 
			this.circularProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circularProgressBar1.AnimationSpeed = 500;
			this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
			this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
			this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
			this.circularProgressBar1.InnerMargin = 1;
			this.circularProgressBar1.InnerWidth = 1;
			this.circularProgressBar1.Location = new System.Drawing.Point(175, 27);
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
			this.circularProgressBar1.TabIndex = 11;
			this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circularProgressBar1.Value = 68;
			this.circularProgressBar1.Visible = false;
			// 
			// MarketsUIModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.circularProgressBar1);
			this.Controls.Add(this.cBoxExchange);
			this.Controls.Add(this.cBoxWatchlist);
			this.Controls.Add(this.lstMarkets);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.txtSearch);
			this.ModuleHeaderText = "Markets";
			this.Name = "MarketsUIModule";
			this.SettingsButtonVisible = false;
			this.Size = new System.Drawing.Size(200, 628);
			this.Load += new System.EventHandler(this.ModuleMarkets_Load);
			this.SizeChanged += new System.EventHandler(this.ModuleMarkets_SizeChanged);
			this.Controls.SetChildIndex(this.moduleGripResize, 0);
			this.Controls.SetChildIndex(this.header, 0);
			this.Controls.SetChildIndex(this.txtSearch, 0);
			this.Controls.SetChildIndex(this.btnFilter, 0);
			this.Controls.SetChildIndex(this.lstMarkets, 0);
			this.Controls.SetChildIndex(this.cBoxWatchlist, 0);
			this.Controls.SetChildIndex(this.cBoxExchange, 0);
			this.Controls.SetChildIndex(this.circularProgressBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFilter)).EndInit();
			this.itemContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox btnFilter;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView lstMarkets;
		private AdvancedComboBox cBoxWatchlist;
		private AdvancedComboBox cBoxExchange;
		private System.Windows.Forms.ContextMenuStrip itemContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addToNewWatchlistToolStripMenuItem;
		private CircularProgressBar.CircularProgressBar circularProgressBar1;
	}
}
