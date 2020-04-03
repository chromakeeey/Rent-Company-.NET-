using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC_Redesign.ServiceRent;
using System.Drawing.Drawing2D;

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCClientInfo : UserControl
    {
        private Account account;
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
            var bounds = this.ClientRectangle;
            bounds.Width--; bounds.Height--;

            using (var path = GetRoundRectagle(bounds, this.Radius))
            {
                this.Region = new Region(path);
            }

            this.Invalidate();
        }

        public UCClientInfo()
        {
            InitializeComponent();
            Radius = 20;
        }

        public void setAccount(Account account, int top)
        {
            this.account = account;

            lbl_money.Text = account.totalMoney.ToString() + " грн.";
            lbl_name.Text = String.Format("{0} {1}\n{2}", account.secondname, account.name, account.fathername);
            lbl_top.Text = top.ToString();
        }

        private void btn_additional_Click(object sender, EventArgs e)
        {

        }
    }
}
