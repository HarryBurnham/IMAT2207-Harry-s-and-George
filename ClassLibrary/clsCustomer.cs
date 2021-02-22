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
    }
}
