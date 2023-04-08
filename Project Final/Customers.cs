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
    public partial class Customers : Form
    {
        Int64 id;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer", con);
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


        public void LoadData()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Customer", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }


      

        private void button9_Click_1(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("Delete from Customer where PhoneNumber =' " + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            id = Convert.ToInt64(row.Cells[0].Value);
        }
    }   
}
