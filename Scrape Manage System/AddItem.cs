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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

       

       

        private void Backbtn_Click_1(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            this.Hide();
            ap.ShowDialog();
        }
    }
}
