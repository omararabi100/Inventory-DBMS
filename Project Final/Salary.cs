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
    public partial class Salary : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Salary()
        {
            InitializeComponent();
        }

        private void dvgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
                if (con.State != ConnectionState.Open)
                    con.Open();
                if (PositionComb.SelectedItem.ToString() == "Administrator")
                {
                    SqlCommand cmd = new SqlCommand("SalaryAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();     
                            cmd.Parameters.AddWithValue("@ADID", int.Parse(dvr.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Salary", int.Parse(dvr.Cells[2].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadAdminData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd = new SqlCommand("SalaryAccountant", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@AID", int.Parse(dvr.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Salary", int.Parse(dvr.Cells[2].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadAccountantData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                {
                    SqlCommand cmd = new SqlCommand("SalaryWareHouseManager", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@WMID", int.Parse(dvr.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Salary", int.Parse(dvr.Cells[2].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadWareHouseManagerData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd = new SqlCommand("SalaryICM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ICMID", int.Parse(dvr.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Salary", int.Parse(dvr.Cells[2].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadInventoryControlManagerData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                {
                    SqlCommand cmd = new SqlCommand("SalaryStaff", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@SID", int.Parse(dvr.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Salary", int.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadStaffData();
                }

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
            }
        }
        public void LoadAdminData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd2 = new SqlCommand("ShowEditSalaryAdmin", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Load(cmd2.ExecuteReader());
            dvgUsers.DataSource = dt2;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public void LoadAccountantData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd3 = new SqlCommand("ShowEditSalaryAccountant", con);
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
            SqlCommand cmd4 = new SqlCommand("ShowEditSalaryICM", con);
            DataTable dt4 = new DataTable();
            dt4.Clear();
            dt4.Load(cmd4.ExecuteReader());
            dvgUsers.DataSource = dt4;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadWareHouseManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd5 = new SqlCommand("ShowEditSalaryWareHouseManager", con);
            DataTable dt5 = new DataTable();
            dt5.Clear();
            dt5.Load(cmd5.ExecuteReader());
            dvgUsers.DataSource = dt5;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadStaffData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd6 = new SqlCommand("ShowEditSalaryStaff", con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Load(cmd6.ExecuteReader());
            dvgUsers.DataSource = dt6;
            if (con.State == ConnectionState.Open)
                con.Close();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
                if (con.State != ConnectionState.Open)
                    con.Open();
                if (PositionComb.SelectedItem.ToString() == "Administrator")
                {
                    SqlCommand cmd = new SqlCommand("Select ADID,Name,SalaryinDollar from Admin where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd = new SqlCommand("Select AID,Name,SalaryinDollar from Accountant where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select WMID,Name,SalaryinDollar from WareHouseManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select ICMID,Name,SalaryinDollar from InventoryControlManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,Role,SalaryinDollar from Staff where Name like '%" + txtSearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dvgUsers.DataSource = dt;
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            accountant form = new accountant();
            this.Close();
            form.Show();

        }
    }
}
