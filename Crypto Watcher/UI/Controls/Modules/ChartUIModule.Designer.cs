namespace CoinInterchanger.UI.Controls.Modules
{
	partial class ChartUIModule
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
			this.panelBrowser = new System.Windows.Forms.Panel();
			this.cBoxTimeframe = new CoinInterchanger.UI.Controls.AdvancedComboBox();
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).BeginInit();
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
			this.moduleGripResize.Location = new System.Drawing.Point(318, 455);
			// 
			// header
			// 
			this.header.Size = new System.Drawing.Size(335, 24);
			// 
			// panelBrowser
			// 
			this.panelBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelBrowser.Location = new System.Drawing.Point(0, 45);
			this.panelBrowser.Name = "panelBrowser";
			this.panelBrowser.Size = new System.Drawing.Size(337, 404);
			this.panelBrowser.TabIndex = 5;
			// 
			// cBoxTimeframe
			// 
			this.cBoxTimeframe.BackColor = System.Drawing.Color.DimGray;
			this.cBoxTimeframe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxTimeframe.FormattingEnabled = true;
			this.cBoxTimeframe.HighlightedForeColor = System.Drawing.Color.White;
			this.cBoxTimeframe.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.cBoxTimeframe.Location = new System.Drawing.Point(0, 24);
			this.cBoxTimeframe.Name = "cBoxTimeframe";
			this.cBoxTimeframe.Size = new System.Drawing.Size(88, 21);
			this.cBoxTimeframe.TabIndex = 9;
			// 
			// ChartUIModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cBoxTimeframe);
			this.Controls.Add(this.panelBrowser);
			this.Name = "ChartUIModule";
			this.SettingsButtonVisible = true;
			this.Size = new System.Drawing.Size(335, 468);
			this.Controls.SetChildIndex(this.moduleGripResize, 0);
			this.Controls.SetChildIndex(this.header, 0);
			this.Controls.SetChildIndex(this.panelBrowser, 0);
			this.Controls.SetChildIndex(this.cBoxTimeframe, 0);
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelBrowser;
		private AdvancedComboBox cBoxTimeframe;
	}
}
