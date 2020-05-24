using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.ServerReference;

namespace ClientVehicle.Dialogs.DialogsVehicle
{
    public static class VehicleEdit
    {
        public static VehicleEditPage Dialog = new VehicleEditPage();

        public static void Show(Vehicle Item)
        {
            Dialog.Item = Item;
            
            Dialog.ShowDialog();
        }
    }
}
