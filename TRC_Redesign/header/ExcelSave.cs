using System;
using System.IO;
using TRC_Redesign.ServiceRent;

using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;

namespace TRC_Redesign.header
{
    public static class ExcelSave
    {
        private const string path_UserTemplate = @"user.xlsx";

        public const int UserTemplate = 0;

        public static bool isTemplateValid(int templateid)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            switch (templateid)
            {
                case 0: path += @"exceltemplate\" + path_UserTemplate; break;
            }

            return File.Exists(path);
        }

        private static FileInfo templateInfo(int templateid)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            switch (templateid)
            {
                case 0: path += @"exceltemplate\" + path_UserTemplate; break;
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
    }
}
