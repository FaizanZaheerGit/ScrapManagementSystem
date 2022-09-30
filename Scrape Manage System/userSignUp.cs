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
    public partial class userSignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        public userSignUp()
        {
            InitializeComponent();
        }

        private void userSignUp_Load(object sender, EventArgs e)
        {

        }

        private void pinTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            int a;
            bool b = Int32.TryParse(pinTxt.Text, out a);
            if (b == false)
            {
                MessageBox.Show("Incorrect Format at Pin!");
                usernameTxt.Text = "";
                pinTxt.Text = "";
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr.ToString() == "Yes")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Login VALUES (@username, @pin, 'User')", con);
                        cmd.Parameters.AddWithValue("@pin", pinTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                        i = cmd.ExecuteNonQuery();
                        if (i < 0)
                        {
                            MessageBox.Show("User Not Created!");
                            usernameTxt.Text = "";
                            pinTxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("User Successfully Created!!");
                            userselection1 us = new userselection1();
                            this.Hide();
                            us.ShowDialog();
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
                    MessageBox.Show("Registration Cancelled!");
                    usernameTxt.Text = "";
                    pinTxt.Text = "";
                }
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            userselection1 us = new userselection1();
            this.Hide();
            us.ShowDialog();
        }
    }
}
