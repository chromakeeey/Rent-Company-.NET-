using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Input;
using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;
using System.Windows.Forms;


namespace TRC_Redesign.header
{
    public class ServerData : IServiceRentCallback
    {
        public Form1 mainWindow;
        public bool is_connected = false;
        public int client_id;

        public void accountObjectCallBack(ServiceRent.account accountObject)
        {
           
            
        }

        
    }
}
