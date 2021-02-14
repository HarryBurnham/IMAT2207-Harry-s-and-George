using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstQuantity
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
            string testData = "test";
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
    }
}
