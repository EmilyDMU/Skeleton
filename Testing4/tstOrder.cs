﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }



        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

        //create some test data to assign to the property
        Boolean TestData = true;

        //assign the data to the property
        AnOrder.OrderStatus = TestData;

         //test to see that the two values are the same
         Assert.AreEqual(AnOrder.OrderStatus, TestData);
            
            
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            float TestData = 1.5f;

            //assign the data to the property
            AnOrder.TotalAmount = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);


        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnOrder.OrderDate = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);


        }

        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.StaffId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);


        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.CustomerId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);


        }










    }
}

        
     



