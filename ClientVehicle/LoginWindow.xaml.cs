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

using ClientVehicle.Header;
using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.ServerReference;

namespace ClientVehicle
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Server server;

        public LoginWindow()
        {
            InitializeComponent();

            Items.loginWindow = this;

            Items.InitializeItems();
            Client.InitializeItems();
            Client.Server.InitializeConnection();

            UiOperation.SetPage(UIPage.Main);
        }

        private void windowMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void onSignInClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(field_Login.Text) || string.IsNullOrEmpty(field_Password.Password))
            {
                SignInFail.Show("Ви не заповнили логін або пароль.");
                return;
            }

            User item = new User();

            item = Client.Server.ConnectProvider.SelectUser_LoginPassword(
                field_Login.Text,
                field_Password.Password
            );

            if (item.Id == 0)
            {
                SignInFail.Show("Логін або пароль були введені неправильно.");
                return;
            }

            if (item.Status != 256)
            {
                SignInFail.Show(item.StatusReason);
                return;
            }

            Client.SetActiveUser(item);

            Hide();
            Items.mainWindow.Show();
            Items.IsActiveMainWindow = true;
        }

        private void onSignUpClick(object sender, RoutedEventArgs e)
        {
            

            Hide();
            Items.signUpWindow.Show();
        }
    }
}
