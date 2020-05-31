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
using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.DialogsUser
{
    /// <summary>
    /// Логика взаимодействия для UserBankOperation.xaml
    /// </summary>
    public partial class UserBankOperation : Window
    {
        public float Credit;

        public UserBankOperation()
        {
            InitializeComponent();

        }

        private string Error
        {
            get { return label_Error.Text; }

            set
            {
                label_Error.Text = value;
            }
        }

        private void onClickBankChange(object sender, RoutedEventArgs e)
        {
            Error = "";

            if (string.IsNullOrEmpty(field_CardNumber.Text))
            {
                Error = "Ви не заповнили поле 'Номер карти'";
                return;
            }

            if (string.IsNullOrEmpty(field_ExpireDate.Text))
            {
                Error = "Ви не заповнили поле 'Термін придатності'";
                return;
            }

            if (string.IsNullOrEmpty(field_CVV.Text))
            {
                Error = "Ви не заповнили поле 'CVV-код'";
                return;
            }

            if (field_CardNumber.Text.Length != 16)
            {
                Error = "Допущена помилка в полі 'Номер карти'";
                return;
            }

            if (!StringOperation.IsOnlyDigit(field_CardNumber.Text))
            {
                Error = "Допущена помилка в полі 'CVV-код'";
                return;
            }

            if (field_ExpireDate.Text.Length != 5)
            {
                Error = "Допущена помилка в полі 'Термін придатності'";
                return;
            }

            if (field_CVV.Text.Length != 3)
            {
                Error = "Допущена помилка в полі 'CVV-код'";
                return;
            }

            if (!StringOperation.IsOnlyDigit(field_CVV.Text))
            {
                Error = "Допущена помилка в полі 'CVV-код'";
                return;
            }

            Client.User.CardNumber = field_CardNumber.Text;
            Client.User.ExpireDate = field_ExpireDate.Text;
            Client.User.CVV = Convert.ToInt32(field_CVV.Text);

            Client.Server.ConnectProvider.SaveUser(Client.User);
        }

        private void onClickHide(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }

        private void minusChecked(object sender, RoutedEventArgs e)
        {
            if (Credit != 0)
            {
                field_Price.IsEnabled = false;
                operationButton.IsEnabled = false;
            }
            else
            {
                field_Price.IsEnabled = true;
                operationButton.IsEnabled = true;
            }
        }

        private void plusChecked(object sender, RoutedEventArgs e)
        {
            field_Price.IsEnabled = true;
            operationButton.IsEnabled = true;
        }

        private void onClickOperation(object sender, RoutedEventArgs e)
        {
            Error = "";

            if (string.IsNullOrEmpty(field_Price.Text))
            {
                Error = "Ви не заповнили поле 'Сумма'";
                return;
            }

            float Price;

            if (!float.TryParse(field_Price.Text, out Price))
            {
                Error = "Допущена помилка в полі 'Сумма'";
                return;
            }

            if (Price < 10 || Price > 5000)
            {
                Error = "Сумма поповнення має бути від 10 до 5000 гривень.";
                return;
            }

            if (radio_Minus.IsChecked == true)
            {
                if (Credit != 0)
                {
                    Error = "Ви маєте активний борг.";
                    return;
                }

                if (Price > Client.User.Balance)
                {
                    Error = "Недостатньо грошей на рахунку.";
                    return;
                }

                Client.User.Balance -= Price;
                Client.Server.ConnectProvider.SaveUser(Client.User);
                Client.Server.ConnectProvider.log_Balance(Client.User.Id, Client.User.CardNumber, -Price);

                Hide();
            }

            if (radio_Plus.IsChecked == true)
            {
                Client.User.Balance += Price;
                Client.Server.ConnectProvider.SaveUser(Client.User);
                Client.Server.ConnectProvider.log_Balance(Client.User.Id, Client.User.CardNumber, Price);

                Hide();
            }
        }
    }
}
