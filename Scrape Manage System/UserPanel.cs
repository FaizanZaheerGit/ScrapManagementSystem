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

namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    public partial class UserPanel : Form
    {
        SqlConnection con = new SqlConnection(""); // Add Connection String To SQL Server here
        SqlDataAdapter adap;
        public UserPanel()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Confirms", MessageBoxButtons.YesNo);
            if (dr.ToString() == "Yes")
            {
                userLogin ul = new userLogin();
                this.Hide();
                ul.ShowDialog();
            }
        }
        private void orderBtn_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            this.Hide();
            c.ShowDialog();
        }

        private void deluserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
