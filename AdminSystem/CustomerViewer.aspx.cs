using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display attributes of the customers
        Response.Write(ACustomer.FirstName + "<br/>");
        Response.Write(ACustomer.Surname + "<br/>");
        Response.Write(ACustomer.Address + "<br/>");
        Response.Write(ACustomer.PhoneNumber + "<br/>");
        Response.Write(ACustomer.EmailAddress + "<br/>");
        Response.Write(ACustomer.DateOfBirth + "<br/>");
        Response.Write(ACustomer.Password + "<br/>");
    }
}