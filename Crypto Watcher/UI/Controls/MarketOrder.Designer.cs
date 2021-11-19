namespace CoinInterchanger.UI.Controls
{
	partial class MarketOrder
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
			this.numTBoxAmount = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.nTxtBoxTotal = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.SuspendLayout();
			// 
			// numTBoxAmount
			// 
			this.numTBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numTBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.numTBoxAmount.DisplayedText = "Amount:";
			this.numTBoxAmount.IncrementVisible = true;
			this.numTBoxAmount.Location = new System.Drawing.Point(3, 3);
			this.numTBoxAmount.Name = "numTBoxAmount";
			this.numTBoxAmount.Size = new System.Drawing.Size(177, 20);
			this.numTBoxAmount.Symbol = "HAND";
			this.numTBoxAmount.TabIndex = 32;
			this.numTBoxAmount.TextBoxLocation = new System.Drawing.Point(52, 0);
			// 
			// nTxtBoxTotal
			// 
			this.nTxtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTxtBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTxtBoxTotal.DisplayedText = "Total:";
			this.nTxtBoxTotal.IncrementVisible = true;
			this.nTxtBoxTotal.Location = new System.Drawing.Point(3, 29);
			this.nTxtBoxTotal.Name = "nTxtBoxTotal";
			this.nTxtBoxTotal.Size = new System.Drawing.Size(177, 20);
			this.nTxtBoxTotal.Symbol = "BTC";
			this.nTxtBoxTotal.TabIndex = 33;
			this.nTxtBoxTotal.TextBoxLocation = new System.Drawing.Point(37, 0);
			// 
			// MarketOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.nTxtBoxTotal);
			this.Controls.Add(this.numTBoxAmount);
			this.Name = "MarketOrder";
			this.Size = new System.Drawing.Size(183, 52);
			this.ResumeLayout(false);

		}

		#endregion
		private NumberTextBox numTBoxAmount;
		private NumberTextBox nTxtBoxTotal;
	}
}
