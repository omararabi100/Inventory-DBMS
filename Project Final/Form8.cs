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

namespace Project_Final
{
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                    SqlCommand cmd = new SqlCommand("Select * from Product", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
               
                
            }
            
            catch
            {
                MessageBox.Show("Error occured...");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                if (tabControl1.SelectedTab == tabPage1)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Product", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                }

                else if (tabControl1.SelectedTab == tabPage2)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Product order by Quantity desc", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView2.DataSource = dt;
                }

                else if (tabControl1.SelectedTab == tabPage3)
                {
                    SqlCommand cmd3 = new SqlCommand("Select * from Product order by Price desc", con);
                    DataTable dt3 = new DataTable();
                    dt3.Load(cmd3.ExecuteReader());
                    dataGridView3.DataSource = dt3;
                }

            }
            catch
            {
                MessageBox.Show("Error occured...");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form form = new addProduct();
            form.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form form = new addProduct();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new addProduct();
            this.Hide();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from product where Name like '%" + textBox1.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
