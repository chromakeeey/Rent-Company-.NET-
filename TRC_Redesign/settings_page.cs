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
        public Form1 objectForm;

        public settings_page()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            panel5.Visible = false;

            //Form1.pointer.ui.SetTheme(objectForm, Form1.pointer.ui.theme_Light);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            panel5.Visible = false;

            //Form1.pointer.ui.SetTheme(objectForm, Form1.pointer.ui.theme_Dark);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            panel5.Visible = true;

            //Form1.pointer.ui.SetTheme(objectForm, Form1.pointer.ui.theme_Custom);
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
                //Form1.pointer.ui.customMainText = PickColor.Color;
                //Form1.pointer.ui.SetMainTextColor(objectForm, PickColor.Color);
            }
        }

        // second text
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customSecondText = PickColor.Color;
                //Form1.pointer.ui.SetSecondTextColor(objectForm, PickColor.Color);
            }
        }

        // button text
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customButton = PickColor.Color;
                //Form1.pointer.ui.SetButtonColor(objectForm, PickColor.Color);
            }
        }

        // icon
        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customIcon = PickColor.Color;
                //Form1.pointer.ui.SetIconColor(objectForm, PickColor.Color);
            }
        }

        // main panel
        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customMainPanel = PickColor.Color;
                //Form1.pointer.ui.SetMainPanelColor(objectForm, PickColor.Color);
            }
        }


        // second panel
        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customSecondPanel = PickColor.Color;
                //Form1.pointer.ui.SetSecondPanelColor(objectForm, PickColor.Color);
            }
        }

        // form
        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog PickColor = new ColorDialog();

            if (PickColor.ShowDialog() == DialogResult.OK)
            {
                //Form1.pointer.ui.customForm = PickColor.Color;
                //Form1.pointer.ui.SetFormColor(objectForm, PickColor.Color);
            }
        }

        // 
    }
}
