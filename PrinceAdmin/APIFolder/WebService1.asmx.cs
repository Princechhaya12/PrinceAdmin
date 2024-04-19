using PrinceAdmin.Panel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Services.Description;

namespace PrinceAdmin.APIFolder
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string strcon = ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString;
        DataClasses1DataContext dc = new DataClasses1DataContext(ConfigurationManager.ConnectionStrings["PrinceAdminConnectionString"].ConnectionString);
        JavaScriptSerializer js = new JavaScriptSerializer();

        [WebMethod]
        public void Loginproc(string token, string Phone)
        {
            if(token.Equals("PRINCE"))
            {
                SqlConnection sqlConnection= new SqlConnection(strcon);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Loginproc", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Phone", Phone);
                int count= (Int32)(sqlCommand.ExecuteScalar());
                if (count > 0)
                {
                    Context.Response.Write("{\"message\":" + js.Serialize("Successfully Login") + "}");

                }
                else
                {
                    Context.Response.Write("{\"message\":" + js.Serialize("Incorrect No.") + "}");
                }
                sqlConnection.Close();
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect TOKEN.") + "}");
            }
        }

        [WebMethod]
        public void UserRegistration(string token, string Firstname, string Lastname, string Emailid, string Phone, string City)
        {
            if (token.Equals("PRINCE"))
            {
                dc.UserRegistration(Firstname, Lastname, Emailid, Phone, City).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Successfully Registered") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]
        public void InsertNmessage(string token, string Messagetitle,string Message)
        {
            if (token.Equals("PRINCE"))
            {
                dc.InsertNmessage(Messagetitle, Message).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("New message Inserted") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]
        public void InsertCoins(string token, string Rupees, string coins)
        {
            if (token.Equals("PRINCE"))
            {
                dc.InsertCoins(Rupees, coins).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Coins Management Updated") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]
        public void GetRegisterById(string token,int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.GetRegisterById(id).ToList();
                Context.Response.Write(js.Serialize(list));
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");
            }
        }

        [WebMethod]

        public void EditRegister(string token, int Id,string Firstname, string Lastname, string Emailid, string Phone, string City)
        {
            if (token.Equals("PRINCE"))
            {
                dc.EditRegister( Id,Firstname, Lastname, Emailid, Phone, City).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Sucessfully updated") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");
            }
        }

        [WebMethod]
        public void InsertReels(string token, string Uprofile, string Video, string Tags, string Hastage, string Description, string Creater)
        {
            if (token.Equals("PRINCE"))
            {
                dc.InsertReels(Uprofile, Video, Tags, Hastage, Description, Creater).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("New Reel uploaded") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]

        public void EditReels(string token,int Id, string Uprofile, string Video, string Tags, string Hastage, string Description, string Creater)
        {
            if (token.Equals("PRINCE"))
            {
                dc.EditReels(Id, Uprofile, Video, Tags, Hastage, Description, Creater).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Sucessfully updated reels") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");
            }
        }

        [WebMethod]

        public void UpdateCoins(string token, int Id, string Rupees, string Coins)
        {
            if (token.Equals("PRINCE"))
            {
                dc.UpdateCoins(Id, Rupees, Coins).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Sucessfully updated Coins") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");
            }
        }

        [WebMethod]
        public void DeleteReels(string token, int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.DeleteReels(id).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Reel Deleted") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Invalid Token!") + "}");
            }
        }

        [WebMethod]
        public void Deleteregistration(string token, int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.Deleteregistration(id).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("User Deleted succesfully") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Invalid Token!") + "}");
            }
        }

        [WebMethod]
        public void DeleteMessage(string token, int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.DeleteMessage(id).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Message Deleted succesfully") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Invalid Token!") + "}");
            }
        }

        [WebMethod]
        public void DeleteCoins(string token, int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.DeleteCoins(id).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Deleted coin successfully") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Invalid Token!") + "}");
            }
        }

        [WebMethod]
        public void InsertBankDetails(string token, string Holdername, string AccountNo, string Branch, string IFSC, string City, string BankName, string DOB)
        {
            if (token.Equals("PRINCE"))
            {
                dc.InsertBankDetails(Holdername, AccountNo, Branch, IFSC, City, BankName, DOB).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Bank Details Inserted") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]
        public void GetBankDetailsById(string token, int id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.GetBankDetailsById(id).ToList();
                Context.Response.Write(js.Serialize(list));
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");
            }
        }

        [WebMethod]
        public void UpdateBankDetails(string token, int Id, string Holdername, string AccountNo, string Branch, string IFSC, string City, string BankName, string DOB)
        {
            if (token.Equals("PRINCE"))
            {
                dc.UpdateBankDetails(Id,Holdername, AccountNo, Branch, IFSC, City, BankName, DOB).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Bank Details Updated") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Incorrect token") + "}");

            }
        }

        [WebMethod]
        public void DeleteBankDetails(string token, int Id)
        {
            if (token.Equals("PRINCE"))
            {
                var list = dc.DeleteBankDetails(Id).ToString();
                Context.Response.Write("{\"message\":" + js.Serialize("Deleted Bank details successfully") + "}");
            }
            else
            {
                Context.Response.Write("{\"message\":" + js.Serialize("Invalid Token!") + "}");
            }
        }
    }
}
