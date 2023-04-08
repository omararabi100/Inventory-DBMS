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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        void Fill_Chart()
        {
            try
            {
             
                    con.Open();

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("Select Date,Returns from DailyIncome", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                chart1.DataSource = ds;
             
                 con.Close();

                chart1.Series["Income"].XValueMember = "Date";
                chart1.Series["Series"].YValueMembers = "Records";


            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            Fill_Chart();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
