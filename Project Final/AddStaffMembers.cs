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
            if (Global.CurrentLogInType == "WareHouseManager")
            {
                txtWMID.Visible = false;
                lblWMID.Visible = false;
                txtDS.Visible = true;
                lblDS.Visible = true;
            }
            else
            {
                txtWMID.Visible = true;
                lblWMID.Visible = true;
                txtDS.Visible = false;
                lblDS.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtDS.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSID.Text = "";
            txtUserName.Text = "";
            txtEmail.Text = "";
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
                if (Global.CurrentLogInType == "Admin")
                {
                    cmd2.Parameters.AddWithValue("@ADID", Global.CurrentSignInID);
                    cmd2.Parameters.AddWithValue("@WMID", txtWMID.Text);
                }
                else if(Global.CurrentLogInType == "WareHouseManager")
                {
                    cmd2.Parameters.AddWithValue("@ADID", null);
                    cmd2.Parameters.AddWithValue("@WMID", Global.CurrentSignInID);
                }
                cmd2.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd2.Parameters.AddWithValue("@Name", txtName.Text);
                cmd2.Parameters.AddWithValue("@Phone", Int64.Parse(txtPhone.Text));
                cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd2.Parameters.AddWithValue("@DailySchedule", txtDS.Text);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Staff Added successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!!!");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Global.CurrentLogInType == "Admin")
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
            else
            {
                warehousem form = new warehousem();
                this.Close();
                //form.LoadStaffData();
                form.Show();

            }
        }

        private void txtWMID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
