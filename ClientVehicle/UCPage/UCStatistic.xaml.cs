using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using ClientVehicle.Dialogs.CustomDefaultDialog;
using ClientVehicle.Dialogs.DialogsStatistic;
using ClientVehicle.Dialogs.Receipts;
using ClientVehicle.Header;
using ClientVehicle.ServerReference;

namespace ClientVehicle.UCPage
{
    public enum StatisticPage
    {
        Invalid = 0,
        Year = 1,
        Month = 2,
        Week = 3,
        Day = 4,
        Custom = 5
    }

    /// <summary>
    /// Interaction logic for UCStatistic.xaml
    /// </summary>
    public partial class UCStatistic : System.Windows.Controls.UserControl
    {
        public StatisticPage Page = StatisticPage.Invalid;

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

        public StatInfo ItemNow = null;

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

        public void SetStatisticPage(StatisticPage Page)
        {
            if (this.Page == Page)
                return;

            if (Page == StatisticPage.Year)
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

                label_YearDate.Text = $"{ItemYear.StartDate.ToShortDateString()} - {ItemYear.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemYear);
            }

            if (Page == StatisticPage.Month)
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

                label_MonthDate.Text = $"{ItemMonth.StartDate.ToShortDateString()} - {ItemMonth.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemMonth);
            }

            if (Page == StatisticPage.Week)
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

