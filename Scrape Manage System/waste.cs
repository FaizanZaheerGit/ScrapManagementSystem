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
    public partial class waste : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        SqlDataReader rdr;
        public waste()
        {
            InitializeComponent();
        }

        private void Waste_Load(object sender, EventArgs e)
        {
            string a = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Items", con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    a = rdr.GetValue(0).ToString();
                    itemBox.Items.Add(a);
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
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            double c = 1.0;
            SqlDataReader rdr1;
            try
            {
                con.Open();
                if(itemBox.SelectedIndex >=0 && itemBox.SelectedIndex < 5)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT i.Quantity,a.Quantity,a.Rate FROM Items i INNER JOIN AdminOrders a ON i.ItemName=a.ItemName WHERE i.ItemName=@name", con);
                    cmd1.Parameters.AddWithValue("@name", itemBox.Text);
                    rdr1 = cmd1.ExecuteReader();
                    while(rdr1.Read())
                    {
                        a = Convert.ToInt32(rdr1.GetValue(0));
                        b = Convert.ToInt32(rdr1.GetValue(1));
                        c = Convert.ToDouble(rdr1.GetValue(2));
                    }
                    summaryTxt.AppendText("Available Quantity: "+a+"\nSold Quantity: "+b+"\nWaste: "+(a-b)+"\nLoss: "+c*b);
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT i.Weight,a.Weight,a.Rate FROM Items i INNER JOIN AdminOrders a ON i.ItemName=a.ItemName WHERE i.ItemName=@name", con);
                    cmd1.Parameters.AddWithValue("@name", itemBox.Text);
                    rdr1 = cmd1.ExecuteReader();
                    while (rdr1.Read())
                    {
                        a = Convert.ToInt32(rdr1.GetValue(0));
                        b = Convert.ToInt32(rdr1.GetValue(1));
                        c = Convert.ToDouble(rdr1.GetValue(2));
                    }
                    summaryTxt.AppendText("Available Weight: " + a + "\nSold Weight: " + b + "\nWaste: " + (a - b) + "\nLoss: " + c * b);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }
    }
}