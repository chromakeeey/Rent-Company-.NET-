using ClientVehicle.ServerReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVehicle.Dialogs.Receipts
{
    public static class Receipt
    {
        public static ReceiptWindow Dialog = new ReceiptWindow();

        public static void Show(CashVoucher Item)
        {
            Dialog.Receipt = Item;
            Dialog.ShowDialog();
        }
    }
}
