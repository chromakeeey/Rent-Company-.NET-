using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentTransportWPF.UCMain;
using RentTransportWPF.UCHelp;

namespace RentTransportWPF.HeaderFile
{
    public class UiItems : UiItemsAnimation
    {

        public WindowMain mainWindow;

        public UCMainPage uCMainPage { get; set; }
        public UCVListPage uCVListPage { get; set; }
        public UCAVehiclePage uCAVehiclePage { get; set; }
        public UCAAccountPage uCAAccountPage { get; set; }
        public UCOperationReceipt uCOperationReceipt { get; set; }
        public UCStatisticPage uCStatisticPage { get; set; }

        public UiItems()
        {
            uCMainPage = new UCMainPage();
            uCVListPage = new UCVListPage();
            uCAVehiclePage = new UCAVehiclePage();
            uCAAccountPage = new UCAAccountPage();
            uCOperationReceipt = new UCOperationReceipt();
            uCStatisticPage = new UCStatisticPage();

            uCMainPage.Visibility = System.Windows.Visibility.Hidden;
            uCVListPage.Visibility = System.Windows.Visibility.Hidden;
            uCAVehiclePage.Visibility = System.Windows.Visibility.Hidden;
            uCAAccountPage.Visibility = System.Windows.Visibility.Hidden;
            uCOperationReceipt.Visibility = System.Windows.Visibility.Hidden;
            uCStatisticPage.Visibility = System.Windows.Visibility.Hidden;

            
        }

        public void childrenAdd()
        {
            mainWindow.MainGrid.Children.Add(uCMainPage);
            mainWindow.MainGrid.Children.Add(uCVListPage);
            mainWindow.MainGrid.Children.Add(uCAVehiclePage);
            mainWindow.MainGrid.Children.Add(uCAAccountPage);
            mainWindow.MainGrid.Children.Add(uCOperationReceipt);
            mainWindow.MainGrid.Children.Add(uCStatisticPage);

            uCMainPage.mainWindow = mainWindow;
            uCVListPage.mainWindow = mainWindow;
        }
    }
}
