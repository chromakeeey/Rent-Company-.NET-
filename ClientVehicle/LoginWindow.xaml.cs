using System.Windows;
using System.Windows.Input;

using ClientVehicle.Header;
using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.Dialogs.DialogsVehicle;
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
            FinalRent.InitializeDialog();

            Client.Server.InitializeConnection();

            UiOperation.SetPage(UIPage.Main);
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
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
