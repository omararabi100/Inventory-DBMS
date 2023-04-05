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
    public partial class RemoveUser : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void PositionComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (PositionComb.SelectedItem.ToString() == "Administrator")
                    LoadAdminData();
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                    LoadAccountantData();
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                    LoadWareHouseManagerData();
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                    LoadInventoryControlManagerData();
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                    LoadStaffData();
            }
            catch (Exception msj)
            {
                MessageBox.Show("Error");
            }
            
        }
        public void LoadAdminData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Admin", con);
            dt.Clear();
            adapter.Fill(dt);
            dvgUsers.DataSource = dt;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadAccountantData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd3 = new SqlCommand("ShowAccountant", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            dt1.Load(cmd3.ExecuteReader());
            dvgUsers.DataSource = dt1;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadInventoryControlManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from InventoryControlManager", con);
            dt.Clear();
            adapter.Fill(dt);
            dvgUsers.DataSource = dt;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadWareHouseManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from WareHouseManager", con);
            dt.Clear();
            adapter.Fill(dt);
            dvgUsers.DataSource = dt;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadStaffData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Staff", con);
            dt.Clear();
            adapter.Fill(dt);
            dvgUsers.DataSource = dt;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dvgUsers.DataSource = null;
        }
    }
}
