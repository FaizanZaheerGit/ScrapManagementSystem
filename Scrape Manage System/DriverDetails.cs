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
    public partial class DriverDetails : Form
    {
        SqlConnection con = new SqlConnection(""); // Add Connection String To SQL Server here
        SqlDataAdapter adap;
        public void Display()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                adap = new SqlDataAdapter("SELECT * FROM Drivers", con);
                adap.Fill(dt);
                driverGView.DataSource = dt;
                driverGView.AutoGenerateColumns = true;
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
        public void clearGrid()
        {
            driverGView.DataSource = null;
            driverGView.Rows.Clear();
            driverGView.Columns.Clear();
        }
        public DriverDetails()
        {
            InitializeComponent();
        }

        

        private void driver_details_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Drivers VALUES (@carno,@name,@contact,@supplier,@capacity)", con);
                cmd.Parameters.AddWithValue("@carno", carnoTxt.Text);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                cmd.Parameters.AddWithValue("@supplier", supplierTxt.Text);
                cmd.Parameters.AddWithValue("@capacity",capacityUpDown.Value);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Driver Successfully Inserted!");
                }
                else
                {
                    MessageBox.Show("Driver Not Inserted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clearGrid();
                Display();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Drivers SET DriverName=@name,DriverContact=@contact,SupplierName=@supplier,Capacity=@capacity WHERE DriverCarNo=@carno", con);
                cmd.Parameters.AddWithValue("@carno", carnoTxt.Text);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                cmd.Parameters.AddWithValue("@supplier", supplierTxt.Text);
                cmd.Parameters.AddWithValue("@capacity", capacityUpDown.Value);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Driver Successfully Updated!");
                }
                else
                {
                    MessageBox.Show("Driver Not Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clearGrid();
                Display();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Drivers WHERE DriverCarNo=@carno", con);
                cmd.Parameters.AddWithValue("@carno", carnoTxt.Text);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Driver Successfully Deleted!");
                }
                else
                {
                    MessageBox.Show("Driver Not Deleted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clearGrid();
                Display();
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
