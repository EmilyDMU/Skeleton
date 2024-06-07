using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

        }

        [TestMethod]
        public void OrderlistOK()
        {
            // Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create some test data to assign to the property
            // In this case, the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();

            // Add an item to the list
            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Set its properties
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 2;
            TestItem.ShoeId = 3;
            TestItem.StaffId = 4;
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now;
            TestItem.Note = "ITEM:COLOUR/SIZE";
            TestItem.TotalAmount = 1.5f;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllOrders.OrderList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property
            Int32 SomeCount = 0;

            //assign the data to the property
            AllOrders.Count = SomeCount;

            //test to see that two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();

            //set the properties of the test object
            TestOrder.Active = true;


//assign the data to the property
AllOrders.ThisOrder = TestOrder;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }


        [TestMethod]
        public void listAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();

            //Add an Item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();

            //set its properties
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 2;
            TestItem.ShoeId = 3;
            TestItem.StaffId = 4;
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now;
            TestItem.Note = "ITEM:COLOUR/SIZE";
            TestItem.TotalAmount = 1.5f;

            //add the line to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllOrders.OrderList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }
    }
}
