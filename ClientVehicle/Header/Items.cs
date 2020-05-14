using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientVehicle.UCPage;

namespace ClientVehicle.Header
{
    public static class Items
    {
        // Main windows
        public static LoginWindow loginWindow;
        public static MainWindow mainWindow;

        // Main pages
        public static UCMain ucMain;
        public static UCVehicle ucVehicle;
        public static UCAVehicle ucAVehicle;
        public static UCAUser ucAUser;
        public static UCStatistic ucStatistic;

        public static void InitializeItems()
        {
            mainWindow = new MainWindow();

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
        }

    }

}
