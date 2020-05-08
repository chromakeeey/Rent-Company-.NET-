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
using RentTransportWPF.UCHelp;
using RentTransportWPF.HeaderFile;

namespace RentTransportWPF.UCMain
{
    /// <summary>
    /// Interaction logic for UCVListPage.xaml
    /// </summary>
    public partial class UCVListPage : UserControl
    {
        private List<UCVehicleRowButton> items;
        public WindowMain mainWindow;
        private Vehicle selectVehicle = new Vehicle();

        public UCVListPage()
        {
            InitializeComponent();
            items = new List<UCVehicleRowButton>();
        }

        private void clearStackPanel()
        {
            foreach (var item in items)
            {
                item.Visibility = Visibility.Hidden;
            }

            spanel_RowVehicle.Children.Clear();
            items.Clear();
        }

        public void setActiveVehicle(UCVehicleRowButton row)
        {
            if (row.itemVehicle.VIN == selectVehicle.VIN)
                return;

            foreach(var i in items) { i.Background = Brushes.Transparent; }

            card_ActiveVehicle.Visibility = Visibility.Visible;
            row.Background = Brushes.LightGray;

            var item = row.itemVehicle;
            var stream = mainWindow.serverData.ConnectProvider.vehicleImage(item);
            image_Vehicle.Source = ServerData.BytesToBitmapImage(stream);

            text_Category.Text = item.category;  
            text_Plate.Text = item.plate; 
            text_Transmission.Text = item.transmission;
            text_Type.Text = item.type;
            text_VIN.Text = item.VIN;

            text_IsRent.Text = item.rentlogid == 0 ? "Не орендований" : "Орендований";

            text_Price.Text = String.Format("₴ {0}", item.price.ToString());
            text_Speed.Text = String.Format("{0} км/г", item.maxspeed.ToString());
            text_Mileage.Text = String.Format("{0} км.", item.mileage.ToString());
            text_Name.Text = String.Format("{0} {1}", item.name, item.model);
            text_NowFuel.Text = String.Format("{0} л.", item.fuel.ToString());
            text_Fuel.Text = String.Format("{0} л.", item.maxfuel.ToString());
        }

        public void showVehicleList(List<Vehicle> item)
        {
            clearStackPanel();

            foreach (var i in item)
            {
                UCVehicleRowButton rowItem = new UCVehicleRowButton();

                rowItem.Margin = new Thickness(0, 0, 0, 15);
                rowItem.mainWindow = mainWindow;
                rowItem.setVehicle(i);

                spanel_RowVehicle.Children.Add(rowItem);
                items.Add(rowItem);
            }

            if (items.Count != 0)
            {
                setActiveVehicle(items[0]);
            }
            else
            {
                card_ActiveVehicle.Visibility = Visibility.Hidden;
            }
        }
    }
}
