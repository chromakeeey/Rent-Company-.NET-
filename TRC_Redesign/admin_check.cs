using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class admin_check : UserControl
    {
        public Form1 mainWindow;

        Account account = new Account();

        public void updateAccountData()
        {

            if (account.documentid == 0)
            {
                panel1.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
                pictureBox1.Visible = true;

                return;
            }

            label40.Text = account.name;
            label5.Text = account.secondname;
            label7.Text = account.fathername;
            label9.Text = account.mail;
            label11.Text = account.phone;
            label1.Text = account.login;

            label13.Text = account.documentid.ToString();
            label3.Text = account.dateCreate.ToShortDateString();

            panel1.Visible = true;
            label15.Visible = false;
            label16.Visible = false;
            pictureBox1.Visible = false;
        }
          
        public void updateAccountObject()
        {
            account = mainWindow.serverData.client.noAcceptedAccount();
        }

        public admin_check()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            updateAccountObject();
            updateAccountData();
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            account.accepted = 1;
            mainWindow.serverData.client.saveAccount(account);

            updateAccountObject();
            updateAccountData();

            mainWindow.dialogCreate("Ви підтвердили аккаунт.", "Підтвердження аккаунта", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {
            account.accepted = 2;
            mainWindow.serverData.client.saveAccount(account);

            updateAccountObject();
            updateAccountData();

            mainWindow.dialogCreate("Ви відмовили аккаунту в реєстрації", "Відмовлення", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
