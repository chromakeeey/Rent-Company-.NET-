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

using RentTransportWPF.DGCustom;

namespace RentTransportWPF.UCMain
{
    /// <summary>
    /// Interaction logic for UCAVehiclePage.xaml
    /// </summary>
    public partial class UCAVehiclePage : UserControl
    {

        

        public UCAVehiclePage()
        {
            InitializeComponent();
        }

        private void onClickAddVehicle(object sender, RoutedEventArgs e)
        {

        }

        private void onClickDeleteVehicle(object sender, RoutedEventArgs e)
        {
            DialogSearchVehicle.Create();
        }

        private void onClickEditVehicle(object sender, RoutedEventArgs e)
        {
            DialogSearchVehicle.Create();
        }
    }
}
