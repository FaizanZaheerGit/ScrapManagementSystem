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
    public partial class adminLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        SqlDataAdapter adap;
        public adminLogin()
        {
            InitializeComponent();
        }

        private void forgetpass_Click(object sender, EventArgs e)
        {
            ChangePinU cp = new ChangePinU();
            this.Hide();
            cp.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {
            int a;
            bool b = Int32.TryParse(pinTxt.ToString(), out a);
            bool c = false;
            if (b == true)
            {
                MessageBox.Show("Incorrect Input Format at Pin!");
                usernameTxt.Text = "";
                pinTxt.Text = "";
            }
            else
            {
                try
                {
                    con.Open();
                    DataSet ds = new DataSet();
                    adap = new SqlDataAdapter("SELECT * FROM Login", con);
                    adap.Fill(ds, "Login");
                    if (ds.Tables[0].Rows.Count <= 0)
                    {
                        MessageBox.Show("No Data Found!");
                    }
                    else
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (ds.Tables[0].Rows[i]["UserName"].ToString() == usernameTxt.Text && ds.Tables[0].Rows[i]["Pin"].ToString() == pinTxt.Text && ds.Tables[0].Rows[i]["UserType"].ToString() == "Admin")
                            {
                                MessageBox.Show(usernameTxt.Text + " Login Successful");
                                c = true;
                                break;
                            }
                        }
                        if (c == true)
                        {
                            AdminPanel ap = new AdminPanel();
                            this.Hide();
                            ap.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Pin Number!");
                            usernameTxt.Text = "";
                            pinTxt.Text = "";
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
        }
        private void pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            userselection1 us = new userselection1();
            this.Hide();
            us.ShowDialog();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
