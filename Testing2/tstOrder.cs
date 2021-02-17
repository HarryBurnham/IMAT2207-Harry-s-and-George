using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
           clsOrder AnOrder = new clsOrder();
           int testData = 1;
           AnOrder.OrderId = testData;
           Assert.AreEqual(AnOrder.OrderId,testData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime testData = Convert.ToDateTime("16/05/2015");
            AnOrder.OrderDate = testData;
            Assert.AreEqual(AnOrder.OrderDate, testData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int testData = 1;
            AnOrder.Quantity = testData;
            Assert.AreEqual(AnOrder.Quantity, testData);
        }

        [TestMethod]
        public void CostPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int testData = 1;
            AnOrder.Cost = testData;
            Assert.AreEqual(AnOrder.Cost, testData);
        }

        [TestMethod]
        public void OrderTypePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string testData = "test";
            AnOrder.OrderType = testData;
            Assert.AreEqual(AnOrder.OrderType, testData);
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool testData = true;
            AnOrder.Dispatched = testData;
            Assert.AreEqual(AnOrder.Dispatched, testData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int testData = 1;
            AnOrder.CustomerId = testData;
            Assert.AreEqual(AnOrder.CustomerId, testData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Int32 OrderId = 2;
            found = AnOrder.Find(OrderId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestOrderIdNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if(AnOrder.OrderId!=2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderDateNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("29/10/2000"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 5)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCostNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.Cost != 3.2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderTypeFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.OrderType!="fast")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean OK = true;
            Int32 OrderId = 2;

            found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }
    }
}
