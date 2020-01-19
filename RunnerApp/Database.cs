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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pravin\Documents\Visual Studio 2010\Projects\Marathon\Marathon\Marathon.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { str = "5 km"; }
            else if (radioButton2.Checked)
            { str = "10 km"; }
            else
            { str = "30 km"; }
            cmd = new SqlCommand("select * from register where kilometer ='"+str+"'",con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
