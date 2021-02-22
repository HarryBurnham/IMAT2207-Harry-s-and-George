using System;
using System.Text;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    /// <summary>
    /// Summary description for tstCustomer
    /// </summary>
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see if that exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void AccountPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean testData = true;
            //assign the data to the property
            ACustomer.Account = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Account, testData);
        }

        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            int testData = 0;
            //assign the data to the property
            ACustomer.CustomerID = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, testData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.FirstName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.FirstName, testData);
        }

        [TestMethod]
        public void SurnamePropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.Surname = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Surname, testData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.Address = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Address, testData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.PhoneNumber = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, testData);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.EmailAddress = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, testData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            DateTime testData = Convert.ToDateTime("01/01/2000");
            //assign the data to the property
            ACustomer.DateOfBirth = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, testData);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            String testData = "n";
            //assign the data to the property
            ACustomer.Password = testData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Password, testData);
        }

        [TestMethod]
        public void FindAccountOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int account = 2;
            //invoke the method
            Found = ACustomer.Find(account);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void FindCustomerIDOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void FindFirstNameOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 2 ;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void FindSurnameOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindAddressOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindPhoneNumberOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindEmailAddressOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindDateOfBirthOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindPasswordOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAccountFound() {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.Account != true) {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.CustomerID != 3)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.FirstName != "Phil")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.Surname != "Barry")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.Address != "2 Random Road,Leicester,England,LE1 5AN")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.PhoneNumber != "07888888888")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.EmailAddress != "p.barry@hotmail.com")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.DateOfBirth != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            int testData = 3;
            //invoke the method
            Found = ACustomer.Find(testData);
            //Check the account 
            if (ACustomer.Password != "phil")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
