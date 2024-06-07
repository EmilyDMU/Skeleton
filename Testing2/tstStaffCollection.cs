using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create item of test data 
            clsStaff TestItem = new clsStaff();
            // var to store primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ron Weasly";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Store Manager";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = true;
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffId = PrimaryKey;
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see see two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOk() {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create item of test data 
            clsStaff TestItem = new clsStaff();
            // var to store primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ron Weasly";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Store Manager";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = true;
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ronald Wesley";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Sales Associate";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = false;
            //set record based on new test data
            AllStaff.ThisStaff.Find(PrimaryKey);
            //update record
            AllStaff.Update();
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if equal
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create item of test data 
            clsStaff TestItem = new clsStaff();
            // var to store primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Ron Weasly";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.StaffRole = "Store Manager";
            TestItem.StaffDepartment = "Retail Operations";
            TestItem.StaffStatus = "active";
            TestItem.StaffPermission = true;
            //set ThisStaff to test data
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffId = PrimaryKey;
            //find the test record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete record
            AllStaff.Delete();
            //find record again
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if record found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDepartmentMethodOk()
        {
            //new instance of class with unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //instance of filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply blank string to return all records
            FilteredStaff.ReportByDepartment("");
            //test to see if the two vales aare same 
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByDepartmentNoneFound() 
        {
            //new instance of class with unfiltered results
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply dep that doesnt exist
            FilteredStaff.ReportByDepartment("Legal");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByDepartmentTestDataFound()
        {
            //new instance of class with unfiltered results
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply dep that doesnt exist
            FilteredStaff.ReportByDepartment("Legal");
            //check if correct no. of records are found
            if (FilteredStaff.Count == 2) 
            {
                //check to see if 1st record is 28
                if (FilteredStaff.StaffList[0].StaffId != 28) 
                {
                    OK = false;
                }

                //check to see if 2nd rec is 29
                if (FilteredStaff.StaffList[1].StaffId != 29)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }
    }
}
