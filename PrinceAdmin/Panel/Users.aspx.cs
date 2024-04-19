using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrinceAdmin.Panel
{
    public partial class Users : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }

        }
        void Bind()
        {

            SqlConnection sqlConnection = new SqlConnection(strcon);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Register", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            sqlConnection.Close();
        }
    }
}