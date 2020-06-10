
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientVehicle.Header;
using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.Receipts
{
    public static class Receipt
    {
        public static ReceiptWindow Dialog = new ReceiptWindow();
        public static ReceiptEdit DialogEdit = new ReceiptEdit();

        public static void Show(CashVoucher Item)
        {
            Dialog.Receipt = Item;
            Dialog.ShowDialog();
        }

        public static void ShowEdit()
        {
            CashVoucherData Item = Client.Server.ConnectProvider.sendCashVoucherData();
            DialogEdit.SetReceiptData(Item);

            DialogEdit.ShowDialog();
        }
    }
}
