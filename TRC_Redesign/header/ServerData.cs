using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;

using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;
using System.Drawing.Imaging;

namespace TRC_Redesign.header
{
    public class ServerData
    {
        public Form1 mainWindow;
        public bool is_connected = false;
        public ServiceRentClient client;
        public int client_id;

       
        /*public void uploadImage(Image path)
        {
            File file = new File();

            file.Content = System.IO.File.ReadAllBytes(path);
            file.Name = System.IO.Path.GetFileName(path);

            client.uploadVehicleImage(file);
        }*/
        

    }
}
