using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marathon
{
    public partial class Cardpay : Form
    {
        public Cardpay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomnumber;
            Random randm = new Random();
            randomnumber = randm.Next(1000, 9999);
            Console.WriteLine(randomnumber);
            MessageBox.Show(randomnumber.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("card holder name is empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("card number is empty");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("expire date is empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("ccv number is empty");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("OTP number is empty");
            }
            else
            {
                MessageBox.Show("Paid Successfully");
                Close();
            }
        }
    }
}
