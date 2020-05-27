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

using ClientVehicle.Header;
using ClientVehicle.ServerReference;
using ClientVehicle.UCHelp;
using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.Dialogs.DialogsVehicle;
using System.Threading;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCVehicle.xaml
    /// </summary>
    public partial class UCVehicle : UserControl
    {
        public List<UCButtonRow> vehicleRow = new List<UCButtonRow>();
        public List<Vehicle> vehicleNumerable = new List<Vehicle>();

        private Vehicle _activeVehicle = new Vehicle();

        public Vehicle Vehicle
        {
            get { return _activeVehicle; }

            set
            {
                _activeVehicle = value;
                Items.UpdateVehicleActive(value);
            }
        }

        public string Status
        {
            get { return label_Status.Text; }

            set 
            {
                if (value == " ")
                {
                    label_Status.Text = value;
                    label_Status.Visibility = Visibility.Collapsed;
                }
                else
                {
                    if (label_Status.Visibility != Visibility.Visible)
                        label_Status.Visibility = Visibility.Visible;

                    label_Status.Text = value;
                }
            }
        }

        public UCVehicle()
        {
            InitializeComponent();
        }

        private void onClickSearch(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            SearchVehicle.Show();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;

            Items.UpdateVehicle(SearchVehicle.GetItemSearched());

            if ( Items.ucVehicle.vehicleRow.Count != 0)
            {
                Items.ucVehicle.Vehicle = Items.ucVehicle.vehicleRow[0].Item;
                //Items.UpdateVehicleActive(Items.ucVehicle.vehicleRow[0].Item);
                Items.ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Items.ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void onClickRent(object sender, RoutedEventArgs e)
        {
            Status = " ";
            Vehicle Item = Client.Server.ConnectProvider.GetUserVehicle(Client.User);

            if (_activeVehicle.ClientId != 0)
            {
                Status = "Цей транспорт вже орендований.";
                return;
            }

            if (Item.VIN != "null")
            {
                Status = "Ви вже маєте орендований автомобіль.";
                return;
            }

            if (date_Picker.Visibility != Visibility.Visible)
            {
                date_Picker.Visibility = Visibility.Visible;

                date_Picker.DisplayDateStart = DateTime.Now.AddDays(1);
                date_Picker.DisplayDateEnd = DateTime.Now.AddDays(50);

                return;
            }
            else
            {
                if (string.IsNullOrEmpty(date_Picker.Text))
                {
                    Status = "Виберіть дату.";

                    return;
                }
            }

            float TotalPrice = 0;

            DateTime Time = date_Picker.SelectedDate ?? DateTime.Now;
            TimeSpan delta = Time - DateTime.Now;
            int days = delta.Days;
            TotalPrice = days * _activeVehicle.Price;



            //if (TotalPrice > )

            string message = $"Ви дійсно хочете орендувати {_activeVehicle.Name} {_activeVehicle.Model} за ₴ {TotalPrice}?";

            if (DialogWindow.Show(message, "Підтвердження оренди", DialogButtons.OkNo, DialogStyle.Information) == DialogResult.Ok)
            {
                if (TotalPrice > Client.User.Balance)
                {
                    Status = "Недостатньо грошей на рахунку.";
                    return;
                }

                Client.User.Balance -= TotalPrice;

                _activeVehicle.StartDate = DateTime.Now;
                _activeVehicle.FinalDate = Time;

                _activeVehicle.ClientId = Client.User.Id;

                CashVoucher ReceiptItem = Client.CollectReceipt(Client.User, _activeVehicle, TotalPrice, _activeVehicle.StartDate, _activeVehicle.FinalDate);
                int Id = Client.Server.ConnectProvider.writeCashVoucher(ReceiptItem);

                _activeVehicle.RentLogId = Client.Server.ConnectProvider.log_TakeRent(
                    Client.User.Id,
                    _activeVehicle.VIN,
                    TotalPrice,
                    Id,
                    _activeVehicle.StartDate,
                    _activeVehicle.FinalDate
                );

                Client.Server.ConnectProvider.SaveUser(Client.User);
                Client.Server.ConnectProvider.saveVehicle(_activeVehicle);

                UiOperation.SetPage(UIPage.Main);
            }
        }
    }
}
