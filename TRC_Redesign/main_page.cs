using System;
using System.Windows.Forms;
using System.Drawing;

using TRC_Redesign.CustomMessageBox;
using TRC_Redesign.header;
using TRC_Redesign.ServiceRent;


namespace TRC_Redesign
{
    public partial class main_page : UserControl
    {
        public Form1 mainWindow;

        public void updateVehicleData()
        {
            Vehicle vehicle = mainWindow.serverData.client.getUserVehicle(mainWindow.clientData.account);

            if (vehicle.plate != "none")
            {
                try { pictureBox7.Image = Image.FromFile(vehicle.image_link); }
                catch { pictureBox7.Image = TRC_Redesign.Properties.Resources.error_vehicle; }

                label9.Text = vehicle.name;
                label11.Text = vehicle.model;
                label12.Text = vehicle.plate;

                label20.Text = vehicle.start_date.ToShortDateString();
                label22.Text = vehicle.end_date.ToShortDateString();

                label24.Text = Convert.ToString(vehicle.fuel) + " л.";
                label27.Text = Convert.ToString(vehicle.price) + " грн.";
                label15.Text = Convert.ToString(vehicle.mileage) + " км.";
                label8.Text = "Основна інформація про " + vehicle.name;

                panel11.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;

                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                panel11.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
            }
        }

        public void updateNameData()
        {
            label1.Text = "Вітаємо, " + mainWindow.clientData.account.name + "!";
        }
  

        public main_page()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = mainWindow.serverData.client.getUserVehicle(mainWindow.clientData.account);
            int days;
            TimeSpan delta = DateTime.Now - vehicle.end_date;

            days = delta.Days;

            if (days < 1)
            {
                int check_days;
                TimeSpan check_delta = vehicle.end_date - DateTime.Now;
                check_days = check_delta.Days;

                if (check_days > 0)
                {
                    mainWindow.clientData.account.balance += check_days * vehicle.price;

                    vehicle.client_documentid = 0;
                    mainWindow.serverData.client.saveVehicle(vehicle);

                    mainWindow.dialogCreate("Ви сдали автомобіль в оренду достроково.\nВи отримали " + check_days * vehicle.price + "грн. на рахунок." +
                        "\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vehicle.client_documentid = 0;
                    mainWindow.serverData.client.saveVehicle(vehicle);

                    mainWindow.dialogCreate("Ви сдали автомобіль в оренду.\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (days > 0 && mainWindow.clientData.account.balance < days * vehicle.price)
            {
                mainWindow.dialogCreate("Ви просрочили термін здачі автомобіля в автосалон.\n\n" +
               "На ваш аккаунт був накладений борг в розмірі - " + days * vehicle.price +
               "грн.\nДнів просрочено - " + days + ".\nЦіна оренди в день - " + vehicle.price + "грн.\n\nВи не зможете сдати автомобіль, поки не поповните баланс на сумму боргу.",
               "Борг", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (days > 0 && mainWindow.clientData.account.balance >= days * vehicle.price)
            {
                mainWindow.clientData.account.balance -= days * vehicle.price;

                vehicle.client_documentid = 0;
                mainWindow.serverData.client.saveVehicle(vehicle);

                mainWindow.dialogCreate("Ви сдали автомобіль в оренду.\n\nДякуємо Вам за користування нашим сервісом. Чекаємо Вас знову", " ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mainWindow.updateAccountData();
            mainWindow.serverData.client.saveAccount(mainWindow.clientData.account);

            this.updateVehicleData();

        }
    }
}
