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
    public partial class insert_imagecs : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public insert_imagecs()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pbimage.Image = ConvertByteArrayToImage((byte[])row["Image"]);
            }
        }
        public void Insert(string fileName, byte[] image)
        {
            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString()))
            {
                try
                {
                    if (Con.State != ConnectionState.Open)
                        Con.Open();
                    SqlCommand cmd = new SqlCommand("AddIMGS", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IID", int.Parse(txtIID.Text));
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@IMG", image);
                    cmd.Parameters.AddWithValue("@PID", int.Parse(txtID.Text));
                    cmd.ExecuteNonQuery();
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
                catch
                {
                    MessageBox.Show("error!!!");
                }

            }
        }

        public void LoadData()
        {
            using (SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString()))
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();
                using (DataTable dt = new DataTable("IMGS"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from IMGS", Con);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (System.IO.MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    
    private void insert_imagecs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbimage.Image = Image.FromFile(ofd.FileName);
                    txtName.Text = ofd.FileName;
                    Insert(txtName.Text, ConvertImageToBytes(pbimage.Image));
                    LoadData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            this.Close();
            form.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            addProduct newForm = new addProduct();
            newForm.Show();
            this.Hide();
        }
    }

}
