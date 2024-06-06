using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class testSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplliers);
        }

        [TestMethod]

        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.PhoneNum = "11111111111";
            TestItem.StreetNum = "16";
            TestItem.Street = "Some Street";
            TestItem.PostCode = "LE3 5KW";
            TestItem.SupplierName = "Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.SupplierId = 32;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
           
        }

        [TestMethod]

        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Street = "Some Street";
            TestSupplier.SupplierId = 32;
            TestSupplier.StreetNum = "16";
            TestSupplier.SupplierName = "Test";
            TestSupplier.RegistrationDate = DateTime.Now;
            TestSupplier.PhoneNum = "12345678901";
            TestSupplier.PostCode = "LE3 5KW";
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Street = "Some Street";
            TestItem.SupplierId = 32;
            TestItem.StreetNum = "16";
            TestItem.SupplierName = "Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.PhoneNum = "12345678901";
            TestItem.PostCode = "LE3 5KW";
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Street = "Some Street";
            TestItem.SupplierId = 32;
            TestItem.StreetNum = "16";
            TestItem.SupplierName = "Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.PhoneNum = "12345678901";
            TestItem.PostCode = "LE3 5KW";
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Street = "Some Street";
            TestItem.SupplierId = 32;
            TestItem.StreetNum = "16";
            TestItem.SupplierName = "Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.PhoneNum = "12345678901";
            TestItem.PostCode = "LE3 5KW";
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.Street = "Another Street";
            TestItem.SupplierId = 35;
            TestItem.StreetNum = "20";
            TestItem.SupplierName = "Another Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.PhoneNum = "01234567890";
            TestItem.PostCode = "LE7 5KW";
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Street = "Some Street";
            TestItem.SupplierId = 32;
            TestItem.StreetNum = "16";
            TestItem.SupplierName = "Test";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.PhoneNum = "12345678901";
            TestItem.PostCode = "LE3 5KW";
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
           

        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByPostCode("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]

        public void ReportByPostCodeNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByPostCode("xxx xxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }
    }
}
