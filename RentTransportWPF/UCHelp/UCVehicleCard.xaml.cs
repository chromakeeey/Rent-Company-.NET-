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

namespace RentTransportWPF.UCHelp
{
    /// <summary>
    /// Interaction logic for UCVehicleCard.xaml
    /// </summary>
    public partial class UCVehicleCard : UserControl
    {
        public UCVehicleCard()
        {
            InitializeComponent();
        }

        private void onLikeClicked(object sender, RoutedEventArgs e)
        {
            var redBrush = new SolidColorBrush(Color.FromArgb(255, (byte)226, (byte)85, (byte)68));

            icon_Like.Foreground = 
                icon_Like.Foreground != new SolidColorBrush(Colors.Black) 
                ? redBrush 
                : new SolidColorBrush(Colors.Black);
        }
    }
}
