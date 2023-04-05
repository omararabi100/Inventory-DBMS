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
    public partial class RemoveOrder : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public RemoveOrder()
        {
            InitializeComponent();
            LoadOrderData();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Select";
            checkbox.Width = 25;
            checkbox.Name = "dvgcb";
            dvgOrder.Columns.Insert(0, checkbox);
        }

        private void svgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadOrderData()
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString()))
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
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("RemoveOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow dvr in dvgOrder.Rows)
                {
                    bool isSelected = Convert.ToBoolean(dvr.Cells["dvgcb"].Value);
                    if (isSelected)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@OID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                LoadOrderData();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show("Error!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Ordered where OID like '%" + txtSearch.Text + "%'", con);
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
    }
}
