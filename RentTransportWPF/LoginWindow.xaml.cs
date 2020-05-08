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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public WindowMain mainWindow;

        public LoginWindow()
        {
            InitializeComponent();
            mainWindow = new WindowMain();

            mainWindow.clientData = new ClientData(mainWindow);
            mainWindow.serverData = new ServerData();
        }

        private void onLoginClick(object sender, RoutedEventArgs e)
        {
            string login = field_Login.Text;
            string password = field_Password.Text;
            Account account;

            // empty textbox
            if (login == "" || password == "")
            {
                MessageBox.Show("Incorrent login or password");
                return;
            }

            account = mainWindow.serverData.ConnectProvider.selectAccount(login, password);

            if (account.documentid != 0)
            {
                if (account.accepted != 0)
                {
                    this.Hide();

                    mainWindow.clientData.setAccount(account);
                    mainWindow.clientData.uiOperation.childrenAdd();
                    mainWindow.clientData.uiOperation.Page = UiPageType.MAIN;

                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Account not activated");
                }
            }
            else
            {
                MessageBox.Show("Incorrent login or password");
            }

            
        }

        private void loginWindowLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
