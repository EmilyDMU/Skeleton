using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass the method
        string StaffName = "Will Smith";
        string DateOfBirth = DateTime.Now.ToShortDateString();
        string StaffRole = "Sales Associate";
        string StaffDepartment = "Retail Operations";
        string StaffStatus = "active";

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class 
            clsStaff AStaff = new clsStaff();
            //test it 
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create instance of class we want to create
            clsStaff AStaff = new clsStaff();
            //create test data to assign to the property
            DateTime TestData = new DateTime(1990, 1, 1);
            //assign data to the property
            AStaff.DateOfBirth = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void StaffDepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales";
            //assign the data to the property
            AStaff.StaffDepartment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDepartment, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Will Smith";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffPermissionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.StaffPermission = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPermission, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Store Manager";
            //assign the data to the property
            AStaff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Annual Leave";
            //assign the data to the property
            AStaff.StaffStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffStatus, TestData);
        }

        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the results of validation
            Boolean Found = false;
            //create some data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffId != 6)
            {
                OK = false;
            }
            //test if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            //create instance of clsStaff
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the date of birth property
            if (AStaff.DateOfBirth != Convert.ToDateTime("08/08/1999"))
            {
                OK = false;
            }
            //test if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff name property
            if (AStaff.StaffName != "Sam Rodgers")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the role property
            if (AStaff.StaffRole != "Team Leader")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the department property
            if (AStaff.StaffDepartment != "Retail Operations")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the status property
            if (AStaff.StaffStatus != "active")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPermissionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the permission property
            if (AStaff.StaffPermission != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            string Error = "";
            //invoke method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should trigger error
                                   //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
                                    //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
                                   //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(49,'a');//this should be ok

                                        //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');//this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');//this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store am error message
            String Error = "";
            //set date of birth to an invalid tyoe 
            String DateOfBirth = "not a date";
            //invoke method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should trigger error
                                   //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "a"; //this should be ok
                                    //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "aa"; //this should be ok
                                     //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(49, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(50, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(25, 'a');//this should be ok
                                                    //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(51, 'a');//this should fail
                                                    //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(500, 'a');//this should fail
                                                     //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = ""; //this should trigger error
                                         //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "a"; //this should be ok
                                          //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "aa"; //this should be ok
                                           //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "";
            StaffDepartment = StaffDepartment.PadRight(49, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "";
            StaffDepartment = StaffDepartment.PadRight(50, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "";
            StaffDepartment = StaffDepartment.PadRight(25, 'a');//this should be ok
                                                                //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "";
            StaffDepartment = StaffDepartment.PadRight(51, 'a');//this should fail
                                                                //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDepartmentExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDepartment = "";
            StaffDepartment = StaffDepartment.PadRight(500, 'a');//this should fail
                                                                 //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = ""; //this should trigger error
                                     //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "a"; //this should be ok
                                      //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "aa"; //this should be ok
                                       //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "";
            StaffStatus = StaffStatus.PadRight(49, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "";
            StaffStatus = StaffStatus.PadRight(50, 'a');//this should be ok

            //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "";
            StaffStatus = StaffStatus.PadRight(25, 'a');//this should be ok
                                                        //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "";
            StaffStatus = StaffStatus.PadRight(51, 'a');//this should fail
                                                        //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffStatus = "";
            StaffStatus = StaffStatus.PadRight(500, 'a');//this should fail
                                                         //invoke the method
            Error = AStaff.Valid(StaffName, DateOfBirth, StaffRole, StaffDepartment, StaffStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
