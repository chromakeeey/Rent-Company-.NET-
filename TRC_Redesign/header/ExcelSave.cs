using System;
using System.IO;
using TRC_Redesign.ServiceRent;

using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System.Collections.Generic;

namespace TRC_Redesign.header
{
    public static class ExcelSave
    {
        private const string path_UserTemplate = @"user.xlsx";
        private const string path_RentTemplate = @"rent.xlsx";

        public const int UserTemplate = 0;
        public const int RentTemplate = 1;

        public static bool isTemplateValid(int templateid)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            switch (templateid)
            {
                case 0: path += @"exceltemplate\" + path_UserTemplate; break;
                case 1: path += @"exceltemplate\" + path_RentTemplate; break;
            }

            return File.Exists(path);
        }

        private static FileInfo templateInfo(int templateid)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            switch (templateid)
            {
                case 0: path += @"exceltemplate\" + path_UserTemplate; break;
                case 1: path += @"exceltemplate\" + path_RentTemplate; break;
            }

            FileInfo fileInfo = new FileInfo(path);

            return fileInfo;
        }

        public static void exportAccount(string path, Account[] account)
        {
            FileInfo fileInfo = templateInfo(UserTemplate);

            Account[] tmpAccount = account;
            int tmp_index = 0;
            for (int i = account.Length - 1; i != -1; i--)
            {
                if (tmp_index <= 20)
                {
                    account[tmp_index] = tmpAccount[i];
                    tmp_index++;

                    continue;
                }

                break;
            }

            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo, true))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet list = excelPackage.Workbook.Worksheets[0];

                for (int i = 0; i < account.Length; i++)
                {
                    if (i < 20)
                    {
                        list.Cells[i + 3, 1].Value = (i + 1).ToString();
                        list.Cells[i + 3, 2].Value = account[i].login;
                        list.Cells[i + 3, 3].Value = account[i].secondname;
                        list.Cells[i + 3, 4].Value = account[i].name;
                        list.Cells[i + 3, 5].Value = account[i].fathername;
                        list.Cells[i + 3, 6].Value = account[i].dateCreate.ToString();
                        list.Cells[i + 3, 7].Value = account[i].totalMoney.ToString() + " грн.";

                        list.Cells[2, 9].Value = DateTime.Now.ToString();

                        continue;
                    }

                    break;
                }

                Byte[] bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }

        public static void exportRent(string path, StatVehicleInfo[] statVehicles, DateTime startDate, DateTime endDate)
        {
            FileInfo fileInfo = templateInfo(RentTemplate);

            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo, true))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet list = excelPackage.Workbook.Worksheets[0];

                int row = 3;

                foreach (StatVehicleInfo item in statVehicles)
                {
                    list.Cells[row, 1].Value = item.VIN;
                    list.Cells[row, 2].Value = item.vehicle.name + " " + item.vehicle.model;
                    list.Cells[row, 3].Value = item.rent_startDate.ToString();
                    list.Cells[row, 4].Value = item.rent_endDate.ToString();
                    list.Cells[row, 5].Value = item.account.secondname + " " + item.account.name + " " + item.account.fathername;
                    list.Cells[row, 6].Value = item.payment;
                    list.Cells[row, 7].Value = item.returning == 0 ? 0 : -(item.returning);
                    list.Cells[row, 8].Value = item.credit;

                    row++;
                }

                string header = String.Format("Історія оренд транспортних засобів ({0} - {1})", startDate.ToShortDateString(), endDate.ToShortDateString());
                list.Cells[1, 1].Value = header;

                Byte[] bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }
    }
}
