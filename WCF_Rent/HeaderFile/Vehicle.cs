using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Drawing;
using System.IO;

using WCF_Rent.Providers;

namespace WCF_Rent.HeaderFile
{

    [DataContract]
    public class Vehicle : Rent
    {
        [DataMember]
        public string VIN { get; set; }

        [DataMember]
        public string Plate { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string PicturePath { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public float Fuel { get; set; }

        [DataMember]
        public float Mileage { get; set; }

        [DataMember]
        public int MaxSpeed { get; set; }

        [DataMember]
        public float MaxFuel { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Transmission { get; set; }

        [DataMember]
        public string Category { get; set; }


        public Vehicle()
        {
            VIN = "null";
            Plate = "null";
            Model = "null";
            PicturePath = "null";

            Type = "null";
            Transmission = "null";
            Category = "null";
        }


        public static Vehicle SelectVehicle(string VIN)
        {
            Vehicle item = new Vehicle();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [vehicles] WHERE [VIN] = @unicalid", SqlData.sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("unicalid", VIN);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    item = new Vehicle()
                    {
                        VIN = reader["VIN"].ToString(),
                        Plate = reader["plate"].ToString(),
                        Name = reader["name"].ToString(),
                        Model = reader["model"].ToString(),
                        PicturePath = reader["picturepath"].ToString(),

                        Price = Convert.ToSingle(reader["price"]),
                        Fuel = Convert.ToSingle(reader["fuel"]),
                        Mileage = Convert.ToSingle(reader["mileage"]),
                        ClientId = Convert.ToInt32(reader["clientid"]),
                        RentLogId = Convert.ToInt32(reader["rentlogid"]),
                        StartDate = Convert.ToDateTime(reader["date_start"]),
                        FinalDate = Convert.ToDateTime(reader["date_end"]),
                        MaxFuel = Convert.ToSingle(reader["fuelmax"]),
                        MaxSpeed = Convert.ToInt32(reader["maxspeed"]),
                        Type = Convert.ToString(reader["type"]),
                        Transmission = Convert.ToString(reader["transmission"]),
                        Category = Convert.ToString(reader["category"])
                    };

                    break;
                }

                if (reader != null)
                    reader.Close();
            }

            return item;
        }

        public static List<Vehicle> SelectAllVehicle()
        {
            List<Vehicle> itemNumerable = new List<Vehicle>();

            try
            {

                SqlCommand sqlCommand;
                SqlDataReader reader;

                sqlCommand = new SqlCommand("SELECT * FROM [vehicles]", SqlData.sqlConnection);
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    itemNumerable.Add(new Vehicle()
                    {
                        VIN = reader["VIN"].ToString(),
                        Plate = reader["plate"].ToString(),
                        Name = reader["name"].ToString(),
                        Model = reader["model"].ToString(),
                        PicturePath = reader["picturepath"].ToString(),

                        Price = Convert.ToSingle(reader["price"]),
                        Fuel = Convert.ToSingle(reader["fuel"]),
                        Mileage = Convert.ToSingle(reader["mileage"]),
                        ClientId = Convert.ToInt32(reader["clientid"]),
                        RentLogId = Convert.ToInt32(reader["rentlogid"]),
                        StartDate = Convert.ToDateTime(reader["date_start"]),
                        FinalDate = Convert.ToDateTime(reader["date_end"]),
                        MaxFuel = Convert.ToSingle(reader["fuelmax"]),
                        MaxSpeed = Convert.ToInt32(reader["maxspeed"]),
                        Type = Convert.ToString(reader["type"]),
                        Transmission = Convert.ToString(reader["transmission"]),
                        Category = Convert.ToString(reader["category"])
                    }
                    );
                }

                if (reader != null)
                    reader.Close();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }

            return itemNumerable;
        }

        public static void DeleteVehicle(Vehicle item)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [vehicles] WHERE [VIN] = @VIN", SqlData.sqlConnection);
                sqlCommand.Parameters.AddWithValue("VIN", item.VIN);
                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void AddVehicle(Vehicle item)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand(
                        "INSERT INTO [vehicles] (VIN, plate, name, model, price, fuel, mileage, clientid, rentlogid, picturepath, date_start, date_end, fuelmax, maxspeed, type, transmission, category) VALUES " +
                        "(@VIN, @plate, @name, @model, @price, @fuel, @mileage, @clientid, @rentlogid, @picturepath, @date_start, @date_end, @fuelmax, @maxspeed, @type, @transmission, @category)",
                    SqlData.sqlConnection);

