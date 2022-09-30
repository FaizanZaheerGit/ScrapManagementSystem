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
    public partial class cardboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        SqlDataReader rdr;
        public cardboard()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Cardboard_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void genBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sum(Weight), Rate, sum(Price) FROM CustomerOrders WHERE ItemName='Cardboard' AND Date=@date", con);
                cmd.Parameters.AddWithValue("@date", datePicker.Value);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
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

        private void Backbtn_Click_1(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }
    }
}
