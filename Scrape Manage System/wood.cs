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
    public partial class wood : Form
    {
        SqlConnection con = new SqlConnection(""); // Add Connection String To SQL Server here
        SqlDataReader rdr;
        public wood()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sum(Weight), Rate, sum(Price) FROM CustomerOrders WHERE ItemName='Cardboard' AND Date=@date", con);
                cmd.Parameters.AddWithValue("@date", datePicker.Value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    summaryTxt.AppendText("Total Weight Sold: " + rdr.GetValue(0) + "\nRate (Per Kg.): " + rdr.GetValue(1) + "\nTotal Price Earned: " + rdr.GetValue(2) + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
