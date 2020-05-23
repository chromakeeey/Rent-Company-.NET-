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

using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.Dialogs.DialogsVehicle;
using ClientVehicle.Dialogs.DialogsUser;
using ClientVehicle.Dialogs.Receipts;
using ClientVehicle.Header;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCMain.xaml
    /// </summary>
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }


        private void onCancelRent(object sender, RoutedEventArgs e)
        {
            DialogWindow.Show("Ви дійсно хочите відмінити оренду?", "Відміна оренди", DialogButtons.OkNo, DialogStyle.Information);
        }

        private void onUpdatePasswordClick(object sender, RoutedEventArgs e)
        {
            new DialogAddVehicle().ShowDialog();
        }

        private void onClickCheckDocument(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            new UserDocumentWindow(Client.User).ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        private void onReceiptSee(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            new ReceiptWindow().ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        private void onClickVehiclePage(object sender, RoutedEventArgs e)
        {
            UiOperation.SetPage(UIPage.Vehicle);
        }
    }
}
