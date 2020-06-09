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

        private CashVoucherData cashVoucherData;

        int nextUserID = 1;

        public ServiceRent()
        {
            Log.AppPath = System.Environment.CurrentDirectory;
            Log.Add(LogStyle.Information, "Server started");

            cashVoucherData = new CashVoucherData();
            cashVoucherData.writeCashVoucher();

            SqlData.InitializeConnection();
            selectAllVehicle();
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

        public void showNotification(int id, string message)
        {
            /*foreach(var userObject in serverUser)
            {
                var user = serverUser.FirstOrDefault(i => i.ID == id);

                if (user != null)
                {
                    userObject.operationContext.GetCallbackChannel<IServerRentCallback>().sendNotification(message);
                }
            }*/
        }

        public Vehicle selectVehicle(string VIN)
        {
            return Vehicle.SelectVehicle(VIN);
        }

        public void selectAllVehicle()
        {
            vehicle = Vehicle.SelectAllVehicle();
        }

        public List<Vehicle> SendAllVehicle()
        {
            return vehicle;
        }

        public void deleteVehicle(Vehicle item)
        {
            /*foreach (var item in serverUser)
            {
                item.operationContext.GetCallbackChannel<IServerRentCallback>().onSaveVehicle(vehicleObject);
            }*/


            Vehicle.DeleteVehicle(item);
            vehicle = (from i in vehicle where i.VIN != item.VIN select i).ToList();

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnDeleteVehicle(item, vehicle);
            }
        }

        public void addVehicle(Vehicle item)
        {
            vehicle.Add(item);
            Vehicle.AddVehicle(item);

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnAddVehicle(item, vehicle);
            }
        }

        public void saveVehicle(Vehicle item)
        {
            int index = vehicle.FindIndex(i => i.VIN == item.VIN);
            vehicle[index] = item;

            Vehicle.SaveVehicle(item);

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnEditVehicle(item, vehicle);
            }
        }

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

        public void uploadVehicleImage(byte[] buffer, string name, string extenstion)
        {
            Vehicle.SaveVehicleImage(buffer, name, extenstion);
        }

        public byte[] vehicleImage(Vehicle item)
        {
            return item.VehicleImage();
        }

        public Vehicle findVehicle(string VIN)
        {
            int index = vehicle.FindIndex(i => i.VIN == VIN);
            return vehicle[index];
        }

        public void log_AddVehicle(int userid, string VIN)
        {
            ActionLog.AddVehicle(userid, VIN);
        }

        public void log_Balance(int userid, string card, float value)
        {
            ActionLog.Balance(userid, card, value);
        }

        public void log_DeleteVehicle(int userid, string VIN, string name)
        {
            ActionLog.DeleteVehicle(userid, VIN, name);
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
            /*try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_request] (admin_userid, application_userid, answer) VALUES" +
                   "(@admin_userid, @application_userid, @answer)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("admin_userid", admin_userid);
                sqlCommand.Parameters.AddWithValue("application_userid", application_userid);
                sqlCommand.Parameters.AddWithValue("answer", answer);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }*/
        }

        public int sendCashVoucherID(int LogId)
        {
            const int INVALID_ID = -1;
            int Id = INVALID_ID;

            try
            {
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [log_takerent] WHERE id = @id", SqlData.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", LogId);

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

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return INVALID_ID;
        }

        public StatInfo SendStatInfo(DateTime startDate, DateTime endDate)
        {
            StatInfo statInfo = new StatInfo();

            statInfo.StartDate = startDate;
            statInfo.FinalDate = endDate;

            statInfo.StatBalances = new List<StatBalanceInfo>();
            statInfo.StatVehicles = new List<StatVehicleInfo>();

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [log_takerent] WHERE startdate > @startDate AND startdate < @endDate", SqlData.sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("startDate", startDate);
                    sqlCommand.Parameters.AddWithValue("endDate", endDate);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    StatVehicleInfo statVehicle = new StatVehicleInfo();

                    while (reader.Read())
                    {
                        statVehicle = new StatVehicleInfo();

                        statVehicle.VIN = Convert.ToString(reader["VIN"]);
                        statVehicle.UserId = Convert.ToInt32(reader["userid"]);
                        statVehicle.Id = Convert.ToInt32(reader["id"]);
                        statVehicle.Payment = Convert.ToInt32(reader["price"]);
                        statVehicle.RentStartDate = Convert.ToDateTime(reader["startdate"]);
                        statVehicle.RentFinalDate = Convert.ToDateTime(reader["enddate"]);

                        statInfo.StatVehicles.Add(statVehicle);
                    }

                    if (reader != null)
                        reader.Close();

                    int length = statInfo.StatVehicles.Count;

                    for (int i = 0; i < length; i++)
                    {
                        float[] endData = new float[2];

                        statInfo.StatVehicles[i].Vehicle = new Vehicle();
                        statInfo.StatVehicles[i].User = new User();

                        statInfo.StatVehicles[i].Vehicle = selectVehicle(statInfo.StatVehicles[i].VIN);
                        statInfo.StatVehicles[i].User = SelectUser(statInfo.StatVehicles[i].UserId);

                        endData = endRentData(statInfo.StatVehicles[i].Id);

                        statInfo.StatVehicles[i].Returning = endData[0];
                        statInfo.StatVehicles[i].Credit = endData[1];
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [log_balance] WHERE dateoperation > @startDate AND dateoperation < @endDate", SqlData.sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("startDate", startDate);
                    sqlCommand.Parameters.AddWithValue("endDate", endDate);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    StatBalanceInfo statBalance = new StatBalanceInfo();

                    while (reader.Read())
                    {
                        statBalance = new StatBalanceInfo();

                        statBalance.Id = Convert.ToInt32(reader["id"]);
                        statBalance.CardNumber = Convert.ToString(reader["card"]);
                        statBalance.Value = Convert.ToSingle(reader["value"]);
                        statBalance.DateNow = Convert.ToDateTime(reader["dateoperation"]);
                        statBalance.UserId = Convert.ToInt32(reader["userid"]);

                        statInfo.StatBalances.Add(statBalance);
                    }

                    if (reader != null)
                        reader.Close();

                    int length = statInfo.StatBalances.Count;

                    for (int i = 0; i < length; i++)
                    {
                        statInfo.StatBalances[i].User = SelectUser(statInfo.StatBalances[i].UserId);
                    }
                }


                using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM (balance) AS INCOME FROM [Users]", SqlData.sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();

                    object dataObject = sqlCommand.ExecuteScalar();

                    if (dataObject != DBNull.Value && dataObject != null)
                        statInfo.TotalBalance = Convert.ToSingle(dataObject);
                }
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return statInfo;
        }

        public float[] endRentData(int takerentid)
        {
            float[] bufferData = new float[2];

            bufferData[0] = 0;
            bufferData[1] = 0;

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [log_removerent] WHERE [takerentid] = @takerentid", SqlData.sqlConnection))
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

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

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

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public CashVoucher readCashVoucher(int Id)
        {
            return CashVoucher.ReadCashVoucher(Id);
        }

        public int writeCashVoucher(CashVoucher cashVoucher)
        {
            return cashVoucherData.AddCashVoucher(
                cashVoucher.User, cashVoucher.Vehicle,
                cashVoucher.StartDate, cashVoucher.FinalDate,
                cashVoucher.Price
            );
        }

        public User SelectUser_LoginPassword(string Login, string Password)
        {
            return User.SelectUser_LoginPassword(Login, Password);
        }

        public User SelectUser(int Id)
        {
            return User.SelectUser(Id);
        }

        public void SaveUser(User item)
        {
            User.SaveUser(item);

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnUserEdit(item, User.SelectAllUser());
            }
        }

        public void AddUser(User item)
        {
            User.AddUser(item);

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnUserAdd(item, User.SelectAllUser());
            }
        }

        public void DeleteUser(User item)
        {
            User.DeleteUser(item);

            foreach (var user in serverUser)
            {
                user.operationContext.GetCallbackChannel<IServerRentCallback>().OnUserDelete(item, User.SelectAllUser());
            }
        }

        public Vehicle GetUserVehicle(User item)
        {
            return item.GetVehicle(vehicle);
        }

        public void SaveBackImage(byte[] Image, string Name, string Extension)
        {
            User.SaveBackImage(Image, Name, Extension);
        }

        public void SaveFrontImage(byte[] Image, string Name, string Extension)
        {
            User.SaveFrontImage(Image, Name, Extension);
        }

        public byte[] BackImageBytes(User item)
        {
            return item.BackImageBytes();
        }

        public byte[] FrontImageBytes(User item)
        {
            return item.FrontImageBytes();
        }

        public bool IsVehicleValid(string VIN)
        {
            return Vehicle.IsVehicleValid(VIN, vehicle);
        }

        public List<User> SelectAllUser()
        {
            return User.SelectAllUser();
        }

        public User SelectUserApplication()
        {
            return User.SelectUserApplication();
        }
    }
}
