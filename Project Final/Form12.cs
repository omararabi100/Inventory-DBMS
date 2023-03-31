using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class Form12 : Form
    {
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public bool Gender;
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
            Name.Text = "";
            ID.Text = "";
            Email.Text = "";
            Uname.Text = "";
            Password.Text = "";

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Male.Checked)
            {
                Gender = true;
            }
            else
            {
                Gender = false;
            }
        }

        private void positionComb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Admin values('" + int.Parse(ID.Text) + "',' " + Uname.Text + "','" + Name.Text + "','" + int.Parse(Age.Text) + "','" + Gender + "','" + Email.Text + "','"+Date.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully");
                Con.Close();
            }
            catch
            {

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
