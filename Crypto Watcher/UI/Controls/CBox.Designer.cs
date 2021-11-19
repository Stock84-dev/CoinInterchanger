namespace CoinInterchanger.UI.Controls
{
	partial class CBox
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
			this.selectedItem = new System.Windows.Forms.Label();
			this.dropDown = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// selectedItem
			// 
			this.selectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectedItem.ForeColor = System.Drawing.Color.White;
			this.selectedItem.Location = new System.Drawing.Point(0, 0);
			this.selectedItem.Name = "selectedItem";
			this.selectedItem.Size = new System.Drawing.Size(82, 27);
			this.selectedItem.TabIndex = 0;
			this.selectedItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.selectedItem.Click += new System.EventHandler(this.dropDown_Click);
			// 
			// dropDown
			// 
			this.dropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dropDown.Font = new System.Drawing.Font("Marlett", 11F);
			this.dropDown.ForeColor = System.Drawing.Color.White;
			this.dropDown.Location = new System.Drawing.Point(82, 0);
			this.dropDown.Name = "dropDown";
			this.dropDown.Size = new System.Drawing.Size(21, 27);
			this.dropDown.TabIndex = 1;
			this.dropDown.Text = "6";
			this.dropDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
			// 
			// CBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.dropDown);
			this.Controls.Add(this.selectedItem);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "CBox";
			this.Size = new System.Drawing.Size(103, 27);
			this.SizeChanged += new System.EventHandler(this.CBox_SizeChanged);
			this.Click += new System.EventHandler(this.dropDown_Click);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label selectedItem;
		private System.Windows.Forms.Label dropDown;
	}
}
