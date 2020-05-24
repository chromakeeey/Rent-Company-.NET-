using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.IO;

using WCF_Rent.Providers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WCF_Rent.HeaderFile
{
    [DataContract]
    public class User : Admin
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Mail { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public float Balance { get; set; }

        [DataMember]
        public List<string> LicenseCategories { get; set; }

        [DataMember]
        public DateTime BirthdayDate { get; set; }

        [DataMember]
        public DateTime UserCreateDate { get; set; }

        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public string StatusReason { get; set; }

        [DataMember]
        public string BackImageName { get; set; }

        [DataMember]
        public string FrontImageName { get; set; }

        public User()
        {
            Name = "null";
            Surname = "null";
            BirthdayDate = DateTime.Now;
            Balance = 0;

            LicenseCategories = new List<string>();
            LicenseCategories.Add("null");
        }

        public Vehicle GetVehicle(List<Vehicle> numerable)
        {
            try
            {
                Vehicle item = new Vehicle();
                item.VIN = "null";

                foreach (var i in numerable)
                {
                    if (i.ClientId == Id)
                    {
                        item = i;
                        break;
                    }
                }

                return item;
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Log.Add(LogStyle.Error,
                    ex.Message.ToString() + " " + ex.Source.ToString() +
                    Convert.ToString(line));
            }

            return new Vehicle();
        }

        public byte[] BackImageBytes()
        {
            string path = Log.AppPath + "\\documentimage\\" + BackImageName;
            string errorpath = Log.AppPath + "\\documentimage\\error.png";

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

        public byte[] FrontImageBytes()
        {
            string path = Log.AppPath + "\\documentimage\\" + FrontImageName;
            string errorpath = Log.AppPath + "\\documentimage\\error.png";

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

        // static methods (operation with sql and images)

        public static void SaveBackImage(byte[] Image, string Name, string Extension)
        {
            string path = Log.AppPath + "\\documentimage\\" + Name + Extension;
            File.WriteAllBytes(path, Image);
        }

        public static void SaveFrontImage(byte[] Image, string Name, string Extension)
        {
            string path = Log.AppPath + "\\documentimage\\" + Name + Extension;
            File.WriteAllBytes(path, Image);
        }

        public static User SelectUser_LoginPassword(string Login, string Password)
        {
            try
            {
                User item = new User();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Users] WHERE [login] = @login AND [password] = @password", SqlData.sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("login", Login);
                    sqlCommand.Parameters.AddWithValue("password", Password);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        item = new User()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Surname = reader["surname"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString(),
                            Mail = reader["mail"].ToString(),
                            Phone = reader["phone"].ToString(),
                            LicenseCategories = JsonConvert.DeserializeObject<List<string>>(reader["category"].ToString()),
                            Level = Convert.ToInt32(reader["admin"]),
                            Balance = Convert.ToInt32(reader["balance"]),

                            Status = Convert.ToInt32(reader["status"]),
                            StatusReason = reader["status_reason"].ToString(),

                            BirthdayDate = Convert.ToDateTime(reader["birthday_date"]),
                            UserCreateDate = Convert.ToDateTime(reader["create_date"]),

                            BackImageName = reader["back_image"].ToString(),
                            FrontImageName = reader["front_image"].ToString(),

                            CardNumber = reader["cardnumber"].ToString(),
                            ExpireDate = reader["expiredate"].ToString(),
                            OwnerName = reader["ownername"].ToString(),
                            CVV = Convert.ToInt32(reader["cvv"])
                        };

                        break;
                    }

                    if (reader != null)
                        reader.Close();

                    return item;
                }
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Log.Add(LogStyle.Error,
                    ex.Message.ToString() + " " + ex.Source.ToString() +
                    Convert.ToString(line));
            }

            return new User();
        }

        public static List<User> SelectAllUser()
        {
            try
            {
                List<User> numerable = new List<User>();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Users]", SqlData.sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        User item = new User()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Surname = reader["surname"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString(),
                            Mail = reader["mail"].ToString(),
                            Phone = reader["phone"].ToString(),
                            LicenseCategories = JsonConvert.DeserializeObject<List<string>>(reader["category"].ToString()),
                            Level = Convert.ToInt32(reader["admin"]),
                            Balance = Convert.ToInt32(reader["balance"]),

                            Status = Convert.ToInt32(reader["status"]),
                            StatusReason = reader["status_reason"].ToString(),

                            BirthdayDate = Convert.ToDateTime(reader["birthday_date"]),
                            UserCreateDate = Convert.ToDateTime(reader["create_date"]),

                            BackImageName = reader["back_image"].ToString(),
                            FrontImageName = reader["front_image"].ToString(),

                            CardNumber = reader["cardnumber"].ToString(),
                            ExpireDate = reader["expiredate"].ToString(),
                            OwnerName = reader["ownername"].ToString(),
                            CVV = Convert.ToInt32(reader["cvv"])
                        };

                        numerable.Add(item);
                    }

                    if (reader != null)
                        reader.Close();
                }

                return numerable;
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Log.Add(LogStyle.Error,
                    ex.Message.ToString() + " " + ex.Source.ToString() +
                    Convert.ToString(line));
            }

            return new List<User>();
        }

        public static User SelectUserApplication()
        {
            try
            {
                User item = new User();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Users] WHERE [status] = 0", SqlData.sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        item = new User()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Surname = reader["surname"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString(),
                            Mail = reader["mail"].ToString(),
                            Phone = reader["phone"].ToString(),
                            LicenseCategories = JsonConvert.DeserializeObject<List<string>>(reader["category"].ToString()),
                            Level = Convert.ToInt32(reader["admin"]),
                            Balance = Convert.ToInt32(reader["balance"]),

                            Status = Convert.ToInt32(reader["status"]),
                            StatusReason = reader["status_reason"].ToString(),

                            BirthdayDate = Convert.ToDateTime(reader["birthday_date"]),
                            UserCreateDate = Convert.ToDateTime(reader["create_date"]),

                            BackImageName = reader["back_image"].ToString(),
                            FrontImageName = reader["front_image"].ToString(),

                            CardNumber = reader["cardnumber"].ToString(),
                            ExpireDate = reader["expiredate"].ToString(),
                            OwnerName = reader["ownername"].ToString(),
                            CVV = Convert.ToInt32(reader["cvv"])
                        };

                        break;
                    }

                    if (reader != null)
                        reader.Close();
                }

                return item;
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Log.Add(LogStyle.Error,
                    ex.Message.ToString() + " " + ex.Source.ToString() +
                    Convert.ToString(line));
            }

            return new User();
        }

        public static User SelectUser(int Id)
        {
            try
            {
                User item = new User();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Users] WHERE [Id] = @unicalid", SqlData.sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("unicalid", Id);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        item = new User()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Surname = reader["surname"].ToString(),
                            Login = reader["login"].ToString(),
                            Password = reader["password"].ToString(),
                            Mail = reader["mail"].ToString(),
                            Phone = reader["phone"].ToString(),
                            LicenseCategories = JsonConvert.DeserializeObject<List<string>>(reader["category"].ToString()),
                            Level = Convert.ToInt32(reader["admin"]),
                            Balance = Convert.ToInt32(reader["balance"]),

                            Status = Convert.ToInt32(reader["status"]),
                            StatusReason = reader["status_reason"].ToString(),

                            BirthdayDate = Convert.ToDateTime(reader["birthday_date"]),
                            UserCreateDate = Convert.ToDateTime(reader["create_date"]),

                            BackImageName = reader["back_image"].ToString(),
                            FrontImageName = reader["front_image"].ToString(),

                            CardNumber = reader["cardnumber"].ToString(),
                            ExpireDate = reader["expiredate"].ToString(),
                            OwnerName = reader["ownername"].ToString(),
                            CVV = Convert.ToInt32(reader["cvv"])
                        };

                        break;
                    }

                    if (reader != null)
                        reader.Close();
                }

                return item;
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) 
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Log.Add(LogStyle.Error, 
                    ex.Message.ToString() + " " + ex.Source.ToString() +
                    Convert.ToString(line) ); 
            }

            return new User();
        }

        public static void SaveUser(User item)
        {
            try
            {
                using (SqlCommand command = SqlData.sqlConnection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Users] SET [name] = @name, [surname] = @surname, [login] = @login, [password] = @password," +
                        "[mail] = @mail, [phone] = @phone, [category] = @category, [admin] = @admin, [status] = @status, [status_reason] = @status_reason," +
                        "[birthday_date] = @birthday_date, [create_date] = @create_date, [back_image] = @back_image, [front_image] = @front_image," +
                        "[cardnumber] = @cardnumber, [expiredate] = @expiredate, [ownername] = @ownername, [cvv] = @cvv, [balance] = @balance " +
                        "WHERE [id] = @id";

                    command.Parameters.AddWithValue("name", item.Name);
                    command.Parameters.AddWithValue("surname", item.Surname);
                    command.Parameters.AddWithValue("login", item.Login);
                    command.Parameters.AddWithValue("password", item.Password);
                    command.Parameters.AddWithValue("mail", item.Mail);
                    command.Parameters.AddWithValue("phone", item.Phone);
                    command.Parameters.AddWithValue("category", JsonConvert.SerializeObject(item.LicenseCategories));
                    command.Parameters.AddWithValue("admin", item.Level);
                    command.Parameters.AddWithValue("status", item.Status);
                    command.Parameters.AddWithValue("status_reason", item.StatusReason);
                    command.Parameters.AddWithValue("birthday_date", item.BirthdayDate);
                    command.Parameters.AddWithValue("create_date", item.UserCreateDate);
                    command.Parameters.AddWithValue("back_image", item.BackImageName);
                    command.Parameters.AddWithValue("front_image", item.FrontImageName);
                    command.Parameters.AddWithValue("cardnumber", item.CardNumber);
                    command.Parameters.AddWithValue("expiredate", item.ExpireDate);
                    command.Parameters.AddWithValue("ownername", item.OwnerName);
                    command.Parameters.AddWithValue("cvv", item.CVV);
                    command.Parameters.AddWithValue("balance", item.Balance);

                    command.Parameters.AddWithValue("id", item.Id);
                    command.ExecuteNonQuery();
                }

            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void AddUser(User item)
        {
            try
            {
                using (SqlCommand command = SqlData.sqlConnection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Users] " +
                        "(name, surname, login, password, mail, phone, category, admin, status, status_reason, birthday_date, create_date, back_image," +
                        "front_image, cardnumber, expiredate, ownername, cvv, balance) " +
                        "VALUES " +
                        "(@name, @surname, @login, @password, @mail, @phone, @category, @admin, @status, @status_reason, @birthday_date, @create_date, @back_image," +
                        "@front_image, @cardnumber, @expiredate, @ownername, @cvv, @balance)";

                    command.Parameters.AddWithValue("name", item.Name);
                    command.Parameters.AddWithValue("surname", item.Surname);
                    command.Parameters.AddWithValue("login", item.Login);
                    command.Parameters.AddWithValue("password", item.Password);
                    command.Parameters.AddWithValue("mail", item.Mail);
                    command.Parameters.AddWithValue("phone", item.Phone);
                    command.Parameters.AddWithValue("category", JsonConvert.SerializeObject(item.LicenseCategories));
                    command.Parameters.AddWithValue("admin", item.Level);
                    command.Parameters.AddWithValue("status", item.Status);
                    command.Parameters.AddWithValue("status_reason", item.StatusReason);
                    command.Parameters.AddWithValue("birthday_date", item.BirthdayDate);
                    command.Parameters.AddWithValue("create_date", item.UserCreateDate);
                    command.Parameters.AddWithValue("back_image", item.BackImageName);
                    command.Parameters.AddWithValue("front_image", item.FrontImageName);
                    command.Parameters.AddWithValue("cardnumber", item.CardNumber);
                    command.Parameters.AddWithValue("expiredate", item.ExpireDate);
                    command.Parameters.AddWithValue("ownername", item.OwnerName);
                    command.Parameters.AddWithValue("cvv", item.CVV);
                    command.Parameters.AddWithValue("balance", item.Balance);

                    command.ExecuteNonQuery();
                }

            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }

        public static void DeleteUser(User item)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM [Users] WHERE [id] = @id");
                sqlCommand.Parameters.AddWithValue("id", item.Id);
                sqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (InvalidOperationException ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
            catch (Exception ex) { Log.Add(LogStyle.Error, ex.Message.ToString() + " " + ex.Source.ToString()); }
        }
    }
}
