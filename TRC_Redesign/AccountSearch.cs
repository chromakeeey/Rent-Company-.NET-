using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class AccountSearch : Form
    {
        public Account account;

        public AccountSearch()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            account = new Account();
            Hide();
        }
    }
}
