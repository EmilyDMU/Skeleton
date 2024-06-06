using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        string RegistrationDate = DateTime.Now.ToShortDateString();
        string Street = "Some Street";
        string PostCode = "LE1 5KW";
        string StreetNum = "19";
        string SupplierName = "Some SupplierName";
        string PhoneNum = "12345678901";



        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]

        public void RegistrationDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.RegistrationDate = TestData;
            Assert.AreEqual(AnSupplier.RegistrationDate, TestData);
        }

        [TestMethod]

        public void SupplierIdOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierId = TestData;
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]

        public void SupplierNameOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "test";
            AnSupplier.SupplierName = TestData;
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }


        [TestMethod]

        public void PhoneNumOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "test";
            AnSupplier.PhoneNum = TestData;
            Assert.AreEqual(AnSupplier.PhoneNum, TestData);
        }

        [TestMethod]

        public void PostCodeOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "test";
            AnSupplier.PostCode = TestData;
            Assert.AreEqual(AnSupplier.PostCode, TestData);
        }

        [TestMethod]

        public void StreetNumOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "test";
            AnSupplier.StreetNum = TestData;
            Assert.AreEqual(AnSupplier.StreetNum, TestData);
        }

        [TestMethod]

        public void StreetOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "test";
            AnSupplier.Street = TestData;
            Assert.AreEqual(AnSupplier.Street, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestSupplierIdFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierId != 32)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestRegistrationDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.RegistrationDate != Convert.ToDateTime("30/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSupplierNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierName != "Test SupplierName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPhoneNumFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.PhoneNum != "11111111111")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPostCodeFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.PostCode != "XXX XXX")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStreetNumFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.StreetNum != "16")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestStreetFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 32;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.Street != "Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "s";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "ss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "sssss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "ssssss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "sss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String StreetNum = "sssssss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StreetNumExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string StreetNum = "";
            StreetNum = StreetNum.PadRight(500, 'a');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void RegristrationDateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string RegistrationDate = TestDate.ToString();
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void RegristrationDateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string RegistrationDate = TestDate.ToString();
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void RegristrationDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string RegistrationDate = TestDate.ToString();
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void RegristrationDateMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string RegistrationDate = TestDate.ToString();
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void RegristrationDateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string RegistrationDate = TestDate.ToString();
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string RegistrationDate = "this is not a date";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "p";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "pp";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "pppppppp";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "ppppppppp";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "pppppppppp";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PostCode = "pppp";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StreetMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "s";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "ss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(49, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(50, 'a');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StreetMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StreetMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Street = "";
            Street = Street.PadRight(25, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "s";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "ss";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void SupplierNameMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 's');
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNum = "11111111111";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNum = "1111111111";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string PhoneNum = "111111111111";
            Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByStreet()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DataTable dT = AnSupplier.StatisticsGroupedByStreet();
            int noOfRecord = 5;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByRegistratedDate()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DataTable dT = AnSupplier.StatisticsGroupedRegistratedDate();
            int noOfRecord = 5;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
