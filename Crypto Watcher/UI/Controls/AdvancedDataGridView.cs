using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	class AdvancedDataGridView : DataGridView
	{
		public AdvancedDataGridView()
		{
			AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			BackgroundColor = Color.FromArgb(37, 37, 38);
			ForeColor = Color.White;
			DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
			headerStyle.ForeColor = Color.White;
			headerStyle.BackColor = Color.DimGray;
			ColumnHeadersDefaultCellStyle = headerStyle;
			GridColor = Color.Gray;
			EnableHeadersVisualStyles = false;
			AllowUserToResizeRows = false;
		}
	}
}
