using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsUser
{
    public static class SignInFail
    {
        private static FailSignIn Dialog = new FailSignIn();

        public static void Show(string Message)
        {
            Items.loginWindow.grid_DialogShow.Visibility = System.Windows.Visibility.Visible;

            Dialog.label_Error.Text = Message;
            Dialog.ShowDialog();

            Items.loginWindow.grid_DialogShow.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
