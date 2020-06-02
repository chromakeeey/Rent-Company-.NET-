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
using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.Dialogs.DialogsVehicle;

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
            toggle_AdminStatus.IsChecked = _item.Level == 0 ? false : true;

            listbox_Category.Items.Clear();
            listbox_Category.IsEnabled = true;

            foreach (var item in Client.ExistsCategory)
            {
                ListBoxItem Category = new ListBoxItem();

                Category.Content = item;
                Category.IsSelected = Client.IsCategoryExists(_item, item) ? true : false;

                listbox_Category.Items.Add(Category);
            }

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
            if (User.Id == Client.User.Id)
            {
                Error = "Ви не можете деактивувати свій же аккаунт.";
                return;
            }


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

        private void onSaveClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(field_Login.Text))
            {
                Error = "Поле 'Логін' не заповнено.";
                return;
            }

            if (string.IsNullOrEmpty(field_Mail.Text))
            {
                Error = "Поле 'Пошта' не заповнено.";
                return;
            }

            if (string.IsNullOrEmpty(field_Phone.Text))
            {
                Error = "Поле 'Номер телефона' не заповнено.";
                return;
            }

            if (field_Login.Text.Length < 3 || field_Login.Text.Length > 16)
            {
                Error = "Розмір логіна має бути від 3 до 16 символів.";
                return;
            }

            if (!StringOperation.IsValidMail(field_Mail.Text))
            {
                Error = "Пошта була введена неправильно.";
                return;
            }

            if (!StringOperation.IsValidPhone(field_Phone.Text))
            {
                Error = "Телефон був введений неправильно.";
                return;
            }

            if (listbox_Category.SelectedItems.Count == 0)
            {
                Error = "Ви не вибрали ні одну категорію прав.";
                return;
            }

            if (string.IsNullOrEmpty(field_Name.Text) || string.IsNullOrEmpty(field_Surname.Text) || string.IsNullOrEmpty(date_Birthday.Text))
            {
                Error = "Ви не заповнили всі поля.";
                return;
            }

            _item.Login = field_Login.Text;
            _item.Surname = field_Surname.Text;
            _item.Name = field_Name.Text;
            _item.Mail = field_Mail.Text;
            _item.Phone = field_Phone.Text;

            List<string> Categories = new List<string>();

            foreach (var category in listbox_Category.SelectedItems)
            {
                Categories.Add(
                    (category as ListBoxItem).Content.ToString()
                );
            }

            _item.LicenseCategories = Categories.ToArray();
            _item.Level = toggle_AdminStatus.IsChecked == true ? 1 : 0;

            Client.Server.ConnectProvider.SaveUser(_item);
            Hide();

            DialogWindow.Show("Ви успішно редагували аккаунт.", "Інформація збережена", DialogButtons.Ok, DialogStyle.Information);
        }

        private void onClickSeeVehicle(object sender, RoutedEventArgs e)
        {
            Vehicle Vehicle = Client.Server.ConnectProvider.GetUserVehicle(_item);

            if (Vehicle.VIN != "null")
            {
                UiOperation.SetPage(UIPage.AVehicle);
                Hide();

                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
                VehicleEdit.Show(Vehicle);
                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;

                return;
            }

            button_VehicleUser.IsEnabled = false;
        }
    }
}
