using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using TRC_Redesign.ServiceRent;
using TRC_Redesign.RentPicker;
using TRC_Redesign.header;

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCMoneyStat : UserControl
    {
        public Form1 mainWindow;
        private int radius = 20;
        private int terminedate = -1;

        private Color selectedColor = Color.FromArgb(187, 134, 252);
        private Color defaultColor = Color.FromArgb(40, 40, 40);

        public StatInfo stat_Year;
        public StatInfo stat_Month;
        public StatInfo stat_Week;
        public StatInfo stat_Custom;

        public bool customUpdate;

        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.roundedCorners();
            }
        }

        private void roundPanel(Panel panel)
        {
            var bounds = panel.ClientRectangle;

            bounds.Width--;
            bounds.Height--;

            using (var path = GetRoundRectagle(bounds, this.Radius))
                panel.Region = new Region(path);

            panel.Invalidate();
        }

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }



        private void roundedCorners()
        {
            roundPanel(pnl_year);
            roundPanel(pnl_month);
            roundPanel(pnl_week);
            roundPanel(pnl_custom);
        }

        public UCMoneyStat()
        {
            InitializeComponent();

            Radius = 30;
            terminedate = -1;
            customUpdate = false;
        }

        public void setTimeButton(int id)
        {
            if (terminedate == id)
                return;

            pnl_year.BackColor = defaultColor;
            pnl_month.BackColor = defaultColor;
            pnl_week.BackColor = defaultColor;
            pnl_custom.BackColor = defaultColor;

            switch (id)
            {
                case 0: pnl_year.BackColor = selectedColor; break;
                case 1: pnl_month.BackColor = selectedColor; break;
                case 2: pnl_week.BackColor = selectedColor; break;
                case 3: pnl_custom.BackColor = selectedColor; break;
            }

            terminedate = id;
        }

        public void setStatObject(StatInfo statInfo)
        {
            lbl_vehcount.Text = statInfo.statVehicles.Length.ToString() + " шт.";

            float profit = 0;
            float credit = 0;

            foreach (StatVehicleInfo item in statInfo.statVehicles)
            {
                profit += item.payment;
                profit -= item.returning;

                credit += item.credit;
            }

            lbl_salary.Text = profit.ToString() + " грн.";
            lbl_credit.Text = credit.ToString() + " грн.";

            lbl_allmoney.Text = (profit + credit).ToString() + " грн.";
            lbl_balanceall.Text = statInfo.totalbalance.ToString() + " грн.";

            lbl_dates.Text = statInfo.startDate.ToShortDateString() + " по " + statInfo.endDate.ToShortDateString();
        }

        private void lbl_year_Click(object sender, EventArgs e)
        {

            if (DateTime.Now > mainWindow.clientData.ui.year_LastUpdate.AddMinutes(10))
            {
                stat_Year = mainWindow.serverData.client.SendStatInfo(DateTime.Now.AddDays(-365), DateTime.Now);
                mainWindow.clientData.ui.year_LastUpdate = DateTime.Now;

                mainWindow.clientData.showPanelMessage("Статистика за рік оновлена. (кожні 10 хв.)");
            }

            setTimeButton(0);
            setStatObject(stat_Year);
        }

        private void lbl_month_Click(object sender, EventArgs e)
        {

            if (DateTime.Now > mainWindow.clientData.ui.month_LastUpdate.AddMinutes(10))
            {
                stat_Month = mainWindow.serverData.client.SendStatInfo(DateTime.Now.AddDays(-30), DateTime.Now);
                mainWindow.clientData.ui.month_LastUpdate = DateTime.Now;

                mainWindow.clientData.showPanelMessage("Статистика за місяць оновлена. (кожні 10 хв.)");
            }

            setTimeButton(1);
            setStatObject(stat_Month);
        }

        private void lbl_week_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > mainWindow.clientData.ui.week_LastUpdate.AddMinutes(10))
            {
                stat_Week = mainWindow.serverData.client.SendStatInfo(DateTime.Now.AddDays(-7), DateTime.Now);
                mainWindow.clientData.ui.week_LastUpdate = DateTime.Now;

                mainWindow.clientData.showPanelMessage("Статистика за тиждень оновлена. (кожні 10 хв.)");
            }

            setTimeButton(2);
            setStatObject(stat_Week);
        }

        private void lbl_custom_Click(object sender, EventArgs e)
        {
         
            if (!customUpdate)
            {
                DateTime startDate;
                DateTime endDate;

                startDate = RentDatePicker.Show("Виберіть початкову дату.", "Вибір дати", new DateTime(), DateTime.Now.AddDays(1));
                endDate = RentDatePicker.Show("Виберіть кінцеву дату.", "Вибір дати", new DateTime(), DateTime.Now.AddDays(1));

                stat_Custom = mainWindow.serverData.client.SendStatInfo(startDate, endDate);
                setStatObject(stat_Custom);

                customUpdate = true;
            }

            setTimeButton(3);
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            startDate = RentDatePicker.Show("Виберіть початкову дату.", "Вибір дати", new DateTime(), DateTime.Now.AddDays(1));
            endDate = RentDatePicker.Show("Виберіть кінцеву дату.", "Вибір дати", new DateTime(), DateTime.Now.AddDays(1));

            stat_Custom = mainWindow.serverData.client.SendStatInfo(startDate, endDate);
            setStatObject(stat_Custom);
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            if (!ExcelSave.isTemplateValid(ExcelSave.RentTemplate))
            {
                mainWindow.dialogCreate("Сталась помилка!\n Не було знайдено шаблоний файл user.xslx",
                    "Помилка шаблону", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Excel Files | *.xlsx";
            saveDialog.DefaultExt = "xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                switch (terminedate)
                {
                    case 0: ExcelSave.exportRent(saveDialog.FileName, stat_Year.statVehicles, stat_Year.startDate, stat_Year.endDate); break;
                    case 1: ExcelSave.exportRent(saveDialog.FileName, stat_Month.statVehicles, stat_Month.startDate, stat_Month.endDate); break;
                    case 2: ExcelSave.exportRent(saveDialog.FileName, stat_Week.statVehicles, stat_Week.startDate, stat_Week.endDate); break;
                    case 3: ExcelSave.exportRent(saveDialog.FileName, stat_Custom.statVehicles, stat_Custom.startDate, stat_Custom.endDate); break;
                }

                //ExcelSave.exportRent(saveDialog.FileName, statInfo.statVehicles, statInfo.startDate, statInfo.endDate);

                mainWindow.dialogCreate("Ви успішно створили Excel-документ", "Збереження Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
