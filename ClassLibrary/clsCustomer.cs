using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private String mFirstName;
        private String mSurname;
        private String mAddress;
        private String mPhoneNumber;
        private DateTime mDateOfBirth;
        private String mPassword;
        private Boolean mAccount;
        private String mEmailAddress;

        public int CustomerID
        {
            get
            {
                //this line of code sends out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property 
                mCustomerID = value;
            }
        }

        public String FirstName
        {
            get
            {
                //this line of code sends out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property 
                mFirstName = value;
            }
        }

        public String Surname
        {
            get
            {
                //this line of code sends out of the property
                return mSurname;
            }
            set
            {
                //this line of code allows data into the property 
                mSurname = value;
            }
        }

        public String Address
        {
            get
            {
                //this line of code sends out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property 
                mAddress = value;
            }
        }

        public String PhoneNumber
        {
            get
            {
                //this line of code sends out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property 
                mPhoneNumber = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property 
                mDateOfBirth = value;
            }
        }

        public String Password
        {
            get
            {
                //this line of code sends out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property 
                mPassword = value;
            }
        }

        public Boolean Account
        {
            get
            {
                //this line of code sends out of the property
                return mAccount;
            }
            set
            {
                //this line of code allows data into the property 
                mAccount = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                //this line of code sends out of the property
                return mEmailAddress;
            }
            set
            {
                //this line of code allows data into the property 
                mEmailAddress = value;
            }
        }

        //function for findina a customers details based on their id number 
        public bool Find(int CustomerID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customerID to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerID");
            //if one record is found (There should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAccount = Convert.ToBoolean(DB.DataTable.Rows[0]["Account"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                //return that everything worked OK
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        //function for the public validation method 
        public string Valid(string FirstName, string Surname, string Address, string PhoneNumber,string EmailAddress,string DateOfBirth,string Password) {

            //create a string variable to store the error 
            String Error = "";
            //Create a temporary value to store date values
            DateTime DateTemp;

            //if the FirstName is blank 
            if (FirstName.Length == 0)
            {
                //record the error 
                Error = Error + "The FirstName may not be blank : ";
            }

            //if the FirstName is greater than 10 characters
            if (FirstName.Length > 10)
            {
                //record the error 
                Error = Error + "The FirstName must be less than 10 characters : ";
            }

            //if the Surname is blank 
            if (Surname.Length == 0)
            {
                //record the error 
                Error = Error + "The Surname may not be blank : ";
            }

            //if the Surname is greater than 10 characters
            if (Surname.Length > 10)
            {
                //record the error 
                Error = Error + "The surname must be less than 10 characters : ";
            }

            //if the Address is blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }

            //if the Address is greater than 50 characters
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 characters : ";
            }

            //if the PhoneNumber is blank
            if (PhoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }

            //if the phone number is greater than 11 characters
            if (PhoneNumber.Length > 11)
            {
                //record the error
                Error = Error + "The Phone number must be less than 11 characters : ";
            }

            //if the EmailAddress is blank
            if (EmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The EmailAddress may not be blank : ";
            }

            //if the EmailAddress is greater than 40 characters
            if (EmailAddress.Length > 40)
            {
                //record the error
                Error = Error + "The EmailAddress must be less than 40 characters : ";
            }

            try
            {
                //copy the DateOfBirth value to the DataTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp < Convert.ToDateTime("01/01/1900"))
                {
                    //record the Error
                    Error = Error + "The DateOfBirth cannot be that far in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //record the Error
                    Error = Error + "The DateOfBirth cannot be in the future : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date : ";
            }

            //if the Password is blank
            if (Password.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }

            //if the Password is greater than 50 characters
            if (Password.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }

            //return any error messages 
            return Error;
        }
    }
}
