using System;
using System.Windows.Forms;

using TRC_Redesign.InputBoxes;
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class UCVehicleEdit : UserControl
    {
        public UCVehicleEdit()
        {
            InitializeComponent();
        }

        public Vehicle vehicle;
        private Vehicle saveObjectVehicle = new Vehicle();

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
            saveObjectVehicle.name = value;
        }

        private void btn_model_Click(object sender, EventArgs e)
        {
            string value = TextBoxGet.Show("Введіть модель автомобіля.");

            lbl_model.Text = value;
            saveObjectVehicle.model = value;
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
            saveObjectVehicle.maxspeed = Convert.ToInt32(value);
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
            saveObjectVehicle.mileage = Convert.ToInt32(value);
        }
    }
}
