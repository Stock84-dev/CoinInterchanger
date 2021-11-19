using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls
{
	class AdvancedComboBox : ComboBox
	{
		private const int _WM_PAINT = 0xF;
		private readonly int _buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

		public AdvancedComboBox()
		{
			base.DrawMode = DrawMode.OwnerDrawFixed;
			BackColor = Color.DimGray;
			DrawItem += OnDrawItem;
			Height = 23;
		}

		[Browsable(true)]
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "DimGray")]
		public Color BorderColor { get; set; } = Color.DimGray;
		new public DrawMode DrawMode { get; set; }
		[Browsable(true)]
		[Category("Appearance")]
		public Color ItemHighlightColor { get; set; } = Color.FromArgb(0, 122, 204);
		[Browsable(true)]
		[Category("Appearance")]
		public Color HighlightedForeColor { get; set; } = Color.White;

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg != _WM_PAINT || DropDownStyle == ComboBoxStyle.Simple)
				return;
			using (var g = Graphics.FromHwnd(Handle))
			{
				// Uncomment this if you don't want the "highlight border".

				//using (var p = new Pen(this.BorderColor, 1))
				//{
				//	g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
				//}
				using (var p = new Pen(BorderColor, 2))
					g.DrawRectangle(p, 2, 2, Width - _buttonWidth - 4, Height - 4);
				g.DrawImageUnscaled(Properties.Resources.dropdown, new Point(Width - _buttonWidth - 1, 1));
			}
		}

		private void OnDrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index < 0)
				return;
			// optimized to only draw when it's neded
			if ((e.State & DrawItemState.Focus) == DrawItemState.Focus && (e.State & DrawItemState.ComboBoxEdit) != DrawItemState.ComboBoxEdit ||
				(e.State & DrawItemState.Selected) == DrawItemState.Selected && DropDownStyle == ComboBoxStyle.DropDown)
			{
				// for some reason if ComboboxStyle is different then state is different
				Rectangle myBounds = Bounds;
				myBounds.Height--;
				e.Graphics.FillRectangle(new SolidBrush(ItemHighlightColor), e.Bounds);
				e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, new SolidBrush(HighlightedForeColor), new Point(e.Bounds.X, e.Bounds.Y));
			}
			else if ((e.State & DrawItemState.Selected) != DrawItemState.Selected || (e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit)
			{
				e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
				e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, new SolidBrush(ForeColor), new Point(e.Bounds.X, e.Bounds.Y));
			}
		}
	}
}
