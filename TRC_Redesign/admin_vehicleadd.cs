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
    public partial class admin_vehicleadd : UserControl
    {
        SqlConnection sqlconnection;

        public Form1 obj;
        public string imgLink = "none";

        public admin_vehicleadd()
        {
            InitializeComponent();
        }

        public void AdminVehicleAdd_Load(SqlConnection sqlconnection)
        {
            this.sqlconnection = sqlconnection;
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            label11.Visible = false;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label11.Text = "Ви не заповнили всі поля.";
                label11.Visible = true;

                return;
            }

            if (imgLink == "none")
            {
                label11.Text = "Виберіть зображеня автомобіля.";
                label11.Visible = true;

                return;
            }

            int vehicleid = -1;

            for (int i = 0; i < 1000; i++)
            {
                if (Form1.pointer.Vehicle[i].IsVehicleValid())
                    continue;

                vehicleid = i;

                break;
            }

            if (vehicleid == -1)
            {
                label11.Text = "Достигнута максимальна кол-во автомобілів (1000)";
                label11.Visible = true;

                return;
            }

            Form1.pointer.Vehicle[vehicleid].name = textBox1.Text;
            Form1.pointer.Vehicle[vehicleid].model = textBox2.Text;
            Form1.pointer.Vehicle[vehicleid].plate = textBox3.Text;
            Form1.pointer.Vehicle[vehicleid].price = Convert.ToSingle(textBox4.Text);
            Form1.pointer.Vehicle[vehicleid].image_link = imgLink;

            Form1.pointer.Vehicle[vehicleid].InsertObjectVehicle(sqlconnection);

            obj.dialogCreate("Ви додали новій автомобіль для оренди автомобіля. Тепер ви зможете його найти в списку авто.", " ", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLink = openFileDialog1.FileName;

                try { pictureBox2.Image = Image.FromFile(imgLink); }
                catch { pictureBox2.Image = TRC_Redesign.Properties.Resources.error_vehicle; }
            }
        }

        private void admin_vehicleadd_Load(object sender, EventArgs e)
        {

        }
    }
}
