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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Confirms", MessageBoxButtons.YesNo);
            if (dr.ToString() == "Yes")
            {
                adminLogin al = new adminLogin();
                this.Hide();
                al.ShowDialog();
            }
        }

        private void scrape_Click(object sender, EventArgs e)
        {
            scrape s = new scrape();
            this.Hide();
            s.ShowDialog();
        }

        private void cardboard_Click(object sender, EventArgs e)
        {
            cardboard c = new cardboard();
            this.Hide();
            c.ShowDialog();
        }

        private void wood_Click(object sender, EventArgs e)
        {
            wood w = new wood();
            this.Hide();
            w.ShowDialog();
        }

        private void plastic_Click(object sender, EventArgs e)
        {
            plastic p = new plastic();
            this.Hide();
            p.ShowDialog();
        }

        private void car_Click(object sender, EventArgs e)
        {
            CarParts cp = new CarParts();
            this.Hide();
            cp.ShowDialog();
        }

        private void waste_Click(object sender, EventArgs e)
        {
            waste wa = new waste();
            this.Hide();
            wa.ShowDialog();
        }

        private void driverBtn_Click(object sender, EventArgs e)
        {
            DriverDetails dd = new DriverDetails();
            this.Hide();
            dd.ShowDialog();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            SupplierDetails sd = new SupplierDetails();
            this.Hide();
            sd.ShowDialog();
        }

        private void additemBtn_Click(object sender, EventArgs e)
        {
            AddItem ai = new AddItem();
            this.Hide();
            ai.ShowDialog();
        }

        private void addcarpartBtn_Click(object sender, EventArgs e)
        {
            AddCarPart ac = new AddCarPart();
            this.Hide();
            ac.ShowDialog();
        }
    }
}
