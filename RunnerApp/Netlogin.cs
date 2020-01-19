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
    public partial class Netlogin : Form
    {
        public Netlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Pls enter the OTP");
            }
            else
            {
                MessageBox.Show("Paid Successfully");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomnumber;
            Random randm = new Random();
            randomnumber = randm.Next(1000, 9999);
            Console.WriteLine(randomnumber);
            MessageBox.Show(randomnumber.ToString());
        }

    }  
}
