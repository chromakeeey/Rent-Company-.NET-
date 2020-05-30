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

using ClientVehicle.ServerReference;
using ClientVehicle.Header;
using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.UCHelp;
using System.Windows.Threading;

namespace ClientVehicle.UCHelp
{
    


    /// <summary>
    /// Interaction logic for UCAUserRow.xaml
    /// </summary>
    public partial class UCAUserRow : UserControl
    {

        

        //private string oldSearch = "null";

        private User _activeUser;

        public User Item
        {
            get { return _activeUser; }

            set
            {
                _activeUser = value;
                UpdateUser();
            }
        }

        public UCAUserRow()
        {
            InitializeComponent();
        }

        private void onMoreClick(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            ContextMenu contextMenu = button.ContextMenu;
            contextMenu.PlacementTarget = button;
            contextMenu.IsOpen = true;
            //e.Handled = true;
        }

        private void onTopContextClick(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            UserACard.Show(_activeUser);
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        public void UpdateUser()
        {
            Vehicle Vehicle = Client.Server.ConnectProvider.GetUserVehicle(_activeUser);

            if (Vehicle.VIN != "null")
            {
                TimeSpan delta = DateTime.Now - Vehicle.FinalDate;
                label_Credit.Text = delta.Days > 0 ? $"₴ {Vehicle.Price}" : "₴ 0";
            }
            else
            {
                label_Credit.Text = "₴ 0";
            }

            label_ID.Text = _activeUser.Id.ToString();
            label_Name.Text = $"{_activeUser.Surname} {_activeUser.Name}";
            label_Balance.Text = $"₴ {_activeUser.Balance}";
            label_Create.Text = _activeUser.UserCreateDate.ToString();


            Opacity = 0;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.10d) == 1) timer.Stop();
            });

            timer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            timer.Start();


        }
    }
}
