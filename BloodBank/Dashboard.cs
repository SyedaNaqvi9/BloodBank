using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fa = new Form1();
            fa.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor adn = new AddNewDonor();
            adn.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();

        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByAddress sdbd = new SearchDonorByAddress();
            sdbd.Show();

        }

        private void bloodGropuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBG sdgb = new SearchDonorByBG();
            sdgb.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease();
            si.Show();

        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd = new StockDecrease();
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();

        }
    }
}
