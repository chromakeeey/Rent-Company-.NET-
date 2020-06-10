using System;
using System.Data.SqlClient;
using System.Data;

namespace WCF_Rent.Providers
{
    public static class SqlData
    {
        public static SqlConnection sqlConnection;
        public static string ConnectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|rentcar.mdf;Integrated Security=True";

        public static void InitializeConnection()
        {
            if ( !sqlStatusConnection() )
            {
                try
                {
                    sqlConnection = new SqlConnection(ConnectionPath);
                    sqlConnection.Open();
                }

                catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
                catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
                catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

                Log.Add(LogStyle.Information, "SQL Base connected");
            }    
        }

        public static bool sqlStatusConnection() { return (sqlConnection != null && sqlConnection.State != ConnectionState.Closed); }
    }
}
