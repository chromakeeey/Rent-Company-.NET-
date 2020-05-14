using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ClientVehicle.Header
{
    public enum UIPage
    {
        Main = 0,
        Vehicle = 1,
        AVehicle = 2,
        AUser = 3,
        Statistic = 4,
        Invalid = 5
    }

    public static class UiOperation
    {
        private static UIPage _page = UIPage.Invalid;

        public static void SetPage(UIPage page)
        {
            if (page == _page)
                return;

            HideOldPage(_page);
            ShowNewPage(page);

            _page = page;
        }

        private static void HideOldPage(UIPage item)
        {
            SolidColorBrush color = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));

            switch (item)
            {
                case UIPage.Main:
                    Items.ucMain.Visibility = System.Windows.Visibility.Hidden;
                    Items.mainWindow.iconMain.Foreground = color;
                    break;

                case UIPage.Vehicle:
                    Items.ucVehicle.Visibility = System.Windows.Visibility.Hidden;
                    Items.mainWindow.iconVehicle.Foreground = color;
                    break;

                case UIPage.AVehicle:
                    Items.ucAVehicle.Visibility = System.Windows.Visibility.Hidden;
                    Items.mainWindow.iconAVehicle.Foreground = color;
                    break;

                case UIPage.AUser:
                    Items.ucAUser.Visibility = System.Windows.Visibility.Hidden;
                    Items.mainWindow.iconAUser.Foreground = color;
                    break;

                case UIPage.Statistic:
                    Items.ucStatistic.Visibility = System.Windows.Visibility.Hidden;
                    Items.mainWindow.iconStatistic.Foreground = color;
                    break;
            }
        }

        private static void ShowNewPage(UIPage item)
        {
            SolidColorBrush color = new SolidColorBrush(Color.FromArgb(255, 59, 147, 247));

            switch (item)
            {
                case UIPage.Main:
                    Items.ucMain.Visibility = System.Windows.Visibility.Visible;
                    Items.mainWindow.iconMain.Foreground = color;
                    break;

                case UIPage.Vehicle:
                    Items.ucVehicle.Visibility = System.Windows.Visibility.Visible;
                    Items.mainWindow.iconVehicle.Foreground = color;
                    break;

                case UIPage.AVehicle:
                    Items.ucAVehicle.Visibility = System.Windows.Visibility.Visible;
                    Items.mainWindow.iconAVehicle.Foreground = color;
                    break;

                case UIPage.AUser:
                    Items.ucAUser.Visibility = System.Windows.Visibility.Visible;
                    Items.mainWindow.iconAUser.Foreground = color;
                    break;

                case UIPage.Statistic:
                    Items.ucStatistic.Visibility = System.Windows.Visibility.Visible;
                    Items.mainWindow.iconStatistic.Foreground = color;
                    break;
            }
        }
    }
}
