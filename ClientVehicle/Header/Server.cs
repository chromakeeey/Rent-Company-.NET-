using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using ClientVehicle.ServerReference;

namespace ClientVehicle.Header
{
    public class Server : IServiceRentCallback
    {
        public ServiceRentClient ConnectProvider { get; private set; }

        public bool ConnectStatus { get; private set; }

        public int ClientId { get; private set; }

        public void userConnect()
        {
            try
            {
                ConnectProvider = new ServiceRentClient(new System.ServiceModel.InstanceContext(this));
                ClientId = ConnectProvider.userConnect();
                ConnectStatus = true;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Під'єднання до сервера неможливе. Сталась помилка (немає інтернету або сервер недоступний)");
                Client.ApplicationShutdown();
            }
        }

        public void userDisconnect()
        {
            if (ConnectStatus)
            {
                ConnectProvider.userDisconnect(ClientId);
                ConnectProvider = null;
                ConnectStatus = false;
            }
        }

        public static BitmapImage BytesToBitmapImage(byte[] stream)
        {
            var image = new BitmapImage();

            using (var memory = new MemoryStream(stream))
            {
                memory.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = memory;
                image.EndInit();
            }

            image.Freeze();
            return image;
        }

        public void onDeleteVehicle(Vehicle vehicleObject)
        {
            //throw new NotImplementedException();
        }

        public void onSaveVehicle(Vehicle vehicleObject)
        {
            //throw new NotImplementedException();
        }

        public void sendNotification(string message)
        {
            //throw new NotImplementedException();
        }
    }
}
