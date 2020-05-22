using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.ServerReference;
using ClientVehicle.Dialogs.DialogsVehicle;

namespace ClientVehicle.Header
{
    public static class Client
    {
        public static User User;


     
        public static Server Server = new Server();

        public static void InitializeItems()
        {
            User = new User();
            Server = new Server();
        }

        public static void SetActiveUser(User item)
        {
            User = item;

            //Items.mainWindow.
            Items.mainWindow.Title = $"{item.Login} - Головне вікно";
            Items.UpdateMainPage();
            Items.UpdateMenuButtons();

            SearchVehicle.ClearSearchFields();
            SearchVehicle.ComplectSearchObject();
            Items.UpdateAVehicle(SearchVehicle.GetItemSearched());
            Items.UpdateVehicle(SearchVehicle.GetItemSearched());

            Vehicle[] numerableVehicle = Server.ConnectProvider.SendAllVehicle();
            Items.UpdateAVehicleHeader(numerableVehicle.ToList());

            User[] numerableUser = Server.ConnectProvider.SelectAllUser();
            Items.UpdateAUserHeader(numerableUser.ToList());
        }

        public static void ApplicationShutdown()
        {
            OnApplicationShutdown();
            System.Windows.Application.Current.Shutdown();
        }

        public static void OnApplicationShutdown()
        {
            Server.userDisconnect();
            Items.notifyIcon.Visible = false;
        }
    }
}
