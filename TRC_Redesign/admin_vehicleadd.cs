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
        public string imgpath = "none";

        public admin_vehicleadd()
        {
            InitializeComponent();
        }

        public void updateComboBox()
        {
            cb_type.Items.Clear();
            cb_transmission.Items.Clear();
            cb_license.Items.Clear();
            
            cb_type.Items.Add("Легковий");
            cb_type.Items.Add("Вантажний");
            cb_type.Items.Add("Позашляховик");
            cb_type.Items.Add("Мотоцикл");
            cb_type.Items.Add("Мопед");

            cb_transmission.Items.Add("Механічна");
            cb_transmission.Items.Add("Автоматична");

            cb_license.Items.Add("A1");
            cb_license.Items.Add("A");
            cb_license.Items.Add("B1");
            cb_license.Items.Add("B");
            cb_license.Items.Add("C1");
            cb_license.Items.Add("C");
            cb_license.Items.Add("D1");
            cb_license.Items.Add("D");
            cb_license.Items.Add("C1E");
            cb_license.Items.Add("BE");
            cb_license.Items.Add("CE");
            cb_license.Items.Add("D1E");
            cb_license.Items.Add("DE");
            cb_license.Items.Add("T1");
            cb_license.Items.Add("T2");
        }

        public void AdminVehicleAdd_Load()
        {
            
        }

        string removeSNull(string str)
        {
            str = str.Remove(2, 0);
            str = str.Remove(6, 0);

            return str;
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;

            if ( string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_model.Text) || string.IsNullOrEmpty(tb_fuelnow.Text) ||
                 string.IsNullOrEmpty(tb_fuelmax.Text) || string.IsNullOrEmpty(tb_mileage.Text) || string.IsNullOrEmpty(tb_maxspeed.Text) ||
                 string.IsNullOrEmpty(cb_type.Text) || string.IsNullOrEmpty(cb_transmission.Text) || string.IsNullOrEmpty(cb_license.Text) || 
                 string.IsNullOrEmpty(mtb_plate.Text) || string.IsNullOrEmpty(tb_price.Text))
            {
                error_label.Text = "Ви не заповнили всі поля.";
                error_label.Visible = true;

                return;
            }

            if (imgpath == "none")
            {
                error_label.Text = "Виберіть зображення автомобіля.";
                error_label.Visible = true;

                return;
            }

            string path = String.Format(@"pictures\{0}{1}", removeSNull(mtb_plate.Text), Path.GetExtension(imgpath));

            Vehicle vehicle = new Vehicle();

            vehicle.name = tb_name.Text;
            vehicle.model = tb_model.Text;

            vehicle.price = Convert.ToSingle(tb_price.Text);
            vehicle.fuel = Convert.ToSingle(tb_fuelnow.Text);
            vehicle.maxfuel = Convert.ToSingle(tb_fuelmax.Text);
            vehicle.plate = removeSNull(mtb_plate.Text);

            vehicle.maxspeed = Convert.ToInt32(tb_maxspeed.Text);
            vehicle.type = cb_type.Text;
            vehicle.transmission = cb_transmission.Text;
            vehicle.category = cb_license.Text;

            vehicle.picturepath = path;

            vehicle.start_date = DateTime.Now;
            vehicle.end_date = DateTime.Now;

            mainWindow.serverData.client.addVehicle(vehicle);
            mainWindow.serverData.uploadImage(imgpath, vehicle);

            mainWindow.dialogCreate("До бази даних було успішно додано новий автомобіль", "Додавання нового автомобіля", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void admin_vehicleadd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_imagepick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgpath = openFileDialog1.FileName;

                /*if (File.ReadAllBytes(imgpath).Length > 20971520)
                {
                    error_label.Text = "Розмір зображення повинен бути не більше 20 мб.";
                    error_label.Visible = true;

                    return;
                }*/

                pb_vehicle.Image = Image.FromFile(imgpath);
            }
        }

        private void visibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
