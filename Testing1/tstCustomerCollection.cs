using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    /// <summary>
    /// Summary description for tstCustomerCollection
    /// </summary>
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.FirstName = "Harry";
            TestItem.Surname = "Potter";
            TestItem.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestItem.PhoneNumber = "07111111111";
            TestItem.EmailAddress = "h.potter@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestItem.Password = "password";
            TestItem.Account = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 2;
            TestCustomer.FirstName = "Harry";
            TestCustomer.Surname = "Potter";
            TestCustomer.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestCustomer.PhoneNumber = "07111111111";
            TestCustomer.EmailAddress = "h.potter@gmail.com";
            TestCustomer.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestCustomer.Password = "password";
            TestCustomer.Account = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //sets its properties
            TestItem.CustomerID = 2;
            TestItem.FirstName = "Harry";
            TestItem.Surname = "Potter";
            TestItem.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestItem.PhoneNumber = "07111111111";
            TestItem.EmailAddress = "h.potter@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestItem.Password = "password";
            TestItem.Account = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CustomerID = 2;
            TestItem.FirstName = "Harry";
            TestItem.Surname = "Potter";
            TestItem.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestItem.PhoneNumber = "07111111111";
            TestItem.EmailAddress = "h.potter@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestItem.Password = "password";
            TestItem.Account = true;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 2;
            //set its properties
            TestItem.FirstName = "Harry";
            TestItem.Surname = "Potter";
            TestItem.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestItem.PhoneNumber = "07111111111";
            TestItem.EmailAddress = "h.potter@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestItem.Password = "password";
            TestItem.Account = true;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.FirstName = "Barry";
            TestItem.Surname = "Barry";
            TestItem.Address = "145 Rainbow Road, Slough, Berkshire, SL1 5ST";
            TestItem.PhoneNumber = "07815476901";
            TestItem.EmailAddress = "B.Barry@hotmail.co.uk";
            TestItem.DateOfBirth = Convert.ToDateTime("08/10/1990");
            TestItem.Password = "Slough";
            TestItem.Account = false;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record 
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.FirstName = "Harry";
            TestItem.Surname = "Potter";
            TestItem.Address = "4 Privet Drive, Surrey, England, PA3 OP1";
            TestItem.PhoneNumber = "07111111111";
            TestItem.EmailAddress = "h.potter@gmail.com";
            TestItem.DateOfBirth = Convert.ToDateTime("31/07/1980");
            TestItem.Password = "password";
            TestItem.Account = true;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record 
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPhoneNumberMethodOk()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPhoneNumber("");
            //test to see if the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNumberNoneFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a phone number that doesn't exist
            FilteredCustomers.ReportByPhoneNumber("88888888888");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNumberTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a phone number that doesn't exist
            FilteredCustomers.ReportByPhoneNumber("99999999999");
            //check the correct number of records are found 
            if (FilteredCustomers.Count == 2)
            {
                //checks if the first record is ID 6 
                if (FilteredCustomers.CustomerList[0].CustomerID != 6)
                {
                    OK = false;
                }

                //checks if the second record is ID 7
                if (FilteredCustomers.CustomerList[1].CustomerID != 7)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
