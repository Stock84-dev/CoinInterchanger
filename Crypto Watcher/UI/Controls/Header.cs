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
	public partial class Header : UserControl
	{
		private List<string> _controlOrder = new List<string>();

		public Header()
		{
			InitializeComponent();
		}

		[Browsable(true)]
		public new string Text { get { return titleLabel.Text; } set { titleLabel.Text = value; } }
		public new Font Font { get { return titleLabel.Font; } set { titleLabel.Font = value; } }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="control"></param>
		/// <param name="order">After which control to add this control (left->right).</param>
		public void AddControlToHeader(Control control, int order)
		{
			control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			control.Height = Height;
			int posx = 0;
			if (order != 0)
				posx += controlPanel.Controls[_controlOrder[order - 1]].Location.X + controlPanel.Controls[_controlOrder[order - 1]].Width;
			control.Location = new Point(posx, 0);
			_controlOrder.Insert(order, control.Name);

			SetAnchorStylesForControlPanelControlsForResize(order);
			controlPanel.Location = new Point(controlPanel.Location.X - control.Width, 0);
			controlPanel.Width += control.Width;
			foreach (Control cont in controlPanel.Controls)
				cont.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			controlPanel.Controls.Add(control);
		}

		/// <summary>
		/// Removes control from header and returns it.
		/// </summary>
		/// <param name="order">After which control to remove this control (left->right).</param>
		public Control RemoveControlFromHeader(int order)
		{
			SetAnchorStylesForControlPanelControlsForResize(order);
			Control control = controlPanel.Controls[_controlOrder[order]];
			control.Parent = null;
			controlPanel.Location = new Point(controlPanel.Location.X + control.Width, 0);
			controlPanel.Width -= control.Width;
			foreach (Control cont in controlPanel.Controls)
				cont.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			_controlOrder.RemoveAt(order);

			return control;
		}

		public void RemoveIconControl()
		{
			headerIcon.Parent = null;
			titleLabel.Location = new Point(0, 0);
			headerIcon = null;
		}

		/// <summary>
		/// Sets anchorStyles for all controls except control with provided order to left before and right after.
		/// </summary>
		/// <param name="exceptControlOrder">Order of control (left->right) to exclude.</param>
		private void SetAnchorStylesForControlPanelControlsForResize(int exceptControlOrder)
		{
			// changing controls anchor for proper resizing
			for (int i = 0; i < _controlOrder.Count; i++)
			{
				if (i < exceptControlOrder)
					controlPanel.Controls[_controlOrder[i]].Anchor = controlPanel.Controls[_controlOrder[i]].Anchor | AnchorStyles.Left;
				else if (i > exceptControlOrder)
					controlPanel.Controls[_controlOrder[i]].Anchor = controlPanel.Controls[_controlOrder[i]].Anchor | AnchorStyles.Right;
			}
		}
	}
}
