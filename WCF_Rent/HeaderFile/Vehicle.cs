using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Rent.HeaderFile
{
    
    public class Vehicle : Rent
    {
        //public static vehicle instance = null;

        // primary key
        public string plate;
        public string name;
        public string model;
        public string image_link;

        // per mounth
        public float price;
        public float fuel;
        public float mileage;

        public int maxspeed;
        public float maxfuel;

        public string type;
        public string transmission;
        public string category;

        
        public Vehicle()
        {

            plate = "none";
            name = "";
            model = "";
            image_link = "";

            maxspeed = 200;
            maxfuel = 60;

            price = 0;
            fuel = 0;
            mileage = 0;

            type = "Легковий";
            transmission = "Механічна";
            category = "B";
        }

        public bool isValidVehicle()
        {
            return (this.plate != "none");
        }


        /*public void AddVehicle(string plate, string name, string model, float price, float fuel, float mileage)
        {
            this.plate = plate;
            this.name = name;
            this.model = model;
            this.price = price;
            this.fuel = fuel;
            this.mileage = mileage;
        }

        public void SaveObjectVehicle(SqlConnection sqlconnection)
        {
            SqlCommand command = new SqlCommand("UPDATE [vehicles] SET [plate] = @plate, " +
                "[name] = @name, [model] = @model, [price] = @price, [fuel] = @fuel, " +
                "[mileage] = @mileage, [client_documentid] = @client_documentid," +
                "[image_link] = @img, [date_start] = @date_start, [date_end] = @date_end " +
                "WHERE [plate] = @plt", sqlconnection);

            command.Parameters.AddWithValue("plate", this.plate);
            command.Parameters.AddWithValue("name", this.name);
            command.Parameters.AddWithValue("model", this.model);
            command.Parameters.AddWithValue("price", this.price);
            command.Parameters.AddWithValue("fuel", this.fuel);
            command.Parameters.AddWithValue("mileage", this.mileage);
            command.Parameters.AddWithValue("client_documentid", this.client_documentid);
            command.Parameters.AddWithValue("img", this.image_link);
            command.Parameters.AddWithValue("plt", this.plate);

            command.Parameters.AddWithValue("date_start", this.start_date);
            command.Parameters.AddWithValue("date_end", this.end_date);

            command.ExecuteNonQuery();
        }

        public void InsertObjectVehicle(SqlConnection sqlconnection)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [vehicles] " +
                "(plate, name, model, price, fuel, mileage, client_documentid, image_link, date_start, date_end) VALUES" +
                "(@plate, @name, @model, @price, @fuel, @mileage, @client_documentid, @image_link, @date_start, @date_end)", sqlconnection);

            command.Parameters.AddWithValue("plate", this.plate);
            command.Parameters.AddWithValue("name", this.name);
            command.Parameters.AddWithValue("model", this.model);
            command.Parameters.AddWithValue("price", this.price);
            command.Parameters.AddWithValue("fuel", this.fuel);
            command.Parameters.AddWithValue("mileage", this.mileage);
            command.Parameters.AddWithValue("client_documentid", this.client_documentid);
            command.Parameters.AddWithValue("image_link", this.image_link);

            command.Parameters.AddWithValue("date_start", this.start_date);
            command.Parameters.AddWithValue("date_end", this.end_date);

            command.ExecuteNonQuery();
        }*/
    }

}
