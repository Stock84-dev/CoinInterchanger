using CoinInterchanger.WPFViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoinInterchanger.Views
{
	/// <summary>
	/// Interaction logic for WindowHeaderView.xaml
	/// </summary>
	public partial class WindowHeader : UserControl
	{
		//private Window _window;
		//private Point _previousWindowPos, _previousWindowSize;

		public WindowHeader()
		{
			InitializeComponent();
            Loaded += (s, e) =>
            {
				//DataContext = new HeaderViewModel((WindowViewModel)Window.GetWindow(this).DataContext);
            };
        }

        //public void WindowHeaderView_Loaded(object sender, RoutedEventArgs e)
        //{
        //	_window = Application.Current.MainWindow;
        //}
        //private void Label_MouseEnter(object sender, MouseEventArgs e) =>
        //	((Label)sender).Background = Brushes.LightGray;

        //private void Label_MouseLeave(object sender, MouseEventArgs e) =>
        //	((Label)sender).Background = Background;

        //private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) =>
        //	((Label)sender).Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));

        //private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) =>
        //	((Label)sender).Background = Background;

        //private void Minimize(object sender, MouseButtonEventArgs e) =>
        //	_window.WindowState = WindowState.Minimized;

        //private void ChangeWindowState(object sender, MouseButtonEventArgs e)
        //{
        //	if (ChangeWindowStateLabel.Content as string == "1") // if WindowState.Normal
        //	{
        //		_previousWindowSize = new Point(_window.Width, _window.Height);
        //		_previousWindowPos = new Point(_window.Left, _window.Top);

        //		_window.Width = SystemParameters.WorkArea.Width;
        //		_window.Height = SystemParameters.WorkArea.Height;
        //		_window.Left = 0;
        //		_window.Top = 0;
        //	}
        //	else // if WindowState.Maximized
        //	{
        //		_window.Width = _previousWindowSize.X;
        //		_window.Height = _previousWindowSize.Y;
        //		_window.Left = _previousWindowPos.X;
        //		_window.Top = _previousWindowPos.Y;
        //	}
        //	if (ChangeWindowStateLabel.Content as string == "1")
        //		ChangeWindowStateLabel.Content = "2";
        //	else
        //		ChangeWindowStateLabel.Content = "1";
        //}

        //private void Header_MouseMove(object sender, MouseEventArgs e)
        //{
        //	if (e.LeftButton == MouseButtonState.Pressed)
        //		_window.DragMove();
        //}

        //private void Close(object sender, MouseButtonEventArgs e) =>
        //	_window.Close();
    }
}
