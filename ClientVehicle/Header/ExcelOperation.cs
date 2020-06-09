
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using ClientVehicle.Header;
using ClientVehicle.ServerReference;

using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System.Windows;

namespace ClientVehicle.Header
{
    public enum ExcelTemplate
    {
        Invalid = 0,
        Rent = 1,
        Balance = 2
    }

    public static class ExcelOperation
    {
        public static void Export(StatInfo Item, string Directory)
        {
            ExportRent(Item, Directory);
            ExportBalance(Item, Directory);
        }

        private static void ExportRent(StatInfo Item, string Directory)
        {
            if (!IsValidTemplate(ExcelTemplate.Rent))
                return;

            FileInfo Template = ReadTemplate(ExcelTemplate.Rent);

            string name = $"RentStory_{Item.StartDate.ToShortDateString()}_{Item.FinalDate.ToShortDateString()}";
            string path = $"{Directory}\\{name}.xlsx";     

            using (ExcelPackage excelPackage = new ExcelPackage(Template, true))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet list = excelPackage.Workbook.Worksheets[0];

                int row = 3;

                foreach (StatVehicleInfo item in Item.StatVehicles)
                {
                    list.Cells[row, 1].Value = item.VIN;
                    list.Cells[row, 2].Value = item.Vehicle.Name + " " + item.Vehicle.Model;
                    list.Cells[row, 3].Value = item.RentStartDate.ToString();
                    list.Cells[row, 4].Value = item.RentFinalDate.ToString();
                    list.Cells[row, 5].Value = item.User.Surname + " " + item.User.Name;
                    list.Cells[row, 6].Value = item.Payment;
                    list.Cells[row, 7].Value = item.Returning == 0 ? 0 : -(item.Returning);
                    list.Cells[row, 8].Value = item.Credit;

                    row++;
                }

                string header = String.Format("Історія оренд транспортних засобів ({0} - {1})", Item.StartDate.ToShortDateString(), Item.FinalDate.ToShortDateString());
                list.Cells[1, 1].Value = header;

                Byte[] bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }

        private static void ExportBalance(StatInfo Item, string Directory)
        {
            if (!IsValidTemplate(ExcelTemplate.Balance))
                return;

            FileInfo Template = ReadTemplate(ExcelTemplate.Balance);

            string name = $"BalanceStory_{Item.StartDate.ToShortDateString()}_{Item.FinalDate.ToShortDateString()}";
            string path = $"{Directory}\\{name}.xlsx";

            using (ExcelPackage excelPackage = new ExcelPackage(Template, true))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet list = excelPackage.Workbook.Worksheets[0];

                int row = 3;

                foreach (StatBalanceInfo item in Item.StatBalances)
                {
                    list.Cells[row, 1].Value = item.Id;
                    list.Cells[row, 2].Value = item.User.Login;
                    list.Cells[row, 3].Value = item.User.Surname + " " + item.User.Name;
                    list.Cells[row, 4].Value = item.CardNumber;
                    list.Cells[row, 5].Value = item.DateNow.ToString(); 
                    list.Cells[row, 6].Value = item.Value == 0 ? 0 : -(item.Value);

                    row++;
                }

                string header = String.Format("Історія операцій з рахунком ({0} - {1})", Item.StartDate.ToShortDateString(), Item.FinalDate.ToShortDateString());
                list.Cells[1, 1].Value = header;

                Byte[] bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }

        private static FileInfo ReadTemplate(ExcelTemplate Template)
        {
            return new FileInfo(
                GetTemplatePath(Template)
            );
        }

        public static bool IsValidTemplate(ExcelTemplate Template)
        {
            return File.Exists(
                GetTemplatePath(Template)
            );
        }

        private static string GetTemplatePath(ExcelTemplate Template)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            if (Template == ExcelTemplate.Rent)
            {
                //System.Windows.MessageBox.Show(path + @"templates\\rent.xlsx");
                return path + @"templates\\rent.xlsx";
            }

            if (Template == ExcelTemplate.Balance)
            {
                return path + @"templates\\balance.xlsx";
            }

            return "null";
        }
    }
}
