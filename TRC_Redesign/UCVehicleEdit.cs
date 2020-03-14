using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

using TRC_Redesign.InputBoxes;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class UCVehicleEdit : UserControl
    {
        public UCVehicleEdit()
        {
            InitializeComponent();
            writeList();

            pnl_empty.Location = new Point(0, 0);
            pnl_empty.Visible = true;

        }

        public Vehicle vehicle;
        public Form1 mainWindow;
        private string picturepath = "none";

        private List<string> categories = new List<string>();
        private List<string> types = new List<string>();
        private List<string> transmissions = new List<string>();

        public void setVehicle(Vehicle vehicleObject)
        {
            vehicle = vehicleObject;
            pnl_empty.Visible = false;

            lbl_name.Text = vehicle.name;
            lbl_model.Text = vehicle.model;
            lbl_category.Text = vehicle.category;
            lbl_type.Text = vehicle.type;
            lbl_transmission.Text = vehicle.transmission;

            lbl_maxspeed.Text = String.Format("{0} км/г", vehicle.maxspeed.ToString());
            lbl_mileage.Text = String.Format("{0} км", vehicle.mileage.ToString());
            lbl_maxfuel.Text = String.Format("{0} л.", vehicle.maxfuel.ToString());
            lbl_fuel.Text = String.Format("{0} л.", vehicle.fuel.ToString());
            lbl_price.Text = String.Format("{0} грн./день", vehicle.price.ToString());

            var stream = new MemoryStream( mainWindow.serverData.client.vehicleImage(vehicle) );
            pb_vehicle.Image = Image.FromStream(stream);
        }

        private void writeList()
        {
            categories.Clear();
            types.Clear();
            transmissions.Clear();

            types.Add("Легковий");
            types.Add("Вантажний");
            types.Add("Позашляховик");
            types.Add("Мотоцикл");
            types.Add("Мопед");

            transmissions.Add("Механічна");
            transmissions.Add("Автоматична");

            categories.Add("A1");
            categories.Add("A");
            categories.Add("B1");
            categories.Add("B");
            categories.Add("C1");
            categories.Add("C");
            categories.Add("D1");
            categories.Add("D");
            categories.Add("C1E");
            categories.Add("BE");
            categories.Add("CE");
            categories.Add("D1E");
            categories.Add("DE");
            categories.Add("T1");
            categories.Add("T2");
        }

        private string Error
        {
            set
            {
                lbl_error.Visible = true;
                lbl_error.Text = value;
            }

            get { return lbl_error.Text; }
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть назву автомобіля.");

            lbl_name.Text = value;
            vehicle.name = value;
        }

        private void btn_model_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть модель автомобіля.");

            lbl_model.Text = value;
            vehicle.model = value;
        }

        private void btn_maxspeed_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть максимальну швидкість автомобіля.");

            if ( !int.TryParse(value, out _) )
            {
                Error = "Значення було введено неправильно.";
                return;
            }

            lbl_maxspeed.Text = String.Format("{0} км/г", value);
            vehicle.maxspeed = Convert.ToInt32(value);
        }

        private void btn_mileage_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть пробіг автомобіля.");

            if (!int.TryParse(value, out _))
            {
                Error = "Значення було введено неправильно.";
                return;
            }

            lbl_mileage.Text = String.Format("{0} км", value);
            vehicle.mileage = Convert.ToInt32(value);
        }

        private void btn_maxfuel_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть об'єм бака автомобіля.\nКопійки вказувати через кому."); 

            if (!float.TryParse(value, out _))
            {
                Error = "Значення було введено неправильно.";
                return;
            }

            lbl_maxfuel.Text = String.Format("{0} л.", value);
            vehicle.maxfuel = Convert.ToSingle(value);
        }

        private void btn_fuel_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть кількість бензина в баці автомобіля.\nКопійки вказувати через кому.");

            if (!float.TryParse(value, out _))
            {
                Error = "Значення було введено неправильно.";
                return;
            }

            lbl_fuel.Text = String.Format("{0} л.", value);
            vehicle.fuel = Convert.ToSingle(value);
        }

        private void btn_price_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть ціну оренди автомобіля за один день\nКопійки вказувати через кому.");

            if (!float.TryParse(value, out _))
            {
                Error = "Значення було введено неправильно.";
                return;
            }

            lbl_price.Text = String.Format("{0} грн./день", value);
            vehicle.price = Convert.ToSingle(value);
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            string value = ComboBoxGet.Show("Виберіть категорію водійського подсвідчення.", categories);

            if (string.IsNullOrEmpty(value))
                return;

            lbl_category.Text = value;
            vehicle.category = value;
        }

        private void btn_type_Click(object sender, EventArgs e)
        {
            string value = ComboBoxGet.Show("Виберіть тип автомобіля.", types);

            if (string.IsNullOrEmpty(value))
                return;

            lbl_type.Text = value;
            vehicle.type = value;
        }

        private void btn_transmission_Click(object sender, EventArgs e)
        {
            string value = ComboBoxGet.Show("Виберіть трансмісію автомобіля.", transmissions);

            if (string.IsNullOrEmpty(value))
                return;

            lbl_transmission.Text = value;
            vehicle.transmission = value;
        }

        private void btn_vin_Click(object sender, EventArgs e)
        {
            Error = "Функція недоступна.";
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picturepath = fileDialog.FileName;

                /*if (File.ReadAllBytes(imgpath).Length > 20971520)
                {
                    error_label.Text = "Розмір зображення повинен бути не більше 20 мб.";
                    error_label.Visible = true;

                    return;
                }*/

                pb_vehicle.Image = Image.FromFile(picturepath);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            mainWindow.serverData.client.deleteVehicle(vehicle);
        }

        public void infoHide()
        {
            pnl_empty.Visible = false;
        }
    }
}