                label_WeekDate.Text = $"{ItemWeek.StartDate.ToShortDateString()} - {ItemWeek.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemWeek);
            }

            if (Page == StatisticPage.Day)
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

                label_DayDate.Text = $"{ItemDay.StartDate.ToShortDateString()} - {ItemDay.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemDay);
            }

            if (Page == StatisticPage.Custom)
            {
                if (ItemCustom == null)
                {
                    if (CustomDate.Show() == Dialogs.CustomDefaultDialog.DialogResult.Ok)
                    {
                        ItemCustom = Client.Server.ConnectProvider.SendStatInfo(
                            CustomDate.GetStartDate(),
                            CustomDate.GetFinalDate()
                        );
                    }
                    else return;
                }

                label_CustomDate.Text = $"{ItemCustom.StartDate.ToShortDateString()} - {ItemCustom.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemCustom);
            }

            DeactiveActiveButton();

            this.Page = Page;
            ActiveDeactiveButton();
        }

        private void ActiveDeactiveButton()
        {
            if (this.Page == StatisticPage.Invalid)
                return;

            if (Page == StatisticPage.Year)
            {
                border_Year.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
                label_YearDate.Foreground = Brushes.Black;
                label_button_Year.Foreground = Brushes.Black;
            }

            if (Page == StatisticPage.Month)
            {
                border_Month.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
                label_MonthDate.Foreground = Brushes.Black;
                label_button_Month.Foreground = Brushes.Black;
            }

            if (Page == StatisticPage.Week)
            {
                border_Week.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
                label_WeekDate.Foreground = Brushes.Black;
                label_button_Week.Foreground = Brushes.Black;
            }

            if (Page == StatisticPage.Day)
            {
                border_Day.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
                label_DayDate.Foreground = Brushes.Black;
                label_button_Day.Foreground = Brushes.Black;
            }

            if (Page == StatisticPage.Custom)
            {
                border_Custom.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
                label_CustomDate.Foreground = Brushes.Black;
                label_button_Custom.Foreground = Brushes.Black;
            }
        }

        private void DeactiveActiveButton()
        {
            if (this.Page == StatisticPage.Invalid)
                return;

            if (Page == StatisticPage.Year)
            {
                border_Year.Background = Brushes.White;
                label_YearDate.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
                label_button_Year.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
            }

            if (Page == StatisticPage.Month)
            {
                border_Month.Background = Brushes.White;
                label_MonthDate.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
                label_button_Month.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
            }

            if (Page == StatisticPage.Week)
            {
                border_Week.Background = Brushes.White;
                label_WeekDate.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
                label_button_Week.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
            }

            if (Page == StatisticPage.Day)
            {
                border_Day.Background = Brushes.White;
                label_DayDate.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
                label_button_Day.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
            }

            if (Page == StatisticPage.Custom)
            {
                border_Custom.Background = Brushes.White;
                label_CustomDate.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
                label_button_Custom.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 165, 182));
            }
        }

        public void SetStatInfo(StatInfo Item)
        {
            ItemNow = Item;

            GridStatistic.Opacity = 0;

            label_Count.Text = Item.StatVehicles.Length.ToString();

            var noCreditCounter = (from i in Item.StatVehicles.ToList() where i.Credit == 0 select i).ToList();
            label_CountNoCredit.Text = noCreditCounter.Count.ToString();

            float Profit = 0,
                  Credit = 0;

            foreach (StatVehicleInfo i in Item.StatVehicles)
            {
                Profit += i.Payment;
                Profit -= i.Returning;

                Credit += i.Credit;
            }

            label_ProfitNoCredit.Text = $"₴ {String.Format("{0:n0}", Profit)}";
            label_ProfitCredit.Text = $"₴ {String.Format("{0:n0}", Credit)}";
            label_ProfitCount.Text = $"₴ {String.Format("{0:n0}", Profit + Credit)}";

            string Date = DateTime.Now.ToString();
            label_Balance.Text = $"₴ {String.Format("{0:n0}", Item.TotalBalance)}";
            label_DateBalance.Text = $"на {Date}";

            float plusMoney = 0,
                  minusMoney = 0;

            foreach(StatBalanceInfo i in Item.StatBalances)
            {
                if (i.Value < 0)
                {
                    minusMoney += i.Value;
                }
                else
                {
                    plusMoney += i.Value;
                }
            }

            label_PlusBalance.Text = $"₴ {String.Format("{0:n0}", plusMoney)}";
            label_MinusBalance.Text = $"₴ {String.Format("{0:n0}", minusMoney)}";

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((GridStatistic.Opacity += 0.02d) == 1) timer.Stop();
            });

            timer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            timer.Start();
        }

        private void onClickYear(object sender, RoutedEventArgs e)
        {
            SetStatisticPage(StatisticPage.Year);
        }

        private void onClickMonth(object sender, RoutedEventArgs e)
        {
            SetStatisticPage(StatisticPage.Month);
        }

        private void onClickWeek(object sender, RoutedEventArgs e)
        {
            SetStatisticPage(StatisticPage.Week);
        }

        private void onClickDay(object sender, RoutedEventArgs e)
        {
            SetStatisticPage(StatisticPage.Day);
        }

        private void onClickCustom(object sender, RoutedEventArgs e)
        {
            SetStatisticPage(StatisticPage.Custom);
        }

        private void onClickTakeNewCustomDate(object sender, RoutedEventArgs e)
        {
            if (CustomDate.Show() == Dialogs.CustomDefaultDialog.DialogResult.Ok)
            {
                ItemCustom = Client.Server.ConnectProvider.SendStatInfo(
                    CustomDate.GetStartDate(),
                    CustomDate.GetFinalDate()
                );

                label_CustomDate.Text = $"{ItemCustom.StartDate.ToShortDateString()} - {ItemCustom.FinalDate.ToShortDateString()}";
                SetStatInfo(ItemCustom);

                DeactiveActiveButton();
                this.Page = StatisticPage.Custom;
                ActiveDeactiveButton();
            }


        }

        private void onClickExportExcel(object sender, RoutedEventArgs e)
        {
            if (ItemNow == null)
            {
                DialogWindow.Show("Ви не вибрал статистику.", "Відмова", DialogButtons.Ok, DialogStyle.Error);
                return;
            }

            var DirectoryDialog = new FolderBrowserDialog();

            if (DirectoryDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Directory = DirectoryDialog.SelectedPath;

                if (!ExcelOperation.IsValidTemplate(ExcelTemplate.Rent))
                    DialogWindow.Show("Статистика про оренду тарнспортнів не буде експортована. Шаблон не було знайдено.", "Відмова", DialogButtons.Ok, DialogStyle.Error);

                if (!ExcelOperation.IsValidTemplate(ExcelTemplate.Balance))
                    DialogWindow.Show("Статистика про операцій з рахунком не буде експортована. Шаблон не було знайдено.", "Відмова", DialogButtons.Ok, DialogStyle.Error);

                ExcelOperation.Export(ItemNow, Directory);

                DialogWindow.Show("Ви успішно експортували статистику.", "Успішно", DialogButtons.Ok, DialogStyle.Information);
            }
        }
    }
}
