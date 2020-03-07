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
        public static admin_page pointer = null;
        public SqlConnection sqlconnection;
        public Form1 obj;

        public admin_page()
        {
            if (pointer == null)
                pointer = this;

            InitializeComponent();
        }

        public void UpdateStatisticInformation()
        {
            //label27.Text = Form1.pointer.ui.GetAllVehicle().ToString();
            //label3.Text = Form1.pointer.ui.GetAllRentVehicle().ToString();
            //label5.Text = Form1.pointer.ui.GetAllNoRentVehicle().ToString();

            //label8.Text = account.instance.GetAdminLevel().ToString() + " рівень";
        }

        public void AdminPageLoad()
        {
            //this.sqlconnection = sqlconnection;
            admin_check1.AdminCheckPageLoad(sqlconnection);
            admin_vehicleadd1.AdminVehicleAdd_Load(sqlconnection);
            //UpdateStatisticInformation();

            //Form1.pointer.ui.CreateAdminSubPanel(Form1.pointer.ui.SUB_CHECK_PANEL, this);
            panel9.Location = new Point(7, panel9.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button1.Location.X, panel9.Location.Y);

            //Form1.pointer.ui.CreateAdminSubPanel(Form1.pointer.ui.SUB_CHECK_PANEL, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button2.Location.X, panel9.Location.Y);
            //Form1.pointer.ui.CreateAdminSubPanel(Form1.pointer.ui.SUB_VEHICLE_ADD, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.dialogCreate("coming soon ...", "later", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //panel9.Location = new Point(button3.Location.X, panel9.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel9.Location = new Point(button4.Location.X, panel9.Location.Y);
            //Form1.pointer.ui.CreateAdminSubPanel(Form1.pointer.ui.SUB_ACCOUNT_PANEL, this);
        }

        
    }
}
