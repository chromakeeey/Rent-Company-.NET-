using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;

using WCF_Rent.Providers;

namespace WCF_Rent.HeaderFile
{
    public class CashVoucherData
    {
        public string companyName;
        public string streetName;
        public string path;

        public CashVoucherData()
        {
            companyName = "Rent Company";
            streetName = "None street";

            path = Log.AppPath + "\\cashvoucher.dat";
        }

        public void readCashVoucher()
        {
            List<CashVoucherData> checkData = new List<CashVoucherData>();
            checkData.Add(this);

            File.WriteAllText(path, new JavaScriptSerializer().Serialize(checkData));
        }

        public void writeCashVoucher()
        {
            if (File.Exists(path))
            {
                List<CashVoucherData> checkData = new List<CashVoucherData>();

                checkData = new JavaScriptSerializer().Deserialize<List<CashVoucherData>>(File.ReadAllText(path));

                this.companyName = checkData[0].companyName;
                this.streetName = checkData[0].streetName;
            }
        }

        public int AddCashVoucher(string User, string Vehicle, DateTime StartDate, DateTime FinalDate, float Price)
        {
            int modified = -1;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [cashvoucher] (company, street, [user], vehicle, datestart, dateend, price, date) OUTPUT INSERTED.ID VALUES" +
                   "(@company, @street, @user, @vehicle, @datestart, @dateend, @price, @date)", SqlData.sqlConnection))
                {
      
                    sqlCommand.Parameters.AddWithValue("company", this.companyName);
                    sqlCommand.Parameters.AddWithValue("street", this.streetName);
                    sqlCommand.Parameters.AddWithValue("user", User);
                    sqlCommand.Parameters.AddWithValue("vehicle", Vehicle);
                    sqlCommand.Parameters.AddWithValue("datestart", StartDate);
                    sqlCommand.Parameters.AddWithValue("dateend", FinalDate);
                    sqlCommand.Parameters.AddWithValue("price", Price);
                    sqlCommand.Parameters.AddWithValue("date", DateTime.Now);

                    
                    sqlCommand.ExecuteNonQuery();
                    modified = (int)sqlCommand.ExecuteScalar();
                }
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString() + " LINE: " + ex.LineNumber.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return modified;
        }
    }
}
