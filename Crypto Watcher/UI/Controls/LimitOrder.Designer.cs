namespace CoinInterchanger.UI.Controls
{
	partial class LimitOrder
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
			this.nTxtBoxTotal = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.nTxtBoxPrice = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.nTBoxAmount = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.SuspendLayout();
			// 
			// nTxtBoxTotal
			// 
			this.nTxtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTxtBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTxtBoxTotal.DisplayedText = "Total:";
			this.nTxtBoxTotal.IncrementVisible = true;
			this.nTxtBoxTotal.Location = new System.Drawing.Point(3, 55);
			this.nTxtBoxTotal.Name = "nTxtBoxTotal";
			this.nTxtBoxTotal.ReadOnly = false;
			this.nTxtBoxTotal.Size = new System.Drawing.Size(177, 20);
			this.nTxtBoxTotal.Symbol = "BTC";
			this.nTxtBoxTotal.TabIndex = 32;
			this.nTxtBoxTotal.TextBoxLocation = new System.Drawing.Point(37, 0);
			this.nTxtBoxTotal.Value = null;
			// 
			// nTxtBoxPrice
			// 
			this.nTxtBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTxtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTxtBoxPrice.DisplayedText = "Price:";
			this.nTxtBoxPrice.IncrementVisible = true;
			this.nTxtBoxPrice.Location = new System.Drawing.Point(3, 29);
			this.nTxtBoxPrice.Name = "nTxtBoxPrice";
			this.nTxtBoxPrice.ReadOnly = false;
			this.nTxtBoxPrice.Size = new System.Drawing.Size(177, 20);
			this.nTxtBoxPrice.Symbol = "BTC";
			this.nTxtBoxPrice.TabIndex = 31;
			this.nTxtBoxPrice.TextBoxLocation = new System.Drawing.Point(38, 0);
			this.nTxtBoxPrice.Value = null;
			// 
			// nTBoxAmount
			// 
			this.nTBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTBoxAmount.DisplayedText = "Amount:";
			this.nTBoxAmount.IncrementVisible = true;
			this.nTBoxAmount.Location = new System.Drawing.Point(3, 3);
			this.nTBoxAmount.Name = "nTBoxAmount";
			this.nTBoxAmount.ReadOnly = false;
			this.nTBoxAmount.Size = new System.Drawing.Size(177, 20);
			this.nTBoxAmount.Symbol = "HAND";
			this.nTBoxAmount.TabIndex = 30;
			this.nTBoxAmount.TextBoxLocation = new System.Drawing.Point(52, 0);
			this.nTBoxAmount.Value = null;
			// 
			// LimitOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.nTxtBoxTotal);
			this.Controls.Add(this.nTxtBoxPrice);
			this.Controls.Add(this.nTBoxAmount);
			this.Name = "LimitOrder";
			this.Size = new System.Drawing.Size(183, 78);
			this.ResumeLayout(false);

		}

		#endregion
		private NumberTextBox nTxtBoxTotal;
		private NumberTextBox nTxtBoxPrice;
		private NumberTextBox nTBoxAmount;
	}
}
