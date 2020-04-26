using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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

            path = localPath() + "cashvoucher.dat";
        }

        private static string localPath()
        {
            string localpath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            int endpos = localpath.Length;
            int startpos = 0;

            for (int i = localpath.Length - 1; i > -1; i--)
            {
                if (localpath[i] == 'W')
                {
                    startpos = i;

                    break;
                }
            }

            //localpath.Remove(startpos, endpos - startpos);

            return localpath.Remove(startpos, endpos - startpos);
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

        public int addCashVoucher(string user, string vehicle, DateTime dateStart, DateTime dateFinal, float price, SqlConnection sqlConnection)
        {
            int modified = -1;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [cashvoucher] (company, street, [user], vehicle, datestart, dateend, price, date) OUTPUT INSERTED.ID VALUES" +
                   "(@company, @street, @user, @vehicle, @datestart, @dateend, @price, @date)", sqlConnection))
                {
      
                    sqlCommand.Parameters.AddWithValue("company", this.companyName);
                    sqlCommand.Parameters.AddWithValue("street", this.streetName);
                    sqlCommand.Parameters.AddWithValue("user", user);
                    sqlCommand.Parameters.AddWithValue("vehicle", vehicle);
                    sqlCommand.Parameters.AddWithValue("datestart", dateStart);
                    sqlCommand.Parameters.AddWithValue("dateend", dateFinal);
                    sqlCommand.Parameters.AddWithValue("price", price);
                    sqlCommand.Parameters.AddWithValue("date", DateTime.Now);

                    ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, sqlCommand.CommandText);
                    

                    sqlCommand.ExecuteNonQuery();
                    modified = (int)sqlCommand.ExecuteScalar();
                }
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString() + " LINE: " + ex.LineNumber.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return modified;
        }
    }
}
