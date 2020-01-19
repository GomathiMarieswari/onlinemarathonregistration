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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pravin\Documents\Visual Studio 2010\Projects\Marathon\Marathon\Marathon.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("name is empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("father name is empty");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("DOB is empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("age is empty");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Blood Group  is empty");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("city is empty");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Nationality is empty");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("mobile number is empty");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("Email id is empty");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("Address is empty");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("gender is empty");
            }

            else
            {
                cmd = new SqlCommand("insert into register values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + str + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Register Successfully");
                Payment pay = new Payment();
                pay.Show();
                Close();
            }
        }
        string str;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                str = "5 Km";   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                str = "10 Km";   
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            str = "30 Km";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("name is empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("father name is empty");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("DOB is empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("age is empty");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Blood Group  is empty");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("city is empty");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Nationality is empty");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("mobile number is empty");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("Email id is empty");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("Address is empty");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("gender is empty");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    int randomnumber;
                    Random randm = new Random();
                    randomnumber = randm.Next(100000, 500000);
                    Console.WriteLine(randomnumber);
                    textBox11.Text = randomnumber.ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    int randomnumber;
                    Random randm = new Random();
                    randomnumber = randm.Next(100000, 500000);
                    Console.WriteLine(randomnumber);
                    textBox11.Text = randomnumber.ToString();
                }
                else if (radioButton3.Checked == true)
                {
                    int randomnumber;
                    Random randm = new Random();
                    randomnumber = randm.Next(100000, 500000);
                    Console.WriteLine(randomnumber);
                    textBox11.Text = randomnumber.ToString();
                }
                else
                {
                    MessageBox.Show("pls select the kilometer");
                } 
                
                
            }
  
        }       
        public void radio()
        {
            if (radioButton1.Checked == true)
                {
                    MessageBox.Show("5 kilometer is selected");
                }
                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("10 kilometer is selected");
                }
                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("30 kilometer is selected");
                }
            else
        {
            MessageBox.Show("pls select the kilometer");
        }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    
    
    }
}
