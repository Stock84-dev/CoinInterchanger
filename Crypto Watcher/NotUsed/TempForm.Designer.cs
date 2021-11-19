namespace CoinInterchanger.UI
{
	partial class TempForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.moduleChart1 = new CoinInterchanger.UI.ModuleChart();
			this.SuspendLayout();
			// 
			// moduleChart1
			// 
			this.moduleChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(74)))));
			this.moduleChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.moduleChart1.CanMove = true;
			this.moduleChart1.CanResize = true;
			this.moduleChart1.Location = new System.Drawing.Point(0, 0);
			this.moduleChart1.ModuleHeaderText = "Module name";
			this.moduleChart1.Name = "moduleChart1";
			this.moduleChart1.SettingsButtonVisible = true;
			this.moduleChart1.SettingsPane = null;
			this.moduleChart1.Size = new System.Drawing.Size(337, 430);
			this.moduleChart1.TabIndex = 0;
			// 
			// TempForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.moduleChart1);
			this.Name = "TempForm";
			this.Text = "TempForm";
			this.ResumeLayout(false);

		}

		#endregion

		private ModuleChart moduleChart1;
	}
}