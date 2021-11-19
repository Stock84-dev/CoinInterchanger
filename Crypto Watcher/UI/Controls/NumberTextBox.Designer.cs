namespace CoinInterchanger.UI.Controls
{
	partial class NumberTextBox
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
			this.lblAmount = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.lblSymbol = new System.Windows.Forms.Label();
			this.lblDown = new System.Windows.Forms.Label();
			this.lblUp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblAmount
			// 
			this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmount.ForeColor = System.Drawing.Color.White;
			this.lblAmount.Location = new System.Drawing.Point(0, -1);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(56, 21);
			this.lblAmount.TabIndex = 0;
			this.lblAmount.Text = "Amount:";
			// 
			// txtAmount
			// 
			this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAmount.ForeColor = System.Drawing.Color.White;
			this.txtAmount.Location = new System.Drawing.Point(55, 3);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(58, 13);
			this.txtAmount.TabIndex = 1;
			// 
			// lblSymbol
			// 
			this.lblSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSymbol.ForeColor = System.Drawing.Color.White;
			this.lblSymbol.Location = new System.Drawing.Point(119, 0);
			this.lblSymbol.Name = "lblSymbol";
			this.lblSymbol.Size = new System.Drawing.Size(55, 20);
			this.lblSymbol.TabIndex = 2;
			this.lblSymbol.Text = "BTC";
			this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDown
			// 
			this.lblDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblDown.Font = new System.Drawing.Font("Marlett", 9F);
			this.lblDown.ForeColor = System.Drawing.Color.White;
			this.lblDown.Location = new System.Drawing.Point(180, 10);
			this.lblDown.Name = "lblDown";
			this.lblDown.Size = new System.Drawing.Size(11, 10);
			this.lblDown.TabIndex = 3;
			this.lblDown.Text = "u";
			this.lblDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblUp
			// 
			this.lblUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblUp.Font = new System.Drawing.Font("Marlett", 9F);
			this.lblUp.ForeColor = System.Drawing.Color.White;
			this.lblUp.Location = new System.Drawing.Point(180, -1);
			this.lblUp.Name = "lblUp";
			this.lblUp.Size = new System.Drawing.Size(11, 10);
			this.lblUp.TabIndex = 4;
			this.lblUp.Text = "t";
			this.lblUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// NumberTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.lblUp);
			this.Controls.Add(this.lblDown);
			this.Controls.Add(this.lblSymbol);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.lblAmount);
			this.Name = "NumberTextBox";
			this.Size = new System.Drawing.Size(191, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblSymbol;
		private System.Windows.Forms.Label lblDown;
		private System.Windows.Forms.Label lblUp;
	}
}
