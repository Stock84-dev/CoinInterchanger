namespace CoinInterchanger.UI.Controls
{
	partial class AdvancedTextBox
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
			this.txtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBox
			// 
			this.txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox.BackColor = System.Drawing.Color.DimGray;
			this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBox.ForeColor = System.Drawing.Color.White;
			this.txtBox.Location = new System.Drawing.Point(1, 1);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(102, 13);
			this.txtBox.TabIndex = 0;
			// 
			// AdvancedTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.Controls.Add(this.txtBox);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "AdvancedTextBox";
			this.Size = new System.Drawing.Size(104, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBox;
	}
}
