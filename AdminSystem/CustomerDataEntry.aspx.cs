using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the create account page when pressed
        Response.Redirect("CreateAccount.aspx");
    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewer.aspx");
    }
}