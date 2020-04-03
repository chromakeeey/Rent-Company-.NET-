using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCMoneyStat : UserControl
    {
        public Form1 mainWindow;
        private int radius = 20;
        private int terminedate = -1;

        private Color selectedColor = Color.FromArgb(187, 134, 252);
        private Color defaultColor = Color.FromArgb(40, 40, 40);

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

        private void roundPanel(Panel panel)
        {
            var bounds = panel.ClientRectangle;

            bounds.Width--;
            bounds.Height--;

            using (var path = GetRoundRectagle(bounds, this.Radius))
                panel.Region = new Region(path);

            panel.Invalidate();
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
            roundPanel(pnl_year);
            roundPanel(pnl_month);
            roundPanel(pnl_week);
            roundPanel(pnl_custom);
        }

        public UCMoneyStat()
        {
            InitializeComponent();

            Radius = 30;
            terminedate = -1;
        }

        public void setTimeButton(int id)
        {
            if (terminedate == id)
                return;

            pnl_year.BackColor = defaultColor;
            pnl_month.BackColor = defaultColor;
            pnl_week.BackColor = defaultColor;
            pnl_custom.BackColor = defaultColor;

            switch (id)
            {
                case 0: pnl_year.BackColor = selectedColor; break;
                case 1: pnl_month.BackColor = selectedColor; break;
                case 2: pnl_week.BackColor = selectedColor; break;
                case 3: pnl_custom.BackColor = selectedColor; break;
            }

            terminedate = id;
        }

        private void lbl_year_Click(object sender, EventArgs e)
        {
            setTimeButton(0);
        }

        private void lbl_month_Click(object sender, EventArgs e)
        {
            setTimeButton(1);
        }

        private void lbl_week_Click(object sender, EventArgs e)
        {
            setTimeButton(2);
        }

        private void lbl_custom_Click(object sender, EventArgs e)
        {
            setTimeButton(3);
        }
    }
}
