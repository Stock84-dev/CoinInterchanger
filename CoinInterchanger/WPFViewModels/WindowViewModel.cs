using CoinInterchanger.Core.ViewModels;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;

namespace CoinInterchanger.WPFViewModels
{
	public class WindowViewModel : BaseViewModel
	{
		private readonly Window _window;

		public WindowViewModel(Window window)
		{
			_window = window;
			_window.StateChanged += Window_StateChanged;
			SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
		}

		public Thickness ResizeBorderThickness { get; set; } = new Thickness(5);
		public Thickness WindowBorderThickness { get; set; } = new Thickness(1);
		public int HeaderHeight { get; set; } = 25;
		public int CaptionHeight => HeaderHeight + (int)WindowBorderThickness.Top - (int)ResizeBorderThickness.Top;

		public virtual void Minimize() => _window.WindowState = WindowState.Minimized;
		public virtual void ChangeWindowState() => _window.WindowState ^= WindowState.Maximized;
		public virtual void Close() => _window.Close();

		private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			// desktop preferences have changed like taskbar size and position, turning on second monitor...
			if (e.Category != UserPreferenceCategory.Desktop)
				return;
			// windows automatically changes window size if his state is normal
			if (_window.WindowState == WindowState.Maximized)
				RepositionWindow();
		}

		private void RepositionWindow()
		{
			// if taskbar is covering window then reposition is required
			Rectangle workingArea = Screen.FromHandle(new WindowInteropHelper(_window).Handle).WorkingArea;
			if (workingArea.Top == _window.Top && workingArea.Left == _window.Left && workingArea.Width == _window.Width && workingArea.Height == _window.Height)
				return;
			MoveWindow(_window, workingArea.Left, workingArea.Top, workingArea.Width, workingArea.Height);
		}

		private void Window_StateChanged(object sender, EventArgs e)
		{
			// removing border around window when maximized and also it cannot resize
			if (_window.WindowState == WindowState.Maximized)
			{
				ResizeBorderThickness = new Thickness(0);
				WindowBorderThickness = new Thickness(0);
				// when window is maximized its bigger than screen by few pixels,
				// sp we are changing its size and position
				RepositionWindow();
			}
			else if (_window.WindowState == WindowState.Normal)
			{
				ResizeBorderThickness = new Thickness(5);
				WindowBorderThickness = new Thickness(1);
			}
		}

		private (int pixelX, int pixelY) TransformToPixels(Visual visual, double unitX, double unitY)
		{
			Matrix matrix;
			var source = PresentationSource.FromVisual(visual);
			if (source != null)
				matrix = source.CompositionTarget.TransformToDevice;
			else
				using (var src = new HwndSource(new HwndSourceParameters()))
					matrix = src.CompositionTarget.TransformToDevice;

			return ((int)(matrix.M11 * unitX), (int)(matrix.M22 * unitY));
		}

		private void MoveWindow(Window window, double left, double top, double width, double height)
		{
			int pxLeft = 0, pxTop = 0;
			if (left != 0 || top != 0)
				(pxLeft, pxTop) = TransformToPixels(window, left, top);

			int pxWidth, pxHeight;
			(pxWidth, pxHeight) = TransformToPixels(window, width, height);

			var helper = new WindowInteropHelper(window);
			MoveWindow(helper.Handle, pxLeft, pxTop, pxWidth, pxHeight, true);
		}

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern int MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, [MarshalAs(UnmanagedType.Bool)] bool bRepaint);
	}
}
