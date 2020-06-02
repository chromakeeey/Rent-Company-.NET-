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
using ClientVehicle.Dialogs.DialogsUser;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    /// <summary>
    /// Interaction logic for VehicleEditPage.xaml
    /// </summary>
    public partial class VehicleEditPage : Window
    {
        private bool IsUnRentPressed = false;
        private Vehicle _vehicleNow = new Vehicle();

        public Vehicle Item
        {
            get { return _vehicleNow; }

            set
            {
                _vehicleNow = value;
                IsUnRentPressed = false;
                UpdateVehicle();
            }
        }

        private string Error
        {
            get { return label_Error.Text; }
            set { label_Error.Text = value; }
        }

        public VehicleEditPage()
        {
            InitializeComponent();
        }

        private void onCloseClick(object sender, MouseButtonEventArgs e)
        {
            Hide();
        }

        private void UpdateVehicle()
        {
            IsUnRentPressed = false;

            image_Vehicle.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.vehicleImage(_vehicleNow));

            combo_Type.Text = _vehicleNow.Type;
            combo_Transmission.Text = _vehicleNow.Transmission;
            combo_Category.Text = _vehicleNow.Category;

            label_VIN.Text = _vehicleNow.VIN;
            label_StartRent.Text = _vehicleNow.ClientId == 0 ? "-" :  _vehicleNow.StartDate.ToString();
            label_FinalRent.Text = _vehicleNow.ClientId == 0 ? "-" : _vehicleNow.FinalDate.ToString();

            button_User.IsEnabled = _vehicleNow.ClientId == 0 ? false : true;
            button_Stop.IsEnabled = _vehicleNow.ClientId == 0 ? false : true;

            field_Name.Text = _vehicleNow.Name;
            field_Model.Text = _vehicleNow.Model;
            field_Mileage.Text = _vehicleNow.Mileage.ToString();
            field_MaxSpeed.Text = _vehicleNow.MaxSpeed.ToString();
            field_MaxFuel.Text = _vehicleNow.MaxFuel.ToString();
            field_Fuel.Text = _vehicleNow.Fuel.ToString();
            field_Plate.Text = _vehicleNow.Plate;
            field_Price.Text = _vehicleNow.Price.ToString();
        }

        private void onClickSave(object sender, RoutedEventArgs e)
        {
            Error = "";

            if (string.IsNullOrEmpty(field_Name.Text))
            {
                Error = "Ви не заповнили пункт 'Назва транспорта'";
                return;
            }

            if (string.IsNullOrEmpty(field_Model.Text))
            {
                Error = "Ви не заповнили пункт 'Модель транспорта'";
                return;
            }

            if (string.IsNullOrEmpty(field_Mileage.Text))
            {
                Error = "Ви не заповнили пункт 'Пробіг'";
                return;
            }

            if (string.IsNullOrEmpty(field_MaxSpeed.Text))
            {
                Error = "Ви не заповнили пункт 'Максимальна швидкість'";
                return;
            }

            if (string.IsNullOrEmpty(field_MaxFuel.Text))
            {
                Error = "Ви не заповнили пункт 'Об'єм бака'";
                return;
            }

            if (string.IsNullOrEmpty(field_Fuel.Text))
            {
                Error = "Ви не заповнили пункт 'Бензина в баці'";
                return;
            }

            if (string.IsNullOrEmpty(field_Plate.Text))
            {
                Error = "Ви не заповнили пункт 'Номерний знак'";
                return;
            }

            if (string.IsNullOrEmpty(field_Price.Text))
            {
                Error = "Ви не заповнили пункт 'Ціна'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Type.Text))
            {
                Error = "Ви не заповнили пункт 'Тип автомобіля'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Transmission.Text))
            {
                Error = "Ви не заповнили пункт 'Трансмісія'";
                return;
            }

            if (string.IsNullOrEmpty(combo_Category.Text))
            {
                Error = "Ви не заповнили пункт 'Категорія прав'";
                return;
            }

            if (!int.TryParse(field_Mileage.Text, out _))
            {
                Error = "Пробіг був введений неправильно.";
                return;
            }

            if (!int.TryParse(field_MaxSpeed.Text, out _))
            {
                Error = "Максимальна швидкість була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_MaxFuel.Text, out _))
            {
                Error = "Об'єм бака була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_Fuel.Text, out _))
            {
                Error = "Кількість бензина в баці була введена неправильно.";
                return;
            }

            if (!float.TryParse(field_Price.Text, out _))
            {
                Error = "Ціна була введена неправильно.";
                return;
            }

            _vehicleNow.Name = field_Name.Text;
            _vehicleNow.Model = field_Model.Text;
            _vehicleNow.Mileage = float.Parse(field_Mileage.Text);
            _vehicleNow.MaxSpeed = int.Parse(field_MaxSpeed.Text);
            _vehicleNow.MaxFuel = float.Parse(field_MaxFuel.Text);
            _vehicleNow.Fuel = float.Parse(field_Fuel.Text);
            _vehicleNow.Plate = field_Plate.Text;
            _vehicleNow.Price = float.Parse(field_Price.Text);
            _vehicleNow.Type = combo_Type.Text;
            _vehicleNow.Transmission = combo_Transmission.Text;
            _vehicleNow.Category = combo_Category.Text;

            Client.Server.ConnectProvider.saveVehicle(_vehicleNow);
            Hide();
        }

        private void onClickUserVehicle(object sender, RoutedEventArgs e)
        {
            User User = Client.Server.ConnectProvider.SelectUser(_vehicleNow.ClientId);

            if (User.Id != 0)
            {
                UiOperation.SetPage(UIPage.AUser);
                Hide();

                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
                UserACard.Show(User);
                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;

                return;
            }

            button_User.IsEnabled = false;
        }

        private void onClickStopRent(object sender, RoutedEventArgs e)
        {
            if (!IsUnRentPressed)
            {
                Error = "Натисніть ще раз для підтвердження відміни оренди.";
                IsUnRentPressed = true;

                return;
            }

            Error = "";

            User User = Client.Server.ConnectProvider.SelectUser(_vehicleNow.ClientId);

            _vehicleNow.ClientId = 0;
            _vehicleNow.RentLogId = 0;

            Client.Server.ConnectProvider.saveVehicle(_vehicleNow);
            Client.Server.ConnectProvider.SaveUser(User);
        }
    }
}
