using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

using TRC_Redesign.ServiceRent;
using TRC_Redesign.header;

using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System.IO;

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCStatClient : UserControl
    {
        public Form1 mainWindow;
        private List<UCClientInfo> ucClients = new List<UCClientInfo>();

        public Account[] account;
        public int length = 0;
        private int yCoord = 0;
        private int top = 1;

        public void updateTop()
        {
            yCoord = 0;
            top = 1;

            foreach(var item in ucClients) { item.Visible = false; }
            ucClients.Clear();

            for (int i = length - 1; i != -1; i--)
            {
                if (top > 20)
                    break;

                ucClients.Add(new UCClientInfo());
                int index = ucClients.Count - 1;

                ucClients[index].setAccount(account[i], top);
                ucClients[index].Location = new Point(47, yCoord);
                ucClients[index].Parent = location_panel;
                ucClients[index].Size = new Size(694, 59);
                ucClients[index].Visible = true;

                yCoord += 70;
                top++;
            }
        }

        public void updateAccounts()
        {
            account = mainWindow.serverData.client.topAccountMoney();
            length = account.Length;
        }

        public UCStatClient()
        {
            InitializeComponent();

        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            if (!ExcelSave.isTemplateValid(ExcelSave.UserTemplate))
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
                ExcelSave.exportAccount(saveDialog.FileName, account);

                mainWindow.dialogCreate("Ви успішно створили Excel-документ", "Збереження Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }


      
    }
}
