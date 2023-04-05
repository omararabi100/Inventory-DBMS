using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Project_Final
{
    public partial class addProduct : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public addProduct()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbimage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtID.Text = "";
            txtColor.Text = "";
            txtICMID.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtSize.Text = "";
            txtQuality.Text = "";

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("AddProduct", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@ICMID", int.Parse(txtICMID.Text));
                cmd.Parameters.AddWithValue("@Size", int.Parse(txtSize.Text));
                cmd.Parameters.AddWithValue("@Price", int.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@COLOR", txtColor.Text);
                cmd.Parameters.AddWithValue("@Quality", txtQuality.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");

                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            insert_imagecs newForm = new insert_imagecs();
            newForm.Show();
            this.Hide();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
