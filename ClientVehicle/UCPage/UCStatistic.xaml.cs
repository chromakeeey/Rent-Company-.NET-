using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ClientVehicle.Dialogs.Receipts;
using ClientVehicle.Header;
using ClientVehicle.ServerReference;

namespace ClientVehicle.UCPage
{
    /// <summary>
    /// Interaction logic for UCStatistic.xaml
    /// </summary>
    public partial class UCStatistic : UserControl
    {
        public UCStatistic()
        {
            InitializeComponent();
        }

        private void onCheckEditClick(object sender, RoutedEventArgs e)
        {
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Visible;
            new ReceiptEdit().ShowDialog();
            Items.mainWindow.GridBackgroundDialog.Visibility = Visibility.Hidden;
        }

        public StatInfo ItemYear = null;
        public StatInfo ItemMonth = null;
        public StatInfo ItemWeek = null;
        public StatInfo ItemDay = null;
        public StatInfo ItemCustom = null;

        public DateTime ItemYearUpdate;
        public DateTime ItemMonthUpdate;
        public DateTime ItemWeekUpdate;
        public DateTime ItemDayUpdate;
        public DateTime ItemCustomUpdate;

        public void SetStatInfo(StatInfo Item)
        {
            label_Count.Text = Item.StatVehicles.Length.ToString();

            float Profit = 0,
                  Credit = 0;

            foreach (StatVehicleInfo i in Item.StatVehicles)
            {
                Profit += i.Payment;
                Profit -= i.Returning;

                Credit += i.Credit;
            }

            label_ProfitNoCredit.Text = $"₴ {String.Format("{0:n0} км", Profit)}";
            label_ProfitCredit.Text = $"₴ {String.Format("{0:n0} км", Credit)}";
            label_ProfitCount.Text = $"₴ {String.Format("{0:n0} км", Profit + Credit)}";

            string Date = DateTime.Now.ToString();
            label_Balance.Text = $"₴ {String.Format("{0:n0} км", Item.TotalBalance)}";
            label_DateBalance.Text = $"на {Date}";
        }

        private void onClickYear(object sender, RoutedEventArgs e)
        {
            if (ItemYear == null)
            {
                ItemYear = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-365), DateTime.Now);
                ItemYearUpdate = DateTime.Now;
            }
            else
            {
                if (DateTime.Now > ItemYearUpdate.AddMinutes(10))
                {
                    ItemYear = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-365), DateTime.Now);
                    ItemYearUpdate = DateTime.Now;
                }
            }

            SetStatInfo(ItemYear);
        }

        private void onClickMonth(object sender, RoutedEventArgs e)
        {
            if (ItemMonth == null)
            {
                ItemMonth = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-30), DateTime.Now);
                ItemMonthUpdate = DateTime.Now;
            }
            else
            {
                if (DateTime.Now > ItemMonthUpdate.AddMinutes(10))
                {
                    ItemMonth = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-30), DateTime.Now);
                    ItemMonthUpdate = DateTime.Now;
                }
            }

            SetStatInfo(ItemMonth);
        }

        private void onClickWeek(object sender, RoutedEventArgs e)
        {
            if (ItemWeek == null)
            {
                ItemWeek = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-7), DateTime.Now);
                ItemWeekUpdate = DateTime.Now;
            }
            else
            {
                if (DateTime.Now > ItemWeekUpdate.AddMinutes(10))
                {
                    ItemWeek = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-7), DateTime.Now);
                    ItemWeekUpdate = DateTime.Now;
                }
            }

            SetStatInfo(ItemWeek);
        }

        private void onClickDay(object sender, RoutedEventArgs e)
        {
            if (ItemDay == null)
            {
                ItemDay = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-1), DateTime.Now);
                ItemDayUpdate = DateTime.Now;
            }
            else
            {
                if (DateTime.Now > ItemDayUpdate.AddMinutes(10))
                {
                    ItemDay = Client.Server.ConnectProvider.SendStatInfo(DateTime.Now.AddDays(-1), DateTime.Now);
                    ItemDayUpdate = DateTime.Now;
                }
            }

            SetStatInfo(ItemDay);
        }

        private void onClickCustom(object sender, RoutedEventArgs e)
        {

        }
    }
}
