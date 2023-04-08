using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;

namespace Project_Final
{
    public partial class Request_Products : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        DataTable dtc = new DataTable();
        DataTable dtp = new DataTable();
        public Request_Products()
        {
            InitializeComponent();
            LoadProductData();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Select";
            checkbox.Width = 25;
            checkbox.Name = "dvgcb";
            dvProduct.Columns.Insert(0, checkbox);
            dtc.Clear();
            dtc.Columns.Add("PID");
            dtc.Columns.Add("Quantity");
        }

        private void Request_Products_Load(object sender, EventArgs e)
        {


        }
        public void LoadProductData()
        {
            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString()))
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Product", Con);
                dtp.Clear();
                adapter.Fill(dtp);
                dvProduct.DataSource = dtp;
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();
                var SelectedProductsIndex = new List<int>();
                foreach (DataGridViewRow dvr in dvProduct.Rows)
                {
                    bool isSelected = Convert.ToBoolean(dvr.Cells["dvgcb"].Value);
                    if (isSelected)
                    {
                        int crIndex = dvr.Index;
                        SelectedProductsIndex.Add(crIndex);
                        dtc.Rows.Add(dvr.Cells[1].Value);
                    }
                    dvcart.DataSource = dtc;
                }
                for (int i = SelectedProductsIndex.Count; i > 0; i--)
                {
                    dtp.Rows.RemoveAt(SelectedProductsIndex[i-1]);
                }
                  dvProduct.DataSource = dtp;

                if (Con.State  == ConnectionState.Open)
                    Con.Close() ;   


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }


            
            
            
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            LoadProductData();
            dtc.Clear();
            dvcart.DataSource = null;
        }

        private void btnRequestItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();
                SqlCommand cmd1 = new SqlCommand("RequestProduct", Con);
                cmd1.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow dvr in dvcart.Rows)
                {
                    if (dvr.Cells[0].Value != null)
                    {
                        cmd1.Parameters.AddWithValue("@Quantity", dvr.Cells[1].Value);
                        cmd1.Parameters.AddWithValue("@PID", dvr.Cells[0].Value);
                        cmd1.ExecuteNonQuery();

                    }
                    cmd1.Parameters.Clear();
                }
                MessageBox.Show("Product Added Successfully!!!");
                LoadProductData();
                dtc.Clear();
                dvcart.DataSource = null;

                if (Con.State  == ConnectionState.Open)
                    Con.Close();

            }
            catch (Exception ex) {

                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICmanager objform5 = new ICmanager();
            this.Hide();
            objform5.Show();
        }
    }

}
