using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.CustomDefaultDialog
{
    public enum DialogResult
    {
        Ok = 0,
        No = 1,
        Cancel = 2,
    }

    public enum DialogButtons
    {
        Ok = 0,
        OkNo = 1,
        OkNoCancel = 2,
    }

    public enum DialogStyle
    {
        Information = 0,
        Warning = 1,
        Error = 2,
    }

    public static class DialogWindow
    {
        public static DialogResult Show(string message, string caption, DialogButtons buttons, DialogStyle style)
        {
            DialogResult result = DialogResult.Cancel;
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;

            switch (buttons)
            {
                case DialogButtons.Ok:
                    var dialog = new DialogOk();
                    dialog.setDialogData(message, caption, style);
                    dialog.ShowDialog();
                    result = dialog.result;
                    break;

                case DialogButtons.OkNo:
                    var dialog1 = new DialogOkNo();
                    dialog1.setDialogData(message, caption, style);
                    dialog1.ShowDialog();
                    result = dialog1.result;
                    break;

                case DialogButtons.OkNoCancel:
                    var dialog2 = new DialogOkNoCancel();
                    dialog2.setDialogData(message, caption, style);
                    dialog2.ShowDialog();
                    result = dialog2.result;
                    break;
            }

            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
            return result;
        }
        
    }
}
