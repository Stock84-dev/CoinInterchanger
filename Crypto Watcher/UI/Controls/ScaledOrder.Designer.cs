namespace CoinInterchanger.UI.Controls
{
	partial class ScaledOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaledOrder));
			this.numberTextBox3 = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.numberTextBox1 = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.numberTextBox2 = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.nTxtBoxTotal = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.nTxtBoxPrice = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.numTBoxAmount = new CoinInterchanger.UI.Controls.NumberTextBox();
			this.btnSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// numberTextBox3
			// 
			this.numberTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numberTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.numberTextBox3.DisplayedText = "Total:";
			this.numberTextBox3.IncrementVisible = true;
			this.numberTextBox3.Location = new System.Drawing.Point(3, 133);
			this.numberTextBox3.Name = "numberTextBox3";
			this.numberTextBox3.Size = new System.Drawing.Size(177, 20);
			this.numberTextBox3.Symbol = "BTC";
			this.numberTextBox3.TabIndex = 38;
			this.numberTextBox3.TextBoxLocation = new System.Drawing.Point(37, 0);
			// 
			// numberTextBox1
			// 
			this.numberTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numberTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.numberTextBox1.DisplayedText = "Order count:";
			this.numberTextBox1.IncrementVisible = true;
			this.numberTextBox1.Location = new System.Drawing.Point(3, 107);
			this.numberTextBox1.Name = "numberTextBox1";
			this.numberTextBox1.Size = new System.Drawing.Size(151, 20);
			this.numberTextBox1.Symbol = "";
			this.numberTextBox1.TabIndex = 37;
			this.numberTextBox1.TextBoxLocation = new System.Drawing.Point(74, 0);
			// 
			// numberTextBox2
			// 
			this.numberTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numberTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.numberTextBox2.DisplayedText = "Price max:";
			this.numberTextBox2.IncrementVisible = true;
			this.numberTextBox2.Location = new System.Drawing.Point(3, 81);
			this.numberTextBox2.Name = "numberTextBox2";
			this.numberTextBox2.Size = new System.Drawing.Size(177, 20);
			this.numberTextBox2.Symbol = "BTC";
			this.numberTextBox2.TabIndex = 36;
			this.numberTextBox2.TextBoxLocation = new System.Drawing.Point(65, 0);
			// 
			// nTxtBoxTotal
			// 
			this.nTxtBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTxtBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTxtBoxTotal.DisplayedText = "Price min:";
			this.nTxtBoxTotal.IncrementVisible = true;
			this.nTxtBoxTotal.Location = new System.Drawing.Point(3, 55);
			this.nTxtBoxTotal.Name = "nTxtBoxTotal";
			this.nTxtBoxTotal.Size = new System.Drawing.Size(177, 20);
			this.nTxtBoxTotal.Symbol = "BTC";
			this.nTxtBoxTotal.TabIndex = 35;
			this.nTxtBoxTotal.TextBoxLocation = new System.Drawing.Point(62, 0);
			// 
			// nTxtBoxPrice
			// 
			this.nTxtBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nTxtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.nTxtBoxPrice.DisplayedText = "Price step:";
			this.nTxtBoxPrice.IncrementVisible = true;
			this.nTxtBoxPrice.Location = new System.Drawing.Point(3, 29);
			this.nTxtBoxPrice.Name = "nTxtBoxPrice";
			this.nTxtBoxPrice.Size = new System.Drawing.Size(177, 20);
			this.nTxtBoxPrice.Symbol = "BTC";
			this.nTxtBoxPrice.TabIndex = 34;
			this.nTxtBoxPrice.TextBoxLocation = new System.Drawing.Point(64, 0);
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
			this.numTBoxAmount.TabIndex = 33;
			this.numTBoxAmount.TextBoxLocation = new System.Drawing.Point(52, 0);
			// 
			// btnSettings
			// 
			this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
			this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Location = new System.Drawing.Point(160, 107);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(20, 20);
			this.btnSettings.TabIndex = 39;
			this.btnSettings.UseVisualStyleBackColor = false;
			// 
			// ScaledOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.numberTextBox3);
			this.Controls.Add(this.numberTextBox1);
			this.Controls.Add(this.numberTextBox2);
			this.Controls.Add(this.nTxtBoxTotal);
			this.Controls.Add(this.nTxtBoxPrice);
			this.Controls.Add(this.numTBoxAmount);
			this.Name = "ScaledOrder";
			this.ResumeLayout(false);

		}

		#endregion

		private NumberTextBox nTxtBoxTotal;
		private NumberTextBox nTxtBoxPrice;
		private NumberTextBox numTBoxAmount;
		private NumberTextBox numberTextBox1;
		private NumberTextBox numberTextBox2;
		private NumberTextBox numberTextBox3;
		private System.Windows.Forms.Button btnSettings;
	}
}
