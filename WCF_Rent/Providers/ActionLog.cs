using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace WCF_Rent.Providers
{
    public static class ActionLog
    {
        public static int TakeRent(int userid, string VIN, float price, int cashVoucherId, DateTime startdate, DateTime enddate)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_takerent] (userid, VIN, price, cashvoucherid, startdate, enddate) OUTPUT INSERTED.ID VALUES" +
                   "(@userid, @VIN, @price, @cashvoucherid, @startdate, @enddate)", SqlData.sqlConnection))
                {

                    sqlCommand.Parameters.AddWithValue("userid", userid);
                    sqlCommand.Parameters.AddWithValue("VIN", VIN);
                    sqlCommand.Parameters.AddWithValue("price", price);
                    sqlCommand.Parameters.AddWithValue("cashvoucherid", cashVoucherId);
                    sqlCommand.Parameters.AddWithValue("startdate", startdate);
                    sqlCommand.Parameters.AddWithValue("enddate", enddate);

                    sqlCommand.ExecuteNonQuery();
                    int modified = (int)sqlCommand.ExecuteScalar();

                    return modified;
                }
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return -1;
        }

        public static void RemoveRent(int userid, int takerentid, DateTime date, float balancereturn, float credit)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_removerent] (userid, takerentid, date, balancereturn, credit) VALUES" +
                   "(@userid, @takerentid, @date, @balancereturn, @credit)", SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("takerentid", takerentid);
                sqlCommand.Parameters.AddWithValue("date", date);
                sqlCommand.Parameters.AddWithValue("balancereturn", balancereturn);
                sqlCommand.Parameters.AddWithValue("credit", credit);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void EditVehicle(int userid, string VIN, string str_params)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_editvehicle] (userid, VIN, params) VALUES" +
                   "(@userid, @VIN, @params)", SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);
                sqlCommand.Parameters.AddWithValue("params", str_params);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void DeleteVehicle(int userid, string VIN, string name)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_deletevehicle] (userid, VIN, name) VALUES" +
                   "(@userid, @VIN, @name)", SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);
                sqlCommand.Parameters.AddWithValue("name", name);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void Balance(int userid, string card, float value)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_balance] (userid, card, value) VALUES" +
                   "(@userid, @card, @value)", SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("card", card);
                sqlCommand.Parameters.AddWithValue("value", value);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void AddVehicle(int userid, string VIN)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_addvehicle] (userid, VIN) VALUES" +
                   "(@userid, @VIN)", SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);

                sqlCommand.ExecuteNonQuery();

            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }
    }
}
