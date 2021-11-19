namespace CoinInterchanger.UI.Controls.Modules
{
	partial class OrdersUIModule
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.orderTabControl = new CoinInterchanger.UI.Controls.TabControlUI();
			this.tabOpenOrders = new System.Windows.Forms.TabPage();
			this.dgvOpenOrders = new CoinInterchanger.UI.Controls.AdvancedDataGridView();
			this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnMarket = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFilledOfTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnCancel = new System.Windows.Forms.DataGridViewButtonColumn();
			this.columnOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).BeginInit();
			this.orderTabControl.SuspendLayout();
			this.tabOpenOrders.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOpenOrders)).BeginInit();
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
			this.moduleGripResize.Location = new System.Drawing.Point(596, 332);
			// 
			// header
			// 
			this.header.Size = new System.Drawing.Size(613, 24);
			// 
			// orderTabControl
			// 
			this.orderTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.orderTabControl.AllowDrop = true;
			this.orderTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.orderTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.orderTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.orderTabControl.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.orderTabControl.ClosingMessage = null;
			this.orderTabControl.Controls.Add(this.tabOpenOrders);
			this.orderTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.orderTabControl.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.orderTabControl.ItemSize = new System.Drawing.Size(240, 16);
			this.orderTabControl.Location = new System.Drawing.Point(0, 24);
			this.orderTabControl.Name = "orderTabControl";
			this.orderTabControl.SelectedIndex = 0;
			this.orderTabControl.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.orderTabControl.ShowClosingButton = false;
			this.orderTabControl.ShowClosingMessage = false;
			this.orderTabControl.Size = new System.Drawing.Size(613, 302);
			this.orderTabControl.TabIndex = 9;
			this.orderTabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// tabOpenOrders
			// 
			this.tabOpenOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.tabOpenOrders.Controls.Add(this.dgvOpenOrders);
			this.tabOpenOrders.Location = new System.Drawing.Point(4, 20);
			this.tabOpenOrders.Name = "tabOpenOrders";
			this.tabOpenOrders.Padding = new System.Windows.Forms.Padding(3);
			this.tabOpenOrders.Size = new System.Drawing.Size(605, 278);
			this.tabOpenOrders.TabIndex = 0;
			this.tabOpenOrders.Text = "Open Orders";
			// 
			// dgvOpenOrders
			// 
			this.dgvOpenOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvOpenOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvOpenOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTime,
            this.columnMarket,
            this.columnType,
            this.columnSide,
            this.columnPrice,
            this.columnAmount,
            this.columnFilledOfTotal,
            this.columnTotal,
            this.columnCancel,
            this.columnOrderId});
			this.dgvOpenOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOpenOrders.Location = new System.Drawing.Point(3, 3);
			this.dgvOpenOrders.Name = "dgvOpenOrders";
			this.dgvOpenOrders.ReadOnly = true;
			this.dgvOpenOrders.Size = new System.Drawing.Size(599, 272);
			this.dgvOpenOrders.TabIndex = 0;
			this.dgvOpenOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpenOrders_CellContentClick);
			// 
			// columnTime
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnTime.DefaultCellStyle = dataGridViewCellStyle1;
			this.columnTime.HeaderText = "Time";
			this.columnTime.Name = "columnTime";
			this.columnTime.ReadOnly = true;
			this.columnTime.Width = 55;
			// 
			// columnMarket
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnMarket.DefaultCellStyle = dataGridViewCellStyle2;
			this.columnMarket.HeaderText = "Market";
			this.columnMarket.Name = "columnMarket";
			this.columnMarket.ReadOnly = true;
			this.columnMarket.Width = 65;
			// 
			// columnType
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnType.DefaultCellStyle = dataGridViewCellStyle3;
			this.columnType.HeaderText = "Type";
			this.columnType.Name = "columnType";
			this.columnType.ReadOnly = true;
			this.columnType.Width = 56;
			// 
			// columnSide
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnSide.DefaultCellStyle = dataGridViewCellStyle4;
			this.columnSide.HeaderText = "Side";
			this.columnSide.Name = "columnSide";
			this.columnSide.ReadOnly = true;
			this.columnSide.Width = 53;
			// 
			// columnPrice
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnPrice.DefaultCellStyle = dataGridViewCellStyle5;
			this.columnPrice.HeaderText = "Price";
			this.columnPrice.Name = "columnPrice";
			this.columnPrice.ReadOnly = true;
			this.columnPrice.Width = 56;
			// 
			// columnAmount
			// 
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnAmount.DefaultCellStyle = dataGridViewCellStyle6;
			this.columnAmount.HeaderText = "Amount";
			this.columnAmount.Name = "columnAmount";
			this.columnAmount.ReadOnly = true;
			this.columnAmount.Width = 68;
			// 
			// columnFilledOfTotal
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnFilledOfTotal.DefaultCellStyle = dataGridViewCellStyle7;
			this.columnFilledOfTotal.HeaderText = "Filled/Total";
			this.columnFilledOfTotal.Name = "columnFilledOfTotal";
			this.columnFilledOfTotal.ReadOnly = true;
			this.columnFilledOfTotal.Width = 85;
			// 
			// columnTotal
			// 
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnTotal.DefaultCellStyle = dataGridViewCellStyle8;
			this.columnTotal.HeaderText = "Total";
			this.columnTotal.Name = "columnTotal";
			this.columnTotal.ReadOnly = true;
			this.columnTotal.Width = 56;
			// 
			// columnCancel
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			this.columnCancel.DefaultCellStyle = dataGridViewCellStyle9;
			this.columnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.columnCancel.HeaderText = "Cancel";
			this.columnCancel.Name = "columnCancel";
			this.columnCancel.ReadOnly = true;
			this.columnCancel.UseColumnTextForButtonValue = true;
			this.columnCancel.Width = 46;
			// 
			// columnOrderId
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnOrderId.DefaultCellStyle = dataGridViewCellStyle10;
			this.columnOrderId.HeaderText = "OrderId";
			this.columnOrderId.Name = "columnOrderId";
			this.columnOrderId.ReadOnly = true;
			this.columnOrderId.Visible = false;
			// 
			// OrdersUIModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.orderTabControl);
			this.Name = "OrdersUIModule";
			this.SettingsButtonVisible = true;
			this.Size = new System.Drawing.Size(613, 345);
			this.Controls.SetChildIndex(this.moduleGripResize, 0);
			this.Controls.SetChildIndex(this.header, 0);
			this.Controls.SetChildIndex(this.orderTabControl, 0);
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).EndInit();
			this.orderTabControl.ResumeLayout(false);
			this.tabOpenOrders.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOpenOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControlUI orderTabControl;
		private System.Windows.Forms.TabPage tabOpenOrders;
		private AdvancedDataGridView dgvOpenOrders;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMarket;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSide;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnFilledOfTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
		private System.Windows.Forms.DataGridViewButtonColumn columnCancel;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOrderId;
	}
}
