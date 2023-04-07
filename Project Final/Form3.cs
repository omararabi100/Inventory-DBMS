using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class admin : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public admin()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;
        }

        public void LoadAdminData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvAdmin.DataSource = null;
            SqlCommand cmd2 = new SqlCommand("ShowAdmin", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Load(cmd2.ExecuteReader());
            dvAdmin.DataSource = dt2;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadAccountantData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvAccountant.DataSource = null;
            SqlCommand cmd3 = new SqlCommand("ShowAccountant", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            dt1.Load(cmd3.ExecuteReader());
            dvAccountant.DataSource = dt1;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadInventoryControlManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvICM.DataSource = null;
            SqlCommand cmd4 = new SqlCommand("ShowICM", con);
            DataTable dt4 = new DataTable();
            dt4.Clear();
            dt4.Load(cmd4.ExecuteReader());
            dvICM.DataSource = dt4;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadWareHouseManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvWareHouseManager.DataSource = null;
            SqlCommand cmd5 = new SqlCommand("ShowWM", con);
            DataTable dt5 = new DataTable();
            dt5.Clear();
            dt5.Load(cmd5.ExecuteReader());
            dvWareHouseManager.DataSource = dt5;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadStaffData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvStaff.DataSource = null;
            SqlCommand cmd6 = new SqlCommand("ShowStaff", con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Load(cmd6.ExecuteReader());
            dvStaff.DataSource = dt6;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Admin where UserName = '" + lblUname.Text.Trim() + "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Global.CurrentSignInID = int.Parse(dt.Rows[0][1].ToString());
                Global.CurrentName = dt.Rows[0][3].ToString();
                Global.CurrentEmail = dt.Rows[0][7].ToString();
                lblName.Text = dt.Rows[0][3].ToString();
                lblEmail.Text = dt.Rows[0][7].ToString();
            }
            LoadStaffData();
            LoadWareHouseManagerData();
            LoadInventoryControlManagerData();
            LoadAccountantData();
            LoadAdminData();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin frm = new admin();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btn_addUsers_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();           
            form.ShowDialog();
            this.Hide();
        }

        private void btnModifyUsers_Click(object sender, EventArgs e)
        {
            ModifyUser form = new ModifyUser();
            form.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffMembers form = new AddStaffMembers();
            form.ShowDialog();
            this.Hide();
        }

        private void dvAdmin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                

                    SqlCommand cmd = new SqlCommand("Select * from Admin where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvAdmin.DataSource = dt;
                
                    
                    SqlCommand cmd1 = new SqlCommand("Select * from Accountant where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da1 = new SqlDataAdapter();
                    DataTable dt1 = new DataTable();
                    da1.SelectCommand = cmd1;
                    dt1.Clear();
                    da1.Fill(dt1);
                    dvAccountant.DataSource = dt1;
                

                    SqlCommand cmd2 = new SqlCommand("Select * from WareHouseManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da2 = new SqlDataAdapter();
                    DataTable dt2 = new DataTable();
                    da2.SelectCommand = cmd2;
                    dt2.Clear();
                    da2.Fill(dt2);
                    dvWareHouseManager.DataSource = dt2;
                

                    SqlCommand cmd3 = new SqlCommand("Select * from InventoryControlManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da3 = new SqlDataAdapter();
                    DataTable dt3 = new DataTable();
                    da3.SelectCommand = cmd3;
                    dt3.Clear();
                    da3.Fill(dt3);
                    dvICM.DataSource = dt3;


                    SqlCommand cmd4 = new SqlCommand("Select * from Staff where Name like '%" + txtSearch.Text + "%'", con);
                    DataTable dt4 = new DataTable();
                    dt4.Load(cmd4.ExecuteReader());
                    dvStaff.DataSource = dt4;
                

            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void lblUname_Click(object sender, EventArgs e)
        {

        }
    }
    
}
