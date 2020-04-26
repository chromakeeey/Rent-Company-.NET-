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
            ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, "Server started");

            //cashVoucher = new CashVoucher();
            //cashVoucher.readCashVoucher();

            cashVoucherData = new CashVoucherData();
            cashVoucherData.readCashVoucher();

            createSqlConnection(sqlString);

           
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
            if ( !isSqlConnection() )
                createSqlConnection(sqlString);

            ServerUser user = new ServerUser()
            {
                ID = nextUserID,
                operationContext = OperationContext.Current
            };

            ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, "ID: " + user.ID.ToString() + " connected");

            serverUser.Add(user);
            return user.ID;
        }

        public void userDisconnect(int id)
        {
            var user = serverUser.FirstOrDefault(i => i.ID == id);

            ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, "ID: " + user.ID.ToString() + " disconnected");

            if (user != null)
                serverUser.Remove(user);
        }

        public void createSqlConnection(string path)
        {
            if (isSqlConnection())
                return;

            try
            {

                sqlconnection = new SqlConnection(path);
                sqlconnection.Open();

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, "SQL Base connected");
            selectAllVehicle();
            
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
            ServerLog.logAdd(ServerLog.NOTIFICATION_TYPE, "VIN - " + VIN);

            Vehicle readVehicle = new Vehicle();

            using ( SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [vehicles] WHERE [VIN] = @unicalid", sqlconnection) )
            {
                sqlCommand.Parameters.AddWithValue("unicalid", VIN);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    readVehicle = new Vehicle()
                    {
                        VIN = reader["VIN"].ToString(),
                        plate = reader["plate"].ToString(),
                        name = reader["name"].ToString(),
                        model = reader["model"].ToString(),
                        price = Convert.ToSingle(reader["price"]),
                        fuel = Convert.ToSingle(reader["fuel"]),
                        mileage = Convert.ToSingle(reader["mileage"]),
                        picturepath = reader["picturepath"].ToString(),
                        clientid = Convert.ToInt32(reader["clientid"]),
                        rentlogid = Convert.ToInt32(reader["rentlogid"]),
                        start_date = Convert.ToDateTime(reader["date_start"]),
                        end_date = Convert.ToDateTime(reader["date_end"]),

                        maxfuel = Convert.ToSingle(reader["fuelmax"]),
                        maxspeed = Convert.ToInt32(reader["maxspeed"]),

                        type = Convert.ToString(reader["type"]),
                        transmission = Convert.ToString(reader["transmission"]),
                        category = Convert.ToString(reader["category"])
                    };

                    break;
                }

                if (reader != null)
                    reader.Close();
            }

            return readVehicle;
        }

        public void selectAllVehicle()
        {
            try
            {

                vehicle.Clear();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [vehicles]", sqlconnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    vehicle.Add(new Vehicle()
                    {
                        VIN = reader["VIN"].ToString(),
                        plate = reader["plate"].ToString(),
                        name = reader["name"].ToString(),
                        model = reader["model"].ToString(),
                        price = Convert.ToSingle(reader["price"]),
                        fuel = Convert.ToSingle(reader["fuel"]),
                        mileage = Convert.ToSingle(reader["mileage"]),
                        picturepath = reader["picturepath"].ToString(),
                        clientid = Convert.ToInt32(reader["clientid"]),
                        rentlogid = Convert.ToInt32(reader["rentlogid"]),
                        start_date = Convert.ToDateTime(reader["date_start"]),
                        end_date = Convert.ToDateTime(reader["date_end"]),

                        maxfuel = Convert.ToSingle(reader["fuelmax"]),
                        maxspeed = Convert.ToInt32(reader["maxspeed"]),

                        type = Convert.ToString(reader["type"]),
                        transmission = Convert.ToString(reader["transmission"]),
                        category = Convert.ToString(reader["category"])
                    }
                    );
                }

                if (reader != null)
                    reader.Close();

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void deleteVehicle(Vehicle vehicleObject)
        {
            foreach (var item in serverUser)
            {
                item.operationContext.GetCallbackChannel<IServerRentCallback>().onSaveVehicle(vehicleObject);
            }

            try
            {

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [vehicles] WHERE [VIN] = @VIN");
                sqlCommand.Parameters.AddWithValue("VIN", vehicleObject.VIN);
                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void addVehicle(Vehicle vehicleObject)
        {
            vehicle.Add(vehicleObject);

            try
            {

                SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [vehicles] (VIN, plate, name, model, price, fuel, mileage, clientid, rentlogid, picturepath, date_start, date_end, fuelmax, maxspeed, type, transmission, category) VALUES " +
                        "(@VIN, @plate, @name, @model, @price, @fuel, @mileage, @clientid, @rentlogid, @picturepath, @date_start, @date_end, @fuelmax, @maxspeed, @type, @transmission, @category)",
                    sqlconnection);

                sqlCommand.Parameters.AddWithValue("VIN", vehicleObject.VIN);
                sqlCommand.Parameters.AddWithValue("plate", vehicleObject.plate);
                sqlCommand.Parameters.AddWithValue("name", vehicleObject.name);
                sqlCommand.Parameters.AddWithValue("model", vehicleObject.model);
                sqlCommand.Parameters.AddWithValue("price", vehicleObject.price);
                sqlCommand.Parameters.AddWithValue("fuel", vehicleObject.fuel);
                sqlCommand.Parameters.AddWithValue("mileage", vehicleObject.mileage);
                sqlCommand.Parameters.AddWithValue("clientid", vehicleObject.clientid);
                sqlCommand.Parameters.AddWithValue("rentlogid", vehicleObject.rentlogid);
                sqlCommand.Parameters.AddWithValue("picturepath", vehicleObject.picturepath);

                sqlCommand.Parameters.AddWithValue("date_start", vehicleObject.start_date);
                sqlCommand.Parameters.AddWithValue("date_end", vehicleObject.end_date);

                sqlCommand.Parameters.AddWithValue("fuelmax", vehicleObject.maxfuel);
                sqlCommand.Parameters.AddWithValue("maxspeed", vehicleObject.maxspeed);
                sqlCommand.Parameters.AddWithValue("type", vehicleObject.type);
                sqlCommand.Parameters.AddWithValue("transmission", vehicleObject.transmission);
                sqlCommand.Parameters.AddWithValue("category", vehicleObject.category);

                sqlCommand.ExecuteNonQuery();

                string message = String.Format("Було додано новий автомобіль - {0} {1} ({2} грн.)",
                    vehicleObject.name, vehicleObject.model, vehicleObject.price.ToString());

                showNotification(0, message);

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void saveVehicle(Vehicle vehicleObject)
        {
            int index = vehicle.FindIndex(i => i.VIN == vehicleObject.VIN);
            vehicle[index] = vehicleObject;

            foreach (var item in serverUser)
            {
                item.operationContext.GetCallbackChannel<IServerRentCallback>().onSaveVehicle(vehicle[index]);
            }

            try
            {

                using (SqlCommand command = sqlconnection.CreateCommand())
                {
                    command.CommandText = "UPDATE [vehicles] SET [plate] = @plate, " +
                        "[name] = @name, [model] = @model, [price] = @price, [fuel] = @fuel, " +
                        "[mileage] = @mileage, [clientid] = @clientid, [rentlogid] = @rentlogid, " +
                        "[picturepath] = @img, [date_start] = @date_start, [date_end] = @date_end," +
                        "[fuelmax] = @fuelmax, [maxspeed] = @maxspeed, [type] = @type, [transmission] = @transmission, [category] = @category " +
                        "WHERE [VIN] = @VIN";

                    command.Parameters.AddWithValue("plate", vehicleObject.plate);
                    command.Parameters.AddWithValue("name", vehicleObject.name);
                    command.Parameters.AddWithValue("model", vehicleObject.model);
                    command.Parameters.AddWithValue("price", vehicleObject.price);
                    command.Parameters.AddWithValue("fuel", vehicleObject.fuel);
                    command.Parameters.AddWithValue("mileage", vehicleObject.mileage);
                    command.Parameters.AddWithValue("clientid", vehicleObject.clientid);
                    command.Parameters.AddWithValue("rentlogid", vehicleObject.rentlogid);
                    command.Parameters.AddWithValue("img", vehicleObject.picturepath);
                    command.Parameters.AddWithValue("VIN", vehicleObject.VIN);

                    command.Parameters.AddWithValue("date_start", vehicleObject.start_date);
                    command.Parameters.AddWithValue("date_end", vehicleObject.end_date);

                    command.Parameters.AddWithValue("fuelmax", vehicleObject.maxfuel);
                    command.Parameters.AddWithValue("maxspeed", vehicleObject.maxspeed);
                    command.Parameters.AddWithValue("type", vehicleObject.type);
                    command.Parameters.AddWithValue("transmission", vehicleObject.transmission);
                    command.Parameters.AddWithValue("category", vehicleObject.category);

                    command.ExecuteNonQuery();
                }

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public List<Vehicle> getAllVehicleToUser(int id)
        {
            return vehicle;
        }


        public Account selectAccount(string login, string password)
        {
            try
            {
                Account accountObject = new Account();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE login = @login AND password = @password", sqlconnection);
                sqlCommand.Parameters.AddWithValue("login", login);
                sqlCommand.Parameters.AddWithValue("password", password);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    accountObject.id = Convert.ToInt32(reader["id"]);
                    accountObject.name = Convert.ToString(reader["name"]);
                    accountObject.secondname = Convert.ToString(reader["secondname"]);
                    accountObject.fathername = Convert.ToString(reader["fathername"]);
                    accountObject.login = Convert.ToString(reader["login"]);
                    accountObject.password = Convert.ToString(reader["password"]);
                    accountObject.phone = Convert.ToString(reader["phone"]);
                    accountObject.mail = Convert.ToString(reader["email"]);

                    accountObject.documentid = Convert.ToInt32(reader["documentid"]);
                    accountObject.level = Convert.ToInt32(reader["adminlevel"]);
                    accountObject.balance = Convert.ToSingle(reader["balance"]);
                    accountObject.dateCreate = Convert.ToDateTime(reader["datecreate"]);
                    accountObject.accepted = Convert.ToInt32(reader["accepted"]);

                    break;
                }

                if (reader != null)
                    reader.Close();

                return accountObject;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new Account();
        }

        public void saveAccount(Account accountObject)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [accounts] SET [documentid] = @documentid, [login] = @login, [password] = @password, " +
                    "[name] = @name, [secondname] = @secondname, [fathername] = @fathername, [email] = @email, [accepted] = @accepted, " +
                    "[adminlevel] = @adminlevel, [balance] = @balance WHERE [id] = @id", sqlconnection);

                command.Parameters.AddWithValue("documentid", accountObject.documentid);
                command.Parameters.AddWithValue("login", accountObject.login);
                command.Parameters.AddWithValue("password", accountObject.password);
                command.Parameters.AddWithValue("name", accountObject.name);
                command.Parameters.AddWithValue("secondname", accountObject.secondname);
                command.Parameters.AddWithValue("fathername", accountObject.fathername);
                command.Parameters.AddWithValue("email", accountObject.mail);
                command.Parameters.AddWithValue("accepted", accountObject.accepted);
                command.Parameters.AddWithValue("adminlevel", accountObject.GetAdminLevel());
                command.Parameters.AddWithValue("id", accountObject.id);
                command.Parameters.AddWithValue("balance", accountObject.balance);

                command.ExecuteNonQuery();

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void addAccount(Account accountObject)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                    "INSERT INTO [accounts] (name, secondname, fathername, documentid, email, login, password, phone, datecreate) VALUES" +
                    "(@name, @secondname, @fathername, @documentid, @email, @login, @password, @phone, @datecreate)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("name", accountObject.name);
                sqlCommand.Parameters.AddWithValue("secondname", accountObject.secondname);
                sqlCommand.Parameters.AddWithValue("fathername", accountObject.fathername);
                sqlCommand.Parameters.AddWithValue("documentid", accountObject.documentid);
                sqlCommand.Parameters.AddWithValue("email", accountObject.mail);
                sqlCommand.Parameters.AddWithValue("login", accountObject.login);
                sqlCommand.Parameters.AddWithValue("password", accountObject.password);
                sqlCommand.Parameters.AddWithValue("phone", accountObject.phone);
                sqlCommand.Parameters.AddWithValue("datecreate", DateTime.Now);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void deleteAccount(Account accountObject)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [accounts] WHERE [id] = @id");
                sqlCommand.Parameters.AddWithValue("id", accountObject.id);
                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public bool isSqlConnection()
        {
            return (sqlconnection != null && sqlconnection.State != ConnectionState.Closed);      
        }

        public bool isAccountValid(string login)
        {
            try
            {
                Account accountObject = new Account();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE login = @login", sqlconnection);
                sqlCommand.Parameters.AddWithValue("login", login);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    accountObject.documentid = Convert.ToInt32(reader["documentid"]);

                    break;
                }

                if (reader != null)
                    reader.Close();

                return (accountObject.documentid != 0);
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return false;
        }

        public Vehicle getUserVehicle(Account account)
        {
            int index = vehicle.FindIndex(i => i.clientid == account.id);

            if (index < 0)
                return new Vehicle();

            return vehicle[index];
        }

        public List<Vehicle> createVehicleObjectParams(int min, int max, int type)
        {
            List<Vehicle> paramsObject = new List<Vehicle>();

            foreach(Vehicle item in vehicle)
            {
                if ( !(item.price >= min && item.price <= max) )
                    continue;

                if (type == 1 && item.clientid == 0)
                    continue;

                if (type == 1 && item.clientid != 0)
                    continue;

                paramsObject.Add(item);
            }

            return paramsObject;
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
                if (item.clientid == 0)
                    continue;

                allvehicle++;
            }

            return allvehicle;
        }

        public int GetAllNoRentVehicle()
        {
            return this.GetAllVehicle() - this.GetAllRentVehicle();
        }

        public Account selectIDAccount(int id)
        {
            try
            {
                Account accountObject = new Account();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE [id] = @id", sqlconnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    accountObject.id = Convert.ToInt32(reader["id"]);

                    accountObject.name = Convert.ToString(reader["name"]);
                    accountObject.secondname = Convert.ToString(reader["secondname"]);
                    accountObject.fathername = Convert.ToString(reader["fathername"]);
                    accountObject.login = Convert.ToString(reader["login"]);
                    accountObject.password = Convert.ToString(reader["password"]);
                    accountObject.phone = Convert.ToString(reader["phone"]);
                    accountObject.mail = Convert.ToString(reader["email"]);

                    accountObject.documentid = Convert.ToInt32(reader["documentid"]);
                    accountObject.level = Convert.ToInt32(reader["adminlevel"]);
                    accountObject.balance = Convert.ToSingle(reader["balance"]);
                    accountObject.dateCreate = Convert.ToDateTime(reader["datecreate"]);
                    accountObject.accepted = Convert.ToInt32(reader["accepted"]);

                    break;
                }

                if (reader != null)
                    reader.Close();

                return accountObject;

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new Account();
        }

        public Account noAcceptedAccount()
        {
            try
            {
                Account accountObject = new Account();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE [accepted] = 0", sqlconnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    accountObject.id = Convert.ToInt32(reader["id"]);

                    accountObject.name = Convert.ToString(reader["name"]);
                    accountObject.secondname = Convert.ToString(reader["secondname"]);
                    accountObject.fathername = Convert.ToString(reader["fathername"]);
                    accountObject.login = Convert.ToString(reader["login"]);
                    accountObject.password = Convert.ToString(reader["password"]);
                    accountObject.phone = Convert.ToString(reader["phone"]);
                    accountObject.mail = Convert.ToString(reader["email"]);

                    accountObject.documentid = Convert.ToInt32(reader["documentid"]);
                    accountObject.level = Convert.ToInt32(reader["adminlevel"]);
                    accountObject.balance = Convert.ToSingle(reader["balance"]);
                    accountObject.dateCreate = Convert.ToDateTime(reader["datecreate"]);
                    accountObject.accepted = Convert.ToInt32(reader["accepted"]);

                    break;
                }

                if (reader != null)
                    reader.Close();

                return accountObject;

            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new Account();
        }

        public void uploadVehicleImage(byte[] buffer, string name, string extenstion)
        {
            string localpath = localPath();
            string path = String.Format(@"{0}pictures\{1}{2}", localpath, name, extenstion);

            File.WriteAllBytes(path, buffer);
        }

        public byte[] vehicleImage(Vehicle vehicleObject)
        {
            string localpath = localPath();
            string path = String.Format(@"{0}{1}", localpath, vehicleObject.picturepath);
            string errorpath = String.Format(@"{0}pictures\error_vehicle.png", localpath, vehicleObject.picturepath);

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

        public Vehicle findVehicle(string plate)
        {
            int index = vehicle.FindIndex(i => i.plate == plate);
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
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_editvehicle] (userid, VIN, params) VALUES" +
                   "(@userid, @VIN, @params)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("VIN", VIN);
                sqlCommand.Parameters.AddWithValue("params", str_params);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public void log_RemoveRent(int userid, int takerentid, DateTime date, float balancereturn, float credit)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_removerent] (userid, takerentid, date, balancereturn, credit) VALUES" +
                   "(@userid, @takerentid, @date, @balancereturn, @credit)", sqlconnection);

                sqlCommand.Parameters.AddWithValue("userid", userid);
                sqlCommand.Parameters.AddWithValue("takerentid", takerentid);
                sqlCommand.Parameters.AddWithValue("date", date);
                sqlCommand.Parameters.AddWithValue("balancereturn", balancereturn);
                sqlCommand.Parameters.AddWithValue("credit", credit);

                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
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

        public int log_TakeRent(int userid, string VIN, float price, int cashVoucherId, DateTime startdate, DateTime enddate)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                   "INSERT INTO [log_takerent] (userid, VIN, price, cashvoucherid, startdate, enddate) OUTPUT INSERTED.ID VALUES" +
                   "(@userid, @VIN, @price, @cashvoucherid, @startdate, @enddate)", sqlconnection))
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

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString());}
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            finally 
            {

            }

            return -1;
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

        public List<Account> selectAllAccount()
        {
            try
            {
                List<Account> allAccount = new List<Account>();
                Account accountObject = new Account();
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand("SELECT * FROM [accounts]", sqlconnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    accountObject = new Account();

                    accountObject.id = Convert.ToInt32(reader["id"]);
                    accountObject.name = Convert.ToString(reader["name"]);
                    accountObject.secondname = Convert.ToString(reader["secondname"]);
                    accountObject.fathername = Convert.ToString(reader["fathername"]);
                    accountObject.login = Convert.ToString(reader["login"]);
                    accountObject.password = Convert.ToString(reader["password"]);
                    accountObject.phone = Convert.ToString(reader["phone"]);
                    accountObject.mail = Convert.ToString(reader["email"]);

                    accountObject.documentid = Convert.ToInt32(reader["documentid"]);
                    accountObject.level = Convert.ToInt32(reader["adminlevel"]);
                    accountObject.balance = Convert.ToSingle(reader["balance"]);
                    accountObject.dateCreate = Convert.ToDateTime(reader["datecreate"]);
                    accountObject.accepted = Convert.ToInt32(reader["accepted"]);

                    allAccount.Add(accountObject);
                }

                if (reader != null)
                    reader.Close();

                return allAccount;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return new List<Account>();
        }

        public List<Account> topAccountMoney()
        {
            List<Account> allAccount = new List<Account>();
            allAccount = selectAllAccount();

            try
            {
                for (int i = 0; i < allAccount.Count; i++)
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM (price) AS INCOME FROM [log_takerent] WHERE userid = @userid", sqlconnection))
                    {
                        sqlCommand.Parameters.AddWithValue("userid", allAccount[i].id);
                        sqlCommand.ExecuteNonQuery();

                        object dataObject = sqlCommand.ExecuteScalar();

                        if (dataObject != DBNull.Value && dataObject != null)
                            allAccount[i].totalMoney = Convert.ToSingle(dataObject);
                    }

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM (balancereturn) AS INCOME FROM [log_removerent] WHERE userid = @userid", sqlconnection))
                    {
                        sqlCommand.Parameters.AddWithValue("userid", allAccount[i].id);
                        sqlCommand.ExecuteNonQuery();

                        object dataObject = sqlCommand.ExecuteScalar();

                        if (dataObject != DBNull.Value && dataObject != null)
                            allAccount[i].totalMoney -= Convert.ToSingle(dataObject);
                    }

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM (credit) AS INCOME FROM [log_removerent] WHERE userid = @userid", sqlconnection))
                    {
                        sqlCommand.Parameters.AddWithValue("userid", allAccount[i].id);
                        sqlCommand.ExecuteNonQuery();

                        object dataObject = sqlCommand.ExecuteScalar();

                        if (dataObject != DBNull.Value && dataObject != null)
                            allAccount[i].totalMoney += Convert.ToSingle(dataObject);
                    }
                }

                allAccount.Sort((x, y) => x.totalMoney.CompareTo(y.totalMoney));
                return allAccount;
            }

            catch (SqlException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString() + " line: " + ex.LineNumber); }
            catch (InvalidOperationException ex) { ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) 
            {
                int line = (new StackTrace(ex, true)).GetFrame(0).GetFileLineNumber();

                ServerLog.logAdd(ServerLog.ERROR_TYPE, ex.Message.ToString() + " " + ex.Source.ToString() + " LINE: " + line.ToString()); 
            }

            return allAccount;
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
                        statInfo.statVehicles[i].account = new Account();

                        statInfo.statVehicles[i].vehicle = selectVehicle(statInfo.statVehicles[i].VIN);
                        statInfo.statVehicles[i].account = selectIDAccount(statInfo.statVehicles[i].userid);

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
