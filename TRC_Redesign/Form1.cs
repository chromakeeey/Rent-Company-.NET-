using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.ServiceModel;

using TRC_Redesign.header;
using TRC_Redesign.CustomMessageBox;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class Form1 : Form
    {
        public ClientData clientData = new ClientData();
        public ServerData serverData = new ServerData();

        public login Login;
        public VehicleInfo vehicleInfo = new VehicleInfo();

        int mov;
        int movX;
        int movY;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public void updateAccountData()
        {
            label4.Text = clientData.account.balance.ToString() + " грн.";

            Vehicle vehicle = serverData.client.getUserVehicle(clientData.account);

            if (vehicle.plate != "none")
            {
                TimeSpan delta = DateTime.Now - vehicle.end_date;
                label5.Text = (delta.Days > 0) ? (delta.Days * vehicle.price + " грн.") : "0 грн.";
            }
            else
                label5.Text = "0 грн.";

            main_page1.label1.Text = "Вітаємо, " + clientData.account.name + "!";
            label2.Text = clientData.account.login;

            button5.Visible = (clientData.account.level != 0) ? true : false;
            btn_statistic.Visible = (clientData.account.level != 0) ? true : false;
        }

        public DialogResult dialogCreate(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {

            DialogResult dialogResult; 
            dialogResult = MsgBox.Show(message, caption, button, icon, this);

            return dialogResult;
        }

        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //vehicle
        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button2.Location.Y);

            clientData.ui.CreatePanel(clientData.ui.VEHICLE_PANEL, this);

            //login.instance
        }

        // pay
        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button3.Location.Y);

            clientData.ui.CreatePanel(clientData.ui.PAYMENT_PANEL, this);
        }

        // settings
        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button4.Location.Y);

            clientData.ui.CreatePanel(clientData.ui.SETTING_PANEL, this);
        }
        
        // admin
        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button5.Location.Y);

            clientData.ui.CreatePanel(clientData.ui.ADMIN_PANEL, this);

            this.admin_page1.UpdateStatisticInformation();

        }

        // main
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button1.Location.Y);

            clientData.ui.CreatePanel(clientData.ui.MAIN_PANEL, this);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button1.Location.Y);
            clientData.ui.CreatePanel(clientData.ui.MAIN_PANEL, this);

            admin_page1.panel9.Location = new Point(admin_page1.button1.Location.X, admin_page1.panel9.Location.Y);
            clientData.ui.CreateAdminSubPanel(clientData.ui.SUB_CHECK_PANEL, admin_page1);

            vehicle_page1.mainWindow = this;
            settings_page1.mainWindow = this;
            main_page1.mainWindow = this;
            admin_page1.mainWindow = this;
            admin_page1.admin_check1.mainWindow = this;
            admin_page1.admin_vehicleadd1.mainWindow = this;
            admin_page1.vehicleEdit.mainWindow = this;
            vehicleInfo.mainWindow = this;
            payment_page1.mainWindow = this;

            ucStatistic.mainWindow = this;
            ucStatistic.ucStatClient.mainWindow = this;
            ucStatistic.ucStatClient.updateAccounts();
            ucStatistic.ucStatClient.updateTop();

            clientData.mainWindow = this;
            serverData.mainWindow = this;

            main_page1.updateVehicleData();
            main_page1.updateNameData();

            admin_page1.admin_check1.updateAccountObject();
            admin_page1.admin_check1.updateAccountData();
            admin_page1.admin_vehicleadd1.updateComboBox();

            clientData.ui.CreatePanel(clientData.ui.MAIN_PANEL, this);
        }

        private void admin_page1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //account.instance.ClearAccountData();
            Login.textBox1.Text = "";
            Login.textBox2.Text = "";

            this.Hide();

            Login.Show();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            closeApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*clientData.ui.SaveTheme();
            serverData.disconnect();

            System.Windows.Forms.Application.Exit();*/

            closeApplication();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            //Form1.pointer.ui.SetTheme(this, Form1.pointer.ui.theme_Light);
        }

        private void OnDarkClick(object sender, EventArgs e)
        {
            //Form1.pointer.ui.SetTheme(this, Form1.pointer.ui.theme_Dark);
        }

        private void MsDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void msMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void msUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clickPanelRight(object sender, EventArgs e)
        {
            
        }

        public void closeApplication()
        {
            Application.Exit();
        }

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, btn_statistic.Location.Y);
            clientData.ui.CreatePanel(5, this);
        }
    }
}
