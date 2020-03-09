﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
using System.Drawing;

using WCF_Rent.HeaderFile;
using System.Drawing.Imaging;

namespace WCF_Rent
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceRent : IServiceRent
    {
        [DataMember]
        public List<Vehicle> vehicle = new List<Vehicle>();

        List<ServerUser> serverUser = new List<ServerUser>();

        SqlConnection sqlconnection;

        int nextUserID = 1;
        const string sqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|rentcar.mdf;Integrated Security=True";
        //const string sqlString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TRC_Redesign\WCF_Rent\rentcar.mdf;Integrated Security=True";

        public int userConnect()
        {
            if ( !isSqlConnection() )
                createSqlConnection(sqlString);

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

        public void createSqlConnection(string path)
        {
            if (isSqlConnection())
                return;

            sqlconnection = new SqlConnection(path);
            sqlconnection.Open();

            selectAllVehicle();
        }

        /*      vehicle block       */


        public void selectAllVehicle()
        {
            vehicle.Clear();
            SqlCommand sqlCommand;

            sqlCommand = new SqlCommand("SELECT * FROM [vehicles]", sqlconnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                vehicle.Add(new Vehicle()
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
            }

            if (reader != null)
                reader.Close();
        }

        public void deleteVehicle(Vehicle vehicleObject)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [vehicles] WHERE [plate] = @plate");
            sqlCommand.Parameters.AddWithValue("plate", vehicleObject.plate);
            sqlCommand.ExecuteNonQuery();
        }

        public void addVehicle(Vehicle vehicleObject)
        {
            vehicle.Add(vehicleObject);

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
        }

        public void saveVehicle(Vehicle vehicleObject)
        {
            int index = vehicle.FindIndex(i => i.plate == vehicleObject.plate);
            vehicle[index] = vehicleObject;

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

        public List<Vehicle> getAllVehicleToUser(int id)
        {
            return vehicle;
        }


        public Account selectAccount(string login, string password)
        {
            Account accountObject = new Account();
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

        public void saveAccount(Account accountObject)
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

        public void addAccount(Account accountObject)
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

        public void deleteAccount(Account accountObject)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM [accounts] WHERE [login] = @login");
            sqlCommand.Parameters.AddWithValue("login", accountObject.login);
            sqlCommand.ExecuteNonQuery();
        }

        public bool isSqlConnection()
        {
            return (sqlconnection != null && sqlconnection.State != ConnectionState.Closed);      
        }

        public bool isAccountValid(string login)
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

        public Vehicle getUserVehicle(Account account)
        {
            Vehicle vehicleObject = new Vehicle();

            foreach (Vehicle item in vehicle)
            {
                if (item.client_documentid != account.documentid)
                    continue;

                vehicleObject = item;

                break;
            }

            return vehicleObject;
        }

        public List<Vehicle> createVehicleObjectParams(int min, int max, int type)
        {
            List<Vehicle> paramsObject = new List<Vehicle>();

            foreach(Vehicle item in vehicle)
            {
                if ( !(item.price >= min && item.price <= max) )
                    continue;

                if (type == 1 && item.client_documentid == 0)
                    continue;

                if (type == 1 && item.client_documentid != 0)
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
                if (item.client_documentid == 0)
                    continue;

                allvehicle++;
            }

            return allvehicle;
        }

        public int GetAllNoRentVehicle()
        {
            return this.GetAllVehicle() - this.GetAllRentVehicle();
        }

        public Account noAcceptedAccount()
        {
            Account accountObject = new Account();
            SqlCommand sqlCommand;

            sqlCommand = new SqlCommand("SELECT * FROM [accounts] WHERE [accepted] = 0", sqlconnection);
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

        public void uploadVehicleImage(byte[] buffer)
        {
            File.Create(@"D:\TRC_Redesign\WCF_Rent\bin\Debug\pictures\niva_PNG73.png");
            File.WriteAllBytes(@"D:\TRC_Redesign\WCF_Rent\bin\Debug\pictures\niva_PNG73.png", buffer);
        }

        /*public Stream downloadVehicleImage(Vehicle vehicleObject)
        {
            string filepath = String.Format(@"\pictures\{0}.png", vehicleObject.plate);
            MemoryStream stream = new MemoryStream();
            var bytes = File.ReadAllBytes(filepath);

            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0;

            return stream;
        }*/

        public void renameFile(string oldpath, string newpath)
        {
            /*if (File.Exists(newpath))
                File.Delete(newpath);

            File.Move(oldpath, newpath);*/
        }

        public Vehicle findVehicle(string plate)
        {
            int index = vehicle.FindIndex(i => i.plate == plate);
            return vehicle[index];
        }
    }
}
