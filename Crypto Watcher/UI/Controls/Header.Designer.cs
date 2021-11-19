namespace CoinInterchanger.UI.Controls
{
	partial class Header
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.headerIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.headerIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(24, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(511, 24);
			this.titleLabel.TabIndex = 14;
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// controlPanel
			// 
			this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.controlPanel.Location = new System.Drawing.Point(535, 0);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(0, 24);
			this.controlPanel.TabIndex = 18;
			// 
			// headerIcon
			// 
			this.headerIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.headerIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.headerIcon.Location = new System.Drawing.Point(0, 0);
			this.headerIcon.Name = "headerIcon";
			this.headerIcon.Size = new System.Drawing.Size(24, 24);
			this.headerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.headerIcon.TabIndex = 13;
			this.headerIcon.TabStop = false;
			// 
			// Header
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.headerIcon);
			this.Name = "Header";
			this.Size = new System.Drawing.Size(535, 24);
			((System.ComponentModel.ISupportInitialize)(this.headerIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.PictureBox headerIcon;
		public System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.ToolTip toolTip;
	}
}
