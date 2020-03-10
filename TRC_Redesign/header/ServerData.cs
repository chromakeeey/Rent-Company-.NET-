using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

       
        public void uploadImage(string path, Vehicle vehicleObject)
        {
            string name = vehicleObject.plate;
            string extenstion = Path.GetExtension(path);
            byte[] buffer = File.ReadAllBytes(path);

            client.uploadVehicleImage(buffer, name, extenstion);
        }

        /*public void uploadImage(Image path)
        {
            File file = new File();

            file.Content = System.IO.File.ReadAllBytes(path);
            file.Name = System.IO.Path.GetFileName(path);

            client.uploadVehicleImage(file);
        }*/
        

    }
}
