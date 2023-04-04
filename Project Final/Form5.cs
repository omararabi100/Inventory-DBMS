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

namespace Project_Final
{
    public partial class ICmanager : Form
    {
        public ICmanager()
        {
            InitializeComponent();
        }

        private void ICmanager_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from InventoryControlManager ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = reader["Name"].ToString();
                label4.Text = reader["Email"].ToString();
                label5.Text = reader["Username"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
