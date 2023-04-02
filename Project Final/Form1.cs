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
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Final
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        private Rectangle buttonoriginalrectangle;
        private Rectangle originalFormsize;
        private readonly SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
            login.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            checkBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            txtpass.UseSystemPasswordChar = true;


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "password";
                txtpass.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUname.Text == "Username")
            {
                txtUname.Text = "";
                txtUname.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                txtUname.Text = "Username";
                txtUname.ForeColor = Color.Silver;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar=true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUname.Clear();
            txtpass.Clear();
            txtUname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
    
            SqlCommand cmd =new SqlCommand ("Select * from Login where UserName = '" + txtUname.Text.Trim() + "' and Password = '" + txtpass.Text.Trim() + "'", con);
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dbt = new DataTable();
                adapter.Fill(dbt);
                if (dbt.Rows.Count > 0)
                {
               
                    if (dbt.Rows[0][0].ToString() == "AWES312")
                    {
                        accountant objform2 = new accountant();
                        this.Hide();
                        objform2.Show();

                    }

                    else if (dbt.Rows[0][0].ToString()== "ADAB529")
                    {
                        admin objform3 = new admin();
                        this.Hide();
                        objform3.Show();
                    }

                    else if (dbt.Rows[0][0].ToString()== "WHMNEH723")
                    {
                        warehousem objform4 = new warehousem(); 
                        this.Hide();
                        objform4.Show();
                    }

                    else if (dbt.Rows[0][0].ToString()== "ICMOA1231")
                    {
                        ICmanager objform5 = new ICmanager();
                        this.Hide();
                        objform5.Show();
                    }

                    else
                    {

                    }

                }
                else
                {
                    MessageBox.Show("Invald login. Try again!");
                    txtpass.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error occured...");
            }
            con.Close();
        }


        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show ("Do you want to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                
            }
            else
            {
                this.Show();
            }
        }
    }
}

