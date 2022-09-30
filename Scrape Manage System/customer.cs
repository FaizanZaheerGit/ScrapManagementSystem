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
    public partial class customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        SqlDataReader rdr;
        public void Clear()
        {
            itemBox.SelectedIndex = -1;
            carpartsBox.SelectedIndex = -1;
            carpartsBox.Enabled = false;
            carpartsBox.Items.Clear();
            carpartsBox.Text = "";
            rateTxt.Text = "";
            WorQUpDown.Value = 1;
            orderidTxt.Text = "";
            priceLbl.Text = "";
            driverBox.SelectedIndex = -1;
        }
        public customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {
            itemBox.SelectedIndex = 0;
            driverBox.Items.Clear();
            driverBox.Text = "";
            SqlDataReader rdr2;
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT DriverName FROM Drivers WHERE SupplierName='AFH Solutions'", con);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string c = rdr2.GetValue(0).ToString();
                    driverBox.Items.Add(c);
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

        private void itemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemBox.SelectedIndex == 3)
            {
                WorQlbl.Text = "Quantity";
                rateLbl.Text = "Rate (per Piece)";
                carpartsBox.Enabled = true;
                string a = "";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Items WHERE ItemName LIKE 'Car_%' AND ItemName NOT LIKE 'Cardboard'", con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        a = rdr.GetValue(0).ToString();
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
            else
            {
                WorQlbl.Text = "Weight (Kg.)";
                rateLbl.Text = "Rate (per Kg)";
                carpartsBox.Items.Clear();
                carpartsBox.Text = "";
                carpartsBox.Enabled = false;
            }
        }

        private void makeorderBtn_Click(object sender, EventArgs e)
        {
            if (itemBox.SelectedIndex == -1 || rateTxt.Text == "" || WorQUpDown.Value < 1 || driverBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill in all fields!");
            }
            else
            {
                Random rnd = new Random();
                orderidTxt.Text = rnd.Next(1000, 10000).ToString();
                double b = Convert.ToDouble(WorQUpDown.Value) * Convert.ToDouble(rateTxt.Text);
                priceLbl.Text = b.ToString();
                DialogResult dr = MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlDataReader rdr3;
                        SqlCommand cmd3 = new SqlCommand("SELECT SupplierContact FROM Suppliers WHERE SupplierName='AFH Solutions'", con);
                        rdr3 = cmd3.ExecuteReader();
                        while (rdr3.Read())
                        {
                            string d = rdr3.GetValue(0).ToString();
                            contactTxt.Text = d;
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
                    try
                    {
                        con.Open();
                        SqlDataReader rdr4;
                        SqlCommand cmd4 = new SqlCommand("SELECT DriverCarNo,DriverContact FROM Drivers WHERE DriverName=@name", con);
                        cmd4.Parameters.AddWithValue("@name", driverBox.Text);
                        rdr4 = cmd4.ExecuteReader();
                        while (rdr4.Read())
                        {
                            string f = rdr4.GetValue(0).ToString();
                            string g = rdr4.GetValue(1).ToString();
                            carnoTxt.Text = f;
                            dcontactTxt.Text = g;
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
                    try
                    {
                        con.Open();
                        int i = 0;
                        SqlCommand cmd5 = new SqlCommand("INSERT INTO CustomerOrders VALUES (@id,@iname,@weight,@quantity,@rate,@price,@carno,@date,'No','AFH Solutions',@comments)", con);
                        cmd5.Parameters.AddWithValue("@id", orderidTxt.Text);
                        cmd5.Parameters.AddWithValue("@rate", rateTxt.Text);
                        cmd5.Parameters.AddWithValue("@price", priceLbl.Text);
                        cmd5.Parameters.AddWithValue("@date", Convert.ToDateTime(datePicker.Value));
                        cmd5.Parameters.AddWithValue("@carno", carnoTxt.Text);
                        cmd5.Parameters.AddWithValue("@comments", commentTxt.Text);
                        if (itemBox.SelectedIndex != 3)
                        {
                            cmd5.Parameters.AddWithValue("@iname", itemBox.Text);
                            cmd5.Parameters.AddWithValue("@weight", Convert.ToDouble(WorQUpDown.Value));
                            cmd5.Parameters.AddWithValue("@quantity", "");
                        }
                        else
                        {
                            cmd5.Parameters.AddWithValue("@iname", "Car_" + carpartsBox.Text);
                            cmd5.Parameters.AddWithValue("@weight", "");
                            cmd5.Parameters.AddWithValue("@quantity", Convert.ToDouble(WorQUpDown.Value));
                        }
                        i = cmd5.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Order Made Succesfully!");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Order Not Made!");
                            Clear();
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
                else
                {
                    MessageBox.Show("Order Cancelled!");
                    Clear();
                }
            }
        }

        private void updateorderBtn_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(WorQUpDown.Value) * Convert.ToDouble(rateTxt.Text);
            priceLbl.Text = b.ToString();
            DialogResult dr = MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlDataReader rdr3;
                    SqlCommand cmd3 = new SqlCommand("SELECT SupplierContact FROM Suppliers WHERE SupplierName='AFH Solutions'", con);
                    rdr3 = cmd3.ExecuteReader();
                    while (rdr3.Read())
                    {
                        string d = rdr3.GetValue(0).ToString();
                        contactTxt.Text = d;
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
                try
                {
                    con.Open();
                    SqlDataReader rdr4;
                    SqlCommand cmd4 = new SqlCommand("SELECT DriverCarNo,DriverContact FROM Drivers WHERE DriverName=@name", con);
                    cmd4.Parameters.AddWithValue("@name", driverBox.Text);
                    rdr4 = cmd4.ExecuteReader();
                    while (rdr4.Read())
                    {
                        string f = rdr4.GetValue(0).ToString();
                        string g = rdr4.GetValue(1).ToString();
                        carnoTxt.Text = f;
                        dcontactTxt.Text = g;
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
                try
                {
                    con.Open();
                    int i = 0;
                    SqlCommand cmd5 = new SqlCommand("UPDATE CustomerOrders SET ItemName=@iname,Weight=@weight,Quantity=@quantity,Rate=@rate,Price=@price,DriverCarNo=@carno,Date=@date,Comments=@comments WHERE OrderID=@id", con);
                    cmd5.Parameters.AddWithValue("@id", orderidTxt.Text);
                    cmd5.Parameters.AddWithValue("@rate", rateTxt.Text);
                    cmd5.Parameters.AddWithValue("@price", priceLbl.Text);
                    cmd5.Parameters.AddWithValue("@date", Convert.ToDateTime(datePicker.Value));
                    cmd5.Parameters.AddWithValue("@carno", carnoTxt.Text);
                    cmd5.Parameters.AddWithValue("@comments", commentTxt.Text);
                    if (itemBox.SelectedIndex != 3)
                    {
                        cmd5.Parameters.AddWithValue("@iname", itemBox.Text);
                        cmd5.Parameters.AddWithValue("@weight", WorQUpDown.Value);
                        cmd5.Parameters.AddWithValue("@quantity", "");
                    }
                    else
                    {
                        cmd5.Parameters.AddWithValue("@iname", carpartsBox.Text);
                        cmd5.Parameters.AddWithValue("@weight", "");
                        cmd5.Parameters.AddWithValue("@quantity", WorQUpDown.Value);
                    }
                    i = cmd5.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Order Updated Succesfully!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Order Not Updated!");
                        Clear();
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
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd6 = new SqlCommand("DELETE FROM CustomerOrders WHERE OrderID=@id", con);
                cmd6.Parameters.AddWithValue("@id", orderidTxt.Text);
                i = cmd6.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Order Deleted Successfully!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Order Not Deleted!");
                    Clear();
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

        private void checkdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataReader rdr5;
                SqlCommand cmd7 = new SqlCommand("SELECT Delivered FROM CustomerOrders WHERE OrderID=@id", con);
                cmd7.Parameters.AddWithValue("@id", orderidTxt.Text);
                rdr5 = cmd7.ExecuteReader();
                while (rdr5.Read())
                {
                    string h = rdr5.GetValue(0).ToString();
                    if (h == "Yes")
                    {
                        MessageBox.Show("Order Delivered!");
                    }
                    else
                    {
                        MessageBox.Show("Order Not Delivered!");
                    }
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

        private void backkBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            this.Hide();
            up.ShowDialog();
        }
    }
}