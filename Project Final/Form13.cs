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
    public partial class addProduct : Form
    {
        SqlConnection Con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public addProduct()
        {
            InitializeComponent();
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
                    cmd.Parameters.AddWithValue("@IID", txtIID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@IMG", image);
                    cmd.Parameters.AddWithValue("@PID", txtID.Text);
                    cmd.ExecuteNonQuery();
                    if (Con.State == ConnectionState.Open)
                        Con.Close();
                }
                catch(Exception msj)
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
                using(DataTable dt = new DataTable("IMGS"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from IMGS", Con);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                } 
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(System.IO.MemoryStream ms = new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbimage_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter="Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg",
                Multiselect = false
            })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pbimage.Image = Image.FromFile(ofd.FileName);
                    txtName.Text=ofd.FileName;
                    Insert(txtName.Text, ConvertImageToBytes(pbimage.Image));
                    LoadData();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                    Con.Open();

                SqlCommand cmd = new SqlCommand("AddProduct", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", int.Parse(txtID.Text));
                cmd.Parameters.AddWithValue("@ICMID", int.Parse(txtICMID.Text));
                cmd.Parameters.AddWithValue("@Size", int.Parse(txtSize.Text));
                cmd.Parameters.AddWithValue("@Price", int.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@COLOR", txtColor.Text);
                cmd.Parameters.AddWithValue("@Quality", txtQuality.Text);
                cmd.Parameters.AddWithValue("@IMG", null);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");

                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (dt!= null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pbimage.Image = ConvertByteArrayToImage((byte[])row["Image"]);
            }
        }
    }
}
