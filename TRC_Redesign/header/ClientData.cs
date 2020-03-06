using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRC_Redesign.header
{
    public class ClientData
    {
        public Form1 mainWindow;
        public ServerData serverData = new ServerData();
        public UI ui;
        public account accountObject;

        public List<vehicle> vehicleObject = new List<vehicle>();

        // Forms
        public VehicleInfo vehicleinfo = new VehicleInfo();
        public login Login = new login();
    }
}
