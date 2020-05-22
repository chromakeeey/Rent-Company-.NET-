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

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    /// <summary>
    /// Interaction logic for BetterSearchVehicle.xaml
    /// </summary>
    public partial class BetterSearchVehicle : Window
    {
        public List<Vehicle> numerableVehicle;

        public BetterSearchVehicle()
        {
            InitializeComponent();
        }

        private void onSearchClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
