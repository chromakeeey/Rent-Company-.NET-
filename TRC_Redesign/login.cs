using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TRC_Redesign.header;
using TRC_Redesign.CustomMessageBox;

namespace TRC_Redesign
{
    public partial class login : Form
    {
        public static login pointer = null;
        public Form1 MainForm;
        public SqlConnection sqlconnection;

        int mov;
        int movX;
        int movY;

        public login()
        {
            if (pointer == null)
                pointer = this;

            InitializeComponent();

            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.10d) == 1) timer.Stop();
            });
            timer.Interval = 30;
            timer.Start();
            this.CenterToScreen();
        }

        async void RegisterAccount(string name, string surname, string fathername, int documentid, string mail, string login, string password, string phone)
        {
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("INSERT INTO [accounts] (name, secondname, fathername, documentid, email, login, password, phone, datecreate) VALUES" +
                "(N'" + name + "', N'" + surname + "', N'" + fathername + "', '" + documentid + "', '" + mail +
                "', N'" + login + "', N'" + password + "', '" + phone + "', @dateCreate)", sqlconnection);

            command.Parameters.AddWithValue("dateCreate", DateTime.Now);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync()) { }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        async void CheckAccountRegister(string login)
        {
            bool answer = false;

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [accounts] WHERE login = '" + login + "'", sqlconnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync()) { answer = true; break;  }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }


            if (answer)
            {
                label11.Visible = true;
                label11.Text = "Такий аккаунт вже зареєстрований.";
            }
            else
            {
                RegisterAccount(textBox3.Text, textBox4.Text, textBox5.Text,
                    Convert.ToInt32(textBox8.Text), textBox6.Text,
                    textBox10.Text, textBox9.Text, textBox7.Text);

                MsgBox.Show("Аккаунт був зареєстрований. Очікуйте перевірки адміністратором.",
                    "Перевірка аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MainForm);
         
            }

        }

        public async void LoadVehicle()
        {
            int pointer = 0;

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [vehicles]", sqlconnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    Form1.pointer.Vehicle[pointer].AddVehicle(
                        sqlReader["plate"].ToString(),
                        sqlReader["name"].ToString(),
                        sqlReader["model"].ToString(),
                        Convert.ToSingle(sqlReader["price"]),
                        Convert.ToSingle(sqlReader["fuel"]),
                        Convert.ToSingle(sqlReader["mileage"])
                    );

                    Form1.pointer.Vehicle[pointer].image_link = Convert.ToString(sqlReader["image_link"]);
                    Form1.pointer.Vehicle[pointer].client_documentid = Convert.ToInt32(sqlReader["client_documentid"]);

                    Form1.pointer.Vehicle[pointer].start_date = Convert.ToDateTime(sqlReader["date_start"]);
                    Form1.pointer.Vehicle[pointer].end_date = Convert.ToDateTime(sqlReader["date_end"]);

                    pointer++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        public void SuccessAuth()
        {

            MainForm.UpdateAccountInformation();
            label2.Visible = false;

            MainForm.Show();
            Hide();

        }

        private async void jThinButton2_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [accounts] WHERE login = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", sqlconnection);
            bool loginSuccess = false;

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    loginSuccess = true;

                    account.instance.SetAccountData(Convert.ToInt32(sqlReader["documentid"]),
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["secondname"]),
                        Convert.ToString(sqlReader["fathername"]),
                        Convert.ToString(sqlReader["login"]),
                        Convert.ToString(sqlReader["password"]),
                        sqlReader["phone"].ToString(),
                        sqlReader["email"].ToString()
                    );

                    account.instance.SetAdminLevel(Convert.ToInt32(sqlReader["adminlevel"]));
                    account.instance.balance = Convert.ToSingle(sqlReader["balance"]);
                    account.instance.dateCreate = Convert.ToDateTime(sqlReader["datecreate"]);
                    account.instance.accepted = Convert.ToInt32(sqlReader["accepted"]);

                    break;
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();

                if (loginSuccess)
                {
                    // if account not accepted
                    if (account.instance.accepted == 0)
                    {

                        label2.Text = "Аккаунт не активований (зачекайте перевірки)";
                        label2.Visible = true;
                    }
                    else
                    {
                        SuccessAuth();
                    }

                }
                else
                {

                    label2.Text = "Пароль або логін невірний";
                    label2.Visible = true;
                }

            }


        }

        private void login_Load(object sender, EventArgs e)
        {
            LoadVehicle();

        }

        private void login_Closing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" 
                || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" 
                || textBox9.Text == "" || textBox10.Text == "")
            {
                label11.Visible = true;
                label11.Text = "Ви не ввели всі дані.";

                return;
            }

            CheckAccountRegister(textBox10.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TMPCLICK(object sender, EventArgs e)
        {
            load Load = new load();

            Load.Show();
            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void msDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void msUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void msMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
