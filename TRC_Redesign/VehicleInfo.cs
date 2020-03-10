using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using TRC_Redesign.header;
using TRC_Redesign.RentPicker;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class VehicleInfo : Form
    {
        private DateTime rentDate;
        private float totalPrice;

        private Vehicle vehicle;
        public Form1 mainWindow;

        public VehicleInfo()
        {
            InitializeComponent();
        }

        int mov;
        int movX;
        int movY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        public void tryRentVehicle()
        {

            if (vehicle.plate == "none")
            {
                MessageBox.Show("Автомобіль який ви переглядали більше недоступний. \nМожливо хтось видалив автомобіль або змінив номерний знак.", "Відміна оренди",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Hide();

                return;
            }

            if (totalPrice > mainWindow.clientData.account.balance)
            {
                MessageBox.Show("Оренда неможлива, поповніть рахунок.", "Відміна оренди",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (vehicle.client_documentid != 0)
            {
                MessageBox.Show("Оренда неможлива, автомобіль вже орендований.", "Відміна оренди",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult answer = MessageBox.Show("Ви дійсно хочите орендувати " + vehicle.name + " " + vehicle.model + "?\n\n" +
                "Дата початку оренди: " + DateTime.Now.ToShortTimeString() + "\n" +
                "Дата кінця оренди: " + rentDate.ToShortTimeString(), "Підтвердіть дію", MessageBoxButtons.YesNoCancel);

            if (answer == DialogResult.Yes)
            {
                mainWindow.clientData.account.balance -= totalPrice;

                vehicle.client_documentid = mainWindow.clientData.account.documentid;

                vehicle.start_date = DateTime.Now;
                vehicle.end_date = rentDate;

                mainWindow.serverData.client.saveVehicle(vehicle);
                mainWindow.updateAccountData();
                mainWindow.main_page1.updateVehicleData();

                mainWindow.clientData.ui.CreatePanel(mainWindow.clientData.ui.MAIN_PANEL, mainWindow);
                Hide();
                
                MessageBox.Show("Ви орендовали автомобіль. Вітаємо!", "Підтвердження оренди", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string toPlate(string plate)
        {
            string rplate = "";

            for (int i = 0; i < plate.Length; i++)
            {
                if (i == 2 || i == 6)
                    rplate += " ";

                rplate += plate[i];
    
            }

            return rplate;
        }

        public void setVehicle(Vehicle objectVehicle)
        {
            vehicle = objectVehicle;

            label76.Text = objectVehicle.name + " " + objectVehicle.model;
            label4.Text = objectVehicle.type;
            label5.Text = objectVehicle.transmission;
            label12.Text = objectVehicle.mileage.ToString() + " км.";
            label1.Text = objectVehicle.category;

            label11.Text = Convert.ToInt32((objectVehicle.fuel * 100) / objectVehicle.maxfuel).ToString() + "%";
            label10.Text = objectVehicle.maxspeed.ToString() + "км/г";
            label9.Text = objectVehicle.price + " грн./день";
            label8.Text = toPlate(objectVehicle.plate);

            var stream = new MemoryStream(mainWindow.serverData.client.vehicleImage(objectVehicle));
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void msDown(object sender, MouseEventArgs e)
        {
            movX = e.X;
            movY = e.Y;

            mov = 1;
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

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            tryRentVehicle();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DateTime maxDay = DateTime.Now;
            maxDay = maxDay.AddDays(50);

            rentDate = RentDatePicker.Show("Виберіть дату кінця оренди.", "Вибір дати",
                DateTime.Now, maxDay);

            TimeSpan delta = rentDate - DateTime.Now;
            int days = delta.Days;
            totalPrice = days * vehicle.price;

            label15.Text = "До " + rentDate.ToString();
            label16.Text = "До оплати: " + totalPrice.ToString() + " грн.";
        }

        private void VehicleInfo_Load(object sender, EventArgs e)
        {
            label15.Text = "Вибір дати ->";
            label16.Text = " ";
        }
    }
}
