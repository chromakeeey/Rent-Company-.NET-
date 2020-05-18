using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
using System.Drawing;

using WCF_Rent.HeaderFile;
using WCF_Rent.Structures;
using WCF_Rent.Providers;

using System.Web.Hosting;

using System.Drawing.Imaging;
using System.Diagnostics;

namespace WCF_Rent
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceRent : IServiceRent
    {
        public List<Vehicle> vehicle = new List<Vehicle>();
        private List<ServerUser> serverUser = new List<ServerUser>();
        private SqlConnection sqlconnection;

        private CashVoucherData cashVoucherData;

        int nextUserID = 1;
        const string sqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|rentcar.mdf;Integrated Security=True";
        //const string sqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TRC_Redesign\WCF_Rent\rentcar.mdf;Integrated Security=True";

        public ServiceRent()
        {
            Log.AppPath = System.Environment.CurrentDirectory;
            Log.Add(LogStyle.Information, "Server started");

            cashVoucherData = new CashVoucherData();
            cashVoucherData.writeCashVoucher();

            SqlData.InitializeConnection();
        }

        string localPath()
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

        public int userConnect()
        {
            if ( !SqlData.sqlStatusConnection() )
                SqlData.InitializeConnection();

            ServerUser user = new ServerUser()
            {
                ID = nextUserID,
                operationContext = OperationContext.Current
            };

            Log.Add(LogStyle.Information, "ID: " + user.ID.ToString() + " connected");
            serverUser.Add(user);

            return user.ID;
        }

        public void userDisconnect(int id)
        {
            var user = serverUser.FirstOrDefault(i => i.ID == id);
            Log.Add(LogStyle.Information, "ID: " + user.ID.ToString() + " disconnected");

            if (user != null)
                serverUser.Remove(user);
        }

        /*      vehicle block       */

        public void showNotification(int id, string message)
        {
            foreach(var userObject in serverUser)
            {
                var user = serverUser.FirstOrDefault(i => i.ID == id);

                if (user != null)
                {
                    userObject.operationContext.GetCallbackChannel<IServerRentCallback>().sendNotification(message);
                }
            }
        }

        public Vehicle selectVehicle(string VIN)
        {
            return Vehicle.SelectVehicle(VIN);
        }

        public void selectAllVehicle()
        {
            vehicle = Vehicle.SelectAllVehicle();
        }

        public void deleteVehicle(Vehicle item)
        {
            /*foreach (var item in serverUser)
            {
                item.operationContext.GetCallbackChannel<IServerRentCallback>().onSaveVehicle(vehicleObject);
            }*/

            Vehicle.DeleteVehicle(item);
        }

        public void addVehicle(Vehicle item)
        {
            vehicle.Add(item);
            Vehicle.AddVehicle(item);
        }

        public void saveVehicle(Vehicle item)
        {
            int index = vehicle.FindIndex(i => i.VIN == item.VIN);
            vehicle[index] = item;

            Vehicle.SaveVehicle(item);           
        }

        // remastered
        public int GetAllVehicle()
        {
            return vehicle.Count;
        }

        public int GetAllRentVehicle()
        {
            int allvehicle = 0;

            foreach (Vehicle item in vehicle)
            {
                if (item.ClientId == 0)
                    continue;

                allvehicle++;
            }

            return allvehicle;
        }

        public int GetAllNoRentVehicle()
        {
            return this.GetAllVehicle() - this.GetAllRentVehicle();
        }

        //

        public void uploadVehicleImage(byte[] buffer, string name, string extenstion)
        {
            string localpath = localPath();
            string path = String.Format(@"{0}pictures\{1}{2}", localpath, name, extenstion);

            File.WriteAllBytes(path, buffer);
        }

        public byte[] vehicleImage(Vehicle vehicleObject)
        {
            string localpath = localPath();
            string path = String.Format(@"{0}{1}", localpath, vehicleObject.PicturePath);
            string errorpath = String.Format(@"{0}pictures\error_vehicle.png", localpath, vehicleObject.PicturePath);

            try
            {
                byte[] buffer;
                buffer = File.ReadAllBytes(path);

                return buffer;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return File.ReadAllBytes(errorpath);
        }

        public Vehicle findVehicle(string VIN)
        {
            int index = vehicle.FindIndex(i => i.VIN == VIN);
            return vehicle[index];
        }

        public void log_AddVehicle(int userid, string VIN)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_addvehicle] (userid, VIN) VALUES" +
                   "(@userid, @VIN)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);

                sqlCommand.ExecuteNonQuery();

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void log_Balance(int userid, string card, float value)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_balance] (userid, card, value) VALUES" +
                   "(@userid, @card, @value)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("card", card);
                sqlCommand.Parameters.AddWithValue("value", value);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void log_DeleteVehicle(int userid, string VIN, string name)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_deletevehicle] (userid, VIN, name) VALUES" +
                   "(@userid, @VIN, @name)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);
                sqlCommand.Parameters.AddWithValue("name", name);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void log_EditVehicle(int userid, string VIN, string str_params)
        {
            ActionLog.EditVehicle(userid, VIN, str_params);
        }

        public void log_RemoveRent(int userid, int takerentid, DateTime date, float balancereturn, float credit)
        {
            ActionLog.RemoveRent(userid, takerentid, date, balancereturn, credit);
        }

        public int log_TakeRent(int userid, string VIN, float price, int cashVoucherId, DateTime startdate, DateTime enddate)
        {
            return ActionLog.TakeRent(userid, VIN, price, cashVoucherId, startdate, enddate);
        }

        public void log_Request(int admin_userid, int application_userid, int answer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_request] (admin_userid, application_userid, answer) VALUES" +
                   "(@admin_userid, @application_userid, @answer)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("admin_userid", admin_userid);
                sqlCommand.Parameters.AddWithValue("application_userid", application_userid);
                sqlCommand.Parameters.AddWithValue("answer", answer);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public int sendCashVoucherID(int logtakerentid)
        {
            const int INVALID_ID = -1;
            int Id = INVALID_ID;

            try
            {
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [log_takerent] WHERE id = @id", sqlconnection);
                sqlCommand.Parameters.AddWithValue("id", logtakerentid);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    object item = reader["cashvoucherid"];

                    if (item != DBNull.Value && item != null)
                        Id = Convert.ToInt32(item);

                    break;
                }

                if (reader != null)
                    reader.Close();

                return Id;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return INVALID_ID;
        }

        

        public StatInfo SendStatInfo(DateTime startDate, DateTime endDate)
        {
            StatInfo statInfo = new StatInfo();

            statInfo.startDate = startDate;
            statInfo.endDate = endDate;

            statInfo.statBalances = new List<StatBalanceInfo>();
            statInfo.statVehicles = new List<StatVehicleInfo>();

            

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [log_takerent] WHERE startdate > @startDate AND startdate < @endDate", sqlconnection))
                {
                    sqlCommand.Parameters.AddWithValue("startDate", startDate);
                    sqlCommand.Parameters.AddWithValue("endDate", endDate);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    StatVehicleInfo statVehicle = new StatVehicleInfo();

                    while (reader.Read())
                    {
                        statVehicle = new StatVehicleInfo();

                        statVehicle.VIN = Convert.ToString(reader["VIN"]);
                        statVehicle.userid = Convert.ToInt32(reader["userid"]);
                        statVehicle.id = Convert.ToInt32(reader["id"]);
                        statVehicle.payment = Convert.ToInt32(reader["price"]);
                        statVehicle.rent_startDate = Convert.ToDateTime(reader["startdate"]);
                        statVehicle.rent_endDate = Convert.ToDateTime(reader["enddate"]);

                        statInfo.statVehicles.Add(statVehicle);
                    }

                    if (reader != null)
                        reader.Close();

                    int length = statInfo.statVehicles.Count;

                    for (int i = 0; i < length; i++)
                    {
                        float[] endData = new float[2];

                        statInfo.statVehicles[i].vehicle = new Vehicle();
                        //statInfo.statVehicles[i].account = new Account();

                        statInfo.statVehicles[i].vehicle = selectVehicle(statInfo.statVehicles[i].VIN);
                        //statInfo.statVehicles[i].account = selectIDAccount(statInfo.statVehicles[i].userid);

                        endData = endRentData(statInfo.statVehicles[i].id);

                        statInfo.statVehicles[i].returning = endData[0];
                        statInfo.statVehicles[i].credit = endData[1];
                    }
                } 

                using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM (balance) AS INCOME FROM [accounts]", sqlconnection))
                {
                    sqlCommand.ExecuteNonQuery();

                    object dataObject = sqlCommand.ExecuteScalar();

                    if (dataObject != DBNull.Value && dataObject != null)
                        statInfo.totalbalance = Convert.ToSingle(dataObject);
                }
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return statInfo;
        }

        public float[] endRentData(int takerentid)
        {
            float[] bufferData = new float[2];

            bufferData[0] = 0;
            bufferData[1] = 0;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [log_removerent] WHERE [takerentid] = @takerentid", sqlconnection))
                {
                    sqlCommand.Parameters.AddWithValue("takerentid", takerentid);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        bufferData[0] = Convert.ToSingle(reader["balancereturn"]);
                        bufferData[1] = Convert.ToSingle(reader["credit"]);

                        break;
                    }

                    if (reader != null)
                        reader.Close();
                }
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return bufferData;
        }

        public CashVoucherData sendCashVoucherData()
        {
            return cashVoucherData;
        }

        public void setCashVoucherData(string Company, string Street)
        {
            try
            {
                cashVoucherData.companyName = Company;
                cashVoucherData.streetName = Street;

                cashVoucherData.readCashVoucher();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public CashVoucher readCashVoucher(int Id)
        {
            return CashVoucher.readCashVoucher(Id, sqlconnection);
        }

        public int writeCashVoucher(CashVoucher cashVoucher)
        {
            return cashVoucherData.addCashVoucher(
                cashVoucher.User, cashVoucher.Vehicle,
                cashVoucher.StartDate, cashVoucher.FinalDate,
                cashVoucher.Price, sqlconnection
            );
        }
    }
}
