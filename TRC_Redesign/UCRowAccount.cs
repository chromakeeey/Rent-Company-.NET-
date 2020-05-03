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

namespace TRC_Redesign
{
    public partial class UCRowAccount : UserControl
    {
        private Account account;
        public Form1 mainWindow;

        public UCRowAccount()
        {
            InitializeComponent();
        }

        public void setAccount(Account account)
        {
            lbl_name.Text = String.Format("{0} {1} {2}", account.secondname, account.name, account.fathername);
            lbl_havecar.Text = mainWindow.serverData.client.getUserVehicle(account).plate != "none" ? "Так" : "Ні";
            lbl_date.Text = account.dateCreate.ToString();

            this.account = account;
        }

        public Account sendAccount()
        {
            return account;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
