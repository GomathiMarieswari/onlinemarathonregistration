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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "manager" && textBox2.Text == "manager")
            {
                Database db = new Database();
                db.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
               
            }
        }

        
    }
}
