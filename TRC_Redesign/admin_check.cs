using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TRC_Redesign.header;

namespace TRC_Redesign
{
    public partial class admin_check : UserControl
    {
        public SqlConnection sqlconnection;
        public Form1 obj;

        account object_tmp = new account();

        public async void UpdateCheckAccount()
        {
            object_tmp.ClearAccountData();

            SqlDataReader sqlReader = null;
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM[accounts] WHERE[accepted] = 0", sqlconnection);

            bool login_search = false;

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    login_search = true;

                    object_tmp.SetAccountData(Convert.ToInt32(sqlReader["documentid"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["secondname"]),
                        Convert.ToString(sqlReader["fathername"]),
                        Convert.ToString(sqlReader["login"]),
                        Convert.ToString(sqlReader["password"]),
                        Convert.ToString(sqlReader["phone"]),
                        Convert.ToString(sqlReader["email"])
                    );

                    object_tmp.dateCreate = Convert.ToDateTime(sqlReader["datecreate"]);

                    break;
                }

                if (login_search)
                {
                    label40.Text = object_tmp.name;
                    label5.Text = object_tmp.secondname;
                    label7.Text = object_tmp.fathername;
                    label9.Text = object_tmp.mail;
                    label11.Text = object_tmp.phone;
                    label13.Text = object_tmp.documentid.ToString();
                    label1.Text = object_tmp.login;

                    label3.Text = object_tmp.dateCreate.ToShortDateString();

                    panel1.Visible = true;

                    label15.Visible = false;
                    label16.Visible = false;
                    pictureBox1.Visible = false;

                }
                else
                {
                    panel1.Visible = false;

                    label15.Visible = true;
                    label16.Visible = true;
                    pictureBox1.Visible = true;
                }
            }

            catch (Exception ex)
            {
                
                obj.dialogCreate(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        public void AdminCheckPageLoad(SqlConnection sqlconnection)
        {
            this.sqlconnection = sqlconnection;
            UpdateCheckAccount();
        }

        public admin_check()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateCheckAccount();
        }

        // accept
        private void jThinButton1_Click(object sender, EventArgs e)
        {
            object_tmp.accepted = 1;
            object_tmp.SaveObjectAccount(sqlconnection);

            UpdateCheckAccount();

            obj.dialogCreate("Ви підтвердили аккаунт.", "Підтвердження аккаунта", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // decline
        private void jThinButton3_Click(object sender, EventArgs e)
        {
            object_tmp.accepted = 2;
            object_tmp.SaveObjectAccount(sqlconnection);

            UpdateCheckAccount();

            obj.dialogCreate("Ви відмовили аккаунту в реєстрації", "Відмовлення", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
