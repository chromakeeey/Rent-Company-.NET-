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
using System.Net;

namespace TRC_Redesign
{
    public partial class load : Form
    {
        SqlConnection sqlconnection;

        UI ui = new UI();
        Form1 MainForm = new Form1();
        login Login = new login();

        public int actionCurrent;
        const int animSpeed = 1;
        int xPlus = 10;

        public load()
        {
            

            InitializeComponent();

            this.CenterToScreen();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        private void load_Load(object sender, EventArgs e)
        {
            
            gradientPanel1.Location = new Point(-16, 177);

            timer1.Interval = animSpeed;
            timer1.Start();

            label2.Text = " ";
            actionCurrent = 0;
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X = gradientPanel1.Location.X;
            gradientPanel1.Location = new Point(X + xPlus, 177);

            if (X > 561)
                gradientPanel1.Location = new Point(-16, 177);

            //SetAnimationPicture(pictureID > 4 ? 0 : pictureID + 1);
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            switch (actionCurrent)
            {
                case 0:
                    {
                        if (!CheckForInternetConnection())
                        {
                            MessageBox.Show("У вас відсутній інтернет-підключення.", "Відмова", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            System.Windows.Forms.Application.Exit();

                            return;
                        }


                        label2.Text = "Створюється підключення до бази даних.";

                        string StringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|rentcar.mdf;Integrated Security=True";
                        sqlconnection = new SqlConnection(StringConnect);

                        while (!(sqlconnection != null && sqlconnection.State != ConnectionState.Closed))
                        {
                            sqlconnection.Close();

                            sqlconnection = null;
                            sqlconnection = new SqlConnection(StringConnect);

                            Login.sqlconnection = this.sqlconnection;
                            MainForm.sqlconnection = this.sqlconnection;
                            MainForm.Login = this.Login;

                            await sqlconnection.OpenAsync();
                        }

                        actionCurrent = 1;

                        break;
                    }
                case 1:
                    {
                        label2.Text = "Вигрузка інформацію про оформлення.";

                        List<UI> tmpUI = ui.LoadTheme();
                        foreach (UI itemUI in tmpUI) { ui = itemUI; }

                        actionCurrent = 2;

                        break;
                    }
                case 2:
                    {
                        label2.Text = "Встановлення теми.";

                        ui.panelidNow = -1;
                        ui.subPanelNow = -1;

                        ui.ColorsToARGB();
                        ui.SetTheme(MainForm, ui.themeCurrent);
                        Login.MainForm = this.MainForm;
                        MainForm.ui = this.ui;
                        //MainForm.Login = this.Login;

                        actionCurrent = 3;

                        break; 
                    }
                case 3:
                    {
                        label2.Text = "Завершення вигрузки інформації.";

                        actionCurrent = 4;

                        break;
                    }
                case 4:
                    {

                        Hide();
                        Login.Show();

                        timer2.Stop();

                        break;
                    }
            }
        }
    }
}
