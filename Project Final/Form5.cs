using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Final
{
    public partial class ICmanager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public ICmanager()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;
        }

        private void ICmanager_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from InventoryControlManager where UserName = '" + lblUname.Text.Trim() + "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Global.CurrentSignInID = int.Parse(dt.Rows[0][1].ToString());
                Global.CurrentName = dt.Rows[0][3].ToString();
                Global.CurrentEmail = dt.Rows[0][7].ToString();
                lblName.Text = dt.Rows[0][3].ToString();
                lblEmail.Text = dt.Rows[0][7].ToString();
            }
            con.Close();
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmdd = new SqlCommand("Select * from Product", con);
                DataTable dtt = new DataTable();
                dtt.Load(cmdd.ExecuteReader());
                dataGridView1.DataSource = dtt;


            }

            catch
            {
                MessageBox.Show("Error occured...");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string imgloaction = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| jpeg file(*.jpeg)|*jpeg| All Files(*.*)|*.* ";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgloaction = dialog.FileName.ToString();
                    pictureBox16.ImageLocation = imgloaction;
                }
            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            Products objform = new Products();
            this.Hide();
            objform.Show();
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products objform = new Products();
            this.Hide();
            objform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICmanager objform5 = new ICmanager();
            this.Hide();
            objform5.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("countproducts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RowCount", SqlDbType.Int).Direction =ParameterDirection.Output;
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                reader.Close();
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OrdersForm objform = new OrdersForm();
            this.Hide();
            objform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrdersForm objform = new OrdersForm();
            this.Hide();
            objform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Request_Products objform = new Request_Products();
            objform.ShowDialog();
            this.Hide();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Suppliers form = new Suppliers();
            this.Close();
            form.Show();
        }
    }
}
