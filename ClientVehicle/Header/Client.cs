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
        public static Vehicle Vehicle { get; set; }
        public static User User = new User();
        public static Server Server = new Server();

        public static bool IsLogin()
        {
            return (User.Id != 0);
        }

        public static void InitializeItems()
        {
            User = new User();
            Server = new Server();

            Vehicle = new Vehicle();
            Vehicle.VIN = "null";
        }

        public static void SetActiveUser(User item)
        {
            User = item;

            //Items.mainWindow.
            Items.mainWindow.Title = $"{item.Login} - Головне вікно";
            Items.UpdateMainPage();
            Items.UpdateMenuButtons();

            Vehicle[] numerableVehicle = Server.ConnectProvider.SendAllVehicle();

            SearchVehicle.ClearSearchFields();
            SearchVehicle.ComplectSearchObject(numerableVehicle.ToList());
            Items.UpdateAVehicle(SearchVehicle.GetItemSearched());
            Items.UpdateVehicle(SearchVehicle.GetItemSearched());
            Items.UpdateAVehicleHeader(numerableVehicle.ToList());

            User[] numerableUser = Server.ConnectProvider.SelectAllUser();
            List<User> sortedApplication = (from i in numerableUser where i.Status != 0 && i.Status != 1 select i).ToList();
            Items.UpdateAUser(Items.ucAUser.SearchAsLogin(sortedApplication));
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

        public static CashVoucher CollectReceipt(User User, Vehicle Vehicle, float Price, DateTime StartDate, DateTime FinalDate)
        {
            string vehicleData = String.Format("VIN: {0}\nІм'я: {1}\nНомерний знак: {2}\nБензина в баці: {3} л.\nПробіг: {4} км.",
                Vehicle.VIN, Vehicle.Name + " " + Vehicle.Model, Vehicle.Plate, Vehicle.Fuel.ToString(), Vehicle.Mileage.ToString());

            return new CashVoucher()
            {
                Id = -1,
                User = String.Format("{0} {1}", User.Surname, User.Name),
                Vehicle = vehicleData,
                Price = Price,
                StartDate = StartDate,
                FinalDate = FinalDate
            };
        }
    }
}
