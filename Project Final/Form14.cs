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

namespace Project_Final
{
    public partial class Form14 : Form
    {
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("addCustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully");
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show("something went wrong!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }
    }
}
