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
    public partial class vehicle_page : UserControl
    {
        public Form1 MainPointer;
        public SqlConnection sqlconnection;

        vehicle[] paramsObject = new vehicle[1000];

        int typeChecked = 0;

        int[] pageIndex = new int[3];

        public List<VehiclePanel> panelObject = new List<VehiclePanel>();

        public void TryRentVehicle(int vehicleid, DateTime date)
        {
            /*TimeSpan delta = dateTimePicker1.Value - DateTime.Now;
            int days = delta.Days;

            if (account.instance.balance < days * paramsObject[vehicleid].price)
            {
                MessageBox.Show("Оренда неможлива, поповніть рахунок.", "Відміна оренди",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (paramsObject[vehicleid].client_documentid != 0)
            {
                MessageBox.Show("Оренда неможлива, автомобіль вже орендований.", "Відміна оренди",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult answer = MessageBox.Show("Ви дійсно хочите орендувати " + paramsObject[vehicleid].name + " " + paramsObject[vehicleid].model + "?\n\n" +
                "Дата початку оренди: " + DateTime.Now.ToShortTimeString() + "\n" +
                "Дата кінця оренди: " + date.ToShortTimeString(), "Підтвердіть дію", MessageBoxButtons.YesNoCancel);

            if (answer == DialogResult.Yes)
            {
                int main_vehicleid = Form1.pointer.ui.ConvertFromParams(paramsObject[vehicleid]);

                account.instance.balance -= days * Form1.pointer.Vehicle[main_vehicleid].price;
                Form1.pointer.Vehicle[main_vehicleid].SetRentInfo(account.instance.documentid, date);
                Form1.pointer.Vehicle[main_vehicleid].SaveObjectVehicle(sqlconnection);

                MainPointer.label4.Text = account.instance.balance.ToString() + " грн.";
                MessageBox.Show("Ви орендовали автомобіль. Вітаємо!", "Підтвердження оренди", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1.pointer.ui.CreatePanel(Form1.pointer.ui.MAIN_PANEL, MainPointer);
                Form1.pointer.main_page1.UpdateVehicleInformation();

            }*/

        }

        

        public void LoadVehiclePage()
        {
            checkedListBox1.SetItemChecked(0, false);

            //UpdateVehicleObject();
            //SetVehiclePage(0);


        }

        public void UpdateVehicleObject()
        {
            paramsObject = Form1.pointer.ui.CreateObjectParams(
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text), typeChecked);
        }

        
        public vehicle_page()
        {
            for (int i = 0; i != 1000; i++)
                paramsObject[i] = new vehicle();

            InitializeComponent();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);

                typeChecked = checkedListBox1.SelectedIndex;
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            UpdateVehicleObject();

            clearVehicleList();
            updateVehicleList();

            

        }

        public void clearVehicleList()
        {
            int max_i = panelObject.Count;

            for (int i = 0; i < max_i; i++)
                panelObject[i].Visible = false;


            for (int i = 0; i < max_i; i++)
            {
                
                panelObject.RemoveAt(0);
            }
        }

        public void updateVehicleList()
        {
            int position_y = 14;

            for (int i = 0; i < 1000; i++)
            {
                if (!paramsObject[i].IsVehicleValid())
                    continue;

                panelObject.Add(new VehiclePanel());
                int index = panelObject.Count - 1;

                panelObject[index].Parent = panel1;
                panelObject[index].Visible = false;
                panelObject[index].Size = vehiclePanel1.Size;
                panelObject[index].Location = new Point(vehiclePanel1.Location.X, position_y);
                position_y += 171;

                panelObject[index].setVehicle(paramsObject[i]);
                panelObject[index].setLocalTheme(MainPointer);
                panelObject[index].Visible = true;
            }
           
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            //SetVehiclePage(currentPage + 1);
        }

        private void jThinButton5_Click(object sender, EventArgs e)
        {
            //SetVehiclePage(currentPage - 1);
        }

        // 1
        private void jThinButton6_Click(object sender, EventArgs e)
        {
            //TryRentVehicle(pageIndex[0], dateTimePicker1.Value);
        }

        // 2
        private void jThinButton2_Click(object sender, EventArgs e)
        {
            //TryRentVehicle(pageIndex[0], dateTimePicker2.Value);
        }

        // 3
        private void jThinButton3_Click(object sender, EventArgs e)
        {
            //TryRentVehicle(pageIndex[0], dateTimePicker3.Value);
        }

        private void Date1_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan delta = dateTimePicker1.Value - DateTime.Now;
            //int days = delta.Days;

            //label4.Visible = true;
            //label4.Text = days * paramsObject[pageIndex[0]].price + " грн.";
        }

        private void Date2_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan delta = dateTimePicker2.Value - DateTime.Now;
            //int days = delta.Days;

            //label5.Visible = true;
            //label5.Text = days * paramsObject[pageIndex[1]].price + " грн.";
        }

        private void Date3_ValueChanged(object sender, EventArgs e)
        {
            //TimeSpan delta = dateTimePicker3.Value - DateTime.Now;
            //int days = delta.Days;

            //label7.Visible = true;
            //label7.Text = days * paramsObject[pageIndex[2]].price + " грн.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            //TryRentVehicle(pageIndex[1], dateTimePicker2.Value);
        }

        private void jThinButton2_Click_1(object sender, EventArgs e)
        {
            //TryRentVehicle(pageIndex[2], dateTimePicker2.Value);
        }
    }
}
