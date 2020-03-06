using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC_Redesign.header;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using TRC_Redesign.CustomMessageBox;
using System.Drawing.Imaging;

namespace TRC_Redesign
{
    public partial class Form1 : Form
    {
        private PictureBox pb;
        public static Form1 pointer = null;

        public UI ui;
        public account Account = new account();
        public vehicle[] Vehicle = new vehicle[1000];
        public login Login = new login();
        public VehicleInfo vinfo = new VehicleInfo();

        public SqlConnection sqlconnection;
        public int DarkMode = 1;

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

        public void UpdateAccountInformation()
        {
            label4.Text = account.instance.balance.ToString() + " грн.";

            if (account.instance.IsUserRentCar())
            {
                int vehicleid = account.instance.GetRentIndex();

                TimeSpan delta = DateTime.Now - Form1.pointer.Vehicle[vehicleid].end_date;
                label5.Text = (delta.Days > 0) ? (delta.Days * Form1.pointer.Vehicle[vehicleid].price + " грн.") : "0 грн.";
            }
            else label5.Text = "0 грн.";

            main_page1.label1.Text = "Вітаємо, " + account.instance.name + "!";
            label2.Text = account.instance.login;
            button5.Visible = (account.instance.GetAdminLevel() != 0) ? true : false;
        }

        

        public DialogResult dialogCreate(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {

            DialogResult dialogResult; 
            dialogResult = MsgBox.Show(message, caption, button, icon, this);

            return dialogResult;
        }

        public Form1()
        {
            if (pointer == null)
                pointer = this;

            for (int i = 0; i < 1000; i++)
                Vehicle[i] = new vehicle();

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

            ui.CreatePanel(ui.VEHICLE_PANEL, this);

            //login.instance
        }

        // pay
        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button3.Location.Y);

            ui.CreatePanel(ui.PAYMENT_PANEL, this);
        }

        // settings
        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button4.Location.Y);

            ui.CreatePanel(ui.SETTING_PANEL, this);
        }
        
        // admin
        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button5.Location.Y);

            ui.CreatePanel(ui.ADMIN_PANEL, this);

            this.admin_page1.UpdateStatisticInformation();

        }

        // main
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(panel5.Location.X, button1.Location.Y);

            ui.CreatePanel(ui.MAIN_PANEL, this);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            main_page1.sqlconnection = this.sqlconnection;
            vehicle_page1.sqlconnection = this.sqlconnection;
            admin_page1.sqlconnection = this.sqlconnection;

            main_page1.loadForm();
            vehicle_page1.LoadVehiclePage();
            admin_page1.AdminPageLoad();

            vehicle_page1.MainPointer = this;
            settings_page1.objectForm = this;
            main_page1.pointerForm = this;
            admin_page1.obj = this;
            admin_page1.admin_check1.obj = this;
            admin_page1.admin_vehicleadd1.obj = this;

            //if (account.instance.GetAdminLevel() != 0)
            //    button5.Visible = true;

            //UpdateAccountInformation();
            ui.CreatePanel(ui.MAIN_PANEL, this);



            /*var frm = this;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save("screenshot.png", System.Drawing.Imaging.ImageFormat.Png);
            }*/
        }

        

        private void admin_page1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            account.instance.ClearAccountData();
            Login.textBox1.Text = "";
            Login.textBox2.Text = "";

            this.Hide();

            Login.Show();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (sqlconnection != null && sqlconnection.State != ConnectionState.Closed)
                sqlconnection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ui.SaveTheme();

            System.Windows.Forms.Application.Exit();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DarkMode_Click(object sender, EventArgs e)
        {
            Form1.pointer.ui.SetTheme(this, Form1.pointer.ui.theme_Light);
        }

        private void OnDarkClick(object sender, EventArgs e)
        {
            Form1.pointer.ui.SetTheme(this, Form1.pointer.ui.theme_Dark);
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
    }
}
