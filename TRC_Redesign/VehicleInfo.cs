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
using TRC_Redesign.RentPicker;

namespace TRC_Redesign
{
    public partial class VehicleInfo : Form
    {
        private DateTime rentDate;
        private float price;

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

        public void setVehicle(vehicle objectVehicle)
        {
            label76.Text = objectVehicle.name + " " + objectVehicle.model;
            label4.Text = objectVehicle.type;
            label5.Text = objectVehicle.transmission;
            label12.Text = objectVehicle.mileage.ToString() + " км.";
            label1.Text = objectVehicle.category;

            label11.Text = Convert.ToInt32((objectVehicle.fuel * 100) / objectVehicle.maxfuel).ToString() + "%";
            label10.Text = objectVehicle.maxspeed.ToString() + "км/г";
            label9.Text = objectVehicle.price + " грн./день";
            label8.Text = toPlate(objectVehicle.plate);

            try { pictureBox1.Image = Image.FromFile(objectVehicle.image_link); }
            catch { pictureBox1.Image = TRC_Redesign.Properties.Resources.error_vehicle; }
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime maxDay = DateTime.Now;
            maxDay = maxDay.AddDays(50);

            rentDate = RentDatePicker.Show("Виберіть дату кінця оренди.", "Вибір дати",
                DateTime.Now, maxDay);

            setEndDate(rentDate);
        }

        private void setEndDate(DateTime date)
        {
            label15.Text = "До " + date.ToString();
        }
    }
}
