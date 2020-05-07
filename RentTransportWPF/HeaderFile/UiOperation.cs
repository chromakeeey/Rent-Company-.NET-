using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace RentTransportWPF.HeaderFile
{
    public class UiOperation : UiItems
    {
        private int _oldpage;
        private int _page;

        public int Page
        {
            get { return _page; }

            set 
            {
                if (value == _page)
                    return;

                _oldpage = _page;
                _page = value;
                
                updateActivePage();
            }
        }

        public UiOperation()
        {
            _oldpage = -1;
            _page = -1;
             
        }

        public UiOperation(WindowMain mainWindow)
        {
            _oldpage = -1;
            _page = -1;

            this.mainWindow = mainWindow;
        }

        private void updateActivePage()
        {
            hideActivePage();


            switch (_page)
            {
                case UiPageType.MAIN:
                    uCMainPage.Visibility = System.Windows.Visibility.Visible;
                    break;

                case UiPageType.VEHICLE:
                    uCVListPage.Visibility = System.Windows.Visibility.Visible;
                    break;

                case UiPageType.OVEHICLE:
                    uCAVehiclePage.Visibility = System.Windows.Visibility.Visible;
                    break;

                case UiPageType.OUSER:
                    uCAAccountPage.Visibility = System.Windows.Visibility.Visible;
                    break;

                case UiPageType.RECEIPT:
                    uCOperationReceipt.Visibility = System.Windows.Visibility.Visible;
                    break;

                case UiPageType.CHART:
                    uCStatisticPage.Visibility = System.Windows.Visibility.Visible;
                    break;

                    /*case UiPageType.SETTING:
                        .Visibility = System.Windows.Visibility.Hidden;
                        break;*/
            }

            updateActiveButton();
        }
        
        private void hideActivePage()
        {
            switch (_oldpage)
            {
                case UiPageType.MAIN:
                    uCMainPage.Visibility = System.Windows.Visibility.Hidden;
                    break;

                case UiPageType.VEHICLE:
                    uCVListPage.Visibility = System.Windows.Visibility.Hidden;
                    break;

                case UiPageType.OVEHICLE:
                    uCAVehiclePage.Visibility = System.Windows.Visibility.Hidden;
                    break;

                case UiPageType.OUSER:
                    uCAAccountPage.Visibility = System.Windows.Visibility.Hidden;
                    break;

                case UiPageType.RECEIPT:
                    uCOperationReceipt.Visibility = System.Windows.Visibility.Hidden;
                    break;

                case UiPageType.CHART:
                    uCStatisticPage.Visibility = System.Windows.Visibility.Hidden;
                    break;

                /*case UiPageType.SETTING:
                    .Visibility = System.Windows.Visibility.Hidden;
                    break;*/
            }

            
        }

        private void hideActiveButton()
        {
            switch (_oldpage)
            {
                case UiPageType.MAIN:
                    mainWindow.buttonMain.Background = Brushes.Transparent;
                    break;

                case UiPageType.VEHICLE:
                    mainWindow.buttonVehicle.Background = Brushes.Transparent;
                    break;

                case UiPageType.OVEHICLE:
                    mainWindow.buttonOVehicle.Background = Brushes.Transparent;
                    break;

                case UiPageType.OUSER:
                    mainWindow.buttonOUser.Background = Brushes.Transparent;
                    break;

                case UiPageType.RECEIPT:
                    mainWindow.buttonReceipt.Background = Brushes.Transparent;
                    break;

                case UiPageType.CHART:
                    mainWindow.buttonChart.Background = Brushes.Transparent;
                    break;

                    /*case UiPageType.SETTING:
                        .Visibility = System.Windows.Visibility.Hidden;
                        break;*/
            }

            

        }

        private void updateActiveButton()
        {
            hideActiveButton();

            switch (_page)
            {
                case UiPageType.MAIN:
                    mainWindow.buttonMain.Background = Brushes.LightGray;
                    break;

                case UiPageType.VEHICLE:
                    mainWindow.buttonVehicle.Background = Brushes.LightGray;
                    break;

                case UiPageType.OVEHICLE:
                    mainWindow.buttonOVehicle.Background = Brushes.LightGray;
                    break;

                case UiPageType.OUSER:
                    mainWindow.buttonOUser.Background = Brushes.LightGray;
                    break;

                case UiPageType.RECEIPT:
                    mainWindow.buttonReceipt.Background = Brushes.LightGray;
                    break;

                case UiPageType.CHART:
                    mainWindow.buttonChart.Background = Brushes.LightGray;                    
                    break;

                    /*case UiPageType.SETTING:
                        .Visibility = System.Windows.Visibility.Hidden;
                        break;*/
            }
        }

    }
}
