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

namespace ClientVehicle.UCHelp
{
    /// <summary>
    /// Interaction logic for UCAVehicleRow.xaml
    /// </summary>
    public partial class UCAVehicleRow : UserControl
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

        public UCAVehicleRow()
        {
            InitializeComponent();
        }

        private void onMoreClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ContextMenu contextMenu = button.ContextMenu;
            contextMenu.PlacementTarget = button;
            contextMenu.IsOpen = true;
            e.Handled = true;
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


            label_VIN.Text = _activeVehicle.VIN;
            label_Fullname.Text = $"{_activeVehicle.Name} {_activeVehicle.Model}";
            label_Price.Text = $"₴ {_activeVehicle.Price}";
            label_Status.Text = _activeVehicle.ClientId == 0 ? "Не орендований" : "Орендований";
            label_Fuel.Text = $"{_activeVehicle.Fuel} л.";
        }
    }
}
