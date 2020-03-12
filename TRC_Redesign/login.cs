using System;
using System.Windows.Forms;
using System.Data.SqlClient;

using TRC_Redesign.header;
using TRC_Redesign.CustomMessageBox;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class login : Form
    {
        public Form1 mainWindow;

        int mov;
        int movX;
        int movY;

        public login()
        {

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

        public void authAccount(Account account)
        {
            mainWindow.clientData.account = account;
            mainWindow.updateAccountData();
            
            mainWindow.Show();
            this.Hide();
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            Account account;

            // empty textbox
            if (login == "" || password == "")
            {
                label2.Text = "Ви не ввели логін або пароль.";
                label2.Visible = true;

                return;
            }

            account = mainWindow.serverData.client.selectAccount(login, password);

            if (account.documentid != 0)
            {
                if (account.accepted != 0)
                    authAccount(account);
                else
                {
                    label2.Text = "Аккаунт не активований (зачекайте перевірки)";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Text = "Пароль або логін невірний";
                label2.Visible = true;
            } 

        }

        private void login_Load(object sender, EventArgs e)
        {
            //LoadVehicle();

        }

        private void login_Closing(object sender, FormClosingEventArgs e)
        {
            mainWindow.closeApplication();
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

            string login = textBox10.Text;

            if ( !mainWindow.serverData.client.isAccountValid(login) )
            {
                Account account = new Account();

                account.name = textBox3.Text;
                account.secondname = textBox4.Text;
                account.fathername = textBox5.Text;
                account.documentid = Convert.ToInt32(textBox8.Text);
                account.mail = textBox6.Text;
                account.login = textBox10.Text;
                account.password = textBox9.Text;
                account.phone = textBox7.Text;

                mainWindow.serverData.client.addAccount(account);

                MsgBox.Show("Аккаунт був зареєстрований. Очікуйте перевірки адміністратором.",
                    "Перевірка аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, mainWindow);
            }
            else label11.Text = "Аккаунт з таким логіном вже зареєстрований.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //mainWindow.serverData.disconnect();
            //System.Windows.Forms.Application.Exit();

            mainWindow.closeApplication();
        }

        private void TMPCLICK(object sender, EventArgs e)
        {
           
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
