using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentTransportWPF.DGCustom
{
    public static class DialogSearchVehicle
    {
        public static void Create()
        {
            DGSearchVehicle dialog = new DGSearchVehicle();
            dialog.ShowDialog();
        }
    }
}
