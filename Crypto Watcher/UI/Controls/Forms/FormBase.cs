using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CoinInterchanger.UI.Controls.Forms
{
	/// <summary>
	/// Based on http://customerborderform.codeplex.com/
	/// </summary>
	public partial class FormBase : Form
	{
		private FormWindowState _previousWindowState;
		private DateTime _systemClickTime = DateTime.MinValue;
		private DateTime _systemMenuCloseTime = DateTime.MinValue;
		private DateTime _titleClickTime = DateTime.MinValue;
		private Point _titleClickPosition = Point.Empty;

		public FormBase()
		{
			InitializeComponent();
			Activated += MainForm_Activated;
			Deactivate += MainForm_Deactivate;

			foreach (var control in new Control[] { minimizeLabel, maximizeLabel, closeLabel })
			{
				control.MouseEnter += (s, e) => SetLabelColors((Control)s, MouseState.Hover);
				control.MouseLeave += (s, e) => SetLabelColors((Control)s, MouseState.Normal);
				control.MouseDown += (s, e) => SetLabelColors((Control)s, MouseState.Down);
			}

			TopLeftCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOPLEFT);
			TopRightCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOPRIGHT);
			BottomLeftCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOMLEFT);
			BottomRightCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOMRIGHT);

			TopBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOP);
			LeftBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTLEFT);
			RightBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTRIGHT);
			BottomBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOM);

			var marlett = new Font("Marlett", 8.5f);

			minimizeLabel.Font = marlett;
			maximizeLabel.Font = marlett;
			closeLabel.Font = marlett;

			minimizeLabel.MouseClick += (s, e) => { if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized; };
			maximizeLabel.MouseClick += (s, e) => { if (e.Button == MouseButtons.Left) ToggleMaximize(); };
			closeLabel.MouseClick += (s, e) => Close(e);
			_previousWindowState = MinMaxState;
			SizeChanged += MainForm_SizeChanged;

			header.AddControlToHeader(minimizeLabel, 0);
			header.AddControlToHeader(maximizeLabel, 1);
			header.AddControlToHeader(closeLabel, 2);
			header.titleLabel.MouseDown += TitleLabel_MouseDown;
			header.MouseUp += (s, e) => { if (e.Button == MouseButtons.Right && header.ClientRectangle.Contains(e.Location)) ShowSystemMenu(MouseButtons); };
			header.Text = "my header";
			header.headerIcon.Image = Properties.Resources.AlarmIcon.ToBitmap();
		}

		protected enum MouseState
		{
			Normal,
			Hover,
			Down
		}

		private enum GetWindow_Cmd : uint
		{
			GW_HWNDFIRST = 0,
			GW_HWNDLAST = 1,
			GW_HWNDNEXT = 2,
			GW_HWNDPREV = 3,
			GW_OWNER = 4,
			GW_CHILD = 5,
			GW_ENABLEDPOPUP = 6
		}

		private enum HitTestValues
		{
			HTERROR = -2,
			HTTRANSPARENT = -1,
			HTNOWHERE = 0,
			HTCLIENT = 1,
			HTCAPTION = 2,
			HTSYSMENU = 3,
			HTGROWBOX = 4,
			HTMENU = 5,
			HTHSCROLL = 6,
			HTVSCROLL = 7,
			HTMINBUTTON = 8,
			HTMAXBUTTON = 9,
			HTLEFT = 10,
			HTRIGHT = 11,
			HTTOP = 12,
			HTTOPLEFT = 13,
			HTTOPRIGHT = 14,
			HTBOTTOM = 15,
			HTBOTTOMLEFT = 16,
			HTBOTTOMRIGHT = 17,
			HTBORDER = 18,
			HTOBJECT = 19,
			HTCLOSE = 20,
			HTHELP = 21
		}

		private enum WindowMessages
		{
			WM_NULL = 0x0000,
			WM_CREATE = 0x0001,
			WM_DESTROY = 0x0002,
			WM_MOVE = 0x0003,
			WM_SIZE = 0x0005,
			WM_ACTIVATE = 0x0006,
			WM_SETFOCUS = 0x0007,
			WM_KILLFOCUS = 0x0008,
			WM_ENABLE = 0x000A,
			WM_SETREDRAW = 0x000B,
			WM_SETTEXT = 0x000C,
			WM_GETTEXT = 0x000D,
			WM_GETTEXTLENGTH = 0x000E,
			WM_PAINT = 0x000F,
			WM_CLOSE = 0x0010,

			WM_QUIT = 0x0012,
			WM_ERASEBKGND = 0x0014,
			WM_SYSCOLORCHANGE = 0x0015,
			WM_SHOWWINDOW = 0x0018,

			WM_ACTIVATEAPP = 0x001C,

			WM_SETCURSOR = 0x0020,
			WM_MOUSEACTIVATE = 0x0021,
			WM_GETMINMAXINFO = 0x24,
			WM_WINDOWPOSCHANGING = 0x0046,
			WM_WINDOWPOSCHANGED = 0x0047,

			WM_CONTEXTMENU = 0x007B,
			WM_STYLECHANGING = 0x007C,
			WM_STYLECHANGED = 0x007D,
			WM_DISPLAYCHANGE = 0x007E,
			WM_GETICON = 0x007F,
			WM_SETICON = 0x0080,

			// non client area
			WM_NCCREATE = 0x0081,
			WM_NCDESTROY = 0x0082,
			WM_NCCALCSIZE = 0x0083,
			WM_NCHITTEST = 0x84,
			WM_NCPAINT = 0x0085,
			WM_NCACTIVATE = 0x0086,

			WM_GETDLGCODE = 0x0087,

			WM_SYNCPAINT = 0x0088,

			// non client mouse
			WM_NCMOUSEMOVE = 0x00A0,
			WM_NCLBUTTONDOWN = 0x00A1,
			WM_NCLBUTTONUP = 0x00A2,
			WM_NCLBUTTONDBLCLK = 0x00A3,
			WM_NCRBUTTONDOWN = 0x00A4,
			WM_NCRBUTTONUP = 0x00A5,
			WM_NCRBUTTONDBLCLK = 0x00A6,
			WM_NCMBUTTONDOWN = 0x00A7,
			WM_NCMBUTTONUP = 0x00A8,
			WM_NCMBUTTONDBLCLK = 0x00A9,

			// keyboard
			WM_KEYDOWN = 0x0100,
			WM_KEYUP = 0x0101,
			WM_CHAR = 0x0102,

			WM_SYSCOMMAND = 0x0112,

			// menu
			WM_INITMENU = 0x0116,
			WM_INITMENUPOPUP = 0x0117,
			WM_MENUSELECT = 0x011F,
			WM_MENUCHAR = 0x0120,
			WM_ENTERIDLE = 0x0121,
			WM_MENURBUTTONUP = 0x0122,
			WM_MENUDRAG = 0x0123,
			WM_MENUGETOBJECT = 0x0124,
			WM_UNINITMENUPOPUP = 0x0125,
			WM_MENUCOMMAND = 0x0126,

			WM_CHANGEUISTATE = 0x0127,
			WM_UPDATEUISTATE = 0x0128,
			WM_QUERYUISTATE = 0x0129,

			// mouse
			WM_MOUSEFIRST = 0x0200,
			WM_MOUSEMOVE = 0x0200,
			WM_LBUTTONDOWN = 0x0201,
			WM_LBUTTONUP = 0x0202,
			WM_LBUTTONDBLCLK = 0x0203,
			WM_RBUTTONDOWN = 0x0204,
			WM_RBUTTONUP = 0x0205,
			WM_RBUTTONDBLCLK = 0x0206,
			WM_MBUTTONDOWN = 0x0207,
			WM_MBUTTONUP = 0x0208,
			WM_MBUTTONDBLCLK = 0x0209,
			WM_MOUSEWHEEL = 0x020A,
			WM_MOUSELAST = 0x020D,

			WM_PARENTNOTIFY = 0x0210,
			WM_ENTERMENULOOP = 0x0211,
			WM_EXITMENULOOP = 0x0212,

			WM_NEXTMENU = 0x0213,
			WM_SIZING = 0x0214,
			WM_CAPTURECHANGED = 0x0215,
			WM_MOVING = 0x0216,

			WM_ENTERSIZEMOVE = 0x0231,
			WM_EXITSIZEMOVE = 0x0232,

			WM_MOUSELEAVE = 0x02A3,
			WM_MOUSEHOVER = 0x02A1,
			WM_NCMOUSEHOVER = 0x02A0,
			WM_NCMOUSELEAVE = 0x02A2,

			WM_MDIACTIVATE = 0x0222,
			WM_HSCROLL = 0x0114,
			WM_VSCROLL = 0x0115,

			WM_SYSMENU = 0x313,

			WM_PRINT = 0x0317,
			WM_PRINTCLIENT = 0x0318,
		}

		private enum SystemCommands
		{
			SC_SIZE = 0xF000,
			SC_MOVE = 0xF010,
			SC_MINIMIZE = 0xF020,
			SC_MAXIMIZE = 0xF030,
			SC_MAXIMIZE2 = 0xF032,  // fired from double-click on caption
			SC_NEXTWINDOW = 0xF040,
			SC_PREVWINDOW = 0xF050,
			SC_CLOSE = 0xF060,
			SC_VSCROLL = 0xF070,
			SC_HSCROLL = 0xF080,
			SC_MOUSEMENU = 0xF090,
			SC_KEYMENU = 0xF100,
			SC_ARRANGE = 0xF110,
			SC_RESTORE = 0xF120,
			SC_RESTORE2 = 0xF122,   // fired from double-click on caption
			SC_TASKLIST = 0xF130,
			SC_SCREENSAVE = 0xF140,
			SC_HOTKEY = 0xF150,

			SC_DEFAULT = 0xF160,
			SC_MONITORPOWER = 0xF170,
			SC_CONTEXTHELP = 0xF180,
			SC_SEPARATOR = 0xF00F
		}

		[Flags]
		private enum WindowStyle
		{
			WS_OVERLAPPED = 0x00000000,
			WS_POPUP = -2147483648, //0x80000000,
			WS_CHILD = 0x40000000,
			WS_MINIMIZE = 0x20000000,
			WS_VISIBLE = 0x10000000,
			WS_DISABLED = 0x08000000,
			WS_CLIPSIBLINGS = 0x04000000,
			WS_CLIPCHILDREN = 0x02000000,
			WS_MAXIMIZE = 0x01000000,
			WS_CAPTION = 0x00C00000,
			WS_BORDER = 0x00800000,
			WS_DLGFRAME = 0x00400000,
			WS_VSCROLL = 0x00200000,
			WS_HSCROLL = 0x00100000,
			WS_SYSMENU = 0x00080000,
			WS_THICKFRAME = 0x00040000,
			WS_GROUP = 0x00020000,
			WS_TABSTOP = 0x00010000,
			WS_MINIMIZEBOX = 0x00020000,
			WS_MAXIMIZEBOX = 0x00010000,
			WS_TILED = WS_OVERLAPPED,
			WS_ICONIC = WS_MINIMIZE,
			WS_SIZEBOX = WS_THICKFRAME,
			WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,
			WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU |
									WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
			WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU),
			WS_CHILDWINDOW = (WS_CHILD)
		}

		private Color hoverTextColor = Color.White;

		public Color HoverTextColor {
			get { return hoverTextColor; }
			set { hoverTextColor = value; }
		}

		private Color downTextColor = Color.FromArgb(25, 71, 138);
		//private Color downTextColor = Color.FromArgb(255, 255, 255);

		public Color DownTextColor {
			get { return downTextColor; }
			set { downTextColor = value; }
		}

		private Color hoverBackColor = Color.FromArgb(63, 63, 65);

		public Color HoverBackColor {
			get { return hoverBackColor; }
			set { hoverBackColor = value; }
		}

		/// <summary>
		/// Color when user clicks.
		/// </summary>
		private Color downBackColor = Color.FromArgb(0, 122, 204);
		//private Color downBackColor = Color.FromArgb(255, 255, 255);

		public Color DownBackColor {
			get { return downBackColor; }
			set { downBackColor = value; }
		}

		private Color normalBackColor = Color.FromArgb(45, 45, 48);
		//private Color normalBackColor = Color.FromArgb(255, 255, 255);

		public Color NormalBackColor {
			get { return normalBackColor; }
			set { normalBackColor = value; }
		}

		private Color activeBorderColor = Color.FromArgb(0, 122, 204);

		public Color ActiveBorderColor {
			get { return activeBorderColor; }
			set { activeBorderColor = value; }
		}

		private Color inactiveBorderColor = Color.FromArgb(28, 28, 28);

		public Color InactiveBorderColor {
			get { return inactiveBorderColor; }
			set { inactiveBorderColor = value; }
		}

		//private Color activeTextColor = Color.FromArgb(68, 68, 68);
		private Color activeTextColor = Color.White;

		public Color ActiveTextColor {
			get { return activeTextColor; }
			set { activeTextColor = value; }
		}

		//private Color inactiveTextColor = Color.FromArgb(177, 177, 177);
		private Color inactiveTextColor = Color.White;

		public Color InactiveTextColor {
			get { return inactiveTextColor; }
			set { inactiveTextColor = value; }
		}

		private FormWindowState MinMaxState {
			get {
				var s = NativeMethods.GetWindowLong(Handle, NativeConstants.GWL_STYLE);
				var max = (s & (int)WindowStyle.WS_MAXIMIZE) > 0;
				if (max) return FormWindowState.Maximized;
				var min = (s & (int)WindowStyle.WS_MINIMIZE) > 0;
				if (min) return FormWindowState.Minimized;
				return FormWindowState.Normal;
			}
		}

		protected void SetLabelColors(Control control, MouseState state)
		{
			// refreshes minimize button if this line is commented
			//if (!ContainsFocus) return;

			var textColor = ActiveTextColor;
			var backColor = NormalBackColor;

			switch (state)
			{
				case MouseState.Hover:
					textColor = HoverTextColor;
					backColor = HoverBackColor;
					break;
				case MouseState.Down:
					textColor = DownTextColor;
					backColor = DownBackColor;
					break;
			}

			control.ForeColor = textColor;
			control.BackColor = backColor;
		}

		protected void SetBorderColor(Color color)
		{
			TopLeftCornerPanel.BackColor = color;
			TopBorderPanel.BackColor = color;
			TopRightCornerPanel.BackColor = color;
			LeftBorderPanel.BackColor = color;
			RightBorderPanel.BackColor = color;
			BottomLeftCornerPanel.BackColor = color;
			BottomBorderPanel.BackColor = color;
			BottomRightCornerPanel.BackColor = color;
		}

		protected void SetTextColor(Color color)
		{
			minimizeLabel.ForeColor = color;
			maximizeLabel.ForeColor = color;
			closeLabel.ForeColor = color;
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);

			if (!DesignMode)
				SetWindowRegion(Handle, 0, 0, Width, Height);
		}

		protected void ShowSystemMenu(MouseButtons buttons)
		{
			ShowSystemMenu(buttons, MousePosition);
		}

		protected static int MakeLong(short lowPart, short highPart)
		{
			return (int)(((ushort)lowPart) | (uint)(highPart << 16));
		}

		protected void ShowSystemMenu(MouseButtons buttons, Point pos)
		{
			NativeMethods.SendMessage(Handle, (int)WindowMessages.WM_SYSMENU, 0, MakeLong((short)pos.X, (short)pos.Y));
		}

		protected override void WndProc(ref Message m)
		{
			if (DesignMode)
			{
				base.WndProc(ref m);
				return;
			}

			switch (m.Msg)
			{
				case (int)WindowMessages.WM_NCCALCSIZE:
					{
						// Provides new coordinates for the window client area.
						WmNCCalcSize(ref m);
						break;
					}
				case (int)WindowMessages.WM_NCPAINT:
					{
						// Here should all our painting occur, but...
						WmNCPaint(ref m);
						break;
					}
				case (int)WindowMessages.WM_NCACTIVATE:
					{
						// ... WM_NCACTIVATE does some painting directly 
						// without bothering with WM_NCPAINT ...
						WmNCActivate(ref m);
						break;
					}
				case (int)WindowMessages.WM_SETTEXT:
					{
						// ... and some painting is required in here as well
						WmSetText(ref m);
						break;
					}
				case (int)WindowMessages.WM_WINDOWPOSCHANGED:
					{
						WmWindowPosChanged(ref m);
						break;
					}
				case 174: // ignore magic message number
					{
						break;
					}
				default:
					{
						base.WndProc(ref m);
						break;
					}
			}
		}

		private void SystemLabel_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) ShowSystemMenu(MouseButtons);
		}

		private void SystemLabel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var clickTime = (DateTime.Now - _systemClickTime).TotalMilliseconds;
				if (clickTime < SystemInformation.DoubleClickTime)
					Close();
				else
				{
					_systemClickTime = DateTime.Now;
					if ((_systemClickTime - _systemMenuCloseTime).TotalMilliseconds > 200)
					{
						ShowSystemMenu(MouseButtons, PointToScreen(new Point(8, 32)));
						_systemMenuCloseTime = DateTime.Now;
					}
				}
			}
		}

		private void Close(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) Close();
		}

		private void DecorationMouseDown(MouseEventArgs e, HitTestValues h)
		{
			if (e.Button == MouseButtons.Left) DecorationMouseDown(h);
		}

		private void MainForm_Deactivate(object sender, EventArgs e)
		{
			SetBorderColor(InactiveBorderColor);
			SetTextColor(InactiveTextColor);
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{
			SetBorderColor(ActiveBorderColor);
			SetTextColor(ActiveTextColor);
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			var maximized = MinMaxState == FormWindowState.Maximized;
			maximizeLabel.Text = maximized ? "2" : "1";

			var panels = new[] { TopLeftCornerPanel, TopRightCornerPanel, BottomLeftCornerPanel, BottomRightCornerPanel,
				TopBorderPanel, LeftBorderPanel, RightBorderPanel, BottomBorderPanel };

			foreach (var panel in panels)
			{
				panel.Visible = !maximized;
			}

			if (_previousWindowState != MinMaxState)
			{
				if (maximized)
				{
					closeLabel.Left += RightBorderPanel.Width;
					closeLabel.Top = 0;
					maximizeLabel.Left += RightBorderPanel.Width;
					maximizeLabel.Top = 0;
					minimizeLabel.Left += RightBorderPanel.Width;
					minimizeLabel.Top = 0;
				}
				else if (_previousWindowState == FormWindowState.Maximized)
				{
					closeLabel.Left -= RightBorderPanel.Width;
					closeLabel.Top = TopBorderPanel.Height;
					maximizeLabel.Left -= RightBorderPanel.Width;
					maximizeLabel.Top = TopBorderPanel.Height;
					minimizeLabel.Left -= RightBorderPanel.Width;
					minimizeLabel.Top = TopBorderPanel.Height;
				}

				_previousWindowState = MinMaxState;
			}
		}

		private FormWindowState ToggleMaximize()
		{
			return WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
		}

		private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var clickTime = (DateTime.Now - _titleClickTime).TotalMilliseconds;
				if (clickTime < SystemInformation.DoubleClickTime && e.Location == _titleClickPosition)
					ToggleMaximize();
				else
				{
					_titleClickTime = DateTime.Now;
					_titleClickPosition = e.Location;
					DecorationMouseDown(HitTestValues.HTCAPTION);
				}
			}
		}

		private void DecorationMouseDown(HitTestValues hit, Point p)
		{
			NativeMethods.ReleaseCapture();
			var pt = new POINTS { X = (short)p.X, Y = (short)p.Y };
			NativeMethods.SendMessage(Handle, (int)WindowMessages.WM_NCLBUTTONDOWN, (int)hit, pt);
		}

		private void DecorationMouseDown(HitTestValues hit)
		{
			DecorationMouseDown(hit, MousePosition);
		}

		private void DecorationMouseUp(HitTestValues hit, Point p)
		{
			NativeMethods.ReleaseCapture();
			var pt = new POINTS { X = (short)p.X, Y = (short)p.Y };
			NativeMethods.SendMessage(Handle, (int)WindowMessages.WM_NCLBUTTONUP, (int)hit, pt);
		}

		private void DecorationMouseUp(HitTestValues hit)
		{
			DecorationMouseUp(hit, MousePosition);
		}

		private void SetWindowRegion(IntPtr hwnd, int left, int top, int right, int bottom)
		{
			var hrg = new HandleRef((object)this, NativeMethods.CreateRectRgn(0, 0, 0, 0));
			var r = NativeMethods.GetWindowRgn(hwnd, hrg.Handle);
			RECT box;
			NativeMethods.GetRgnBox(hrg.Handle, out box);
			if (box.left != left || box.top != top || box.right != right || box.bottom != bottom)
			{
				var hr = new HandleRef((object)this, NativeMethods.CreateRectRgn(left, top, right, bottom));
				NativeMethods.SetWindowRgn(hwnd, hr.Handle, NativeMethods.IsWindowVisible(hwnd));
			}
		}

		private void WmWindowPosChanged(ref Message m)
		{
			DefWndProc(ref m);
			UpdateBounds();
			var pos = (WINDOWPOS)Marshal.PtrToStructure(m.LParam, typeof(WINDOWPOS));
			SetWindowRegion(m.HWnd, 0, 0, pos.cx, pos.cy);
			m.Result = NativeConstants.TRUE;
		}

		private void WmNCCalcSize(ref Message m)
		{
			// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/winui/winui/windowsuserinterface/windowing/windows/windowreference/windowmessages/wm_nccalcsize.asp
			// http://groups.google.pl/groups?selm=OnRNaGfDEHA.1600%40tk2msftngp13.phx.gbl

			var r = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
			var max = MinMaxState == FormWindowState.Maximized;

			if (max)
			{
				var x = NativeMethods.GetSystemMetrics(NativeConstants.SM_CXSIZEFRAME);
				var y = NativeMethods.GetSystemMetrics(NativeConstants.SM_CYSIZEFRAME);
				var p = NativeMethods.GetSystemMetrics(NativeConstants.SM_CXPADDEDBORDER);
				var w = x + p;
				var h = y + p;

				r.left += w;
				r.top += h;
				r.right -= w;
				r.bottom -= h;

				var appBarData = new APPBARDATA();
				appBarData.cbSize = Marshal.SizeOf(typeof(APPBARDATA));
				var autohide = (NativeMethods.SHAppBarMessage(NativeConstants.ABM_GETSTATE, ref appBarData) & NativeConstants.ABS_AUTOHIDE) != 0;
				if (autohide) r.bottom -= 1;

				Marshal.StructureToPtr(r, m.LParam, true);
			}

			m.Result = IntPtr.Zero;
		}

		private void WmNCPaint(ref Message msg)
		{
			// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/gdi/pantdraw_8gdw.asp
			// example in q. 2.9 on http://www.syncfusion.com/FAQ/WindowsForms/FAQ_c41c.aspx#q1026q

			// The WParam contains handle to clipRegion or 1 if entire window should be repainted
			//PaintNonClientArea(msg.HWnd, (IntPtr)msg.WParam);

			// we handled everything
			msg.Result = NativeConstants.TRUE;
		}

		private void WmSetText(ref Message msg)
		{
			// allow the system to receive the new window title
			DefWndProc(ref msg);

			// repaint title bar
			//PaintNonClientArea(msg.HWnd, (IntPtr)1);
		}

		private void WmNCActivate(ref Message msg)
		{
			// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/winui/winui/windowsuserinterface/windowing/windows/windowreference/windowmessages/wm_ncactivate.asp

			bool active = (msg.WParam == NativeConstants.TRUE);

			if (MinMaxState == FormWindowState.Minimized)
				DefWndProc(ref msg);
			else
			{
				// repaint title bar
				//PaintNonClientArea(msg.HWnd, (IntPtr)1);

				// allow to deactivate window
				msg.Result = NativeConstants.TRUE;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;

			public RECT(int left, int top, int right, int bottom)
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			public static RECT FromXYWH(int x, int y, int width, int height)
			{
				return new RECT(x,
								y,
								x + width,
								y + height);
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct WINDOWPOS
		{
			internal IntPtr hwnd;
			internal IntPtr hWndInsertAfter;
			internal int x;
			internal int y;
			internal int cx;
			internal int cy;
			internal uint flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct POINTS
		{
			public short X;
			public short Y;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct NativeMessage
		{
			public IntPtr handle;
			public uint msg;
			public IntPtr wParam;
			public IntPtr lParam;
			public uint time;
			public System.Drawing.Point p;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct APPBARDATA
		{
			public int cbSize; // initialize this field using: Marshal.SizeOf(typeof(APPBARDATA));
			public IntPtr hWnd;
			public uint uCallbackMessage;
			public uint uEdge;
			public RECT rc;
			public int lParam;
		}

		private static class NativeMethods
		{
			[DllImport("user32.dll")]
			public static extern bool ReleaseCapture();

			[DllImport("user32.dll")]
			public static extern IntPtr SetCapture(IntPtr hWnd);

			[DllImport("user32.dll")]
			public static extern IntPtr GetCapture();

			[DllImport("user32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool SetForegroundWindow(IntPtr hWnd);

			[DllImport("user32.dll", SetLastError = true)]
			public static extern IntPtr SetActiveWindow(IntPtr hWnd);

			[DllImport("user32.dll")]
			public static extern int SendMessage(IntPtr hwnd, int msg, int wparam, int lparam);

			[DllImport("user32.dll")]
			public static extern int PostMessage(IntPtr hwnd, int msg, int wparam, int lparam);

			[DllImport("user32.dll")]
			public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

			[DllImport("user32.dll")]
			public static extern int TrackPopupMenuEx(IntPtr hmenu, uint fuFlags, int x, int y,
			   IntPtr hwnd, IntPtr lptpm);

			[DllImport("user32.dll")]
			public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll")]
			public static extern int SendMessage(IntPtr hwnd, int msg, int wparam, POINTS pos);

			[DllImport("user32.dll")]
			public static extern int PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll")]
			public static extern int PostMessage(IntPtr hwnd, int msg, int wparam, POINTS pos);

			[DllImport("user32.dll")]
			public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

			[DllImport("user32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool IsWindowVisible(IntPtr hWnd);

			[DllImport("gdi32.dll")]
			public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

			[DllImport("user32.dll")]
			public static extern int GetWindowRgn(IntPtr hWnd, IntPtr hRgn);

			[DllImport("gdi32.dll")]
			public static extern int GetRgnBox(IntPtr hrgn, out RECT lprc);

			[DllImport("user32.dll")]
			public static extern Int32 GetWindowLong(IntPtr hWnd, Int32 Offset);

			[DllImport("user32.dll")]
			public static extern int GetSystemMetrics(int smIndex);

			[DllImport("user32.dll", SetLastError = true)]
			public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

			[DllImport("shell32.dll")]
			public static extern int SHAppBarMessage(uint dwMessage, [In] ref APPBARDATA pData);
		}

		private static class NativeConstants
		{
			public const int SM_CXSIZEFRAME = 32;
			public const int SM_CYSIZEFRAME = 33;
			public const int SM_CXPADDEDBORDER = 92;

			public const int GWL_ID = (-12);
			public const int GWL_STYLE = (-16);
			public const int GWL_EXSTYLE = (-20);

			public const int WM_NCLBUTTONDOWN = 0x00A1;
			public const int WM_NCRBUTTONUP = 0x00A5;

			public const uint TPM_LEFTBUTTON = 0x0000;
			public const uint TPM_RIGHTBUTTON = 0x0002;
			public const uint TPM_RETURNCMD = 0x0100;

			public static readonly IntPtr TRUE = new IntPtr(1);
			public static readonly IntPtr FALSE = new IntPtr(0);

			public const uint ABM_GETSTATE = 0x4;
			public const int ABS_AUTOHIDE = 0x1;
		}

		private void FormBase_Load(object sender, EventArgs e)
		{

		}
	}
}
