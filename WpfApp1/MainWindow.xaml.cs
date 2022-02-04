using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                int xPos = 100*i;
                int yPos = 100*i;

                Win32.POINT p = new Win32.POINT(xPos, yPos);

                Win32.SetCursorPos(p.x, p.y);
                Thread.Sleep(1000);
            }
            for (int i = 0; i < 5; i++)
            {
                int xPos = 500 - 100 * i;
                int yPos = 500 - 100 * i;

                Win32.POINT p = new Win32.POINT(xPos, yPos);

                Win32.SetCursorPos(p.x, p.y);
                Thread.Sleep(1000);
            }
        }
    }

    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;

            public POINT(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
