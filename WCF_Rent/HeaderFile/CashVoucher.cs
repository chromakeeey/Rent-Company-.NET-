﻿using System;
using System.Data.SqlClient;
using System.Runtime.Serialization;

using WCF_Rent.Providers;

namespace WCF_Rent.HeaderFile
{

    [DataContract]
    public class CashVoucher
    {
        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Company { get; private set; }

        [DataMember]
        public string Street { get; private set; }

        [DataMember]
        public string User { get; private set; }

        [DataMember]
        public string Vehicle { get; private set; }

        [DataMember]
        public float Price { get; private set; }

        [DataMember]
        public DateTime Date { get; private set; }

        [DataMember]
        public DateTime StartDate { get; private set; }

        [DataMember]
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

        public static CashVoucher ReadCashVoucher(int Id)
        {
            try
            {
                CashVoucher cashVoucher = new CashVoucher();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [cashvoucher] WHERE id = @id", SqlData.sqlConnection);
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

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new CashVoucher();
        }


    }
}
