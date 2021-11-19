namespace CoinInterchanger.UI.Controls.Modules
{
	partial class TradeUIModule
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
			this.tabControlSide = new CoinInterchanger.UI.Controls.TabControlUI();
			this.tabBuy = new System.Windows.Forms.TabPage();
			this.tabSell = new System.Windows.Forms.TabPage();
			this.lblType = new System.Windows.Forms.Label();
			this.lblBalanceName = new System.Windows.Forms.Label();
			this.lblInOrdersName = new System.Windows.Forms.Label();
			this.lblTotalName = new System.Windows.Forms.Label();
			this.lblBestPriceName = new System.Windows.Forms.Label();
			this.lblBestPrice = new CoinInterchanger.UI.LblAmount();
			this.lblTotal = new CoinInterchanger.UI.LblAmount();
			this.lblInOrders = new CoinInterchanger.UI.LblAmount();
			this.lblBalance = new CoinInterchanger.UI.LblAmount();
			this.btnAction = new System.Windows.Forms.Button();
			this.tradeUserInput1 = new CoinInterchanger.UI.Controls.TradeUserInput();
			this.workspacePanel = new System.Windows.Forms.Panel();
			this.cBoxType = new CoinInterchanger.UI.Controls.AdvancedComboBox();
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).BeginInit();
			this.tabControlSide.SuspendLayout();
			this.workspacePanel.SuspendLayout();
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
			// moduleExpand
			// 
			this.moduleExpand.FlatAppearance.BorderSize = 0;
			// 
			// moduleGripResize
			// 
			this.moduleGripResize.Location = new System.Drawing.Point(175, 344);
			// 
			// header
			// 
			this.header.Size = new System.Drawing.Size(192, 24);
			// 
			// tabControlSide
			// 
			this.tabControlSide.ActiveColor = System.Drawing.Color.Green;
			this.tabControlSide.AllowDrop = true;
			this.tabControlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSide.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.tabControlSide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.tabControlSide.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.tabControlSide.ClosingMessage = null;
			this.tabControlSide.Controls.Add(this.tabBuy);
			this.tabControlSide.Controls.Add(this.tabSell);
			this.tabControlSide.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.tabControlSide.HorizontalLineColor = System.Drawing.Color.Green;
			this.tabControlSide.ItemSize = new System.Drawing.Size(240, 16);
			this.tabControlSide.Location = new System.Drawing.Point(0, 0);
			this.tabControlSide.Name = "tabControlSide";
			this.tabControlSide.SelectedIndex = 0;
			this.tabControlSide.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabControlSide.ShowClosingButton = false;
			this.tabControlSide.ShowClosingMessage = false;
			this.tabControlSide.Size = new System.Drawing.Size(187, 21);
			this.tabControlSide.TabIndex = 2;
			this.tabControlSide.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabControlSide.SelectedIndexChanged += new System.EventHandler(this.tabControlSide_SelectedIndexChanged);
			// 
			// tabBuy
			// 
			this.tabBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.tabBuy.Location = new System.Drawing.Point(4, 20);
			this.tabBuy.Name = "tabBuy";
			this.tabBuy.Padding = new System.Windows.Forms.Padding(3);
			this.tabBuy.Size = new System.Drawing.Size(179, 0);
			this.tabBuy.TabIndex = 0;
			this.tabBuy.Text = "Buy";
			// 
			// tabSell
			// 
			this.tabSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.tabSell.Location = new System.Drawing.Point(4, 20);
			this.tabSell.Name = "tabSell";
			this.tabSell.Padding = new System.Windows.Forms.Padding(3);
			this.tabSell.Size = new System.Drawing.Size(179, 0);
			this.tabSell.TabIndex = 1;
			this.tabSell.Text = "Sell";
			// 
			// lblType
			// 
			this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.ForeColor = System.Drawing.Color.White;
			this.lblType.Location = new System.Drawing.Point(4, 31);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(47, 23);
			this.lblType.TabIndex = 3;
			this.lblType.Text = "Type:";
			this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBalanceName
			// 
			this.lblBalanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalanceName.ForeColor = System.Drawing.Color.White;
			this.lblBalanceName.Location = new System.Drawing.Point(4, 57);
			this.lblBalanceName.Name = "lblBalanceName";
			this.lblBalanceName.Size = new System.Drawing.Size(59, 23);
			this.lblBalanceName.TabIndex = 4;
			this.lblBalanceName.Text = "Balance:";
			this.lblBalanceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInOrdersName
			// 
			this.lblInOrdersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInOrdersName.ForeColor = System.Drawing.Color.White;
			this.lblInOrdersName.Location = new System.Drawing.Point(4, 80);
			this.lblInOrdersName.Name = "lblInOrdersName";
			this.lblInOrdersName.Size = new System.Drawing.Size(60, 23);
			this.lblInOrdersName.TabIndex = 6;
			this.lblInOrdersName.Text = "In Orders:";
			this.lblInOrdersName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTotalName
			// 
			this.lblTotalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalName.ForeColor = System.Drawing.Color.White;
			this.lblTotalName.Location = new System.Drawing.Point(4, 103);
			this.lblTotalName.Name = "lblTotalName";
			this.lblTotalName.Size = new System.Drawing.Size(59, 23);
			this.lblTotalName.TabIndex = 8;
			this.lblTotalName.Text = "Total:";
			this.lblTotalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBestPriceName
			// 
			this.lblBestPriceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBestPriceName.ForeColor = System.Drawing.Color.White;
			this.lblBestPriceName.Location = new System.Drawing.Point(4, 126);
			this.lblBestPriceName.Name = "lblBestPriceName";
			this.lblBestPriceName.Size = new System.Drawing.Size(59, 23);
			this.lblBestPriceName.TabIndex = 10;
			this.lblBestPriceName.Text = "Best bid:";
			this.lblBestPriceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBestPrice
			// 
			this.lblBestPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBestPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lblBestPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblBestPrice.ChangeFontAfterDecimalLength = 8;
			this.lblBestPrice.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBestPrice.ForeColor = System.Drawing.Color.White;
			this.lblBestPrice.Location = new System.Drawing.Point(72, 132);
			this.lblBestPrice.Multiline = false;
			this.lblBestPrice.Name = "lblBestPrice";
			this.lblBestPrice.ReadOnly = true;
			this.lblBestPrice.Size = new System.Drawing.Size(112, 17);
			this.lblBestPrice.TabIndex = 12;
			this.lblBestPrice.Text = "0.000000089112 BTC";
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTotal.ChangeFontAfterDecimalLength = -1;
			this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(72, 109);
			this.lblTotal.Multiline = false;
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.ReadOnly = true;
			this.lblTotal.Size = new System.Drawing.Size(115, 17);
			this.lblTotal.TabIndex = 13;
			this.lblTotal.Text = "0.757 BTC";
			// 
			// lblInOrders
			// 
			this.lblInOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lblInOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblInOrders.ChangeFontAfterDecimalLength = -1;
			this.lblInOrders.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblInOrders.ForeColor = System.Drawing.Color.White;
			this.lblInOrders.Location = new System.Drawing.Point(72, 86);
			this.lblInOrders.Multiline = false;
			this.lblInOrders.Name = "lblInOrders";
			this.lblInOrders.ReadOnly = true;
			this.lblInOrders.Size = new System.Drawing.Size(115, 17);
			this.lblInOrders.TabIndex = 14;
			this.lblInOrders.Text = "0.2 BTC";
			// 
			// lblBalance
			// 
			this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblBalance.ChangeFontAfterDecimalLength = -1;
			this.lblBalance.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBalance.ForeColor = System.Drawing.Color.White;
			this.lblBalance.Location = new System.Drawing.Point(72, 63);
			this.lblBalance.Multiline = false;
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.ReadOnly = true;
			this.lblBalance.Size = new System.Drawing.Size(115, 17);
			this.lblBalance.TabIndex = 15;
			this.lblBalance.Text = "0.547 BTC";
			// 
			// btnAction
			// 
			this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAction.BackColor = System.Drawing.Color.Green;
			this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAction.FlatAppearance.BorderSize = 0;
			this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAction.ForeColor = System.Drawing.Color.White;
			this.btnAction.Location = new System.Drawing.Point(3, 280);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(184, 23);
			this.btnAction.TabIndex = 19;
			this.btnAction.Text = "Buy";
			this.btnAction.UseVisualStyleBackColor = false;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// tradeUserInput1
			// 
			this.tradeUserInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tradeUserInput1.BackColor = System.Drawing.Color.Transparent;
			this.tradeUserInput1.Location = new System.Drawing.Point(2, 152);
			this.tradeUserInput1.MarketBaseSymbol = null;
			this.tradeUserInput1.MarketQuoteSymbol = null;
			this.tradeUserInput1.Name = "tradeUserInput1";
			this.tradeUserInput1.Size = new System.Drawing.Size(185, 122);
			this.tradeUserInput1.TabIndex = 20;
			// 
			// workspacePanel
			// 
			this.workspacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.workspacePanel.Controls.Add(this.cBoxType);
			this.workspacePanel.Controls.Add(this.tabControlSide);
			this.workspacePanel.Controls.Add(this.lblType);
			this.workspacePanel.Controls.Add(this.lblBalanceName);
			this.workspacePanel.Controls.Add(this.lblInOrdersName);
			this.workspacePanel.Controls.Add(this.lblTotalName);
			this.workspacePanel.Controls.Add(this.lblBestPriceName);
			this.workspacePanel.Controls.Add(this.lblBestPrice);
			this.workspacePanel.Controls.Add(this.lblTotal);
			this.workspacePanel.Controls.Add(this.lblInOrders);
			this.workspacePanel.Controls.Add(this.lblBalance);
			this.workspacePanel.Controls.Add(this.btnAction);
			this.workspacePanel.Controls.Add(this.tradeUserInput1);
			this.workspacePanel.Location = new System.Drawing.Point(0, 27);
			this.workspacePanel.Name = "workspacePanel";
			this.workspacePanel.Size = new System.Drawing.Size(190, 307);
			this.workspacePanel.TabIndex = 21;
			// 
			// cBoxType
			// 
			this.cBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cBoxType.BackColor = System.Drawing.Color.DimGray;
			this.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxType.ForeColor = System.Drawing.Color.White;
			this.cBoxType.FormattingEnabled = true;
			this.cBoxType.HighlightedForeColor = System.Drawing.Color.White;
			this.cBoxType.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.cBoxType.Location = new System.Drawing.Point(72, 35);
			this.cBoxType.Name = "cBoxType";
			this.cBoxType.Size = new System.Drawing.Size(112, 21);
			this.cBoxType.TabIndex = 21;
			// 
			// TradeUIModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.workspacePanel);
			this.Name = "TradeUIModule";
			this.Size = new System.Drawing.Size(192, 357);
			this.Controls.SetChildIndex(this.moduleGripResize, 0);
			this.Controls.SetChildIndex(this.header, 0);
			this.Controls.SetChildIndex(this.workspacePanel, 0);
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).EndInit();
			this.tabControlSide.ResumeLayout(false);
			this.workspacePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TabControlUI tabControlSide;
		private System.Windows.Forms.TabPage tabBuy;
		private System.Windows.Forms.TabPage tabSell;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblBalanceName;
		private System.Windows.Forms.Label lblBestPriceName;
		private System.Windows.Forms.Label lblTotalName;
		private System.Windows.Forms.Label lblInOrdersName;
		private LblAmount lblBestPrice;
		private LblAmount lblBalance;
		private LblAmount lblInOrders;
		private LblAmount lblTotal;
		private System.Windows.Forms.Button btnAction;
		private TradeUserInput tradeUserInput1;
		private System.Windows.Forms.Panel workspacePanel;
		private AdvancedComboBox cBoxType;
	}
}
