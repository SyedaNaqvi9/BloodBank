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
   
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            string query = "select* from newDonor where did = " + id + " ";
            DataSet ds = fn.getData(query);
            
            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();


            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text == "")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtEmail.Clear();
                txtGender.ResetText();
                txtBloodGroup.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String query = "update NewDonor set dname ='"+txtName.Text+ "' ,fname ='" + txtFather.Text + "', mname ='" + txtMother.Text + "', dob ='" + txtDOB.Text + "', mobile ='" + txtMobile.Text + "', gender ='" + txtGender.Text + "', email ='" + txtEmail.Text + "', bloodgroup ='" + txtBloodGroup.Text + "' ,city ='" + txtCity.Text + "',daddress ='" + txtAddress.Text + "' where did ="+txtDonorID.Text+"";
            fn.setData(query);
            UpdateDonorDetails_Load(this, null);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();

        }
    }
}
