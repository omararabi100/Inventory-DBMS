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
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public admin()
        {
            InitializeComponent();
        }

        public void LoadAdminData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvgUsers.DataSource = null;
            SqlCommand cmd2 = new SqlCommand("ShowAdmin", con);
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
            SqlCommand cmd4 = new SqlCommand("ShowICM", con);
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
            SqlCommand cmd5 = new SqlCommand("ShowWM", con);
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
            SqlCommand cmd6 = new SqlCommand("ShowStaff", con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Load(cmd6.ExecuteReader());
            dvgUsers.DataSource = dt6;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Admin ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = reader["Name"].ToString();
                label4.Text = reader["Email"].ToString();
                label12.Text = reader["Username"].ToString();
            }
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
        }

        private void btnModifyUsers_Click(object sender, EventArgs e)
        {
            ModifyUser form = new ModifyUser();
            form.ShowDialog();
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

    }
}
