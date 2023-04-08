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
    public partial class Add_Supplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("addSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SPID", int.Parse(SPID_txt.Text));
                cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", Int64.Parse(numb_txt.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier has been added successfully");

                if(con.State != ConnectionState.Closed)
                    con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            Suppliers form = new Suppliers();
            this.Close();

            form.LoadData();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SPID_txt.Text = "";
            Name_txt.Text = "";
            Address_txt.Text = "";
            numb_txt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers form = new Suppliers();
            this.Close();

            form.LoadData();
            form.Show();

        }
    }
}
