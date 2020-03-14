using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC_Redesign.header;
using System.Data.SqlClient;

namespace TRC_Redesign
{
    public partial class admin_page : UserControl
    {
        public Form1 mainWindow;

        public admin_page()
        {

            InitializeComponent();
        }

        public void UpdateStatisticInformation()
        {
            label27.Text = mainWindow.serverData.client.GetAllVehicle().ToString();
            label3.Text = mainWindow.serverData.client.GetAllRentVehicle().ToString();
            label5.Text = mainWindow.serverData.client.GetAllNoRentVehicle().ToString();  

            label8.Text = mainWindow.clientData.account.level.ToString() + " рівень";
        }

        public void AdminPageLoad()
        {
            panel9.Location = new Point(7, panel9.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button1.Location.X, panel9.Location.Y);
            mainWindow.clientData.ui.CreateAdminSubPanel(mainWindow.clientData.ui.SUB_CHECK_PANEL, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button2.Location.X, panel9.Location.Y);
            mainWindow.clientData.ui.CreateAdminSubPanel(mainWindow.clientData.ui.SUB_VEHICLE_ADD, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button3.Location.X, panel9.Location.Y);
            mainWindow.clientData.ui.CreateAdminSubPanel(mainWindow.clientData.ui.SUB_VEHICLE_EDIT, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button4.Location.X, panel9.Location.Y);
            mainWindow.clientData.ui.CreateAdminSubPanel(mainWindow.clientData.ui.SUB_ACCOUNT_PANEL, this);
        }

        
    }
}
