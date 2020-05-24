using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.Header;
using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.DialogsUser
{
    public static class ApplicationUser
    {
        public static UserApplication Dialog = new UserApplication();

        public static void Show(User Item)
        {
            Dialog.SetUser(Item);
            Dialog.ShowDialog();
        }
    }
}
