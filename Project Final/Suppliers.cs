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
    public partial class Suppliers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        int id;
        public Suppliers()
        {
            InitializeComponent();
        }

       public void LoadData()
        {
            try
            {
                if(con.State != ConnectionState.Open) 
                    con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Supplier", con);
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
        private void button9_Click(object sender, EventArgs e)
        {
            Add_Supplier objform = new Add_Supplier();
            objform.ShowDialog();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("Delete from Supplier where SPID =' " + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!");
            }
            catch { 
            MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Supplier where Name like '%" + textBox1.Text + "%'", con);
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
    }
    
}
