using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.InputBoxes
{
    public partial class InputTextBox : Form
    {
        public InputTextBox()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return message_box.Text; }
            set { message_box.Text = value;  }
        }
    }
}
