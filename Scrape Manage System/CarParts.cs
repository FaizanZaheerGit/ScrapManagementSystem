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
    public partial class CarParts : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        SqlDataReader rdr;
        public CarParts()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }

        private void CarParts_Load(object sender, EventArgs e)
        {
            SqlDataReader rdr1;
            string a = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Items WHERE ItemName LIKE 'Car%' AND ItemName NOT LIKE 'Cardboard'", con);
                rdr1 = cmd.ExecuteReader();
                while (rdr1.Read())
                {
                    a = rdr1.GetValue(0).ToString();
                    a = a.Substring(4);
                    carpartsBox.Items.Add(a);
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

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sum(Quantity), Rate, sum(Price) FROM CustomerOrders WHERE ItemName=@name AND Date=@date", con);
                cmd.Parameters.AddWithValue("@name", "Car_"+carpartsBox.Text);
                cmd.Parameters.AddWithValue("@date", datePicker.Value);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    summaryTxt.AppendText("Total Quantity Sold: " + rdr.GetValue(0) + "\nRate (Per Piece): " + rdr.GetValue(1) + "\nTotal Price Earned: " + rdr.GetValue(2) + "\n");
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

        private void backBtn_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }
    }
}
