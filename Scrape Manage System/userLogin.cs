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
    public partial class userLogin : Form
    {
        SqlConnection con = new SqlConnection(""); // Add Connection String To SQL Server here
        SqlDataAdapter adap;
        public userLogin()
        {
            InitializeComponent();
        }

        private void Forgetpass_Click(object sender, EventArgs e)
        {
            ChangePinU cp = new ChangePinU();
            this.Hide();
            cp.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            userselection1 us = new userselection1();
            this.Hide();
            us.ShowDialog();
        }

        private void usernameTxt_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void usernameTxt_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTxt.Text = "";
        }

        private void pinTxt_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void userLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
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
                    if(ds.Tables[0].Rows.Count <= 0)
                    {
                        MessageBox.Show("No Data Found!");
                    }
                    else
                    {
                        for(int i=0; i<ds.Tables[0].Rows.Count; i++)
                        {
                            if(ds.Tables[0].Rows[i]["UserName"].ToString() == usernameTxt.Text && ds.Tables[0].Rows[i]["Pin"].ToString() == pinTxt.Text && ds.Tables[0].Rows[i]["UserType"].ToString() == "User")
                            {
                                MessageBox.Show(usernameTxt.Text+" Login Successful");
                                c = true;
                                break;
                            }
                        }
                        if(c==true)
                        {
                            UserPanel up = new UserPanel();
                            this.Hide();
                            up.ShowDialog();
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

        private void deluserBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(usernameTxt.Text=="")
            {
                MessageBox.Show("No Username Entered");
                usernameTxt.Text = "";
                pinTxt.Text = "";
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Login WHERE UserName=@username AND UserType='User'", con);
                    cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                    i = cmd.ExecuteNonQuery();
                    if(i < 0)
                    {
                        MessageBox.Show("User Not Deleted!");
                        usernameTxt.Text = "";
                        pinTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("User Deleted Successfully!");
                        usernameTxt.Text = "";
                        pinTxt.Text = "";
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
    }
}
