using ClientVehicle.Dialogs.CustomDefaultDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.Header;
using System.Windows;

namespace ClientVehicle.Dialogs.DialogsStatistic
{
    public static class CustomDate
    {
        public static DialogCustomDate Dialog = new DialogCustomDate();

        public static DialogResult Show(bool IsBackGround = true)
        {
            if (IsBackGround == true)
                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;

            Dialog.ShowDialog();

            if (IsBackGround == true)
                Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;

            return Dialog.Result;
        }

        public static DateTime GetStartDate()
        {
            return Dialog.calendar_Start.DisplayDate;
        }

        public static DateTime GetFinalDate()
        {
            return Dialog.calender_Final.DisplayDate;
        }
    }
}
