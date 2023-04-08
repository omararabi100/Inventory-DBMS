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
    public partial class OrdersForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public void LoadOrderData()
        {
            
                if (con.State != ConnectionState.Open)
                    con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Ordered", con);
                dt.Clear();
                adapter.Fill(dt);
                dvgOrder.DataSource = dt;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddOrder form = new AddOrder();
            form.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RemoveOrder Form = new RemoveOrder();

                Form.ShowDialog();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Ordered where OID like '%" + txtSearchBar.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                dvgOrder.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
           
        }
    }
}
