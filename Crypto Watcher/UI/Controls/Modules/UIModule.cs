using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using CoinInterchanger.UI.Controls.Forms;

namespace CoinInterchanger.UI.Controls.Modules
{
	// TODO: disable maximize when popuped and gray popup icon
	// TODO: check if everything works
	// TODO: have multiple exchange windows
	// TODO: select multiple order and increase price by specified amount, buy amount can be same or increase decrese to have total cost same as before
	// allow controls to be added to module in designer, same as panels
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))] 
	public partial class UIModule : UserControl
	{
		private const int _DISTANCE_BETWEEN_PANELS = 5;
		private const int _SNAP_SENZITIVITY = 15;
		private Size _minSize = new Size(-1, -1);
		private FormBase _popupForm;
		private bool _movable = true, _resizable = true;

		public UIModule()
		{
			InitializeComponent();
			SetPopupForm = new FormBase();
			//_popupForm.FormBorderStyle = FormBorderStyle.None;

			UIUtility.MakeButton(moduleExpand, moduleExpand_Click);
			UIUtility.MakeButton(modulePopup, modulePopup_Click);
			UIUtility.MakeButton(moduleSettings, moduleSettings_Click);

			header.RemoveIconControl();
			header.Text = "module text";
			header.AddControlToHeader(moduleSettings, 0);
			header.AddControlToHeader(modulePopup, 1);
			header.AddControlToHeader(moduleExpand, 2);
			header.titleLabel.MouseDown += moduleHeader_MouseDown;
			header.titleLabel.MouseMove += moduleHeader_MouseMove;
		}

		public FormBase SetPopupForm { set { _popupForm = value; _popupForm.FormClosed += modulePopup_Click; } }
		public SettingsPane SettingsPane { get; set; }
		public string ModuleHeaderText { get { return moduleLabel.Text; } set { moduleLabel.Text = value; } }
		public bool CanMove { get; set; } = true;
		public bool CanResize { get { return _resizable; } set { _resizable = value; moduleGripResize.Visible = value; } }
		public bool SettingsButtonVisible { get { return moduleSettings.Visible; } set { moduleSettings.Visible = value; } }
		public Size SetMinSize { set { _minSize = value; } }
		//public Point GripLocation { get { return moduleGripResize.Location; } set { moduleGripResize.Location = value; moduleGripResize.BringToFront(); } }
		//public Size GetGripSize { get { return moduleGripResize.Size; } }

		#region Moving

		private Point _mouseDownLocation;

		private Point _dragCursorPoint;
		private Point _dragFormPoint;

		// getting location of mouse when clicked
		private void moduleHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				if (_popuped)
				{
					_dragCursorPoint = Cursor.Position;
					_dragFormPoint = _popupForm.Location;
				}
				else
					_mouseDownLocation = e.Location;
			}
		}

		private void moduleHeader_MouseMove(object sender, MouseEventArgs e)
		{
			// moving window
			if (e.Button == MouseButtons.Left && _movable && CanMove)
			{
				Point newLoc = new Point(e.X + Left - _mouseDownLocation.X, e.Y + Top - _mouseDownLocation.Y);
				Snap(this, newLoc);
			}
			// moving whole form when popuped
			else if (_popuped && e.Button == MouseButtons.Left)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
				_popupForm.Location = Point.Add(_dragFormPoint, new Size(dif));
			}
		}

		private void Snap(Control movable, Point newLocation)
		{
			bool snapXFound = false, snapYFound = false;

			// looking for controls to snap
			foreach (Control control in movable.Parent.Controls)
			{
				// excluding control that is moving
				if (control.Name == movable.Name)
					continue;
				if (!snapXFound
					// snapping on allignement
					&& (control.Location.X == movable.Location.X
					|| movable.Location.X + movable.Width == control.Location.X + control.Width
					// snapping with distance between panels
					|| control.Location.X + control.Width + _DISTANCE_BETWEEN_PANELS == movable.Location.X
					|| movable.Location.X + movable.Width + _DISTANCE_BETWEEN_PANELS == control.Location.X))
				{
					snapXFound = true;
					// snapping control if user didn't move mouse far enough
					if (Math.Abs(newLocation.X - movable.Location.X) < _SNAP_SENZITIVITY)
						newLocation.X = movable.Location.X;
				}
				if (!snapYFound
					// snapping on allignement
					&& (control.Location.Y == movable.Location.Y
					|| movable.Location.Y + movable.Height == control.Location.Y + control.Height
					// snapping with distance between panels
					|| control.Location.Y + control.Height + _DISTANCE_BETWEEN_PANELS == movable.Location.Y
					|| movable.Location.Y + movable.Height + _DISTANCE_BETWEEN_PANELS == control.Location.Y))
				{
					snapYFound = true;
					// snapping control if user didn't move mouse far enough
					if (Math.Abs(newLocation.Y - movable.Location.Y) < _SNAP_SENZITIVITY)
						newLocation.Y = movable.Location.Y;
				}
			}

			movable.Left = newLocation.X;
			movable.Top = newLocation.Y;
		}

		#endregion

		#region Resizing
		bool _mouseClicked = false;

		private void moduleGripResize_MouseDown(object sender, MouseEventArgs e)
		{
			_mouseClicked = true;
		}

		private void moduleGripResize_MouseUp(object sender, MouseEventArgs e)
		{
			_mouseClicked = false;
		}

		private void moduleGripResize_MouseMove(object sender, MouseEventArgs e)
		{
			Size size = new Size(((PictureBox)sender).Left + e.X, ((PictureBox)sender).Top + e.Y);
			if (!_expanded)
			{
				// resizing window in form
				if (_mouseClicked && !_popuped)
					Snap(this, size.Width, size.Height);
				// resizing whole form
				else if (_mouseClicked && _popuped)
					_popupForm.Size = size;
			}
		}

		private void Snap(Control sizable, int newWidth, int newHeight)
		{
			bool snapXFound = false, snapYFound = false;
			
			// looking for controls to snap
			foreach (Control control in sizable.Parent.Controls)
			{
				// excluding control that is resizing
				if (control.Name == sizable.Name)
					continue;
				if (!snapXFound
					// snapping on allignement
					&& (control.Location.X == sizable.Location.X
					|| sizable.Location.X + sizable.Width == control.Location.X + control.Width
					// snapping with distance between panels
					//|| control.Location.X + control.Width + _DISTANCE_BETWEEN_PANELS == sizable.Location.X
					|| sizable.Location.X + sizable.Width + _DISTANCE_BETWEEN_PANELS == control.Location.X))
				{
					snapXFound = true;
					// snapping control if user didn't move mouse far enough
					if (Math.Abs(newWidth - sizable.Width) < _SNAP_SENZITIVITY)
						newWidth = sizable.Width;
				}

				if (!snapYFound
					// snapping on allignement
					&& (control.Location.Y == sizable.Location.Y
					|| sizable.Location.Y + sizable.Height == control.Location.Y + control.Height
					// snapping with distance between panels
					//|| control.Location.Y + control.Height + _DISTANCE_BETWEEN_PANELS == sizable.Location.Y
					|| sizable.Location.Y + sizable.Height + _DISTANCE_BETWEEN_PANELS == control.Location.Y))
				{
					snapYFound = true;
					// snapping control if user didn't move mouse far enough
					if (Math.Abs(newHeight - sizable.Height) < _SNAP_SENZITIVITY)
						newHeight = sizable.Height;
				}
			}

			if (newWidth > _minSize.Width)
				sizable.Width = newWidth;
			if (newHeight > _minSize.Height)
				sizable.Height = newHeight;
		}

		#endregion

		private bool _expanded = false;
		private Point _oldLocation;
		private Size _oldSize;
		private bool _oldDataStored = false;
		private Control _oldParent;
		// resizing module to fill whole form
		private void moduleExpand_Click(object sender, EventArgs e)
		{
			bool settingsShowing = _settingsShowing;
			if (settingsShowing)
				moduleSettings_Click(this, new EventArgs());
			if (!_popuped)
			{
				if (!_expanded)
				{
					if (!_oldDataStored)
					{
						_oldLocation = Location;
						_oldSize = Size;
						_oldDataStored = true;
					}
					Location = new Point(0, 0);
					Size = FindForm().Size;
					_expanded = true;
					moduleExpand.BackgroundImage = new Bitmap(Properties.Resources.contract);
					BringToFront();
				}
				else
				{
					_expanded = false;
					Location = _oldLocation;
					Size = _oldSize;
					_oldDataStored = false;
					moduleExpand.BackgroundImage = new Bitmap(Properties.Resources.expand);
				}
			}
			else
			{
				if (!_expanded)
				{
					Location = new Point(0, 0);
					// order matters
					_popupForm.WindowState = FormWindowState.Maximized;
					Size = _popupForm.Size;
					// now doesn't
					_expanded = true;
					moduleExpand.BackgroundImage = new Bitmap(Properties.Resources.contract);
				}
				else
				{
					_popupForm.WindowState = FormWindowState.Normal;
					_popupForm.Size = _oldSize;
					_expanded = false;
					moduleExpand.BackgroundImage = new Bitmap(Properties.Resources.expand);
				}
			}
			if (settingsShowing)
				moduleSettings_Click(this, new EventArgs());
			if (_expanded && _resizable)
				moduleGripResize.Visible = false;
			else if(_resizable)
				moduleGripResize.Visible = true;
		}

		private bool _popuped = false;
		private DockStyle _oldDock;
		private bool _settingsShowing = false;

		// showing hiding settings panel
		private void moduleSettings_Click(object sender, EventArgs e)
		{
			SettingsPane.ShowPane((Control)sender, new Size(0, 3));
		}

		private void Module_Resize(object sender, EventArgs e)
		{
			moduleGripResize.Location = new Point(Width - moduleGripResize.Width, Height - moduleGripResize.Height);
		}

		// putting module into separate form, called when user click popup button and 
		private void modulePopup_Click(object sender, EventArgs e)
		{
			bool settingsShowing = _settingsShowing;
			if (settingsShowing)
				moduleSettings_Click(this, new EventArgs());
			if (!_popuped)
			{
				if (!_oldDataStored)
				{
					_oldLocation = Location;
					_oldSize = Size;
					_oldDock = Dock;
					_oldDataStored = true;
				}
				_oldParent = Parent;
				Location = new Point(0, 0);
				// order matters
				_popupForm.Size = Size;
				Dock = DockStyle.Fill;
				// now desn't
				_movable = false;
				_popupForm.Controls.Add(this);
				header.RemoveControlFromHeader(0);
				_popupForm.header.AddControlToHeader(moduleSettings, 0);
				_popupForm.Show();
				_popupForm.Location = new Point(0, 0);
				_popupForm.TopMost = true;
				header.Visible = false;
				_popuped = true;
			}
			else
			{
				// order matters
				Dock = _oldDock;
				Size = _oldSize;
				// now desn't
				Location = _oldLocation;
				if(CanMove)
					_movable = true;
				_popupForm.Hide();
				_popupForm.Controls.Remove(this);
				_popupForm.TopMost = false;
				Parent = _oldParent;
				_popupForm.header.RemoveControlFromHeader(0);
				header.AddControlToHeader(moduleSettings, 0);
				header.Visible = true;
				_popuped = false;
				if (_expanded)
				{
					_expanded = false;
					moduleExpand.BackgroundImage = new Bitmap(Properties.Resources.expand);
				}
			}
			if (settingsShowing)
				moduleSettings_Click(this, new EventArgs());
		}
	}
}
