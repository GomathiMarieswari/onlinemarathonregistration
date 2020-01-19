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
    public partial class Net : Form
    {
        public Net()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Enter the Username Password");
            }
            else
            {
                Netlogin login = new Netlogin();
                login.Show();
            }
        }
    }
}
