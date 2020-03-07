using System;

namespace WCF_Rent.HeaderFile
{
    public class Account : Admin
    {
        // singleton
        //public static account instance = null;

        public int documentid;
        public int accepted;

        public string name;
        public string secondname;
        public string fathername;

        public string login;
        public string password;

        public string phone;
        public string mail;

        public float balance;

        public DateTime dateCreate;

        public Account()
        {

            documentid = 0;
            accepted = 0;
            balance = 0;

            name = "";
            secondname = "";
            fathername = "";

            login = "";
            password = "";

            phone = "";
            mail = "";
        }

        public void SetAccountData(int documentid, string name, string secondname, string fathername, string login, string password, string phone, string mail)
        {
            this.documentid = documentid;
            this.name = name;
            this.secondname = secondname;
            this.fathername = fathername;
            this.login = login;
            this.password = password;
            this.phone = phone;
            this.mail = mail;
        }

        public void ClearAccountData() { this.SetAccountData(0, "", "", "", "", "", "", ""); }

        /*public void SaveObjectAccount(SqlConnection sqlconnection)
        {
            SqlCommand command = new SqlCommand("UPDATE [accounts] SET [documentid] = @documentid, [login] = @login, [password] = @password, " +
                "[name] = @name, [secondname] = @secondname, [fathername] = @fathername, [email] = @email, [accepted] = @accepted, " +
                "[adminlevel] = @adminlevel, [balance] = @balance WHERE [documentid] = @docid", sqlconnection);

            command.Parameters.AddWithValue("documentid", this.documentid);
            command.Parameters.AddWithValue("login", this.login);
            command.Parameters.AddWithValue("password", this.password);
            command.Parameters.AddWithValue("name", this.name);
            command.Parameters.AddWithValue("secondname", this.secondname);
            command.Parameters.AddWithValue("fathername", this.fathername);
            command.Parameters.AddWithValue("email", this.mail);
            command.Parameters.AddWithValue("accepted", this.accepted);
            command.Parameters.AddWithValue("adminlevel", this.GetAdminLevel());
            command.Parameters.AddWithValue("docid", this.documentid);
            command.Parameters.AddWithValue("balance", this.balance);

            command.ExecuteNonQuery();
        }

        

        public void DeleteObjectAccount(SqlConnection sqlconnection)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [accounts] WHERE [documentid] = @docid", sqlconnection);

            command.Parameters.AddWithValue("documentid", this.documentid);
            command.ExecuteNonQuery();

            this.ClearAccountData();
        }  */

        /*public int GetRentIndex()
        {
            int index = -1;

            for (int i = 0; i < 1000; i++)
            {
                if (Form1.pointer.Vehicle[i].client_documentid != this.documentid)
                    continue;

                index = i;

                break;
            }

            return index;
        }*/

        //public bool IsUserRentCar() { return (this.GetRentIndex() != -1); }
    }
}
