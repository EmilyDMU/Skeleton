using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AStaff .DateAdded = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
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

    }
}
