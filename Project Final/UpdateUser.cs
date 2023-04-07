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
    public partial class ModifyUser : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public ModifyUser()
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
            SqlCommand cmd2 = new SqlCommand("ShowEditAdmin", con);
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
            SqlCommand cmd3 = new SqlCommand("ShowEditAccountant", con);
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
            SqlCommand cmd4 = new SqlCommand("ShowEditICM", con);
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
            SqlCommand cmd5 = new SqlCommand("ShowEditWareHouseManager", con);
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
            SqlCommand cmd6 = new SqlCommand("ShowEditStaff", con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Load(cmd6.ExecuteReader());
            dvgUsers.DataSource = dt6;
            if (con.State == ConnectionState.Open)
                con.Close();
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
                    SqlCommand cmd = new SqlCommand("ModifyAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ActivityStatus", dvr.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@ADID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Name", dvr.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Age", int.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Gender", dvr.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@YOE", dvr.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@Email", dvr.Cells[6].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadAdminData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd = new SqlCommand("ModifyAccountant", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ActivityStatus", dvr.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@AID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Name", dvr.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Age", int.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Gender", dvr.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@YOE", dvr.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@Email", dvr.Cells[6].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadAccountantData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                {
                    SqlCommand cmd = new SqlCommand("ModifyWareHouseManager", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ActivityStatus", dvr.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@WMID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Name", dvr.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Age", int.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Gender", dvr.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@YOE", dvr.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@Email", dvr.Cells[6].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadWareHouseManagerData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd = new SqlCommand("ModifyICM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ActivityStatus", dvr.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@ICMID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Name", dvr.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Age", int.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Gender", dvr.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@YOE", dvr.Cells[5].Value);
                            cmd.Parameters.AddWithValue("@Email", dvr.Cells[6].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadInventoryControlManagerData();
                }
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                {
                    SqlCommand cmd = new SqlCommand("ModifyStaff", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow dvr in dvgUsers.Rows)
                    {
                        if (dvr.Cells[0].Value != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ActivityStatus", dvr.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@SID", int.Parse(dvr.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Name", dvr.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Phone", Int64.Parse(dvr.Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Email", dvr.Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@DailySchedule", dvr.Cells[5].Value.ToString());
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

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            if (Global.CurrentLogInType == "WareHouseManager")
            {
                PositionComb.SelectedIndex = PositionComb.Items.IndexOf("Staff Member");
                lblSP.Visible = false;
                PositionComb.Visible = false;
            }
            else
            {
                lblSP.Visible = true;
                PositionComb.Visible = true;
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
                    SqlCommand cmd = new SqlCommand("Select ActivityStatus,ADID,Name,Age,Gender,YOE,Email from Admin where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd = new SqlCommand("Select ActivityStatus,AID,Name,Age,Gender,YOE,Email from Accountant where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select ActivityStatus,WMID,Name,Age,Gender,YOE,Email from WareHouseManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select ActivityStatus,ICMID,Name,Age,Gender,YOE,Email from InventoryControlManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvgUsers.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                {
                    SqlCommand cmd = new SqlCommand("Select ActivityStatus,SID,Name,Phone,Email,DailySchedule from Staff where Name like '%" + txtSearch.Text + "%'", con);
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

        private void dvgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            admin form = new admin();
            this.Close();
            form.LoadStaffData();
            form.LoadWareHouseManagerData();
            form.LoadInventoryControlManagerData();
            form.LoadAccountantData();
            form.LoadAdminData();
            form.Show();
        }
    }
}
