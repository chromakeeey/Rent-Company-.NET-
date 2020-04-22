using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Data.SqlClient;

namespace WCF_Rent.HeaderFile
{

    public class CashVoucher
    {
        public int Id { get; private set; }

        public string Company { get; private set; }

        public string Street { get; private set; }

        public string User { get; private set; }

        public string Vehicle { get; private set; }
 
        public float Price { get; private set; }


        public DateTime Date { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime FinalDate { get; private set; }

        public CashVoucher()
        {
            this.Id = 0;
            this.Company = "INVALID";
            this.Street = "INVALID";
            this.User = "INVALID";
            this.Vehicle = "INVALID";
            this.Price = 0;
            this.Date = DateTime.Now;
            this.StartDate = DateTime.Now;
            this.FinalDate = DateTime.Now;
        }

        public CashVoucher(int Id, string Company, string Street, string User, string Vehicle, float Price, 
            DateTime Date, DateTime StartDate, DateTime FinalDate)
        {
            this.Id = Id;
            this.Company = Company;
            this.Street = Street;
            this.User = User;
            this.Vehicle = Vehicle;
            this.Price = Price;
            this.Date = Date;
            this.StartDate = StartDate;
            this.FinalDate = FinalDate;
        }

        public static CashVoucher readCashVoucher(int Id, SqlConnection sqlConnection)
        {
            try
            {
                CashVoucher cashVoucher = new CashVoucher();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [cashvoucher] WHERE id = @id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", Id);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    cashVoucher = new CashVoucher(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToString(reader["company"]),
                        Convert.ToString(reader["street"]),
                        Convert.ToString(reader["user"]),
                        Convert.ToString(reader["vehicle"]),
                        Convert.ToSingle(reader["price"]),
                        Convert.ToDateTime(reader["date"]),
                        Convert.ToDateTime(reader["datestart"]),
                        Convert.ToDateTime(reader["dateend"])
                    );

                    break;
                }

                if (reader != null)
                    reader.Close();

                return cashVoucher;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new CashVoucher();
        }


    }
}
