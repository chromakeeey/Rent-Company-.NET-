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
using System.Windows.Threading;

using ClientVehicle.ServerReference;
using ClientVehicle.Header;

namespace ClientVehicle.UCHelp
{
    /// <summary>
    /// Interaction logic for UCButtonRow.xaml
    /// </summary>
    public partial class UCButtonRow : UserControl
    {
        private Vehicle _activeVehicle;

        public Vehicle Item
        {
            get { return _activeVehicle; }

            set
            {
                _activeVehicle = value;

                UpdateVehicle();
            }
        }

        public UCButtonRow()
        {
            InitializeComponent();
        }

        private void UpdateVehicle()
        {
            Opacity = 0;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.10d) == 1) timer.Stop();
            });

            timer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            timer.Start();


            label_Name.Text = $"{_activeVehicle.Name} {_activeVehicle.Model}";
            label_VIN.Text = _activeVehicle.VIN;
            image_Vehicle.Source = Server.BytesToBitmapImage(Client.Server.ConnectProvider.vehicleImage(_activeVehicle));
        }

        private void onClickButton(object sender, RoutedEventArgs e)
        {
            Items.UpdateVehicleActive(_activeVehicle);
        }
    }
}
