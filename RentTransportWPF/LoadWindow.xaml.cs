using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Windows.Threading;

namespace RentTransportWPF
{
    /// <summary>
    /// Interaction logic for LoadWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        private DispatcherTimer loadTimer;
        private LoginWindow loginWindow;

        public LoadWindow()
        {
            InitializeComponent();

            
            

            loginWindow = new LoginWindow();
        }

        private static bool isInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        private void OnLoadLoaded(object sender, RoutedEventArgs e)
        {
            loadTimer = new DispatcherTimer();

            loadTimer.Tick += new EventHandler(timer_Tick);
            loadTimer.Interval = new TimeSpan(0, 0, 1);

            loadTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loginWindow.mainWindow.serverData.userConnect();

            loadTimer.Stop();
            loginWindow.Show();
            Hide();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {

        }
    }
}
