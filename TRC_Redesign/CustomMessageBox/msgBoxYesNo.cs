using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.CustomMessageBox
{
    public partial class msgBoxYesNo : Form
    {
        public msgBoxYesNo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Image MessageIcon
        {
            get { return icon_box.Image; }
            set { icon_box.Image = value; }
        }

        public string Caption
        {
            get { return caption_box.Text; }
            set { caption_box.Text = value; }
        }

        public string Message
        {
            get { return message_box.Text; }
            set { message_box.Text = value; }
        }
    }
}
