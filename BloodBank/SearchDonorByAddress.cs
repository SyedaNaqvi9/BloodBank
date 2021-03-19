using DGVPrinterHelper;
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
    
    public partial class SearchDonorByAddress : Form
    {
        function fn = new function();
        public SearchDonorByAddress()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchDonorByAddress_Load(object sender, EventArgs e)
        {
            String query = "select*from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                String query = "select* from newDonor where city like '" + txtAddress.Text + "%' or daddress Like '" +txtAddress.Text + "%' ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                String query = "select*from newDonor";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Blood Bank Report"; //give your report name
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footer"; //this is the footer
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
