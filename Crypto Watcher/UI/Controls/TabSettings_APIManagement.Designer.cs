namespace CoinInterchanger.UI.Controls
{
	partial class TabSettings_APIManagement
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelBtn = new System.Windows.Forms.Panel();
			this.btnSave = new CoinInterchanger.UI.Controls.AdvancedButton();
			this.btnHide = new CoinInterchanger.UI.Controls.AdvancedButton();
			this.btnShow = new CoinInterchanger.UI.Controls.AdvancedButton();
			this.dgvAPI = new CoinInterchanger.UI.Controls.AdvancedDataGridView();
			this.columnExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAPIKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAPISecret = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelBtn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAPI)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBtn
			// 
			this.panelBtn.BackColor = System.Drawing.Color.Transparent;
			this.panelBtn.Controls.Add(this.btnSave);
			this.panelBtn.Controls.Add(this.btnHide);
			this.panelBtn.Controls.Add(this.btnShow);
			this.panelBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelBtn.Location = new System.Drawing.Point(1175, 0);
			this.panelBtn.Name = "panelBtn";
			this.panelBtn.Size = new System.Drawing.Size(85, 645);
			this.panelBtn.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DimGray;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(11, 58);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnHide
			// 
			this.btnHide.BackColor = System.Drawing.Color.DimGray;
			this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHide.Location = new System.Drawing.Point(11, 29);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(75, 23);
			this.btnHide.TabIndex = 1;
			this.btnHide.Text = "Hide";
			this.btnHide.UseVisualStyleBackColor = false;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnShow
			// 
			this.btnShow.BackColor = System.Drawing.Color.DimGray;
			this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShow.Location = new System.Drawing.Point(11, 0);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 0;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = false;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// dgvAPI
			// 
			this.dgvAPI.AllowUserToAddRows = false;
			this.dgvAPI.AllowUserToDeleteRows = false;
			this.dgvAPI.AllowUserToResizeRows = false;
			this.dgvAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvAPI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.dgvAPI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dgvAPI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAPI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnExchange,
            this.columnAPIKey,
            this.columnAPISecret});
			this.dgvAPI.EnableHeadersVisualStyles = false;
			this.dgvAPI.GridColor = System.Drawing.Color.Gray;
			this.dgvAPI.Location = new System.Drawing.Point(0, 0);
			this.dgvAPI.Name = "dgvAPI";
			this.dgvAPI.RowHeadersVisible = false;
			this.dgvAPI.Size = new System.Drawing.Size(1175, 645);
			this.dgvAPI.TabIndex = 2;
			// 
			// columnExchange
			// 
			this.columnExchange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnExchange.DefaultCellStyle = dataGridViewCellStyle2;
			this.columnExchange.HeaderText = "Exchange";
			this.columnExchange.Name = "columnExchange";
			this.columnExchange.ReadOnly = true;
			this.columnExchange.Width = 79;
			// 
			// columnAPIKey
			// 
			this.columnAPIKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnAPIKey.DefaultCellStyle = dataGridViewCellStyle3;
			this.columnAPIKey.HeaderText = "API Key";
			this.columnAPIKey.Name = "columnAPIKey";
			// 
			// columnAPISecret
			// 
			this.columnAPISecret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.columnAPISecret.DefaultCellStyle = dataGridViewCellStyle4;
			this.columnAPISecret.HeaderText = "API Secret";
			this.columnAPISecret.Name = "columnAPISecret";
			// 
			// TabSettings_APIManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelBtn);
			this.Controls.Add(this.dgvAPI);
			this.Name = "TabSettings_APIManagement";
			this.Size = new System.Drawing.Size(1260, 645);
			this.panelBtn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAPI)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBtn;
		private AdvancedButton btnSave;
		private AdvancedButton btnHide;
		private AdvancedButton btnShow;
		private AdvancedDataGridView dgvAPI;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnExchange;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAPIKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAPISecret;
	}
}
