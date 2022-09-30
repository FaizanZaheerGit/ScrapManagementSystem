using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrapemanagesystem__inventory_vp_c_sharp_
{
    public partial class userselection1 : Form
    {
        public userselection1()
        {
            InitializeComponent();
        }

        private void user_Click(object sender, EventArgs e)
        {
            userLogin ul = new userLogin();
            this.Hide();
            ul.ShowDialog();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminLogin al = new adminLogin();
            this.Hide();
            al.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            userSignUp us = new userSignUp();
            this.Hide();
            us.ShowDialog();
        }
    }
}
