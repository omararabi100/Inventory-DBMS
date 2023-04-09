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
using System.IO;

namespace Project_Final
{
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Staff()
        {
            InitializeComponent();
            lblUname.Text = Global.CurrentUserName;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Staff where UserName = '" + lblUname.Text.Trim() + "'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Global.CurrentSignInID = int.Parse(dt.Rows[0][1].ToString());
                    Global.CurrentName = dt.Rows[0][5].ToString();
                    lblName.Text = dt.Rows[0][5].ToString();
                    lblUname.Text = dt.Rows[0][4].ToString();
                    lblEmail.Text = dt.Rows[0][7].ToString();
                }

                SqlCommand cmd2 = new SqlCommand("Select * from Customer", con);
                SqlDataAdapter apt = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                apt.Fill(dt2);

                Customerdvg.DataSource = dt2;

                SqlCommand cmd3 = new SqlCommand("Select * from Ordered", con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                adpt.Fill(dt3);

                Orderdvg.DataSource = dt3;

            }
            catch
            {
                MessageBox.Show("Error");
            }
            con.Close();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            this.Hide();
            form.Show();
        
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();

            customers.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string imglocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| jpeg file(*.jpeg)|*jpeg| All Files(*.*)|*.* ";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imglocation = dialog.FileName.ToString();
                    pictureBox16.ImageLocation = imglocation;
                }
                byte[] images = null;
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Accountant set Photo = @image where UserName ='" + lblUname.Text + "'", con);
                cmd.Parameters.Add(new SqlParameter("@image", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Customers form = new Customers();
            this.Close();
            form.Show();
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            this.Close();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Ordered where OID like '%" + txtSearchBar.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                Orderdvg.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void txtSeachBar2_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer where Name like '%" + txtSearchBar.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                Customerdvg.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void Orderdvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customerdvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
