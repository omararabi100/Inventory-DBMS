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
        public Suppliers()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Select";
            checkbox.Width = 25;
            checkbox.Name = "dvgcb";
            dvSupp.Columns.Insert(0, checkbox);
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
                dvSupp.DataSource = dt;


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


        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("RemoveSupp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow dvr in dvSupp.Rows)
                {
                    bool isSelected = Convert.ToBoolean(dvr.Cells["dvgcb"].Value);
                    if (isSelected)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@SPID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                LoadData();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show("Error!");
            }
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
                dvSupp.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void dvSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICmanager form = new ICmanager();
            this.Close();
            form.Show();
        }

        private void dvSupp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
