using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Input;
using System.Windows.Forms;

using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;


namespace TRC_Redesign.header
{
    public class ServerData
    {
        public Form1 mainWindow;
        public bool is_connected = false;
        public ServiceRentClient client;
        public int client_id;

       

        
    }
}
