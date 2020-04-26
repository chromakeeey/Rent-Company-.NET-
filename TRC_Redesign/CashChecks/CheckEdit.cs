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

namespace TRC_Redesign.CashChecks
{
    public partial class CheckEdit : Form
    {
        public Form1 mainWindow;
       

        public CheckEdit()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            mainWindow.serverData.client.setCashVoucherData(textBox1.Text, textBox2.Text);
            mainWindow.dialogCreate("Інформація про чек було успішно змінена.", "Зміна чека", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
