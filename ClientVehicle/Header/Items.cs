using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.UCPage;
using ClientVehicle.ServerReference;
using ClientVehicle.UCHelp;
using System.Windows.Threading;

namespace ClientVehicle.Header
{
    public static class Items
    {
        // Main windows
        public static LoginWindow loginWindow;
        public static MainWindow mainWindow;
        public static SignUpWindow signUpWindow;

        // Main pages
        public static UCMain ucMain;
        public static UCVehicle ucVehicle;
        public static UCAVehicle ucAVehicle;
        public static UCAUser ucAUser;
        public static UCStatistic ucStatistic;

        // notify icon
        public static System.Windows.Forms.NotifyIcon notifyIcon;
        public static System.Windows.Forms.ContextMenu notifyContext;

        public static bool IsActiveMainWindow;

        private static void exitContextClick(object sender, EventArgs e)
        {
            Client.ApplicationShutdown();
        }

        private static void notifyClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                

                if (IsActiveMainWindow && mainWindow.Visibility == System.Windows.Visibility.Hidden)
                    mainWindow.Show();
            }
        }

        public static void InitializeItems()
        {
            mainWindow = new MainWindow();
            signUpWindow = new SignUpWindow();
            IsActiveMainWindow = false;

            ucMain = new UCMain();
            ucVehicle = new UCVehicle();
            ucAVehicle = new UCAVehicle();
            ucAUser = new UCAUser();
            ucStatistic = new UCStatistic();

            mainWindow.pageGrid.Children.Add(ucMain);
            mainWindow.pageGrid.Children.Add(ucVehicle);
            mainWindow.pageGrid.Children.Add(ucAVehicle);
            mainWindow.pageGrid.Children.Add(ucAUser);
            mainWindow.pageGrid.Children.Add(ucStatistic);

            ucMain.Visibility = System.Windows.Visibility.Hidden;
            ucVehicle.Visibility = System.Windows.Visibility.Hidden;
            ucAVehicle.Visibility = System.Windows.Visibility.Hidden;
            ucAUser.Visibility = System.Windows.Visibility.Hidden;
            ucStatistic.Visibility = System.Windows.Visibility.Hidden;

            notifyIcon = new System.Windows.Forms.NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon("notify.ico");
            notifyIcon.Visible = true;
            notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyClick);

            notifyContext = new System.Windows.Forms.ContextMenu();

            notifyContext.MenuItems.Add("Головна сторінка");
            notifyContext.MenuItems.Add("Транспортні засоби");
            notifyContext.MenuItems.Add("Выход", new EventHandler(exitContextClick));

            notifyIcon.ContextMenu = notifyContext;
        }

        public static void UpdateMenuButtons()
        {
            if (Client.User.Level == 0)
            {
                mainWindow.button_AVehicle.Visibility = System.Windows.Visibility.Hidden;
                mainWindow.button_AUser.Visibility = System.Windows.Visibility.Hidden;
                mainWindow.button_Statistic.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                mainWindow.button_AVehicle.Visibility = System.Windows.Visibility.Visible;
                mainWindow.button_AUser.Visibility = System.Windows.Visibility.Visible;
                mainWindow.button_Statistic.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public static void UpdateMainPage()
        {
            ucMain.label_Balance.Text = String.Format("₴ {0:n0}", Client.User.Balance);
            ucMain.label_Credit.Text = "₴ 0";

            // account grid
            ucMain.label_FullName.Text = String.Format("{0} {1}", Client.User.Surname, Client.User.Name);
            ucMain.label_DateSignUp.Text = Client.User.UserCreateDate.ToString();
            ucMain.label_Login.Text = Client.User.Login;
            ucMain.label_Mail.Text = Client.User.Mail;
            ucMain.label_Phone.Text = Client.User.Phone;

            if (Client.User.CardNumber == "null")
            {
                ucMain.label_Cardnumber.Text = "Не вказано";
                ucMain.label_PayType.Text = "-";
                ucMain.label_ExpireDate.Text = "-/-";
                ucMain.label_OwnerCard.Text = " ";
            }
            else
            {

            }

            Vehicle item = Client.Server.ConnectProvider.GetUserVehicle(Client.User);

            if (item.VIN != "null")
            {
                ucMain.image_Vehicle.Source = Server.BytesToBitmapImage(
                    Client.Server.ConnectProvider.vehicleImage(item)
                );

                ucMain.label_HeaderVehicle.Text = $"{item.Name} {item.Model}";
                ucMain.label_VIN.Text = item.VIN;
                ucMain.label_Plate.Text = item.Plate;
                ucMain.label_Category.Text = item.Category;
                ucMain.label_Fuel.Text = $"{item.Fuel} л.";
                ucMain.label_MaxFuel.Text = $"{item.MaxFuel} л.";
                ucMain.label_MaxSpeed.Text = $"{item.MaxSpeed} км/г";
                ucMain.label_Type.Text = item.Type;
                ucMain.label_Transmission.Text = item.Transmission;
                ucMain.label_Mileage.Text = String.Format("{0:n0} км", item.Mileage);

                ucMain.label_StartRent.Text = item.StartDate.ToString();
                ucMain.label_FinalRent.Text = item.FinalDate.ToString();


                ucMain.VehicleGrid.Visibility = System.Windows.Visibility.Visible;
                ucMain.notFoundVehicle_Grid.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                ucMain.VehicleGrid.Visibility = System.Windows.Visibility.Hidden;
                ucMain.notFoundVehicle_Grid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public static void UpdateAVehicleHeader(List<Vehicle> numerable)
        {
            var numerableRent = (from i in numerable where i.ClientId != 0 select i).ToList();

            ucAVehicle.label_Count.Text = numerable.Count.ToString();
            ucAVehicle.label_Rent.Text = numerableRent.Count.ToString();
        }

        public static void UpdateAVehicle(List<Vehicle> numerable)
        {
            ucAVehicle.vehicleNumerable = numerable;

            ucAVehicle.vehicleRow.Clear();
            ucAVehicle.panel_VehicleRow.Children.Clear();

            foreach (var item in ucAVehicle.vehicleNumerable)
            {
                var row = new UCAVehicleRow();

                row.Height = 93;
                row.Item = item;

                ucAVehicle.vehicleRow.Add(row);
                ucAVehicle.panel_VehicleRow.Children.Add(row);
            }
        }

        public static void UpdateVehicle(List<Vehicle> numerable)
        {
            ucVehicle.vehicleNumerable = numerable;

            ucVehicle.vehicleRow.Clear();
            ucVehicle.panel_VehicleNumerable.Children.Clear();

            foreach (var item in ucVehicle.vehicleNumerable)
            {
                var row = new UCButtonRow();
                row.Item = item;

                ucVehicle.vehicleRow.Add(row);
                ucVehicle.panel_VehicleNumerable.Children.Add(row);
            }

            if (numerable.Count != 0)
            {
                UpdateVehicleActive(numerable[0]);
                ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                ucVehicle.VehicleGrid.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        public static void UpdateAUserHeader(List<User> numerable)
        {
            var numerableDeactive = (from i in numerable where i.Status == 1 select i).ToList();
            var numerableCheck = (from i in numerable where i.Status == 0 select i).ToList();

            ucAUser.button_AccountCheck.IsEnabled = numerableCheck.Count == 0 ? false : true;

            ucAUser.label_Count.Text = numerable.Count.ToString();
            ucAUser.label_Deactive.Text = numerableDeactive.Count.ToString();
            ucAUser.label_Check.Text = numerableCheck.Count.ToString();
        }

        public static void UpdateVehicleActive(Vehicle item)
        {
            
            ucVehicle.image_Vehicle.Source = Server.BytesToBitmapImage(
                    Client.Server.ConnectProvider.vehicleImage(item)
                );

            ucVehicle.label_HeaderVehicle.Text = $"{item.Name} {item.Model}";
            ucVehicle.label_VIN.Text = item.VIN;
            ucVehicle.label_Plate.Text = item.Plate;
            ucVehicle.label_Category.Text = item.Category;
            ucVehicle.label_Fuel.Text = $"{item.Fuel} л.";
            ucVehicle.label_MaxFuel.Text = $"{item.MaxFuel} л.";
            ucVehicle.label_MaxSpeed.Text = $"{item.MaxSpeed} км/г";
            ucVehicle.label_Type.Text = item.Type;
            ucVehicle.label_Transmission.Text = item.Transmission;
            ucVehicle.label_Mileage.Text = String.Format("{0:n0} км", item.Mileage);

            ucVehicle.label_StartRent.Text = item.ClientId == 0 ? "-" : item.StartDate.ToString();
            ucVehicle.label_FinalRent.Text = item.ClientId == 0 ? "-" : item.FinalDate.ToString();

            ucVehicle.label_Status.Visibility = item.ClientId == 0 
                ? System.Windows.Visibility.Hidden 
                : System.Windows.Visibility.Visible;

            ucVehicle.button_Rent.IsEnabled = item.ClientId == 0 ? true : false;


            ucVehicle.VehicleGrid.Opacity = 0;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((ucVehicle.VehicleGrid.Opacity += 0.10d) == 1) timer.Stop();
            });

            timer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            timer.Start();
        }

    }

}
