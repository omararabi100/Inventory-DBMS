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
using System.Xml.Linq;
using System.IO;
using System.Reflection.Emit;

namespace Project_Final
{
    public partial class accountant : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public accountant()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;
            PositionComb.SelectedIndex = PositionComb.Items.IndexOf("Administrator");

        }
        public void LoadAdminData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd2 = new SqlCommand("ShowSalaryAdmin", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Load(cmd2.ExecuteReader());
            dvSalary.DataSource = dt2;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadAccountantData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd3 = new SqlCommand("ShowSalaryAccountant", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            dt1.Load(cmd3.ExecuteReader());
            dvSalary.DataSource = dt1;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadInventoryControlManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd4 = new SqlCommand("ShowSalaryICM", con);
            DataTable dt4 = new DataTable();
            dt4.Clear();
            dt4.Load(cmd4.ExecuteReader());
            dvSalary.DataSource = dt4;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadWareHouseManagerData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd5 = new SqlCommand("ShowSalaryWareHouseManager", con);
            DataTable dt5 = new DataTable();
            dt5.Clear();
            dt5.Load(cmd5.ExecuteReader());
            dvSalary.DataSource = dt5;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadStaffData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd6 = new SqlCommand("ShowSalaryStaff", con);
            DataTable dt6 = new DataTable();
            dt6.Clear();
            dt6.Load(cmd6.ExecuteReader());
            dvSalary.DataSource = dt6;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadDailyIncomeData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd7 = new SqlCommand("ShowDailyIncome", con);
            DataTable dt7 = new DataTable();
            dt7.Clear();
            dt7.Load(cmd7.ExecuteReader());
            dvIncome.DataSource = dt7;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadDailyExpensesData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd8 = new SqlCommand("ShowDailyExpenses", con);
            DataTable dt8 = new DataTable();
            dt8.Clear();
            dt8.Load(cmd8.ExecuteReader());
            dvExpense.DataSource = dt8;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void LoadDailyRecordsData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            dvSalary.DataSource = null;
            SqlCommand cmd9 = new SqlCommand("ShowDailyRecords", con);
            DataTable dt9 = new DataTable();
            dt9.Clear();
            dt9.Load(cmd9.ExecuteReader());
            dvRecord.DataSource = dt9;
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            LoadDailyRecordsData();
            LoadDailyExpensesData();
            LoadDailyIncomeData();
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

        private void label4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string imglocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| jpeg file(*.jpeg)|*jpeg| All Files(*.*)|*.* ";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imglocation = dialog.FileName.ToString();
                    pictureBox16.ImageLocation = imglocation;
                }
                byte[] images = null;
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Accountant set Photo = @image where UserName ='" + lblUname.Text + "'", con);
                cmd.Parameters.Add(new SqlParameter("@image", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }

        private void accountant_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Accountant where UserName = '" + lblUname.Text.Trim() + "'", con);
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
            con.Close();


        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary form = new Salary();
            form.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDI_Click(object sender, EventArgs e)
        {
            DailyRecords dailyRecords = new DailyRecords();
            dailyRecords.ShowDialog();
            this.Hide();
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
                if (con.State != ConnectionState.Open)
                    con.Open();
                if (PositionComb.SelectedItem.ToString() == "Administrator")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,SalaryinDollar from Admin where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvSalary.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,SalaryinDollar from Accountant where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvSalary.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Warehouse Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,SalaryinDollar from WareHouseManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvSalary.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,SalaryinDollar from InventoryControlManager where Name like '%" + txtSearch.Text + "%'", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    dt.Clear();
                    da.Fill(dt);
                    dvSalary.DataSource = dt;
                }
                else if (PositionComb.SelectedItem.ToString() == "Staff Member")
                {
                    SqlCommand cmd = new SqlCommand("Select SID,Name,SalaryinDollar from Staff where Name like '%" + txtSearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dvSalary.DataSource = dt;
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show(msj.ToString());
            }
        }

        private void dvSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvSalary_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }       
    }
}
