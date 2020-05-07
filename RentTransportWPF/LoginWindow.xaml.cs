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

namespace RentTransportWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void onLoginClick(object sender, RoutedEventArgs e)
        {
            Hide();

            var item = new WindowMain();

            item.clientData = new ClientData(item);
            item.clientData.uiOperation.childrenAdd();
            item.clientData.uiOperation.Page = UiPageType.MAIN;

            item.Show();
        }

        private void loginWindowLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
