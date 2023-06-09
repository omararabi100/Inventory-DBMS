﻿using System;
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
    public partial class AddOrder : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        DataTable dts = new DataTable();
        DataTable dtp = new DataTable();
        public AddOrder()
        {
            InitializeComponent();
            LoadProductData();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Select";
            checkbox.Width = 25;
            checkbox.Name = "dvgcb";
            dvAdd.Columns.Insert(0, checkbox);
            dts.Clear();
            dts.Columns.Add("PID");
        }


        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (Con.State != ConnectionState.Open)
                    Con.Open();
                SqlCommand cmd = new SqlCommand("AddOrder", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OID", int.Parse(txtOID.Text));
                cmd.Parameters.AddWithValue("@AID", int.Parse(txtAID.Text));
                cmd.Parameters.AddWithValue("@SID", Global.CurrentSignInID);
                cmd.Parameters.AddWithValue("@PhoneNumber", Int64.Parse(txtPhoneNumber.Text));
                cmd.Parameters.AddWithValue("@AmmountSpent", double.Parse(txtSpent.Text));
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("AddSelectedItems", Con);
                cmd1.CommandType = CommandType.StoredProcedure;
                foreach (DataGridViewRow dvr in dvSelected.Rows)
                {
                    if (dvr.Cells[0].Value != null)
                    {
                        cmd1.Parameters.AddWithValue("@OID", int.Parse(txtOID.Text));
                        cmd1.Parameters.AddWithValue("@PID", dvr.Cells[0].Value);
                        cmd1.ExecuteNonQuery();
                     
                    }
                       cmd1.Parameters.Clear();
                }
                MessageBox.Show("Order Added Successfully!!!");
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dvAdd.DataSource = dtp;
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var SelectedProductsIndex = new List<int>();
            foreach(DataGridViewRow dvr in dvAdd.Rows)
            {
                bool isSelected = Convert.ToBoolean(dvr.Cells["dvgcb"].Value);
                if (isSelected)
                {
                    int crIndex = dvr.Index;
                    SelectedProductsIndex.Add(crIndex);
                    dts.Rows.Add(dvr.Cells[1].Value);
                }
                dvSelected.DataSource = dts;
            }
            for(int i = SelectedProductsIndex.Count; i > 0; i--)
            {
                dtp.Rows.RemoveAt(SelectedProductsIndex[i-1]);
            }
            dvAdd.DataSource = dtp;
        }

        private void dvSI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveProductBtn_Click(object sender, EventArgs e)
        {
            LoadProductData();
            dts.Clear();
            dvSelected.DataSource = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAID.Text = "";
            txtOID.Text = "";
            txtPhoneNumber.Text = "";
            txtSpent.Text = "";
            dts.Clear();
            dvSelected.DataSource=dts;
            LoadProductData();
        }

        private void txtSpent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            this.Close();

            form.LoadOrderData();
            form.Show();


        }
    }
}
