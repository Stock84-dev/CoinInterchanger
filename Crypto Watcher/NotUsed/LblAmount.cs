using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI
{
	class LblAmount : RichTextBox
	{
		public LblAmount() : base()
		{
		}

		public int ChangeFontAfterDecimalLength { get; set; } = 8;

		public override string Text {
			get {
				return base.Text;
			}

			set {
				base.Text = value;
				if (Text.Contains(' ') && ChangeFontAfterDecimalLength != -1)
				{
					Select(Text.IndexOf('.') + ChangeFontAfterDecimalLength + 1, Text.IndexOf(' ') - ChangeFontAfterDecimalLength - 2);
					SelectionFont = new System.Drawing.Font(Font.FontFamily, Font.Size - 1.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
					Select(0, 0);
					Size = new System.Drawing.Size(PreferredSize.Width, Height);
				}
			}
		}
	}
}
