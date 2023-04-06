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
    public partial class AddStaffMembers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public AddStaffMembers()
        {
            InitializeComponent();
        }

        private void AddStaffMembers_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtADID.Text = "";
            txtDS.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSID.Text = "";
            txtUserName.Text = "";
            txtWMID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (Con.State != ConnectionState.Open)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("addLogin", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassWord.Text);
                cmd.Parameters.AddWithValue("@LogInType", "Staff");
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("addStaff", Con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@SID", int.Parse(txtSID.Text));
                cmd2.Parameters.AddWithValue("@ADID", int.Parse(txtADID.Text));
                cmd2.Parameters.AddWithValue("@WMID", int.Parse(txtWMID.Text));
                cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd2.Parameters.AddWithValue("@Name", txtName.Text);
                cmd2.Parameters.AddWithValue("@Phone", Int64.Parse(txtPhone.Text));
                cmd2.Parameters.AddWithValue("@DailySchedule", txtDS.Text);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Staff Added successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!!!");
            }


        }
    }
}
