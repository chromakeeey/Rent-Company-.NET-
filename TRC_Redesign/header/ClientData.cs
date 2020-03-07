using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TRC_Redesign.ServiceRent;

namespace TRC_Redesign.header
{
    public class ClientData
    {
        public Form1 mainWindow;
        public UI ui = new UI();
        public Account account;

        // Forms
        public VehicleInfo vehicleinfo = new VehicleInfo();
        public login Login = new login();
    }
}
