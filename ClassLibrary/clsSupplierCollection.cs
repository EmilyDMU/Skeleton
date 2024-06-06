using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }


        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray( DB );
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Street", mThisSupplier.Street);
            DB.AddParameter("@StreetNum", mThisSupplier.StreetNum);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);
            DB.AddParameter("@PhoneNum", mThisSupplier.PhoneNum);
            DB.AddParameter("@RegistrationDate", mThisSupplier.RegistrationDate);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@Street", mThisSupplier.Street);
            DB.AddParameter("@StreetNum", mThisSupplier.StreetNum);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@PostCode", mThisSupplier.PostCode);
            DB.AddParameter("@PhoneNum", mThisSupplier.PhoneNum);
            DB.AddParameter("@RegistrationDate", mThisSupplier.RegistrationDate);

            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByPostCode(string PostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_tblSupplier_FilterByPostCode");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier AnSupplier = new clsSupplier();
                AnSupplier.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnSupplier.StreetNum = Convert.ToString(DB.DataTable.Rows[Index]["StreetNum"]);
                AnSupplier.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.PhoneNum = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNum"]);
                mSupplierList.Add(AnSupplier);
                Index++;
            }
        }

    
    }
}
