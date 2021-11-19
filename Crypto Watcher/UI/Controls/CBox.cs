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
	public partial class CBox : UserControl
	{
		private Panel _dropDown = new Panel();
		private List<string> _items = new List<string>();
		public delegate void OnSelectedIndexChangedEventHandler(object sender, SelectedIndexEventArgs e);
		public event OnSelectedIndexChangedEventHandler SelectedIndexChanged;

		public CBox()
		{
			InitializeComponent();
			_dropDown.Visible = false;
			_dropDown.BackColor = Color.FromArgb(45, 45, 48);
		}

		// NOTE: use only Items = list;
		public List<string> Items { get { return _items; } set { _items = value; OnItemsChanged(); if (value != null && value.Count > 0) selectedItem.Text = _items[0]; } }
		public string SelectedText { get { return selectedItem.Text; } }
		public int SelectedIndex { get { return _items.IndexOf(selectedItem.Text); } set 
				{
				int oldIndex = SelectedIndex;
				if (oldIndex != value)
				{
					selectedItem.Text = _items[value];
					SelectedIndexChanged?.Invoke(this, new SelectedIndexEventArgs(value));
				}
			}
		}

		private void OnItemsChanged()
		{
			_dropDown.Height = Height * Items.Count;
			_dropDown.Controls.Clear();
			_dropDown.Width = Width;
			for (int i = 0; i < _items.Count; i++)
			{
				Label label = new Label();
				label.AutoSize = false;
				label.Name = i.ToString();
				label.Width = Width;
				label.Height = Height;
				label.Location = new Point(0, Height * i);
				label.ForeColor = Color.White;
				label.Text = _items[i];
				label.Size = Size;
				UIUtility.MakeButton(label, OnClickItem);
				_dropDown.Controls.Add(label);
			}
		}

		private void OnClickItem(object sender, EventArgs e)
		{
			string oldText = selectedItem.Text;
			selectedItem.Text = ((Label)sender).Text;
			if(oldText != selectedItem.Text)
				SelectedIndexChanged?.Invoke(this, new SelectedIndexEventArgs(SelectedIndex));
			dropDown_Click(sender, e);
		}

		private void dropDown_Click(object sender, EventArgs e)
		{
			if(_dropDown.Parent == null)
			{
				_dropDown.Parent = FindForm();
			}
			if (!_dropDown.Visible)
			{
				Point locationOnForm = FindForm().PointToClient(Parent.PointToScreen(Location));
				locationOnForm = new Point(locationOnForm.X, locationOnForm.Y + Height);
				_dropDown.Location = locationOnForm;
				_dropDown.Visible = true;
				_dropDown.BringToFront();
			}
			else
			{
				_dropDown.Visible = false;
			}

		}

		private void CBox_SizeChanged(object sender, EventArgs e)
		{
			_dropDown.Width = Width;
			foreach (Control control in _dropDown.Controls)
				control.Width = Width;
		}

		public class SelectedIndexEventArgs : EventArgs
		{
			public SelectedIndexEventArgs(int selectedIndex) : base()
			{
				SelectedIndex = selectedIndex;
			}

			public int SelectedIndex { get; private set; }
		}
	}
}
