using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RentTransportWPF
{
    /// <summary>
    /// Interaction logic for WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void onHideWindow(object sender, RoutedEventArgs e)
        {
            
        }

        private void onCloseWindow(object sender, RoutedEventArgs e)
        {

        }

        private void onResizeWindow(object sender, RoutedEventArgs e)
        {
            switch (WindowState)
            {
                case (WindowState.Maximized):
                    ResizeMode = ResizeMode.CanResize;
                    WindowStyle = WindowStyle.SingleBorderWindow;
                    WindowState = WindowState.Normal;
                    break;

                case (WindowState.Normal):
                    ResizeMode = ResizeMode.NoResize;
                    WindowStyle = WindowStyle.None;
                    WindowState = WindowState.Maximized;
                    break;
            }
        }
    }
}
