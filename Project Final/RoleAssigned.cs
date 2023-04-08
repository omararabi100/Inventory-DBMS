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
    public partial class RoleAssigned : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        int TempSID;
        public RoleAssigned(String Name, int SID)
        {
            InitializeComponent();
            lblChange.Text = "Change "+ Name +"'s";
            TempSID = SID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbRoll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoleAssigned_Load(object sender, EventArgs e)
        {

        }
    }
}
