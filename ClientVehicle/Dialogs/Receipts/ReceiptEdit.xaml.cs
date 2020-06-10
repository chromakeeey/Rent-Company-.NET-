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
using ClientVehicle.Header;
using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.Receipts
{
    /// <summary>
    /// Interaction logic for ReceiptEdit.xaml
    /// </summary>
    public partial class ReceiptEdit : Window
    {
        public ReceiptEdit()
        {
            InitializeComponent();
            this.Closing += new System.ComponentModel.CancelEventHandler(OnMainWindow_Closing);
        }

        private void OnMainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void SetReceiptData(CashVoucherData Item)
        {
            field_Company.Text = Item.companyName;
            field_Street.Text = Item.streetName;

            label_Company.Text = Item.companyName;
            label_Street.Text = Item.streetName;
        }

        private void OnCompanyTextChanged(object sender, TextChangedEventArgs e)
        {
            label_Company.Text = field_Company.Text;
        }

        private void OnStreeTextChanged(object sender, TextChangedEventArgs e)
        {
            label_Street.Text = field_Street.Text;
        }

        private void OnClickSave(object sender, RoutedEventArgs e)
        {
            Client.Server.ConnectProvider.setCashVoucherData(
                field_Company.Text,
                field_Street.Text
            );

            Hide();
        }
    }
}
