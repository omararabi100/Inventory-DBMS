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
    public partial class AddStaff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlCommand cmd = new SqlCommand("addLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", txtUname.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);


            if (positionComb.SelectedItem.ToString() == "Administrator")
            {
                SqlCommand cmd1 = new SqlCommand("AddAdmin", Con);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.AddWithValue("@UserName", txtUname.Text);
                cmd1.Parameters.AddWithValue("@ADID", int.Parse(txtID.Text));
                cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                cmd1.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            }
    }
}
