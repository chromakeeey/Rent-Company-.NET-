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

using RentTransportWPF.HeaderFile;
using RentTransportWPF.ServiceRent;

namespace RentTransportWPF
{
    /// <summary>
    /// Interaction logic for WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {

        private bool onMove = false;
        private Point pointMove = new Point();

        public ClientData clientData;
        public ServerData serverData;

        public LoginWindow loginWindow;

        public WindowMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void onHideWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void onCloseWindow(object sender, RoutedEventArgs e)
        {
            this.onExitApplication();
        }

        private void onResizeWindow(object sender, RoutedEventArgs e)
        {
            switch (WindowState)
            {
                case (WindowState.Maximized):
                    ResizeMode = ResizeMode.CanResize;
                    WindowState = WindowState.Normal;
                    break;

                case (WindowState.Normal):
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Maximized;
                    break;
            }
        }

        private void onClickButtonMain(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.MAIN;
        }

        private void onClickButtonVehicle(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.VEHICLE;
        }

        private void onClickButtonOVehicle(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.OVEHICLE;
        }

        private void onClickButtonOUser(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.OUSER;
        }

        private void onClickButtonReceipt(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.RECEIPT;
        }

        private void onClickButtonChart(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.CHART;
        }

        private void onClickButtonSetting(object sender, RoutedEventArgs e)
        {
            clientData.uiOperation.Page = UiPageType.SETTING;
        }

        

        public void onExitApplication()
        {    
            serverData.userDisconnect();
            Application.Current.Shutdown();
        }

        private void onMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void onLogoutClick(object sender, RoutedEventArgs e)
        {
            Hide();
            loginWindow.Show();
        }

        private void moveMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            
        }

        private void moveMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void moveMouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
