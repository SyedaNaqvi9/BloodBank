using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    class function
    {
        protected SqlConnection getConncetion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1IASIRK\\SQLEXPRESS; database = bloodbank;integrated security =True";
            return con;


        }
        public DataSet getData(string query)
        {
            SqlConnection con = getConncetion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public void setData(String query)
        {
            SqlConnection con = getConncetion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Proceeded Successful.","Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
