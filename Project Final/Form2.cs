﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Project_Final
{
    public partial class accountant : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public accountant()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void accountant_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Accountant where UserName = '"+lblUname.Text.Trim()+ "'", con);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count>0)
            {
                Global.CurrentSignInID = int.Parse(dt.Rows[0][1].ToString());
                Global.CurrentName = dt.Rows[0][3].ToString();
                Global.CurrentEmail = dt.Rows[0][7].ToString();
                lblName.Text = dt.Rows[0][3].ToString();
                lblEmail.Text = dt.Rows[0][7].ToString();
            }
            con.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
