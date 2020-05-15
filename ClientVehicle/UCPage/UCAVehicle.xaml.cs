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

using ClientVehicle.Dialogs.DialogsVehicle;
using ClientVehicle.Header;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCAVehicle.xaml
    /// </summary>
    public partial class UCAVehicle : UserControl
    {
        public UCAVehicle()
        {
            InitializeComponent();
        }

        private void onClickAddVehicle(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            new DialogAddVehicle().ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }
    }
}
