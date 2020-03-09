using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign
{
    public partial class settings_page : UserControl
    {
        public Form1 mainWindow;

        public settings_page()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            panel5.Visible = false;

            mainWindow.clientData.ui.SetTheme(mainWindow, mainWindow.clientData.ui.theme_Light);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            panel5.Visible = false;

            mainWindow.clientData.ui.SetTheme(mainWindow, mainWindow.clientData.ui.theme_Dark);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            panel5.Visible = true;

            mainWindow.clientData.ui.SetTheme(mainWindow, mainWindow.clientData.ui.theme_Custom);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // main text
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customMainText = PickColor.Color;
                mainWindow.clientData.ui.SetMainTextColor(mainWindow, PickColor.Color);
            }
        }

        // second text
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customSecondText = PickColor.Color;
                mainWindow.clientData.ui.SetSecondTextColor(mainWindow, PickColor.Color);
            }
        }

        // button text
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customButton = PickColor.Color;
                mainWindow.clientData.ui.SetButtonColor(mainWindow, PickColor.Color);
            }
        }

        // icon
        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customIcon = PickColor.Color;
                mainWindow.clientData.ui.SetIconColor(mainWindow, PickColor.Color);
            }
        }

        // main panel
        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customMainPanel = PickColor.Color;
                mainWindow.clientData.ui.SetMainPanelColor(mainWindow, PickColor.Color);
            }
        }


        // second panel
        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customSecondPanel = PickColor.Color;
                mainWindow.clientData.ui.SetSecondPanelColor(mainWindow, PickColor.Color);
            }
        }

        // form
        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                mainWindow.clientData.ui.customForm = PickColor.Color;
                mainWindow.clientData.ui.SetFormColor(mainWindow, PickColor.Color);
            }
        }

        // 
    }
}
