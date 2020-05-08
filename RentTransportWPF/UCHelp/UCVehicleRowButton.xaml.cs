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
using RentTransportWPF.ServiceRent;
using RentTransportWPF.HeaderFile;

namespace RentTransportWPF.UCHelp
{
    /// <summary>
    /// Interaction logic for UCVehicleRowButton.xaml
    /// </summary>
    public partial class UCVehicleRowButton : UserControl
    {
        public Vehicle itemVehicle;
        public WindowMain mainWindow;

        public UCVehicleRowButton()
        {
            InitializeComponent();
        }

        public void setVehicle(Vehicle item)
        {
            itemVehicle = item;

            text_Name.Text = String.Format("{0} {1}", item.name, item.model);
            text_Price.Text = String.Format("₴ {0}", item.price.ToString());
            text_Status.Text = item.rentlogid == 0 ? "Не орендований" : "Орендований";
            text_VIN.Text = item.VIN;

            var stream = mainWindow.serverData.ConnectProvider.vehicleImage(item);
            image_Vehicle.Source = ServerData.BytesToBitmapImage(stream);
        }

        private void onButtonClick(object sender, RoutedEventArgs e)
        {
            
            mainWindow.clientData.uiOperation.uCVListPage.setActiveVehicle(this);
        }
    }
}
