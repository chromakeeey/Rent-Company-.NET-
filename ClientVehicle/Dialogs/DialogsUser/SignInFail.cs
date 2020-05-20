using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVehicle.Dialogs.DialogsUser
{
    public static class SignInFail
    {
        private static FailSignIn Dialog = new FailSignIn();

        public static void Show(string Message)
        {
            Dialog.label_Error.Text = Message;
            Dialog.ShowDialog();
        }
    }
}
