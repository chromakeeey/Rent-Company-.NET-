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
using ClientVehicle.Dialogs.DialogsVehicle;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCVehicle.xaml
    /// </summary>
    public partial class UCVehicle : UserControl
    {
        public List<UCButtonRow> vehicleRow = new List<UCButtonRow>();
        public List<Vehicle> vehicleNumerable = new List<Vehicle>();

        private Vehicle _activeVehicle;

        public Vehicle Vehicle
        {
            get { return _activeVehicle; }

            set
            {
                _activeVehicle = value;
                Items.UpdateVehicleActive(value);
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
                Items.UpdateVehicleActive(Items.ucVehicle.vehicleRow[0].Item);
                Items.ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                Items.ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Hidden;
            }
        }
    }
}
