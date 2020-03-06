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

namespace TRC_Redesign
{
    public partial class VehiclePanel : UserControl
    {
        public Form1 mainForm;
        vehicle objectVehicle;

        public VehiclePanel()
        {
            InitializeComponent();
            //setLocalTheme();
        }

        public void setLocalTheme(Form1 FormObject)
        {
            mainForm = FormObject;

            switch(FormObject.ui.themeCurrent)
            {
                case 0:
                    {
                        Color fullBlack = Color.FromArgb(0, 0, 0);
                        Color lightGray = Color.FromArgb(222, 222, 222);
                        Color darkGray = Color.FromArgb(64, 64, 64);

                        FormObject.ui.SetPictureColor(pictureBox2, fullBlack);
                        FormObject.ui.SetPictureColor(pictureBox4, fullBlack);
                        FormObject.ui.SetPictureColor(pictureBox5, fullBlack);
                        FormObject.ui.SetButtonPictureColor(button1, fullBlack);

                        this.BackColor = lightGray;
                        label1.ForeColor = fullBlack;
                        label2.ForeColor = fullBlack;
                        label3.ForeColor = fullBlack;
                        label4.ForeColor = darkGray;
                        label76.ForeColor = darkGray;

                        break;
                    }
                case 1:
                    {
                        Color fullWhite = Color.FromArgb(255, 255, 255);
                        Color lightGray = Color.FromArgb(192, 192, 192);
                        Color darkGray = Color.FromArgb(40, 40, 40);

                        FormObject.ui.SetPictureColor(pictureBox2, fullWhite);
                        FormObject.ui.SetPictureColor(pictureBox4, fullWhite);
                        FormObject.ui.SetPictureColor(pictureBox5, fullWhite);
                        FormObject.ui.SetButtonPictureColor(button1, fullWhite);

                        this.BackColor = darkGray;
                        label1.ForeColor = fullWhite;
                        label2.ForeColor = fullWhite;
                        label3.ForeColor = fullWhite;
                        label4.ForeColor = lightGray;
                        label76.ForeColor = lightGray;

                        break;
                    }
                case 2:
                    {
                        FormObject.ui.SetPictureColor(pictureBox2, FormObject.ui.customIcon);
                        FormObject.ui.SetPictureColor(pictureBox4, FormObject.ui.customIcon);
                        FormObject.ui.SetPictureColor(pictureBox5, FormObject.ui.customIcon);
                        FormObject.ui.SetButtonPictureColor(button1, FormObject.ui.customIcon);

                        this.BackColor = FormObject.ui.customMainPanel;
                        label1.ForeColor = FormObject.ui.customMainText;
                        label2.ForeColor = FormObject.ui.customMainText;
                        label3.ForeColor = FormObject.ui.customMainText;
                        label4.ForeColor = FormObject.ui.customSecondText;
                        label76.ForeColor = FormObject.ui.customSecondText;

                        break;
                    }
            }

            
        }

        public void setVehicle(vehicle vehicleObject)
        {
            this.Text = vehicleObject.name + " " + vehicleObject.model; 
            objectVehicle = vehicleObject;

            label76.Text = vehicleObject.name + " " + vehicleObject.model;
            label1.Text = Convert.ToInt32( (vehicleObject.fuel * 100) / vehicleObject.maxfuel ).ToString() + "%";
            label2.Text = vehicleObject.maxspeed + " км/г";
            label3.Text = vehicleObject.price + " грн./день";

            try { pictureBox1.Image = Image.FromFile(vehicleObject.image_link); }
            catch { pictureBox1.Image = TRC_Redesign.Properties.Resources.error_vehicle; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.vinfo.setVehicle(objectVehicle);
            mainForm.vinfo.Show();
        }
    }
}
