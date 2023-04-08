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
using static System.Net.Mime.MediaTypeNames;



namespace Project_Final
{
    public partial class Products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        DataTable dtp = new DataTable();
        public Products()
        {
            InitializeComponent();
        }
        public void LoadProductData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlCommand cmd = new SqlCommand("ShowProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dtp.Clear();
            dtp.Load(cmd.ExecuteReader());
            dvProduct.DataSource = dtp;
            if (con.State == ConnectionState.Open)
                con.Close();           
        }

        private void Products_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btndb_Click(object sender, EventArgs e)
        {
            ICmanager form = new ICmanager();
            this.Close();
            form.Show();
        }

        private void dvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd4 = new SqlCommand("Select * from Product where Name like '%" + txtSearch.Text + "%'", con);
            DataTable dt4 = new DataTable();
            dt4.Load(cmd4.ExecuteReader());
            dvProduct.DataSource = dt4;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProduct form = new addProduct();
            form.ShowDialog();
            this.Hide();
        }   
        
    }
}