                sqlCommand.Parameters.AddWithValue("VIN", item.VIN);
                sqlCommand.Parameters.AddWithValue("plate", item.Plate);
                sqlCommand.Parameters.AddWithValue("name", item.Name);
                sqlCommand.Parameters.AddWithValue("model", item.Model);
                sqlCommand.Parameters.AddWithValue("price", item.Price);
                sqlCommand.Parameters.AddWithValue("fuel", item.Fuel);
                sqlCommand.Parameters.AddWithValue("mileage", item.Mileage);
                sqlCommand.Parameters.AddWithValue("clientid", item.ClientId) ;
                sqlCommand.Parameters.AddWithValue("rentlogid", item.RentLogId);
                sqlCommand.Parameters.AddWithValue("picturepath", item.PicturePath);

                sqlCommand.Parameters.AddWithValue("date_start", item.StartDate);
                sqlCommand.Parameters.AddWithValue("date_end", item.FinalDate);

                sqlCommand.Parameters.AddWithValue("fuelmax", item.MaxFuel);
                sqlCommand.Parameters.AddWithValue("maxspeed", item.MaxSpeed);
                sqlCommand.Parameters.AddWithValue("type", item.Type);
                sqlCommand.Parameters.AddWithValue("transmission", item.Transmission);
                sqlCommand.Parameters.AddWithValue("category", item.Category);

                sqlCommand.ExecuteNonQuery();

                /*string message = String.Format("Було додано новий автомобіль - {0} {1} ({2} грн.)",
                    vehicleObject.name, vehicleObject.model, vehicleObject.price.ToString());

                showNotification(0, message);*/

            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void SaveVehicle(Vehicle item)
        {
            try
            {

                using (SqlCommand command = SqlData.sqlConnection.CreateCommand())
                {
                    command.CommandText = "UPDATE [vehicles] SET [plate] = @plate, " +
                        "[name] = @name, [model] = @model, [price] = @price, [fuel] = @fuel, " +
                        "[mileage] = @mileage, [clientid] = @clientid, [rentlogid] = @rentlogid, " +
                        "[picturepath] = @img, [date_start] = @date_start, [date_end] = @date_end," +
                        "[fuelmax] = @fuelmax, [maxspeed] = @maxspeed, [type] = @type, [transmission] = @transmission, [category] = @category " +
                        "WHERE [VIN] = @VIN";

                    command.Parameters.AddWithValue("plate", item.Plate);
                    command.Parameters.AddWithValue("name", item.Name);
                    command.Parameters.AddWithValue("model", item.Model);
                    command.Parameters.AddWithValue("price", item.Price);
                    command.Parameters.AddWithValue("fuel", item.Fuel);
                    command.Parameters.AddWithValue("mileage", item.Mileage);
                    command.Parameters.AddWithValue("clientid", item.ClientId);
                    command.Parameters.AddWithValue("rentlogid", item.RentLogId);
                    command.Parameters.AddWithValue("img", item.PicturePath);
                    command.Parameters.AddWithValue("VIN", item.VIN);

                    command.Parameters.AddWithValue("date_start", item.StartDate);
                    command.Parameters.AddWithValue("date_end", item.FinalDate);

                    command.Parameters.AddWithValue("fuelmax", item.MaxFuel);
                    command.Parameters.AddWithValue("maxspeed", item.MaxSpeed);
                    command.Parameters.AddWithValue("type", item.Type);
                    command.Parameters.AddWithValue("transmission", item.Transmission);
                    command.Parameters.AddWithValue("category", item.Category);

                    command.ExecuteNonQuery();
                }

            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void SaveVehicleImage(byte[] Image, string Name, string Extension)
        {
            string path = Log.AppPath + "\\vehicleimage\\" + Name + Extension;
            File.WriteAllBytes(path, Image);
        }

        public byte[] VehicleImage()
        {
            string path = Log.AppPath + "\\vehicleimage\\" + PicturePath;
            string errorpath = Log.AppPath + "\\vehicleimage\\error.png";

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

        public static bool IsVehicleValid(string VIN, List<Vehicle> numerable)
        {
            foreach (var item in numerable)
            {
                if (item.VIN == VIN)
                    return true;
            }

            return false;
        }
    }

    
        
}
