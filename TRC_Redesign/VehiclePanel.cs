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
using TRC_Redesign.ServiceRent;

namespace TRC_Redesign
{
    public partial class VehiclePanel : UserControl
    {
        public Form1 mainWindow;
        Vehicle objectVehicle;

        public VehiclePanel()
        {
            InitializeComponent();
            //setLocalTheme();
        }

        public void setLocalTheme()
        {
            //mainForm = FormObject;

            switch(mainWindow.clientData.ui.themeCurrent)
            {
                case 0:
                    {
                        Color fullBlack = Color.FromArgb(0, 0, 0);
                        Color lightGray = Color.FromArgb(222, 222, 222);
                        Color darkGray = Color.FromArgb(64, 64, 64);

                        mainWindow.clientData.ui.SetPictureColor(pictureBox2, fullBlack);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox4, fullBlack);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox5, fullBlack);
                        mainWindow.clientData.ui.SetButtonPictureColor(button1, fullBlack);

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

                        mainWindow.clientData.ui.SetPictureColor(pictureBox2, fullWhite);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox4, fullWhite);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox5, fullWhite);
                        mainWindow.clientData.ui.SetButtonPictureColor(button1, fullWhite);

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
                        mainWindow.clientData.ui.SetPictureColor(pictureBox2, mainWindow.clientData.ui.customIcon);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox4, mainWindow.clientData.ui.customIcon);
                        mainWindow.clientData.ui.SetPictureColor(pictureBox5, mainWindow.clientData.ui.customIcon);
                        mainWindow.clientData.ui.SetButtonPictureColor(button1, mainWindow.clientData.ui.customIcon);

                        this.BackColor = mainWindow.clientData.ui.customMainPanel;
                        label1.ForeColor = mainWindow.clientData.ui.customMainText;
                        label2.ForeColor = mainWindow.clientData.ui.customMainText;
                        label3.ForeColor = mainWindow.clientData.ui.customMainText;
                        label4.ForeColor = mainWindow.clientData.ui.customSecondText;
                        label76.ForeColor = mainWindow.clientData.ui.customSecondText;

                        break;
                    }
            }

            
        }

        public void setVehicle(Vehicle vehicleObject)
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
            mainWindow.vinfo.setVehicle(objectVehicle);
            mainWindow.vinfo.Show();
        }
    }
}
