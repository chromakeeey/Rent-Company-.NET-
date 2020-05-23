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

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    /// <summary>
    /// Interaction logic for VehicleEditPage.xaml
    /// </summary>
    public partial class VehicleEditPage : Window
    {
        private Vehicle _vehicleNow = new Vehicle();

        public Vehicle Item
        {
            get { return _vehicleNow; }

            set
            {
                _vehicleNow = value;
                UpdateVehicle();
            }
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
            combo_Type.Text = _vehicleNow.Type;
            combo_Transmission.Text = _vehicleNow.Transmission;
            combo_Category.Text = _vehicleNow.Category;

            label_VIN.Text = _vehicleNow.VIN;
            label_StartRent.Text = _vehicleNow.ClientId == 0 ? "-" :  _vehicleNow.StartDate.ToString();
            label_FinalRent.Text = _vehicleNow.ClientId == 0 ? "-" : _vehicleNow.FinalDate.ToString();

            image_Vehicle.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.vehicleImage(_vehicleNow));

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
    }
}
