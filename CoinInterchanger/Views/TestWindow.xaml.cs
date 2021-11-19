using CoinInterchanger.WPFViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoinInterchanger.Views
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
            DataContext = new TestViewModel(this);
        }

        private void TestWindow_StateChanged(object sender, EventArgs e)
        {
            //Screen sc = Screen.FromHandle(new WindowInteropHelper(this).Handle);
            //MaxHeight = sc.WorkingArea.Height + 7 * 2;
            //MaxWidth = sc.WorkingArea.Width + 7 * 2;
            //if (WindowState != WindowState.Maximized)
            //    return;
            //Top = sc.WorkingArea.Top + 7;
            //Left = sc.WorkingArea.Left + 7;
            
            //if (sc.WorkingArea.Top > 0)
            //{
            //    // TASKBAR TOP
                
            //}
            //else if (sc.WorkingArea.Left != sc.Bounds.X)
            //{
            //    // TASKBAR LEFT
            //}
            //else if ((sc.Bounds.Height - sc.WorkingArea.Height) > 0)
            //{
            //    // TASKBAR BOTTOM
            //}
            //else if (sc.WorkingArea.Right != 0)
            //{
            //    // TASKBAR RIGHT
            //}
            //else
            //{
            //    // TASKBAR NOT FOUND
            //}
        }

        //private enum TaskBarLocation { TOP, BOTTOM, LEFT, RIGHT }

        //private TaskBarLocation GetTaskBarLocation()
        //{
        //    TaskBarLocation taskBarLocation = TaskBarLocation.BOTTOM;
        //    bool taskBarOnTopOrBottom = (Screen.PrimaryScreen.WorkingArea.Width == Screen.PrimaryScreen.Bounds.Width);
        //    if (taskBarOnTopOrBottom)
        //    {
        //        if (Screen.PrimaryScreen.WorkingArea.Top > 0) taskBarLocation = TaskBarLocation.TOP;
        //    }
        //    else
        //    {
        //        if (Screen.PrimaryScreen.WorkingArea.Left > 0)
        //        {
        //            taskBarLocation = TaskBarLocation.LEFT;
        //        }
        //        else
        //        {
        //            taskBarLocation = TaskBarLocation.RIGHT;
        //        }
        //    }
        //    return taskBarLocation;
        //}

        //private const int ABM_GETTASKBARPOS = 5;

        //[System.Runtime.InteropServices.DllImport("shell32.dll")]
        //private static extern IntPtr SHAppBarMessage(int msg, ref APPBARDATA data);

        //private struct APPBARDATA
        //{
        //    public int cbSize;
        //    public IntPtr hWnd;
        //    public int uCallbackMessage;
        //    public int uEdge;
        //    public RECT rc;
        //    public IntPtr lParam;
        //}

        //private struct RECT
        //{
        //    public int left, top, right, bottom;
        //}

        //protected override void OnSourceInitialized(EventArgs e)
        //{
        //    base.OnSourceInitialized(e);

        //    APPBARDATA data = new APPBARDATA();
        //    data.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(data);
        //    SHAppBarMessage(ABM_GETTASKBARPOS, ref data);
        //    MessageBox.Show("Width: " + (data.rc.right - data.rc.left) + ", Height: " + (data.rc.bottom - data.rc.top));
        //}
    }


}
