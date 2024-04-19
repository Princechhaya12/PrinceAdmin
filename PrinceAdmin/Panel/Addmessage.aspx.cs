using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrinceAdmin.Panel
{
    public partial class Addmessage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(strcon);
            sqlConnection1.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Insert into Nmessage values('" + TextBox1.Text + "','" + TextBox2.Text + "')", sqlConnection1);
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}