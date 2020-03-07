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
    public partial class payment_page : UserControl
    {
        int actionType = 0;
        public Form1 obj;

        public payment_page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(pictureBox1.Location.X, panel1.Location.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(pictureBox2.Location.X, panel1.Location.Y);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Enabled = true;
            maskedTextBox3.Enabled = true;
            maskedTextBox4.Enabled = true;
            label10.Visible = false;

            panel2.Location = new Point(30, panel2.Location.Y);
            actionType = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            maskedTextBox4.Enabled = false;
            label10.Visible = false;

            panel2.Location = new Point(114, panel2.Location.Y);
            actionType = 1;
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            /*if (actionType == 0)
            {
                if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" ||
                    maskedTextBox3.Text == "" && maskedTextBox4.Text == "" ||
                    textBox1.Text == "")
                {
                    label10.Text = "Ви не ввели всі потрібні дані.";
                    label10.Visible = true;
                    return;
                }

                if (Convert.ToInt32(textBox1.Text) > 10000)
                {
                    label10.Text = "Сумма поповнення занад-то велика.";
                    label10.Visible = true;
                    return;
                }

                account.instance.balance += Convert.ToSingle(textBox1.Text);
                Form1.pointer.UpdateAccountInformation();

                MessageBox.Show("Ви успішно поповнили свій рахунок.");
            }

            if (actionType == 1)
            {
                if (maskedTextBox1.Text == "" || textBox1.Text == "")
                {
                    label10.Text = "Ви не ввели всі потрібні дані.";
                    label10.Visible = true;
                    return;
                }

                if (account.instance.balance < Convert.ToSingle(textBox1.Text))
                {
                    label10.Text = "Не вистачає грошей на рахунку для виводу їх на карту.";
                    label10.Visible = true;
                    return;
                }

                account.instance.balance -= Convert.ToSingle(textBox1.Text);
                Form1.pointer.UpdateAccountInformation();

                obj.dialogCreate("Гроші були виведені Вам на карту.", "Успішна операція", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
