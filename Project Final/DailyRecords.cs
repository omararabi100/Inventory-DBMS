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
    public partial class DailyRecords : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public DailyRecords()
        {
            InitializeComponent();
        }

        private void DailyIncome_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                double TotalExpenses = double.Parse(txtBought.Text) + double.Parse(txtPayDay.Text) + double.Parse(txtMain.Text) + double.Parse(txtTaxes.Text);
                double Revenue = double.Parse(txtReturns.Text) - TotalExpenses;
                if(con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd3 = new SqlCommand("AddDailyRecord", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@Date", dtDate.Value);
                cmd3.Parameters.AddWithValue("@AID", Global.CurrentSignInID);
                cmd3.Parameters.AddWithValue("@Revenue", Revenue);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("AddDailyIncome",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ICODE", int.Parse(txtRecordID.Text));
                cmd.Parameters.AddWithValue("@Date", dtDate.Value);
                cmd.Parameters.AddWithValue("@Returns", double.Parse(txtReturns.Text));
                SqlCommand cmd2 = new SqlCommand("AddDailyExpenses", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@ECODE", int.Parse(txtRecordID.Text));
                cmd2.Parameters.AddWithValue("@Date", dtDate.Value);
                cmd2.Parameters.AddWithValue("@Bought", double.Parse(txtBought.Text));
                cmd2.Parameters.AddWithValue("@PayDay", double.Parse(txtPayDay.Text));
                cmd2.Parameters.AddWithValue("@Maintenance", double.Parse(txtMain.Text));
                cmd2.Parameters.AddWithValue("@Taxes", double.Parse(txtTaxes.Text));
                cmd2.Parameters.AddWithValue("@TotalExpenses", TotalExpenses);


                
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Daily Records Added successfully!!!");

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error!!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            accountant form = new accountant();
            this.Close();
            form.Show();
        }
    }
}
