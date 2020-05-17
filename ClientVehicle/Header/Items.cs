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
            notifyContext.MenuItems.Add("Выход", new EventHandler(exitContextClick));

            notifyIcon.ContextMenu = notifyContext;
        }

    }

}
