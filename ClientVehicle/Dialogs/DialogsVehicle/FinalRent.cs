using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.ServerReference;
using ClientVehicle.Header;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    public static class FinalRent
    {
        public static FinalRentWindow Dialog;

        public static void InitializeDialog()
        {
            Dialog = new FinalRentWindow();
        }

        public static DialogResult Show(Vehicle Vehicle, out Vehicle EditVehicle)
        {
            Dialog.field_Fuel.Text = Vehicle.Fuel.ToString();
            Dialog.field_Mileage.Text = Vehicle.Mileage.ToString();

            Dialog.Result = DialogResult.Cancel;
            Dialog.Vehicle = Vehicle;

            Items.mainWindow.GridBackgroundDialog.Visibility = System.Windows.Visibility.Visible;
            Dialog.ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = System.Windows.Visibility.Hidden;

            EditVehicle = Dialog.Vehicle;
            return Dialog.Result;
        }
    }
}
