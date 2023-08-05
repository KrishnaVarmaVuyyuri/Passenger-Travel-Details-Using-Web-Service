using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APCRTC__Web_service.ServiceReference2;

namespace APCRTC__Web_service
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebService1SoapClient obj = new WebService1SoapClient(); // using proxy class obj
            gv.DataSource = obj.GetPassengerDetails();
            
            gv.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string b = TextBox2.Text;       
            string c = TextBox3.Text;   
            // Call the web service method to insert data into the database
            WebService1 service = new WebService1();
            service.PostPassengerDetails(a,b,c);
            ResultLabel.Text = "Data inserted successfully!";


        }
    }
}