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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
