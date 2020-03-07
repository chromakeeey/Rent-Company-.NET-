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
    public partial class admin_account : UserControl
    {
        Account tmpObject;
        SqlConnection sqlconnection;

        public void AdminAccountLoad()
        {

        }

        public void ClearEditInfomation()
        {
            label15.Visible = true;
            label16.Visible = true;

            panel1.Visible = false;
        }

        public void UpdateEditInformation()
        {
            label15.Visible = false;
            label16.Visible = false;

            panel1.Visible = true;

            textBox1.Text = tmpObject.name;
            textBox2.Text = tmpObject.secondname;
            textBox3.Text = tmpObject.fathername;
            textBox4.Text = tmpObject.mail;
            textBox5.Text = tmpObject.phone;

            textBox6.Text = tmpObject.documentid.ToString();


        }

        public admin_account()
        {
            InitializeComponent();
        }
    }
}
