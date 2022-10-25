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
    public partial class SupplierDetails : Form
    {
        SqlConnection con = new SqlConnection(""); // Add Connection String To SQL Server here
        SqlDataAdapter adap;
        public void Display()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                adap = new SqlDataAdapter("SELECT * FROM Suppliers", con);
                adap.Fill(dt);
                supplierGView.DataSource = dt;
                supplierGView.AutoGenerateColumns = true;
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
            supplierGView.DataSource = null;
            supplierGView.Rows.Clear();
            supplierGView.Columns.Clear();
        }
        public SupplierDetails()
        {
            InitializeComponent();
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers VALUES (@name,@contact)", con);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Supplier Successfully Inserted!");
                }
                else
                {
                    MessageBox.Show("Supplier Not Inserted!");
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
                SqlCommand cmd = new SqlCommand("UPDATE Suppliers SET SupplierContact=@contact WHERE SupplierName=@name", con);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Supplier Successfully Updated!");
                }
                else
                {
                    MessageBox.Show("Supplier Not Updated!");
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierName=@name", con);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Supplier Successfully Deleted!");
                }
                else
                {
                    MessageBox.Show("Supplier Not Deleted!");
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

        private void historyBtn_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            int i = 0;
            try
            {
                con.Close();
                adap = new SqlDataAdapter();
                adap.SelectCommand = new SqlCommand("GetOrderHistory", con);
                adap.SelectCommand.Parameters.AddWithValue("name", nameTxt.Text);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                // adap = new SqlDataAdapter("SELECT a.OrderID, s.SupplierName, S.SupplierContact, a.ItemName,a.Weight,a.Quantity,a.Rate,a.Price,a.Date,a.Recieved FROM Suppliers s INNER JOIN AdminOrders a ON a.SupplierName=s.SupplierName WHERE s.SupplierName=@name", con);
                // adap.SelectCommand.Parameters.AddWithValue("@name", nameTxt.Text);
                adap.Fill(dt1);
                supplierGView.DataSource = dt1;
                supplierGView.AutoGenerateColumns = true;
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

        private void back_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }
    }
}