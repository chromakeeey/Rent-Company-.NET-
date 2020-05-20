using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.ServerReference;

namespace ClientVehicle.Header
{
    public static class Client
    {
        public static User User { get; set; }
        public static Server Server = new Server();

        public static void InitializeItems()
        {
            User = new User();
            Server = new Server();
        }

        public static void ApplicationShutdown()
        {
            OnApplicationShutdown();
            System.Windows.Application.Current.Shutdown();
        }

        public static void OnApplicationShutdown()
        {
            Server.userDisconnect();
        }
    }
}
