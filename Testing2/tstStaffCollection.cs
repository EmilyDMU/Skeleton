using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK() 
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add item to list and create item of test data 
            clsStaff TestItem = new clsStaff();
            //set it's properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ron Weasly";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Store Manager";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = true; 
            //add items to test list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            // test if the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        /*[TestMethod]
        public void CountProperty()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to property 
            Int32 SomeCount = 2;
            //assign data to property
            AllStaff.Count = SomeCount;
            //test to see two values are the same 
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisStaffProperty()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to property 
            clsStaff TestStaff = new clsStaff();
            //set properties of test object
            TestStaff.StaffId = 1;
            TestStaff.StaffName = "Ron Weasly";
            TestStaff.DateOfBirth = DateTime.Now;
            TestStaff.StaffRole = "Store Manager";
            TestStaff.StaffDepartment = "Retail Operations";
            TestStaff.StaffStatus = "active";
            TestStaff.StaffPermission = true;
            //assign data to property
            AllStaff.ThisStaff = TestStaff;
            // test if the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]   
        public void ListAndCountOk()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add item to list and create item of test data 
            clsStaff TestItem = new clsStaff();
            //set it's properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ron Weasly";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Store Manager";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = true;
            //add items to test list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            // test if the two values are the same 
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see see two values are the same
            Assert.AreEqual(AllStaff.Count, 2);
        }*/
    }
}
