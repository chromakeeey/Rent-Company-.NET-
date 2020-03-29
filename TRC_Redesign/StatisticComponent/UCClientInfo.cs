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

namespace TRC_Redesign.StatisticComponent
{
    public partial class UCClientInfo : UserControl
    {
        private Account account;

        public UCClientInfo()
        {
            InitializeComponent();
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
