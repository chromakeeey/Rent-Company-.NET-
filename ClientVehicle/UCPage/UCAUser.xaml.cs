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
using System.Windows.Navigation;
using System.Windows.Shapes;

using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.Header;
using ClientVehicle.UCHelp;
using ClientVehicle.ServerReference;


namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCAUser.xaml
    /// </summary>
    public partial class UCAUser : UserControl
    {
        public List<User> userNumerable = new List<User>();
        public List<UCAUserRow> userRow = new List<UCAUserRow>();

        private string oldSearch = "INVALID_SEARCH_PARAMS";

        public UCAUser()
        {
            InitializeComponent();
        }

        private void onUserApplicationClick(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;

            User Item = Client.Server.ConnectProvider.SelectUserApplication();

            if (Item.Id != 0)
            {
                ApplicationUser.Show(Item);
            }
            else
            {
                button_AccountCheck.IsEnabled = false;
            }

            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        public List<User> SearchAsLogin(List<User> numerable)
        {
            if (string.IsNullOrEmpty(textbox_Search.Text))
                return numerable;

            string filter = textbox_Search.Text;

            List<User> sortNumerable = (
                from i in numerable 
                where (i.Surname + " " + i.Name).StartsWith(filter) 
                select i).ToList();

            return sortNumerable;
        }

        private void onClickSearch(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_Search.Text))
                return;

            if (textbox_Search.Text == oldSearch)
                return;

            oldSearch = textbox_Search.Text;

            User[] numerableUser = Client.Server.ConnectProvider.SelectAllUser();
            List<User> sortedApplication = (from i in numerableUser where i.Status != 0 select i).ToList();
            Items.UpdateAUser(SearchAsLogin(sortedApplication));
        }
    }
}
