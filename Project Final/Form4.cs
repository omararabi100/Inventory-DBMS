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
using System.Data.SqlClient;

namespace Project_Final
{
    public partial class warehousem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public warehousem()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;
        }

        private void warehousem_Load(object sender, EventArgs e)
        {
            if(con.State != ConnectionState.Open)
             con.Open();

            SqlCommand cmd = new SqlCommand("Select * from WareHouseManager where UserName = '" + lblUname.Text.Trim() + "'", con);
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
            if(con.State == ConnectionState.Open)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffMembers form = new AddStaffMembers();
            form.ShowDialog();
            this.Hide();


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
