using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using TRC_Redesign.StatisticComponent;

namespace TRC_Redesign
{
    public partial class UCStatistic : UserControl
    {
        public Form1 mainWindow;
        private int radius = 20;

        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.roundedCorners();
            }
        }

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void roundedCorners()
        {
            var bounds = btn_vehicle.ClientRectangle;
            bounds.Width --; bounds.Height --;

            using (var path = GetRoundRectagle(bounds, this.Radius))
            {
                btn_client.Region = new Region(path);
                btn_vehicle.Region = new Region(path);
                btn_money.Region = new Region(path);
            }

            btn_client.Invalidate();
            btn_vehicle.Invalidate();
            btn_money.Invalidate();
        }


        public UCStatistic()
        {
            InitializeComponent();

            Radius = 20;
        }

        private void lbl_client_Click(object sender, System.EventArgs e)
        {
            btn_vehicle.BackColor = Color.FromArgb(40, 40, 40);
            btn_money.BackColor = Color.FromArgb(40, 40, 40);

            btn_client.BackColor = Color.FromArgb(187, 134, 252);
            mainWindow.clientData.ui.CreateStatisticPanel(mainWindow.clientData.ui.STATISTIC_CLIENT, this);
        }

        private void lbl_vehicle_Click(object sender, System.EventArgs e)
        {
            btn_money.BackColor = Color.FromArgb(40, 40, 40);
            btn_client.BackColor = Color.FromArgb(40, 40, 40);

            btn_vehicle.BackColor = Color.FromArgb(187, 134, 252);
            mainWindow.clientData.ui.CreateStatisticPanel(mainWindow.clientData.ui.STATISTIC_CLIENT, this);
        }

        private void lbl_money_Click(object sender, System.EventArgs e)
        {
            btn_client.BackColor = Color.FromArgb(40, 40, 40);
            btn_vehicle.BackColor = Color.FromArgb(40, 40, 40);

            btn_money.BackColor = Color.FromArgb(187, 134, 252);
            mainWindow.clientData.ui.CreateStatisticPanel(mainWindow.clientData.ui.STATISTIC_CLIENT, this);
        }

        private void client_MouseHover(object sender, System.EventArgs e)
        {
            if (btn_client.BackColor != Color.FromArgb(187, 134, 252))
                btn_client.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void vehicle_MouseHover(object sender, System.EventArgs e)
        {
            if (btn_vehicle.BackColor != Color.FromArgb(187, 134, 252))
                btn_vehicle.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void money_MouseHover(object sender, System.EventArgs e)
        {
            if (btn_money.BackColor != Color.FromArgb(187, 134, 252))
                btn_money.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void money_MouseLeave(object sender, System.EventArgs e)
        {
            if (btn_money.BackColor != Color.FromArgb(187, 134, 252))
                btn_money.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void vehicle_MouseLeave(object sender, System.EventArgs e)
        {
            if (btn_vehicle.BackColor != Color.FromArgb(187, 134, 252))
                btn_vehicle.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void client_MouseLeave(object sender, System.EventArgs e)
        {
            if (btn_client.BackColor != Color.FromArgb(187, 134, 252))
                btn_client.BackColor = Color.FromArgb(40, 40, 40);
        }
    }
}
