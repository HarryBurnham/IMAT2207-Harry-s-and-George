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
        //good test data
        //create some test data to pass to the method
        String FirstName = "Harry";
        String Surname = "Burnham";
        String Address = " 2 Random Road, Leicester, LE3 0JX";
        String PhoneNumber = "11111111111";
        String EmailAddress = "h.burnham@random.com";
        String DateOfBirth = DateTime.Now.Date.ToString();
        String Password = "password";

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
            if (ACustomer.Address != "2 Random Road, Leicester, England, LE1 5AN")
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //tests to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //VALIDATION TESTS FOR FIRST NAME
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; 
            FirstName = FirstName.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //VALIDATION TESTS FOR SURNAME 
        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "";
            Surname = Surname.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //VALIDATION TESTS FOR ADDRESS
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(51, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(25, 'a'); //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //VALIDATION TESTS FOR PHONE NUMBER
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "aaaaaa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        //VALIDATION TESTS FOR EMAIL ADDRESS
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(39, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(40, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(41, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(20, 'a'); //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //VALIDATION TESTS FOR DATE OF BIRTH
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my minimum value
            testData = Convert.ToDateTime("01/01/1900");
            //change the date to whatever the date is less  100 years 
            testData = testData.AddYears(-100);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my minimum value
            testData = Convert.ToDateTime("01/01/1900");
            //change the date to whatever the date is less than 1 year
            testData = testData.AddYears(-1);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my minimum value
            testData = Convert.ToDateTime("01/01/1900");
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my minimum value
            testData = Convert.ToDateTime("01/01/1900");
            //change the date to whatever the date is less than 1 year
            testData = testData.AddYears(1);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my maximum value
            testData = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 year
            testData = testData.AddYears(-1);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my maximum value
            testData = DateTime.Now.Date;
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my maximum value
            testData = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 year
            testData = testData.AddYears(1);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to a rough middle date 
            testData = Convert.ToDateTime("06/06/1970");
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime testData;
            //set the date to my maximum value
            testData = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 year
            testData = testData.AddYears(100);
            //convert the date variable to a string variable
            String DateOfBirth = testData.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            String DateOfBirth = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, EmailAddress, DateOfBirth, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //VALIDATION TESTS FOR PASSWORD
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(39, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(40, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(41, 'a'); //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(20, 'a'); //this should be okay
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Address, PhoneNumber, Password, DateOfBirth, Password);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


    }
}
