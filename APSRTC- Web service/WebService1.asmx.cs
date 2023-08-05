using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace APCRTC__Web_service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        SqlConnection conObj = new SqlConnection("Data Source=LAPTOP-IGCVHMJQ\\SQLEXPRESS;Initial Catalog=Virtusa;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        SqlDataAdapter DA = null;
        [WebMethod]
        public DataSet GetPassengerDetails()
        {
            DA = new SqlDataAdapter("Select * from Apcrtc",conObj);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Passengers");
            return DS;
        }
        [WebMethod]
       public void PostPassengerDetails(string n, string origin, string destination)
       {
            conObj.Open();
            cmd = new SqlCommand("Apcrtc_insert",conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", n);
            cmd.Parameters.AddWithValue("@from",origin);
            cmd.Parameters.AddWithValue("@to", destination);

            cmd.ExecuteNonQuery();
            conObj.Close();

       }
        
       
    }
}
