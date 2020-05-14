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

namespace ClientVehicle.UCHelp
{
    /// <summary>
    /// Interaction logic for UCAVehicleRow.xaml
    /// </summary>
    public partial class UCAVehicleRow : UserControl
    {
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
    }
}
