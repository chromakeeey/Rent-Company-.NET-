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
        //public ServerData serverData = new ServerData();
        public UI ui;
        public Account account;

        public List<Vehicle> vehicleObject = new List<Vehicle>();

        // Forms
        public VehicleInfo vehicleinfo = new VehicleInfo();
        public login Login = new login();
    }
}
