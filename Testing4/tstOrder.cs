using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string Note = "ITEM: BLACK/M";
        string OrderStatus = "Pending";
        string OrderDate = DateTime.Now.ToShortDateString();
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
            string TestData = "Something";

            //assign the data to the property
            AnOrder.OrderStatus = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);


        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrder.Active = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);


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

        [TestMethod]
        public void OrderIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.OrderId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);


        }

        [TestMethod]
        public void ShoeIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.ShoeId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShoeId, TestData);


        }

        [TestMethod]
        public void NotePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            string TestData = "Something";

            //assign the data to the property
            AnOrder.Note = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Note, TestData);


        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the Order id 
            if (AnOrder.OrderId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the order date property 
            if (AnOrder.OrderDate != Convert.ToDateTime("07/04/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNoteFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the note property
            if (AnOrder.Note != "ITEM: BLACK/M")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the customer id property
            if (AnOrder.CustomerId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the shoe id property
            if (AnOrder.ShoeId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the staff id property
            if (AnOrder.StaffId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the order status property
            if (AnOrder.OrderStatus != "Pending")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the Active property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 3;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the total Amount property
            if (AnOrder.TotalAmount != 215)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string OrderStatus = "xxxxx"; //this should trigger an error

            //ivoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string OrderStatus = "xxxxxxxx"; //this should be ok 

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderStatusMinPusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string OrderStatus = "xxxxxxx"; //this should be ok 

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "xxxxxxx"; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");



        }

        [TestMethod]

        public void OrderStatusMax()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "xxxxxxxx"; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");



        }

        [TestMethod]

        public void OrderStatusMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "xxxxxxxxx"; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");



        }



        [TestMethod]

        public void OrderStatusExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(15, 'x'); //this should fail

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(4, 'x'); //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void NoteMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string Note = "xxxxxxxxx"; //this should trigger an error

            //ivoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NoteMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string Note = "xxxxxxxxxx"; //this should be ok 

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NoteMinPusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error mesaage
            String Error = "";

            //create some test data to padss to the method 
            string Note = "xxxxxxxxxxx"; //this should be ok 

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NoteMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string Note = "xxxxxxxxxxxxxxx"; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");


        }

        [TestMethod]

        public void NotesMax()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string Note = "xxxxxxxxxxxxxxxx"; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreEqual(Error, "");



        }

        [TestMethod]

        public void NoteMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string Note = ""; //this should fail
            Note = Note.PadRight(19, 'x'); //this should fail

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        /*TestMethod]
       public void NoteMid()
       {
             //clsOrder AnOrder = new clsOrder();

             //string variable to store any error meassage
             //String Error = "";

             //create some test data to pass to the method 
             //string Note = "";
             //Note = Note.PadRight(9, 'x');

             //invoke the method
             Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

             //test to see that the result is correct 
             Assert.AreEqual(Error, "");

         }*/


        [TestMethod]

        public void NoteExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(23, 'x'); //this should fail

            //invoke the method
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            //invoke the method 
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            //invoke the method 
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            //invoke the method 
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            //invoke the method 
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();

            //string variable to store any error meassage
            String Error = "";

            //create some test data to pass to the method 
            DateTime TestDate;

            //set the date to todays date 
            TestDate = DateTime.Now.Date;

            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);

            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();

            //invoke the method 
            Error = AnOrder.Valid(OrderStatus, Note, OrderDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        //[TestMethod]
        //public void StatisticsGroupByOrderStatus()
        //{
        //create an instance of the class we want to create
        //clsOrder AnOrder = new clsOrder();

        //invote the method
        //DataTable dT = AnOrder.StatisticsGroupByOrderStatus();

        //According to the last executed stroed produre, there should be three rows of data.
        //int noOfRecord = 3;

        //test to see that the result is correct 
        //Assert.AreEqual(noOfRecord, dT.Rows.Count);

        //}


        //[TestMethod]
        //public void StatStatisticsGroupedByOrderDate()
        //{
        //create an instance of the class we want to create
        //clsOrder AnOrder = new clsOrder();

        // invote the method
        //DataTable dT = AnOrder.StatStatisticsGroupedByOrderDate();

        //According to the last executed stroed produre, there should be three rows of data.
        ///int noOfRecord = 10;

        //test to see that the result is correct 
        //Assert.AreEqual(noOfRecord, dT.Rows.Count);
        //}
    }
}









        //[TestMethod]
        //public void StatisticsGroupByOrderStatus()
        //{
        //create an instance of the class we want to create
        //clsOrder AnOrder = new clsOrder();

        //invote the method
        //DataTable dT = AnOrder.StatisticsGroupByOrderStatus();

        //According to the last executed stroed produre, there should be three rows of data.
        //int noOfRecord = 3;

        //test to see that the result is correct 
        //Assert.AreEqual(noOfRecord, dT.Rows.Count);

        //}


        //[TestMethod]
        //publicvoid StatStatisticsGroupedByOrderDate()
        //{
        //create an instance of the class we want to create
        //clsOrder AnOrder = new clsOrder();

        // invote the method
        //DataTable dT = AnOrder.StatStatisticsGroupedByOrderDate();

        //According to the last executed stroed produre, there should be three rows of data.
        //int noOfRecord = 10;

        //test to see that the result is correct 
        //Assert.AreEqual(noOfRecord, dT.Rows.Count);
        //}
  






