namespace CoinInterchanger.UI.Controls.Modules
{
	partial class UIModule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIModule));
			this.moduleLabel = new System.Windows.Forms.Label();
			this.moduleSettings = new System.Windows.Forms.Button();
			this.modulePopup = new System.Windows.Forms.Button();
			this.moduleExpand = new System.Windows.Forms.Button();
			this.moduleToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.moduleGripResize = new System.Windows.Forms.PictureBox();
			this.header = new CoinInterchanger.UI.Controls.Header();
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).BeginInit();
			this.SuspendLayout();
			// 
			// moduleLabel
			// 
			this.moduleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.moduleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.moduleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moduleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moduleLabel.ForeColor = System.Drawing.Color.White;
			this.moduleLabel.Location = new System.Drawing.Point(3, 0);
			this.moduleLabel.Name = "moduleLabel";
			this.moduleLabel.Size = new System.Drawing.Size(251, 25);
			this.moduleLabel.TabIndex = 5;
			this.moduleLabel.Text = "Module name";
			this.moduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.moduleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseDown);
			this.moduleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseMove);
			// 
			// moduleSettings
			// 
			this.moduleSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.moduleSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.moduleSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moduleSettings.BackgroundImage")));
			this.moduleSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.moduleSettings.FlatAppearance.BorderSize = 0;
			this.moduleSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moduleSettings.Location = new System.Drawing.Point(260, 3);
			this.moduleSettings.Name = "moduleSettings";
			this.moduleSettings.Size = new System.Drawing.Size(20, 20);
			this.moduleSettings.TabIndex = 7;
			this.moduleSettings.UseVisualStyleBackColor = false;
			this.moduleSettings.Visible = false;
			this.moduleSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseDown);
			this.moduleSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseMove);
			// 
			// modulePopup
			// 
			this.modulePopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.modulePopup.BackColor = System.Drawing.Color.Transparent;
			this.modulePopup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modulePopup.BackgroundImage")));
			this.modulePopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.modulePopup.FlatAppearance.BorderSize = 0;
			this.modulePopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modulePopup.Location = new System.Drawing.Point(286, 3);
			this.modulePopup.Name = "modulePopup";
			this.modulePopup.Size = new System.Drawing.Size(20, 20);
			this.modulePopup.TabIndex = 6;
			this.modulePopup.UseVisualStyleBackColor = false;
			this.modulePopup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseDown);
			this.modulePopup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseMove);
			// 
			// moduleExpand
			// 
			this.moduleExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.moduleExpand.BackColor = System.Drawing.Color.Transparent;
			this.moduleExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moduleExpand.BackgroundImage")));
			this.moduleExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.moduleExpand.FlatAppearance.BorderSize = 0;
			this.moduleExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moduleExpand.Location = new System.Drawing.Point(312, 3);
			this.moduleExpand.Name = "moduleExpand";
			this.moduleExpand.Size = new System.Drawing.Size(20, 20);
			this.moduleExpand.TabIndex = 4;
			this.moduleExpand.UseVisualStyleBackColor = false;
			this.moduleExpand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseDown);
			this.moduleExpand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moduleHeader_MouseMove);
			// 
			// moduleGripResize
			// 
			this.moduleGripResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.moduleGripResize.BackColor = System.Drawing.Color.Transparent;
			this.moduleGripResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moduleGripResize.BackgroundImage")));
			this.moduleGripResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.moduleGripResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.moduleGripResize.Location = new System.Drawing.Point(318, 415);
			this.moduleGripResize.Name = "moduleGripResize";
			this.moduleGripResize.Size = new System.Drawing.Size(19, 15);
			this.moduleGripResize.TabIndex = 1;
			this.moduleGripResize.TabStop = false;
			this.moduleGripResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moduleGripResize_MouseDown);
			this.moduleGripResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moduleGripResize_MouseMove);
			this.moduleGripResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moduleGripResize_MouseUp);
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(337, 24);
			this.header.TabIndex = 8;
			// 
			// UIModule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.header);
			this.Controls.Add(this.moduleGripResize);
			this.Name = "UIModule";
			this.Size = new System.Drawing.Size(337, 430);
			this.Resize += new System.EventHandler(this.Module_Resize);
			((System.ComponentModel.ISupportInitialize)(this.moduleGripResize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		protected System.Windows.Forms.Button moduleSettings;
		protected System.Windows.Forms.Button modulePopup;
		protected System.Windows.Forms.Label moduleLabel;
		protected System.Windows.Forms.Button moduleExpand;
		protected System.Windows.Forms.ToolTip moduleToolTip;
		protected System.Windows.Forms.PictureBox moduleGripResize;
		protected Header header;
	}
}
