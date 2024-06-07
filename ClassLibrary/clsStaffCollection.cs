using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //constructor for the class
        public clsStaffCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            // var to store record count
            Int32 RecordCount = 0;
            // object for db connect
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                // create blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields for th current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.StaffDepartment = Convert.ToString(DB.DataTable.Rows[Index]["StaffDepartment"]);
                AStaff.StaffStatus = Convert.ToString(DB.DataTable.Rows[Index]["StaffStatus"]);
                AStaff.StaffPermission = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffPermission"]);
                //add record to private data member 
                mStaffList.Add(AStaff);
                //point at next record
                Index++;
            }
           

        }

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //public property for staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //set private data
                return mStaffList;
            }
            set
            {
                //set private data 
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //sort later
            }
        }

        public clsStaff ThisStaff { get; set; }
    }
}