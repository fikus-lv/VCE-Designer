using Fikus_Server.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fikus_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SqlConnection con = new SqlConnection("conStr");
            string sql = "Select * From Test";

            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            dataGridView1.DataSource = dr;
            dr.Close();
            con.Close();
        }
        
    

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}
