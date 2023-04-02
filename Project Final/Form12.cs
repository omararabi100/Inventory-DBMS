using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class Form12 : Form
    {
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public bool Gender;
        public bool isSelected = false;
        public bool isLogin = false;
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtID.Text = "";
            txtEmail.Text = "";
            txtUname.Text = "";
            txtPassword.Text = "";

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            isSelected = true;
            if (RBMale.Checked)
            {
                Gender = true;
                RBFemale.Checked = false;
            }

        }
        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            isSelected = true;
            if (RBFemale.Checked)
            {
                Gender = false;
                RBMale.Checked = false;
            }
        }


        private void positionComb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if(Con.State != ConnectionState.Open)
                Con.Open();

                    SqlCommand cmd = new SqlCommand("addLogin", Con);
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
                        if (isSelected)
                        {
                            cmd1.Parameters.AddWithValue("@GENDER", Gender);
                        }
                        else
                        {
                            cmd1.Parameters.AddWithValue("@GENDER", null);
                        }
                        cmd1.Parameters.AddWithValue("@YOE", txtDate.Value);
                        cmd1.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                     cmd.Parameters.AddWithValue("@LogInType", "Admin");
                        cmd.ExecuteNonQuery();
                     cmd1.ExecuteNonQuery();
                        MessageBox.Show("Admin added successfully");
                }
                else if (positionComb.SelectedItem.ToString() == "Accountant")
                {
                    SqlCommand cmd1 = new SqlCommand("AddAccountant", Con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.AddWithValue("@UserName", txtUname.Text);
                    cmd1.Parameters.AddWithValue("@AID", int.Parse(txtID.Text));
                    cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd1.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    if (isSelected)
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", Gender);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", null);
                    }
                    cmd1.Parameters.AddWithValue("@YOE", txtDate.Value);
                    cmd1.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@LogInType", "Accountant");
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Accountant added successfully");
                }
                else if (positionComb.SelectedItem.ToString() == "Inventory Control Manager")
                {
                    SqlCommand cmd1 = new SqlCommand("AddIcm", Con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.AddWithValue("@UserName", txtUname.Text);
                    cmd1.Parameters.AddWithValue("@ICMID", int.Parse(txtID.Text));
                    cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd1.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    if (isSelected)
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", Gender);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", null);
                    }
                    cmd1.Parameters.AddWithValue("@YOE", txtDate.Value);
                    cmd1.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@LogInType", "InventoryControlManager");
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("InventoryControlManager added successfully");
                }
                else if (positionComb.SelectedItem.ToString() == "Warehourse Manager")
                {
                    SqlCommand cmd1 = new SqlCommand("AddWareHouseManager", Con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.AddWithValue("@UserName", txtUname.Text);
                    cmd1.Parameters.AddWithValue("@WMID", int.Parse(txtID.Text));
                    cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd1.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    if (isSelected)
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", Gender);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@GENDER", null);
                    }
                    cmd1.Parameters.AddWithValue("@YOE", txtDate.Value);
                    cmd1.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@LogInType", "InventoryControlManager");
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("WarehourseManager added successfully");
                }
                if (Con.State == ConnectionState.Open)
                Con.Close();
            }
            catch (Exception msj)
            {
                MessageBox.Show("something went wrong!!!");
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void date_txt_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
