using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Marathon
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pravin\Documents\Visual Studio 2010\Projects\Marathon\Marathon\Marathon.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("User id  is empty");
            }
            else
            {
                cmd = new SqlCommand("insert into payment values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + label5.Text + "','" + str1 + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (radioButton1.Checked)
            {
                Cardpay card = new Cardpay();
                card.Show();
            }
            else
            {
                Net net = new Net();
                net.Show();
            }
            this.Close();
        }

        string str1;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            str1 = "card";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            str1 = "Net Banking";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select MobileNo , kilometer from register where Userid='"+textBox1.Text+"' ",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
            }
            con.Close();
        }
    }
}
