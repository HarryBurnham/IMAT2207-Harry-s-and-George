using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //dispay the current data for the record
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record 
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtFirstname.Text = CustomerBook.ThisCustomer.FirstName;
        txtSurname.Text = CustomerBook.ThisCustomer.Surname;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
        txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress;
        txtPassword.Text = CustomerBook.ThisCustomer.Password;
        chkAccount.Checked = CustomerBook.ThisCustomer.Account;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        found = ACustomer.Find(CustomerID);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtFirstname.Text = ACustomer.FirstName.ToString();
            txtSurname.Text = ACustomer.Surname.ToString();
            txtAddress.Text = ACustomer.Address.ToString();
            txtPhoneNumber.Text = ACustomer.PhoneNumber.ToString();
            txtEmailAddress.Text = ACustomer.EmailAddress.ToString();
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtPassword.Text = ACustomer.Password.ToString();
            
        }
}

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        String FirstName = txtFirstname.Text;
        String Surname = txtSurname.Text;
        String Address = txtAddress.Text;
        String PhoneNumber = txtPhoneNumber.Text;
        String EmailAddress = txtEmailAddress.Text;
        String DateOfBirth = txtDateOfBirth.Text;
        String Password = txtPassword.Text;
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
        if (Error == "")
        {
            //capture the customers attributes
            ACustomer.CustomerID = CustomerID;
            ACustomer.FirstName = txtFirstname.Text;
            ACustomer.Surname = txtSurname.Text;
            ACustomer.Address = txtAddress.Text;
            ACustomer.PhoneNumber = txtPhoneNumber.Text;
            ACustomer.EmailAddress = txtEmailAddress.Text;
            ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            ACustomer.Password = txtPassword.Text;
            //capture account
            ACustomer.Account = chkAccount.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerID = -1 then add the data
            if (CustomerID == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the thisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}