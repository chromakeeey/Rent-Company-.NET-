using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsUser
{
    public static class BankOperationWindow
    {
        public static UserBankOperation Dialog = new UserBankOperation();

        public static void Show()
        {
            Dialog.label_Balance.Text = String.Format("₴ {0:n0}", Client.User.Balance);
            Dialog.label_Credit.Text = Items.ucMain.label_Credit.Text;

            Dialog.radio_Minus.IsChecked = false;
            Dialog.radio_Plus.IsChecked = false;

            Dialog.field_Price.Text = "";

            if (Client.User.CardNumber == "null")
            {
                Dialog.field_CardNumber.Text = "";
                Dialog.field_ExpireDate.Text = "";
                Dialog.field_CVV.Text = "";
            }
            else
            {
                Dialog.field_CardNumber.Text = Client.User.CardNumber;
                Dialog.field_ExpireDate.Text = Client.User.ExpireDate;
                Dialog.field_CVV.Text = Client.User.CVV.ToString();
            }

            Dialog.ShowDialog();
        }
    }
}
