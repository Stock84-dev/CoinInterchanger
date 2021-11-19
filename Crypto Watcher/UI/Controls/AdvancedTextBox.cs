using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	public partial class AdvancedTextBox : UserControl
	{
		public AdvancedTextBox()
		{
			InitializeComponent();
			txtBox.AutoSize = false;
			txtBox.Height = 18;
		}

		public TextBox TextBox { get { return txtBox; } }
	}
}
