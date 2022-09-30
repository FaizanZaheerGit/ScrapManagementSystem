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
    public partial class ChangePinA : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1M7L2SI\\FAIZANSQL;Initial Catalog=Project;User ID=sa;Password=fizzySQL");
        public ChangePinA()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminLogin al = new adminLogin();
            this.Hide();
            al.ShowDialog();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (npinTxt.ToString() != cpinTxt.ToString())
            {
                MessageBox.Show("New Pin and Confirm Pin Not Matched!");
                usernameTxt.Text = "";
                npinTxt.Text = "";
                cpinTxt.Text = "";
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dr.ToString() == "Yes")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Login SET Pin=@pin WHERE UserName=@username", con);
                        cmd.Parameters.AddWithValue("@pin", npinTxt.Text.ToString());
                        cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                        i = cmd.ExecuteNonQuery();
                        if (i < 0)
                        {
                            MessageBox.Show("Pin Not Changed!");
                            usernameTxt.Text = "";
                            npinTxt.Text = "";
                            cpinTxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Pin Changed Successfully!");
                            usernameTxt.Text = "";
                            npinTxt.Text = "";
                            cpinTxt.Text = "";
                            userLogin ul = new userLogin();
                            this.Hide();
                            ul.ShowDialog();
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
                    MessageBox.Show("Pin Change Cancelled!");
                    usernameTxt.Text = "";
                    npinTxt.Text = "";
                    cpinTxt.Text = "";
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminLogin al = new adminLogin();
            this.Hide();
            al.ShowDialog();
        }
    }
}
