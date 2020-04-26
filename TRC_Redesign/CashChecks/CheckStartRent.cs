using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TRC_Redesign.ServiceRent;

namespace TRC_Redesign.CashChecks
{
    public partial class CheckStartRent : Form
    {
        public Form1 mainWindow;

        private Account account;
        private Vehicle vehicle;
        

        public CheckStartRent()
        {
            InitializeComponent();

            
        }

        public void setCashVoucher(CashVoucher item)
        {
            lbl_num_check.Text      = String.Format("Номер чека - {0}", item.Id);
            lbl_name_company.Text   = item.Company;
            lbl_street_name.Text    = item.Street;
            lbl_name.Text           = item.User;
            lbl_startrent.Text      = item.StartDate.ToString();
            lbl_endrent.Text        = item.FinalDate.ToString();
            lbl_datatime.Text       = item.Date.ToString();
            lbl_totalprice.Text     = String.Format("{0} грн.", item.Price);
            lbl_vehicle.Text        = item.Vehicle;
        }

        /*public void setCheckData(Vehicle vehicle, Account account)
        {
            this.account = account;
            this.vehicle = vehicle;

            float price;
            int days;
            TimeSpan delta;

            delta = vehicle.end_date - vehicle.start_date;
            days = delta.Days;
            price = days * vehicle.price;

            lbl_num_check.Text = String.Format("Номер чека - {0}", vehicle.rentlogid);
            lbl_name_company.Text = mainWindow.clientData.checkData.companyName;
            lbl_street_name.Text = mainWindow.clientData.checkData.streetName;
            lbl_name.Text = String.Format("{0} {1} {2}", account.secondname, account.name, account.fathername);
            lbl_startrent.Text = vehicle.start_date.ToString();
            lbl_endrent.Text = vehicle.end_date.ToString();
            lbl_datatime.Text = vehicle.start_date.ToString();
            lbl_totalprice.Text = String.Format("{0} грн.", price);

            lbl_vehicle.Text = String.Format("VIN: {0}\nІм'я: {1}\nНомерний знак: {2}\nБензина в баці: {3} л.\nПробіг: {4} км.",
                vehicle.VIN, vehicle.name + " " + vehicle.model, vehicle.plate, vehicle.fuel.ToString(), vehicle.mileage.ToString());
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {       
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "PNG Files | *.png";
            saveDialog.DefaultExt = "png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                btn_close.Visible = false;
                btn_print.Visible = false;
                var screenshotForm = Form.ActiveForm;

                using (var bmp = new Bitmap(screenshotForm.Width, screenshotForm.Height))
                {
                    screenshotForm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(saveDialog.FileName);
                }
            }

            btn_close.Visible = true;
            btn_print.Visible = true;
        }
    }
}
