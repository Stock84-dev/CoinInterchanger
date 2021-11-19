using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CoinInterchanger.UI.Controls
{
	public partial class NumberTextBox : UserControl
	{
		private float? _value;
		private bool _readOnly;

		public NumberTextBox()
		{
			InitializeComponent();
			ReadOnly = false;
		}

		public delegate void ValueChangedEventHandler(object sender, ValueChangedEventArgs e);

		public event ValueChangedEventHandler ValueChanged;

		public string DisplayedText {
			get { return lblAmount.Text; }
			set {
				lblAmount.Text = value;
				lblAmount.Size = lblAmount.PreferredSize;
				txtAmount.Location = new Point(lblAmount.Location.X + lblAmount.Width);
			}
		}
		public string Symbol {
			get { return lblSymbol.Text; }
			set {
				lblSymbol.Text = value;
				lblSymbol.Width = lblSymbol.PreferredWidth;
				AnchorStyles oldAnchor = lblSymbol.Anchor;
				lblSymbol.Anchor = AnchorStyles.None;
				lblSymbol.Location = new Point(lblUp.Location.X - lblSymbol.Width, lblSymbol.Location.Y);
				lblSymbol.Anchor = oldAnchor;
				txtAmount.Size = new Size(lblSymbol.Location.X - txtAmount.Location.X, lblSymbol.Location.Y - txtAmount.Location.Y);
			}
		}
		public bool IncrementVisible { get { return lblUp.Visible; } set { lblUp.Visible = value; lblDown.Visible = value; } }
		public Point TextBoxLocation { get { return txtAmount.Location; } set { txtAmount.Location = value; } }
		public float? Value {
			get => _value;
			set {
				if (value == null)
					txtAmount.Text = "";
				else
				{
					_value = value;
					txtAmount.Text = value.Value.ToString("G", CultureInfo.InvariantCulture);
				}
			}
		}
		public bool ReadOnly {
			get => _readOnly;
			set {
				_readOnly = value;
				if(value == false)
				{
					txtAmount.TextChanged += TxtAmount_TextChanged;
					lblUp.MouseClick += lblUp_Click;
					lblUp.MouseEnter += Control_MouseEnter;
					lblUp.MouseLeave += Control_MouseLeave;
					lblDown.MouseClick += lblDown_Click;
					lblDown.MouseEnter += Control_MouseEnter;
					lblDown.MouseLeave += Control_MouseLeave;
					txtAmount.ReadOnly = false;
				}
				else
				{
					txtAmount.TextChanged -= TxtAmount_TextChanged;
					lblUp.MouseClick -= lblUp_Click;
					lblUp.MouseEnter -= Control_MouseEnter;
					lblUp.MouseLeave -= Control_MouseLeave;
					lblDown.MouseClick -= lblDown_Click;
					lblDown.MouseEnter -= Control_MouseEnter;
					lblDown.MouseLeave -= Control_MouseLeave;
					txtAmount.ReadOnly = true;
				}
			}
		}

		private string IncrementDecrementOnLastPlaceByOne(string number, bool increment)
		{
			int numOfDecimals = -1;
			string oldText = number.Replace(',', '.');
			string newText = null;

			if (!ToFloat(oldText, out float num))
				return null;

			if ((!oldText.Contains('.') && increment) || (oldText.Last() != '1' && !increment && !oldText.Contains('.')))
			{
				num = increment ? num + 1 : num - 1;
				newText = num.ToString();
			}
			else
			{
				string strLast = "0.";

				numOfDecimals = oldText.Length - oldText.IndexOf('.');
				for (int i = 2; i < numOfDecimals; i++)
					strLast += "0";
				if (!increment && oldText.Last() == '1' && oldText.Length != 1)
					strLast += "0";
				strLast += "1";

				float incrementValue = float.Parse(strLast, NumberStyles.Float, CultureInfo.InvariantCulture);
				if (increment)
					num += incrementValue;
				else num -= incrementValue;
				num = (float)Math.Round(num, numOfDecimals);
				newText = num.ToString();
			}

			if (increment && newText.Length < oldText.Length && newText.Contains('.'))
				newText += "0";
			else if (increment && newText.Length < oldText.Length && !newText.Contains('.'))
			{
				newText += ".";
				for (int i = 1; i < numOfDecimals; i++)
					newText += "0";
			}
			return newText;
		}

		private bool ToFloat(string text, out float number, bool showOnError = true)
		{
			if (!float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out number))
			{
				if (showOnError)
				{
					string label;
					if (DisplayedText.Last() == ':')
						label = DisplayedText.Substring(0, DisplayedText.Length - 2);
					else label = DisplayedText;
					MessageBox.Show("Input isn't in correct format in " + label + " section!");
				}
				return false;
			}
			return true;
		}

		private void TxtAmount_TextChanged(object sender, EventArgs e)
		{
			if (!ToFloat(txtAmount.Text, out float number, false))
			{
				_value = null;
				return;
			}
			_value = number;
			ValueChanged?.Invoke(this, new ValueChangedEventArgs(number));
		}

		private void lblUp_Click(object sender, MouseEventArgs e)
		{
			string text = IncrementDecrementOnLastPlaceByOne(txtAmount.Text, true);
			if (text != null)
				txtAmount.Text = text;
		}

		private void lblDown_Click(object sender, MouseEventArgs e)
		{
			string text = IncrementDecrementOnLastPlaceByOne(txtAmount.Text, false);
			if (text != null)
				txtAmount.Text = text;
		}

		private void Control_MouseEnter(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.FromArgb(0, 122, 204);
		}

		private void Control_MouseLeave(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.Transparent;
		}

		public class ValueChangedEventArgs : EventArgs
		{
			public ValueChangedEventArgs(float value)
			{
				Value = value;
			}

			public float Value { get; set; }
		}
	}
}
