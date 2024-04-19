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
    public partial class Reels : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }

        }

        void bind()
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Reels Order by id desc", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            sqlConnection.Close();
        }
    }
}