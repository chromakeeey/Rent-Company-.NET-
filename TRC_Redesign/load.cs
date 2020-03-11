using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class load : Form
    {

        UI ui = new UI();
        Form1 mainWindow = new Form1();
        login Login = new login();

        public int actionCurrent;
        const int animSpeed = 1;
        int xPlus = 10;

        public load()
        {
            

            InitializeComponent();

            this.CenterToScreen();
        }

        public static bool isEthernet()
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
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            gradientPanel1.Location = new Point(-16, 177);

            timer1.Interval = animSpeed;
            timer1.Start();

            Login.mainWindow = mainWindow;
            mainWindow.Login = Login;

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

        private void OnApplicationExit(object sender, EventArgs e)
        {
            mainWindow.serverData.disconnect();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (actionCurrent)
            {
                case 0:
                    {
                        if ( !isEthernet() )
                        {
                            MessageBox.Show("У вас відсутній інтернет-підключення.", "Відмова", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            System.Windows.Forms.Application.Exit();

                            return;
                        }


                        label2.Text = "Створюється підключення до сервера.";
                        mainWindow.serverData.connect();

                        actionCurrent = 1;

                        break;
                    }
                case 1:
                    {
                        label2.Text = "Вигрузка інформацію про оформлення.";

                        List<UI> tmpUI = mainWindow.clientData.ui.LoadTheme();
                        foreach (UI itemUI in tmpUI) { mainWindow.clientData.ui = itemUI; }

                        mainWindow.clientData.ui.panelidNow = -1;
                        mainWindow.clientData.ui.subPanelNow = -1;

                        mainWindow.clientData.ui.ColorsToARGB();
                        mainWindow.clientData.ui.SetTheme(mainWindow, mainWindow.clientData.ui.themeCurrent);

                        actionCurrent = 2;

                        break;
                    }
                case 2:
                    {
                        label2.Text = "Вигрузка інформацію про оформлення.";

                        

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
                        Login.mainWindow = mainWindow;

                        timer2.Stop();

                        break;
                    }
            }
        }
    }
}
