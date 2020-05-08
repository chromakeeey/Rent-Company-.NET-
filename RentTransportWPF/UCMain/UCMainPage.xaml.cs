using System;
using System.Collections.Generic;
using System.IO;
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

namespace RentTransportWPF.UCMain
{
    /// <summary>
    /// Interaction logic for UCMainPage.xaml
    /// </summary>
    public partial class UCMainPage : UserControl
    {
        public WindowMain mainWindow;
        private Vehicle Vehicle;

        public UCMainPage()
        {
            InitializeComponent();
        }

        public void updateVehicleInfo()
        {
            Vehicle item = mainWindow.serverData.ConnectProvider.getUserVehicle(mainWindow.clientData.Account);
            Vehicle = item;

            if (item.plate != "none")
            {
                var stream = mainWindow.serverData.ConnectProvider.vehicleImage(item);
                image_Vehicle.Source = ServerData.BytesToBitmapImage(stream);

                text_VehicleName.Text = String.Format("{0} {1}", item.name, item.model);
                text_VIN.Text = item.VIN;
                text_StartDate.Text = item.start_date.ToString();
                text_FinalDate.Text = item.end_date.ToString();
                text_DayPrice.Text = String.Format("₴ {0}", item.price.ToString());

                card_VehicleInfo.Visibility = Visibility.Visible;
                label_NonRent.Visibility = Visibility.Hidden;

                button_CancelRent.IsEnabled = true;
                button_More.IsEnabled = true;
            }
            else
            {
                card_VehicleInfo.Visibility = Visibility.Hidden;
                label_NonRent.Visibility = Visibility.Visible;

                button_CancelRent.IsEnabled = false;
                button_More.IsEnabled = false;
                text_VehicleName.Text = "Автомобіль не орендований";
            }
        }
    }
}
