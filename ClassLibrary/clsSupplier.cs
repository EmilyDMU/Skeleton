using System;
using System.Data;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierId;
        public Int32 SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }
        private DateTime mRegistrationDate;
        public DateTime RegistrationDate
        {
            get
            {
                return mRegistrationDate;
            }
            set
            {
                mRegistrationDate = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        private string mPhoneNum;
        public string PhoneNum
        {
            get
            {
                return mPhoneNum;
            }
            set
            {
                mPhoneNum = value;
            }
        }
        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        private string mStreetNum;
        public string StreetNum
        {
            get
            {
                return mStreetNum;
            }
            set
            {
                mStreetNum = value;
            }
        }
        private string mStreet;
        public string Street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }

        public bool Find(int supplierId)
        {
            mSupplierId = 32;
            mRegistrationDate = Convert.ToDateTime("30/05/2024");
            mSupplierName = "Test SupplierName";
            mPhoneNum = "11111111111";
            mPostCode = "XXX XXX";
            mStreetNum = "16";
            mStreet = "Test Street";
            return true;
        }

        public string Valid(string registrationDate, string street, string streetNum, string postCode, string supplierName, string phoneNum)
        {
            String Error = "";
            DateTime DateTemp;
            if (streetNum.Length == 0)
            {
                Error = Error + "The street number may not be blank";
            }

            if (streetNum.Length > 6)
            {
                Error = Error + "The street number be less than 6 characters";
            }


            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(registrationDate);
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The data was not a valid date";
            }

            if (postCode.Length == 0)
            {
                Error = Error + "The post code may not be blank";
            }
            if (postCode.Length > 9)
            {
                Error = Error + "The post code must be less than 9 characters";
            }
            if (street.Length == 0)
            {
                Error = Error + "the street may not be blank";
            }
            if (street.Length > 50)
            {
                Error = Error + "the street must be be less than 50 characters";
            }
            if (supplierName.Length == 0)
            {
                Error = Error + "the supplier name may not be blank";
            }   
            if (supplierName.Length > 50)
            {
                Error = Error + "the supplier name must be less than 50 characters";
            }
            if (phoneNum.Length != 11)
            {
                Error = Error + "the phone number must be 11 characters";
            }

            return Error;
        }

        public DataTable StatisticsGroupedByStreet()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSuppliers_Count_GroupByStreet");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedRegistratedDate()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_Count_GroupDateRegistrated");
            return DB.DataTable;
        }
    }
}
