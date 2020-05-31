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
        public static UserBankOperation Dialog;

        public static void Show()
        {
            Dialog = new UserBankOperation();

            Dialog.label_Balance.Text = String.Format("₴ {0:n0}", Client.User.Balance);
            Dialog.label_Credit.Text = Items.ucMain.label_Credit.Text;

            Dialog.field_Price.Text = "";

            if (Client.Vehicle.VIN != "null")
            {
                TimeSpan delta = DateTime.Now - Client.Vehicle.FinalDate;
                Dialog.Credit = delta.Days > 0 ? Client.Vehicle.Price * delta.Days : 0;
            }

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
