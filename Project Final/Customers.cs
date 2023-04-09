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

        private void btnLogout_Click(object sender, EventArgs e)
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
                dvCustomer.DataSource = dt;
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
                dvCustomer.DataSource = dt;


            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }


      

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();
            this.Hide();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dvCustomer.CurrentCell.RowIndex;
            dvCustomer.Rows.RemoveAt(rowIndex);
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
            DataGridViewRow row = this.dvCustomer.Rows[e.RowIndex];
            id = Convert.ToInt64(row.Cells[0].Value);
        }

        private void btnDB_Click_1(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.Show();
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            this.Close();
            form.Show();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Customers form = new Customers();
            this.Close();
            form.Show();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer where Name like '%" + txtSearchBar.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                dvCustomer.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void dvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }  
}
