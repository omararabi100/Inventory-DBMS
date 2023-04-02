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
    public partial class warehousem : Form
    {
        public warehousem()
        {
            InitializeComponent();
        }

        private void warehousem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from WareHouseManager  ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = reader["Name"].ToString();
                label6.Text = reader["Email"].ToString();
                label8.Text = reader["Username"].ToString();
            }
            con.Close();
        }
    }
}
