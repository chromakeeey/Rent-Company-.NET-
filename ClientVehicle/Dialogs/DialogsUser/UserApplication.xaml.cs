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
    /// Interaction logic for UserApplication.xaml
    /// </summary>
    public partial class UserApplication : Window
    {
        public User Item = new User();

        public UserApplication()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private string Error
        {
            get { return label_Error.Text; }

            set { label_Error.Text = value; }
        }

        public void SetUser(User Item)
        {
            this.Item = Item;

            image_Front.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.FrontImageBytes(Item));
            image_Back.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.BackImageBytes(Item));

            label_Login.Text = Item.Login;
            label_Mail.Text = Item.Mail;
            label_Phone.Text = Item.Phone;

        }

        private void onClickAccept(object sender, RoutedEventArgs e)
        {
            Error = " ";

            if (listbox_Category.SelectedItems.Count == 0)
            {
                Error = "Ви не вибрали ні одну категорію прав.";
                return;
            }

            if ( string.IsNullOrEmpty(field_Name.Text) || string.IsNullOrEmpty(field_Surname.Text) || string.IsNullOrEmpty(field_Birthday.Text) )
            {
                Error = "Ви не заповнили всі поля.";
                return;
            }

            Item.Name = field_Name.Text;
            Item.Surname = field_Surname.Text;
            Item.BirthdayDate = field_Birthday.SelectedDate ?? DateTime.Now;

            List<string> Categories = new List<string>();

            foreach (var category in listbox_Category.SelectedItems)
            {
                Categories.Add(
                    (category as ListBoxItem).Content.ToString()
                );
            }

            Item.LicenseCategories = Categories.ToArray();

            Item.Status = 256;
            Item.StatusReason = "null";

            
            Hide();
            Client.Server.ConnectProvider.SaveUser(Item);
        }

        private void onClickNoAccept(object sender, RoutedEventArgs e)
        {
            Error = " ";

            Item.Status = 1;
            Item.StatusReason = "Вам було відмовлено в реєстрації.";

            Hide();
            Client.Server.ConnectProvider.SaveUser(Item);
        }
    }
}
