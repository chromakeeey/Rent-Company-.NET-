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
using TRC_Redesign.CustomMessageBox;

namespace TRC_Redesign
{
    public partial class main_page : UserControl
    {

        public SqlConnection sqlconnection;
        public Form1 pointerForm;

        /*public void UpdateVehicleInformation()
        {
            int rentid = account.instance.GetRentIndex();

            try
            {
                pictureBox7.Image = Image.FromFile(Form1.pointer.Vehicle[rentid].image_link);
            }

            catch
            {
                pictureBox7.Image = TRC_Redesign.Properties.Resources.error_vehicle;
            }

            label9.Text = Form1.pointer.Vehicle[rentid].name;
            label11.Text = Form1.pointer.Vehicle[rentid].model;
            label12.Text = Form1.pointer.Vehicle[rentid].plate;

            label20.Text = Form1.pointer.Vehicle[rentid].start_date.ToShortDateString();
            label22.Text = Form1.pointer.Vehicle[rentid].end_date.ToShortDateString();

            label24.Text = Convert.ToString(Form1.pointer.Vehicle[rentid].fuel) + " л.";
            label27.Text = Convert.ToString(Form1.pointer.Vehicle[rentid].price) + " грн.";
            label15.Text = Convert.ToString(Form1.pointer.Vehicle[rentid].mileage) + " км.";
            label8.Text = "Основна інформація про " + Form1.pointer.Vehicle[rentid].name;

            panel11.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;

            label2.Visible = false;
            label3.Visible = false;
        }

        public void loadForm()
        {
            label1.Text = "Вітаємо, " + account.instance.name + "!";

            if (!account.instance.IsUserRentCar())
            {
                panel11.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                UpdateVehicleInformation();
            }
        }*/

        public main_page()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            /*int vehicleid = account.instance.GetRentIndex();
            int days;
            TimeSpan delta = DateTime.Now - Form1.pointer.Vehicle[vehicleid].end_date;

            days = delta.Days;

            if (days < 1)
            {
                int check_days;
                TimeSpan check_delta = Form1.pointer.Vehicle[vehicleid].end_date - DateTime.Now;
                check_days = check_delta.Days;

                if (check_days > 0)
                {
                    account.instance.balance += check_days * Form1.pointer.Vehicle[vehicleid].price;

                    Form1.pointer.Vehicle[vehicleid].CancelRent();
                    Form1.pointer.Vehicle[vehicleid].SaveObjectVehicle(Form1.pointer.sqlconnection);

                    pointerForm.dialogCreate("Ви сдали автомобіль в оренду достроково.\nВи отримали " + check_days * Form1.pointer.Vehicle[vehicleid].price + "грн. на рахунок." +
                        "\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form1.pointer.Vehicle[vehicleid].CancelRent();
                    Form1.pointer.Vehicle[vehicleid].SaveObjectVehicle(Form1.pointer.sqlconnection);

                    pointerForm.dialogCreate("Ви сдали автомобіль в оренду.\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (days > 0 && account.instance.balance < days * Form1.pointer.Vehicle[vehicleid].price)
            {
                pointerForm.dialogCreate("Ви просрочили термін здачі автомобіля в автосалон.\n\n" +
               "На ваш аккаунт був накладений борг в розмірі - " + days * Form1.pointer.Vehicle[vehicleid].price +
               "грн.\nДнів просрочено - " + days + ".\nЦіна оренди в день - " + Form1.pointer.Vehicle[vehicleid].price + "грн.\n\nВи не зможете сдати автомобіль, поки не поповните баланс на сумму боргу.",
               "Борг", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (days > 0 && account.instance.balance >= days * Form1.pointer.Vehicle[vehicleid].price)
            {
                account.instance.balance -= days * Form1.pointer.Vehicle[vehicleid].price;

                Form1.pointer.Vehicle[vehicleid].CancelRent();
                Form1.pointer.Vehicle[vehicleid].SaveObjectVehicle(Form1.pointer.sqlconnection);

                pointerForm.dialogCreate("Ви сдали автомобіль в оренду.\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Form1.pointer.UpdateAccountInformation();
            account.instance.SaveObjectAccount(sqlconnection);

            panel11.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;

            label2.Visible = true;
            label3.Visible = true;*/

        }
    }
}
