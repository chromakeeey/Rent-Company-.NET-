using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TRC_Redesign.header
{
    public class theme
    {
        public int themeCurrent;  

        public int theme_Light = 0;
        public int theme_Dark = 1;
        public int theme_Custom = 2;

        public Color customForm;
        public Color customIcon;
        public Color customMainText;
        public Color customSecondText;
        public Color customMainPanel;
        public Color customSecondPanel;
        public Color customButton;


        // tmp var for save colors to file
        public string clrForm;
        public string clrIcon;
        public string clrMainText;
        public string clrSecondText;
        public string clrMainPanel;
        public string clrSecondPanel;
        public string clrButton;

        public void ColorsToHTML()
        {
            clrForm = ColorTranslator.ToHtml(customForm);
            clrIcon = ColorTranslator.ToHtml(customIcon);
            clrMainText = ColorTranslator.ToHtml(customMainText);
            clrSecondText = ColorTranslator.ToHtml(customSecondText);
            clrMainPanel = ColorTranslator.ToHtml(customMainPanel);
            clrSecondPanel = ColorTranslator.ToHtml(customSecondPanel);
            clrButton = ColorTranslator.ToHtml(customButton);
        }

        public void ColorsToARGB()
        {
            customForm = ColorTranslator.FromHtml(clrForm);
            customIcon = ColorTranslator.FromHtml(clrIcon);
            customMainText = ColorTranslator.FromHtml(clrMainText);
            customSecondText = ColorTranslator.FromHtml(clrSecondText);
            customMainPanel = ColorTranslator.FromHtml(clrMainPanel);
            customSecondPanel = ColorTranslator.FromHtml(clrSecondPanel);
            customButton = ColorTranslator.FromHtml(clrButton);
        }

        public void SetTheme(Form1 objectForm, int themeid)
        {
            themeCurrent = themeid;

            switch (themeid)
            {
                case 0: SetLightTheme(objectForm); break;
                case 1: SetDarkTheme(objectForm); break;
                case 2: SetCustomTheme(objectForm); break;
            }

            int countObject = objectForm.vehicle_page1.panelObject.Count;

            for (int i = 0; i < countObject; i++)
                objectForm.vehicle_page1.panelObject[i].setLocalTheme();
        }

        void SetLightTheme(Form1 objectForm)
        {
            Color fullBlack = Color.FromArgb(0, 0, 0);
            Color fullWhite = Color.FromArgb(255, 255, 255);

            Color lightGray = Color.FromArgb(222, 222, 222);
            Color ultraLightGray = Color.FromArgb(240, 240, 240);
            Color darkGray = Color.FromArgb(64, 64, 64);
            Color fullPink = Color.FromArgb(195, 143, 255);

            this.SetIconColor(objectForm, fullBlack);
            this.SetMainPanelColor(objectForm, lightGray);
            this.SetSecondPanelColor(objectForm, ultraLightGray);
            this.SetMainTextColor(objectForm, fullBlack);
            this.SetFormColor(objectForm, fullWhite);
            this.SetSecondTextColor(objectForm, darkGray);
            this.SetButtonColor(objectForm, fullPink);

            
        }

        void SetDarkTheme(Form1 objectForm)
        {
            Color fullBlack = Color.FromArgb(0, 0, 0);
            Color fullWhite = Color.FromArgb(255, 255, 255);
            Color lightGray = Color.FromArgb(192, 192, 192);

            Color darkGray = Color.FromArgb(40, 40, 40);
            Color mediumGray = Color.FromArgb(30, 30, 30);
            Color lightBlack = Color.FromArgb(18, 18, 18);
            Color fullPink = Color.FromArgb(195, 143, 255);

            this.SetIconColor(objectForm, fullWhite);
            this.SetMainPanelColor(objectForm, darkGray);
            this.SetSecondPanelColor(objectForm, mediumGray);
            this.SetMainTextColor(objectForm, fullWhite);
            this.SetFormColor(objectForm, lightBlack);
            this.SetSecondTextColor(objectForm, lightGray);
            this.SetButtonColor(objectForm, fullPink);
        }

        void SetCustomTheme(Form1 objectForm)
        {
            //this.SetIconColor(objectForm, customIcon);
            //this.SetMainTextColor(objectForm, customMainText);

            this.SetIconColor(objectForm, customIcon);
            this.SetMainPanelColor(objectForm, customMainPanel);
            this.SetSecondPanelColor(objectForm, customSecondPanel);
            this.SetMainTextColor(objectForm, customMainText);
            this.SetFormColor(objectForm, customForm);
            this.SetSecondTextColor(objectForm, customSecondText);
            this.SetButtonColor(objectForm, customButton);
        }

        public void SetIconColor(Form1 objectForm, Color color)
        {
            SetButtonPictureColor(objectForm.button1, color);
            SetButtonPictureColor(objectForm.button2, color);
            SetButtonPictureColor(objectForm.button3, color);
            SetButtonPictureColor(objectForm.button4, color);
            SetButtonPictureColor(objectForm.button5, color);
            SetButtonPictureColor(objectForm.button6, color);

            SetPictureColor(objectForm.pictureBox1, color);
            SetPictureColor(objectForm.pictureBox2, color);
            SetPictureColor(objectForm.pictureBox3, color);
            SetPictureColor(objectForm.pictureBox4, color);
            SetPictureColor(objectForm.pictureBox5, color);

            // setting page
            SetPictureColor(objectForm.settings_page1.pictureBox1, color);

            SetButtonPictureColor(objectForm.settings_page1.button1, color);
            SetButtonPictureColor(objectForm.settings_page1.button2, color);
            SetButtonPictureColor(objectForm.settings_page1.button3, color);
            SetButtonPictureColor(objectForm.settings_page1.button4, color);
            SetButtonPictureColor(objectForm.settings_page1.button5, color);
            SetButtonPictureColor(objectForm.settings_page1.button6, color);
            SetButtonPictureColor(objectForm.settings_page1.button7, color);

            //payment page
            SetPictureColor(objectForm.payment_page1.pictureBox1, color);
            SetPictureColor(objectForm.payment_page1.pictureBox2, color);
            SetPictureColor(objectForm.payment_page1.pictureBox3, color);

            // admin page
            SetPictureColor(objectForm.admin_page1.pictureBox8, color);
            SetPictureColor(objectForm.admin_page1.pictureBox1, color);
            SetPictureColor(objectForm.admin_page1.pictureBox2, color);
            SetPictureColor(objectForm.admin_page1.pictureBox3, color);

            SetButtonPictureColor(objectForm.admin_page1.button1, color);
            SetButtonPictureColor(objectForm.admin_page1.button4, color);
            SetButtonPictureColor(objectForm.admin_page1.button2, color);
            SetButtonPictureColor(objectForm.admin_page1.button3, color);

            // main page
            SetPictureColor(objectForm.main_page1.pictureBox6, color);
            SetPictureColor(objectForm.main_page1.pictureBox8, color);

            // vehicle page
            

            // admin vehicleadd
            

            //login
            SetPictureColor(objectForm.Login.pictureBox1, color);
            SetPictureColor(objectForm.Login.pictureBox2, color);
            SetPictureColor(objectForm.Login.pictureBox3, color);

            // account check
            SetPictureColor(objectForm.admin_page1.admin_check1.pictureBox8, color);
        }

        public void SetMainTextColor(Form1 objectForm, Color color)
        {
            objectForm.button1.ForeColor = color;
            objectForm.button2.ForeColor = color;
            objectForm.button3.ForeColor = color;
            objectForm.button4.ForeColor = color;
            objectForm.button5.ForeColor = color;
            objectForm.button6.ForeColor = color;

            objectForm.label2.ForeColor = color;
            objectForm.label3.ForeColor = color;
            objectForm.label6.ForeColor = color;

            // main page
            objectForm.main_page1.label1.ForeColor = color;
            objectForm.main_page1.label2.ForeColor = color;

            objectForm.main_page1.label9.ForeColor = color;
            objectForm.main_page1.label8.ForeColor = color;
            objectForm.main_page1.label18.ForeColor = color;
            objectForm.main_page1.label11.ForeColor = color;
            objectForm.main_page1.label12.ForeColor = color;
            objectForm.main_page1.label15.ForeColor = color;
            objectForm.main_page1.label16.ForeColor = color;
            objectForm.main_page1.label24.ForeColor = color;
            objectForm.main_page1.label20.ForeColor = color;
            objectForm.main_page1.label22.ForeColor = color;
            objectForm.main_page1.label26.ForeColor = color;

            // payment page
            objectForm.payment_page1.label1.ForeColor = color;

            // setting page
            objectForm.settings_page1.label1.ForeColor = color;
            objectForm.settings_page1.label2.ForeColor = color;
            objectForm.settings_page1.label6.ForeColor = color;

            // admin page
            objectForm.admin_page1.label26.ForeColor = color;
            objectForm.admin_page1.label4.ForeColor = color;
            objectForm.admin_page1.label6.ForeColor = color;
            objectForm.admin_page1.label9.ForeColor = color;
            objectForm.admin_page1.label1.ForeColor = color;
            objectForm.admin_page1.label2.ForeColor = color;

            objectForm.admin_page1.button1.ForeColor = color;
            objectForm.admin_page1.button2.ForeColor = color;
            objectForm.admin_page1.button3.ForeColor = color;
            objectForm.admin_page1.button4.ForeColor = color;

            // vehicle page
            objectForm.vehicle_page1.label77.ForeColor = color;
            objectForm.vehicle_page1.checkedListBox1.ForeColor = color;

            objectForm.vehicle_page1.textBox1.ForeColor = color;
            objectForm.vehicle_page1.textBox2.ForeColor = color;

            // admin vehicleadd
            

            // login
            objectForm.Login.textBox1.ForeColor = color;
            objectForm.Login.textBox2.ForeColor = color;
            objectForm.Login.textBox3.ForeColor = color;
            objectForm.Login.textBox4.ForeColor = color;
            objectForm.Login.textBox5.ForeColor = color;
            objectForm.Login.textBox6.ForeColor = color;
            objectForm.Login.textBox7.ForeColor = color;
            objectForm.Login.textBox8.ForeColor = color;
            objectForm.Login.textBox9.ForeColor = color;
            objectForm.Login.textBox10.ForeColor = color;

            objectForm.Login.textBox1.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox2.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox3.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox4.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox5.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox6.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox7.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox8.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox9.BackColor = objectForm.Login.panel3.BackColor;
            objectForm.Login.textBox10.BackColor = objectForm.Login.panel3.BackColor;

            objectForm.Login.panel5.BackColor = color;
            objectForm.Login.panel4.BackColor = color;
            objectForm.Login.panel7.BackColor = color;
            objectForm.Login.panel8.BackColor = color;
            objectForm.Login.panel9.BackColor = color;
            objectForm.Login.panel10.BackColor = color;
            objectForm.Login.panel11.BackColor = color;
            objectForm.Login.panel14.BackColor = color;
            objectForm.Login.panel12.BackColor = color;
            objectForm.Login.panel13.BackColor = color;

            // account check
            objectForm.admin_page1.admin_check1.label1.ForeColor = color;
            objectForm.admin_page1.admin_check1.label40.ForeColor = color;
            objectForm.admin_page1.admin_check1.label7.ForeColor = color;
            objectForm.admin_page1.admin_check1.label9.ForeColor = color;
            objectForm.admin_page1.admin_check1.label11.ForeColor = color;
            objectForm.admin_page1.admin_check1.label13.ForeColor = color;
            objectForm.admin_page1.admin_check1.label16.ForeColor = color;
            objectForm.admin_page1.admin_check1.label3.ForeColor = color;
            objectForm.admin_page1.admin_check1.label5.ForeColor = color;
        }

        public void SetSecondTextColor(Form1 objectForm, Color color)
        {
            // setting page
            objectForm.settings_page1.label3.ForeColor = color;
            objectForm.settings_page1.label4.ForeColor = color;
            objectForm.settings_page1.label5.ForeColor = color;
            objectForm.settings_page1.label7.ForeColor = color;
            objectForm.settings_page1.label8.ForeColor = color;

            objectForm.settings_page1.label8.ForeColor = color;
            objectForm.settings_page1.label9.ForeColor = color;
            objectForm.settings_page1.label10.ForeColor = color;
            objectForm.settings_page1.label11.ForeColor = color;
            objectForm.settings_page1.label12.ForeColor = color;

            // payment page
            objectForm.payment_page1.label7.ForeColor = color;
            objectForm.payment_page1.label2.ForeColor = color;
            objectForm.payment_page1.label3.ForeColor = color;
            objectForm.payment_page1.label9.ForeColor = color;
            objectForm.payment_page1.label4.ForeColor = color;
            objectForm.payment_page1.label5.ForeColor = color;
            objectForm.payment_page1.label11.ForeColor = color;
            objectForm.payment_page1.label6.ForeColor = color;
            objectForm.payment_page1.label8.ForeColor = color;

            // admin page
            objectForm.admin_page1.label7.ForeColor = color;
            objectForm.admin_page1.label10.ForeColor = color;

            // main page
            objectForm.main_page1.label7.ForeColor = color;
            objectForm.main_page1.label3.ForeColor = color;

            objectForm.main_page1.label19.ForeColor = color;
            objectForm.main_page1.label10.ForeColor = color;
            objectForm.main_page1.label13.ForeColor = color;
            objectForm.main_page1.label14.ForeColor = color;
            objectForm.main_page1.label17.ForeColor = color;
            objectForm.main_page1.label25.ForeColor = color;
            objectForm.main_page1.label21.ForeColor = color;
            objectForm.main_page1.label23.ForeColor = color;

           

            objectForm.vehicle_page1.label75.ForeColor = color;
            objectForm.vehicle_page1.label74.ForeColor = color;
            objectForm.vehicle_page1.label76.ForeColor = color;

            //login
            objectForm.Login.label1.ForeColor = color;
            objectForm.Login.label41.ForeColor = color;
            objectForm.Login.label4.ForeColor = color;
            objectForm.Login.label5.ForeColor = color;
            objectForm.Login.label6.ForeColor = color;
            objectForm.Login.label7.ForeColor = color;
            objectForm.Login.label8.ForeColor = color;
            objectForm.Login.label12.ForeColor = color;
            objectForm.Login.label9.ForeColor = color;
            objectForm.Login.label10.ForeColor = color;
            objectForm.Login.label3.ForeColor = color;


            // account check
            objectForm.admin_page1.admin_check1.label4.ForeColor = color;
            objectForm.admin_page1.admin_check1.label6.ForeColor = color;
            objectForm.admin_page1.admin_check1.label8.ForeColor = color;
            objectForm.admin_page1.admin_check1.label10.ForeColor = color;
            objectForm.admin_page1.admin_check1.label12.ForeColor = color;
            objectForm.admin_page1.admin_check1.label14.ForeColor = color;
            objectForm.admin_page1.admin_check1.label15.ForeColor = color;
            objectForm.admin_page1.admin_check1.label2.ForeColor = color;
            objectForm.admin_page1.admin_check1.label41.ForeColor = color;
        }

        public void SetMainPanelColor(Form1 objectForm, Color color)
        {
            objectForm.panel1.BackColor = color;
            objectForm.panel4.BackColor = color;
            objectForm.panel6.BackColor = color;

            objectForm.vehicle_page1.textBox1.BackColor = color;
            objectForm.vehicle_page1.textBox2.BackColor = color;
            objectForm.vehicle_page1.checkedListBox1.BackColor = color;
            objectForm.vehicle_page1.panel30.BackColor = color;

            // setting page
            objectForm.settings_page1.panel1.BackColor = color;
            objectForm.settings_page1.panel5.BackColor = color;

            // admin page
            objectForm.admin_page1.panel1.BackColor = color;
            objectForm.admin_page1.panel2.BackColor = color;
            objectForm.admin_page1.panel3.BackColor = color;
            objectForm.admin_page1.panel4.BackColor = color;
            objectForm.admin_page1.panel5.BackColor = color;

            // main panel
            objectForm.main_page1.panel11.BackColor = color;
            objectForm.main_page1.panel8.BackColor = color;
            objectForm.main_page1.panel9.BackColor = color;
            objectForm.main_page1.panel12.BackColor = color;
            objectForm.main_page1.panel13.BackColor = color;

            // admin vehicle add
            

            // login
            objectForm.Login.panel1.BackColor = color;
            objectForm.Login.panel2.BackColor = color;
            objectForm.Login.panel3.BackColor = color;

            // account check
            objectForm.admin_page1.admin_check1.panel1.BackColor = color;
            objectForm.admin_page1.admin_check1.BackColor = color;
        }

        public void SetSecondPanelColor(Form1 objectForm, Color color)
        {
            objectForm.panel2.BackColor = color;
            objectForm.panel3.BackColor = color;

            // admin page
            objectForm.admin_page1.panel8.BackColor = color;
        }

        public void SetButtonColor(Form1 objectForm, Color color)
        {
            objectForm.panel5.BackColor = color;

            // payment page
            objectForm.payment_page1.jThinButton1.BackgroundColor = color;
            objectForm.payment_page1.jThinButton1.BorderColor = color;
            objectForm.payment_page1.jThinButton1.HoverBorder = color;
            objectForm.payment_page1.jThinButton1.HoverBackground = objectForm.payment_page1.panel7.BackColor;
            objectForm.payment_page1.panel1.BackColor = color;
            objectForm.payment_page1.panel2.BackColor = color;
            objectForm.payment_page1.panel10.BackColor = color;

            // admin page
            SetPictureColor(objectForm.admin_page1.pictureBox15, color);
            objectForm.admin_page1.panel10.BackColor = color;
            objectForm.admin_page1.panel9.BackColor = color;

            objectForm.admin_page1.label27.ForeColor = color;
            objectForm.admin_page1.label3.ForeColor = color;
            objectForm.admin_page1.label5.ForeColor = color;
            objectForm.admin_page1.label8.ForeColor = color;

            // main page
            objectForm.main_page1.panel10.BackColor = color;
            objectForm.main_page1.panel14.BackColor = color;
            objectForm.main_page1.panel15.BackColor = color;

            objectForm.main_page1.jThinButton1.BackgroundColor = color;
            objectForm.main_page1.jThinButton1.BorderColor = color;
            objectForm.main_page1.jThinButton1.HoverBorder = color;
            objectForm.main_page1.jThinButton1.HoverBackground = objectForm.main_page1.panel11.BackColor;

            // vehicle page
            SetPictureColor(objectForm.vehicle_page1.pictureBox15, color);
            objectForm.vehicle_page1.panel31.BackColor = color;

            /*objectForm.vehicle_page1.jThinButton5.BackgroundColor = color;
            objectForm.vehicle_page1.jThinButton5.BorderColor = color;
            objectForm.vehicle_page1.jThinButton5.HoverBorder = color;
            objectForm.vehicle_page1.jThinButton5.HoverBackground = objectForm.main_page1.panel11.BackColor;

            objectForm.vehicle_page1.jThinButton4.BackgroundColor = color;
            objectForm.vehicle_page1.jThinButton4.BorderColor = color;
            objectForm.vehicle_page1.jThinButton4.HoverBorder = color;
            objectForm.vehicle_page1.jThinButton4.HoverBackground = objectForm.vehicle_page1.panel17.BackColor;

            // vehicle buttons

            objectForm.vehicle_page1.jThinButton1.BackgroundColor = color;
            objectForm.vehicle_page1.jThinButton1.BorderColor = color;
            objectForm.vehicle_page1.jThinButton1.HoverBorder = color;
            objectForm.vehicle_page1.jThinButton1.HoverBackground = objectForm.vehicle_page1.panel27.BackColor;

            objectForm.vehicle_page1.jThinButton2.BackgroundColor = color;
            objectForm.vehicle_page1.jThinButton2.BorderColor = color;
            objectForm.vehicle_page1.jThinButton2.HoverBorder = color;
            objectForm.vehicle_page1.jThinButton2.HoverBackground = objectForm.vehicle_page1.panel27.BackColor;

            objectForm.vehicle_page1.jThinButton6.BackgroundColor = color;
            objectForm.vehicle_page1.jThinButton6.BorderColor = color;
            objectForm.vehicle_page1.jThinButton6.HoverBorder = color;
            objectForm.vehicle_page1.jThinButton6.HoverBackground = objectForm.vehicle_page1.panel27.BackColor;*/

            // setting page
            objectForm.settings_page1.jThinButton6.BackgroundColor = color;
            objectForm.settings_page1.jThinButton6.BorderColor = color;
            objectForm.settings_page1.jThinButton6.HoverBorder = color;
            objectForm.settings_page1.jThinButton6.HoverBackground = objectForm.settings_page1.panel5.BackColor;

            objectForm.settings_page1.panel10.BackColor = color;

            // admin vehicleadd
            objectForm.admin_page1.admin_vehicleadd1.jThinButton2.BackgroundColor = color;
            objectForm.admin_page1.admin_vehicleadd1.jThinButton2.BorderColor = color;
            objectForm.admin_page1.admin_vehicleadd1.jThinButton2.HoverBorder = color;
            objectForm.admin_page1.admin_vehicleadd1.jThinButton2.HoverBackground = objectForm.admin_page1.admin_vehicleadd1.BackColor;

            // login
            objectForm.Login.jThinButton2.BackgroundColor = color;
            objectForm.Login.jThinButton2.BorderColor = color;
            objectForm.Login.jThinButton2.HoverBorder = color;
            objectForm.Login.jThinButton2.HoverBackground = objectForm.Login.BackColor;

            objectForm.Login.jThinButton1.BackgroundColor = color;
            objectForm.Login.jThinButton1.BorderColor = color;
            objectForm.Login.jThinButton1.HoverBorder = color;
            objectForm.Login.jThinButton1.HoverBackground = objectForm.Login.BackColor;

            objectForm.Login.panel6.BackColor = color;

            // account check
            SetPictureColor(objectForm.admin_page1.admin_check1.pictureBox1, color);
        }

        public void SetFormColor(Form1 objectForm, Color color)
        {
            objectForm.BackColor = color;
            objectForm.main_page1.panel7.BackColor = color;
            objectForm.vehicle_page1.panel16.BackColor = color;
            objectForm.settings_page1.BackColor = color;
            objectForm.payment_page1.panel7.BackColor = color;
            objectForm.admin_page1.panel7.BackColor = color;
            objectForm.Login.BackColor = color;
            

        }

        public void SetPictureColor(PictureBox picture, Color color)
        {
            Bitmap bmp = new Bitmap(picture.Image);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (bmp.GetPixel(i, j).A == 0)
                        continue;

                    bmp.SetPixel(i, j,
                        Color.FromArgb(bmp.GetPixel(i, j).A,
                        color.R,
                        color.G,
                        color.B));
                }
            }

            picture.Image = bmp;
        }
        

        public void SetButtonPictureColor(Button button, Color color)
        {
            Bitmap bmp = new Bitmap(button.Image);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (bmp.GetPixel(i, j).A == 0)
                        continue;

                    bmp.SetPixel(i, j,
                        Color.FromArgb(bmp.GetPixel(i, j).A,
                        color.R,
                        color.G,
                        color.B));
                }
            }

            button.Image = bmp;
        }

        
    }
}
