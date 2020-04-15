﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRC_Redesign.CashChecks
{
    public partial class CheckEdit : Form
    {
        public Form1 mainWindow;

        public CheckEdit()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            mainWindow.clientData.checkData.companyName = textBox1.Text;
            mainWindow.clientData.checkData.streetName = textBox2.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
