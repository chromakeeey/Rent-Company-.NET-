using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TRC_Redesign.header;

namespace WCF_Rent
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceRent : IServiceRent
    {
        List<vehicle> allVehicle = new List<vehicle>();
        List<ServerUser> serverUser = new List<ServerUser>();
        SqlConnection sqlconnection;

        int nextUserID = 1;
        const string sqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|rentcar.mdf;Integrated Security=True";

        public int userConnect()
        {
            ServerUser user = new ServerUser()
            {
                ID = nextUserID,
                operationContext = OperationContext.Current
            };

            serverUser.Add(user);
            return user.ID;
        }

        public void userDisconnect(int id)
        {
            var user = serverUser.FirstOrDefault(i => i.ID == id);

            if (user != null)
                serverUser.Remove(user);
        }

        public async void createSqlConnection(string path)
        {
            // if sql base connected
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                return;

            sqlconnection = new SqlConnection(path);

            try { await sqlconnection.OpenAsync(); }

            catch
            {
                sqlconnection.Close();
                sqlconnection = null;

                createSqlConnection(path);
            }
        }

        /*      vehicle block       */

        public void sendVehicleList(int id)
        {
            var user = serverUser.FirstOrDefault(i => i.ID == id);

            if (user != null)
                user.operationContext.GetCallbackChannel<IServerRentCallback>().vehicleListCallBack(allVehicle);
        }

        public void selectAllVehicle()
        {
            List<vehicle> vehicleObject = new List<vehicle>();
            SqlCommand sqlCommand;

            sqlCommand = new SqlCommand("SELECT * FROM [vehicles]", sqlconnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                vehicleObject.Add(new vehicle()
                {
                    plate = reader["plate"].ToString(),
                    name = reader["name"].ToString(),
                    model = reader["model"].ToString(),
                    price = Convert.ToSingle(reader["price"]),
                    fuel = Convert.ToSingle(reader["fuel"]),
                    mileage = Convert.ToSingle(reader["mileage"]),
                    image_link = reader["image_link"].ToString(),
                    client_documentid = Convert.ToInt32(reader["client_documentid"]),
                    start_date = Convert.ToDateTime(reader["date_start"]),
                    end_date = Convert.ToDateTime(reader["date_end"])
                }
                );

                break;
            }

            if (reader != null)
                reader.Close();

            allVehicle = vehicleObject;
        }

        public void deleteVehicle(string plate)
        {
            var vehicle = allVehicle.FirstOrDefault(i => i.plate == plate);

            if (vehicle != null)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [vehicles] WHERE [plate] = @plate");
                sqlCommand.Parameters.AddWithValue("plate", vehicle.plate);
                sqlCommand.ExecuteNonQuery();

                allVehicle.Remove(vehicle);
            }

            sendVehicleList(0);
        }

        public void addVehicle(vehicle vehicleObject)
        {
            allVehicle.Add(vehicleObject);

            SqlCommand command = new SqlCommand("INSERT INTO [vehicles] " +
                "(plate, name, model, price, fuel, mileage, client_documentid, image_link, date_start, date_end) VALUES" +
                "(@plate, @name, @model, @price, @fuel, @mileage, @client_documentid, @image_link, @date_start, @date_end)", sqlconnection);

            command.Parameters.AddWithValue("plate", vehicleObject.plate);
            command.Parameters.AddWithValue("name", vehicleObject.name);
            command.Parameters.AddWithValue("model", vehicleObject.model);
            command.Parameters.AddWithValue("price", vehicleObject.price);
            command.Parameters.AddWithValue("fuel", vehicleObject.fuel);
            command.Parameters.AddWithValue("mileage", vehicleObject.mileage);
            command.Parameters.AddWithValue("client_documentid", vehicleObject.client_documentid);
            command.Parameters.AddWithValue("image_link", vehicleObject.image_link);

            command.Parameters.AddWithValue("date_start", vehicleObject.start_date);
            command.Parameters.AddWithValue("date_end", vehicleObject.end_date);

            command.ExecuteNonQuery();

            sendVehicleList(0);
        }

        public void saveVehicle(vehicle vehicleObject)
        {
            SqlCommand command = new SqlCommand("UPDATE [vehicles] SET [plate] = @plate, " +
                "[name] = @name, [model] = @model, [price] = @price, [fuel] = @fuel, " +
                "[mileage] = @mileage, [client_documentid] = @client_documentid," +
                "[image_link] = @img, [date_start] = @date_start, [date_end] = @date_end " +
                "WHERE [plate] = @plt", sqlconnection);

            command.Parameters.AddWithValue("plate", vehicleObject.plate);
            command.Parameters.AddWithValue("name", vehicleObject.name);
            command.Parameters.AddWithValue("model", vehicleObject.model);
            command.Parameters.AddWithValue("price", vehicleObject.price);
            command.Parameters.AddWithValue("fuel", vehicleObject.fuel);
            command.Parameters.AddWithValue("mileage", vehicleObject.mileage);
            command.Parameters.AddWithValue("client_documentid", vehicleObject.client_documentid);
            command.Parameters.AddWithValue("img", vehicleObject.image_link);
            command.Parameters.AddWithValue("plt", vehicleObject.plate);

            command.Parameters.AddWithValue("date_start", vehicleObject.start_date);
            command.Parameters.AddWithValue("date_end", vehicleObject.end_date);

            command.ExecuteNonQuery();
        }


        /*      account block       */

        public void sendAccountObject(int id, account accountObject)
        {
            var user = serverUser.FirstOrDefault(i => i.ID == id);

            if (user != null)
                user.operationContext.GetCallbackChannel<IServerRentCallback>().accountObjectCallBack(accountObject);
        }

        public account selectAccount(string login, string password)
        {
            account accountObject = new account();
            SqlCommand sqlCommand;

            sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE login = @login AND password = @password", sqlconnection);
            sqlCommand.Parameters.AddWithValue("login", login);
            sqlCommand.Parameters.AddWithValue("password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                accountObject.name = Convert.ToString(reader["name"]);
                accountObject.secondname = Convert.ToString(reader["secondname"]);
                accountObject.fathername = Convert.ToString(reader["fathername"]);
                accountObject.login = Convert.ToString(reader["login"]);
                accountObject.password = Convert.ToString(reader["password"]);
                accountObject.phone = Convert.ToString(reader["phone"]);
                accountObject.mail = Convert.ToString(reader["email"]);

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

        public void saveAccount(account accountObject)
        {
            SqlCommand command = new SqlCommand("UPDATE [accounts] SET [documentid] = @documentid, [login] = @login, [password] = @password, " +
                "[name] = @name, [secondname] = @secondname, [fathername] = @fathername, [email] = @email, [accepted] = @accepted, " +
                "[adminlevel] = @adminlevel, [balance] = @balance WHERE [documentid] = @docid", sqlconnection);

            command.Parameters.AddWithValue("documentid", accountObject.documentid);
            command.Parameters.AddWithValue("login", accountObject.login);
            command.Parameters.AddWithValue("password", accountObject.password);
            command.Parameters.AddWithValue("name", accountObject.name);
            command.Parameters.AddWithValue("secondname", accountObject.secondname);
            command.Parameters.AddWithValue("fathername", accountObject.fathername);
            command.Parameters.AddWithValue("email", accountObject.mail);
            command.Parameters.AddWithValue("accepted", accountObject.accepted);
            command.Parameters.AddWithValue("adminlevel", accountObject.GetAdminLevel());
            command.Parameters.AddWithValue("docid", accountObject.documentid);
            command.Parameters.AddWithValue("balance", accountObject.balance);

            command.ExecuteNonQuery();
        }

        public void addAccount(account accountObject)
        {
            SqlCommand sqlCommand = new SqlCommand(
                "NSERT INTO [accounts] (name, secondname, fathername, documentid, email, login, password, phone, datecreate) VALUES" +
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

        public void deleteAccount(account accountObject)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [accounts] WHERE [login] = @login");
            sqlCommand.Parameters.AddWithValue("login", accountObject.login);
            sqlCommand.ExecuteNonQuery();
        }

        
    }
}
