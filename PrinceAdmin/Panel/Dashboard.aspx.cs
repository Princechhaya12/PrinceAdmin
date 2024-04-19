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
    public partial class Dashboard : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cards("select count(*) from Register", Label1);
                //Cards("select count(*) from Competition", Label2);
                //Cards("select count(*) from Post", Label3);
            }
        }

        void Cards(string query, System.Web.UI.WebControls.Label label)
        {
            SqlConnection sqlConnection = new SqlConnection(strcon);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int k = (Int32)sqlCommand.ExecuteScalar();
            label.Text = "" + k;
            sqlConnection.Close();
        }
    }
}