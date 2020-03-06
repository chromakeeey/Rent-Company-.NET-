using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.RentPicker
{
    public partial class RentTimePicker : Form
    {
        public RentTimePicker()
        {
            InitializeComponent();
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
