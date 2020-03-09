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
using System.IO;

using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;


namespace TRC_Redesign
{
    public partial class admin_vehicleadd : UserControl
    {
        public Form1 mainWindow;
        public string imgLink = "none";

        public admin_vehicleadd()
        {
            InitializeComponent();
        }

        public void AdminVehicleAdd_Load()
        {
            
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;

            /*if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label11.Text = "Ви не заповнили всі поля.";
                label11.Visible = true;

                return;
            }*/

            if (imgLink == "none")
            {
                error_label.Text = "Виберіть зображеня автомобіля.";
                error_label.Visible = true;

                return;
            }

            
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {

            Vehicle vehicleObject = new Vehicle()
            {
                plate = "CE5456AT"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLink = openFileDialog1.FileName;

                /*try { pictureBox2.Image = Image.FromFile(imgLink); }
                catch { pictureBox2.Image = TRC_Redesign.Properties.Resources.error_vehicle; }*/

                //mainWindow.serverData.uploadImage(imgLink);

                byte[] buffer = File.ReadAllBytes(imgLink);
                mainWindow.serverData.client.uploadVehicleImage(buffer);
                


            }

            
            
        }

        private void admin_vehicleadd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
