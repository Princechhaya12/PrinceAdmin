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
    public partial class Coins : System.Web.UI.Page
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
            SqlCommand sqlCommand = new SqlCommand("select * from Coins", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            sqlConnection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(strcon);
            sqlConnection1.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Insert into Coins values('" + TextBox1.Text + "','" + TextBox2.Text + "')", sqlConnection1);
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();

            Bind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM Coins where id='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Bind();
        }
    }
}