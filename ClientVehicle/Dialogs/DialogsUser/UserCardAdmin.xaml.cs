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

using ClientVehicle.ServerReference;
using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsUser
{
    /// <summary>
    /// Interaction logic for UserCardAdmin.xaml
    /// </summary>
    public partial class UserCardAdmin : Window
    {
        private User _item = new User();

        public User User
        {
            get { return _item; }

            set
            {
                _item = value;
                UpdateUser();
            }
        }

        private string Error
        {
            get { return label_Error.Text; }

            set 
            {
                if (value == " ")
                {
                    label_Error.Visibility = Visibility.Collapsed;
                    label_Error.Text = value;
                }
                else
                {
                    if (label_Error.Visibility != Visibility.Visible)
                        label_Error.Visibility = Visibility.Visible;

                    label_Error.Text = value;
                }

            }
        }

        public UserCardAdmin()
        {
            InitializeComponent();
        }

        private void UpdateUser()
        {
            Error = " ";
            GridReason.Visibility = Visibility.Collapsed;

            label_FullName.Text = $"{_item.Surname} {_item.Name}";
            label_ID.Text = $"№ {_item.Id}";
            label_Register.Text = _item.UserCreateDate.ToString();

            field_Login.Text = _item.Login;
            field_Surname.Text = _item.Surname;
            field_Name.Text = _item.Name;
            field_Mail.Text = _item.Mail;
            field_Phone.Text = _item.Phone;
            date_Birthday.SelectedDate = _item.BirthdayDate;

            image_Front.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.FrontImageBytes(_item));
            image_Back.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.BackImageBytes(_item));

            Vehicle Item = Client.Server.ConnectProvider.GetUserVehicle(_item);
            button_VehicleUser.IsEnabled = Item.VIN == "null" ? false : true;
            
            if (_item.Status != 256)
            {
                InvalidUserPanel.Visibility = Visibility.Visible;
                label_Reason.Text = _item.StatusReason;
            }
            else
            {
                InvalidUserPanel.Visibility = Visibility.Hidden;
            }
        }

        private void UIElement_OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
        }

        private void onClickExit(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }

        private void onClickDeactive(object sender, RoutedEventArgs e)
        {
            if (GridReason.Visibility != Visibility.Visible)
            {
                GridReason.Visibility = Visibility.Visible;
                field_Reason.Text = "";

                return;
            }
            else
            {
                if (string.IsNullOrEmpty(field_Reason.Text))
                {
                    Error = "Введіть причину деактивації.";
                }
                else
                {
                    _item.Status = 5;
                    _item.StatusReason = field_Reason.Text;

                    GridReason.Visibility = Visibility.Collapsed;
                    Client.Server.ConnectProvider.SaveUser(_item);
                }
            }

        }

        private void onClickBack(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void onClickActive(object sender, RoutedEventArgs e)
        {
            _item.Status = 256;
            Client.Server.ConnectProvider.SaveUser(_item);

        }
    }
}
