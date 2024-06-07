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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute sproc
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
        }

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return private data
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

        public clsStaff ThisStaff
        {
            get
            {
                //return private data
                return mThisStaff;
            }
            set
            {
                
                //set private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds record to the db based on a values of mThisStaff
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parameters
         
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffDepartment", mThisStaff.StaffDepartment);
            DB.AddParameter("@StaffStatus", mThisStaff.StaffStatus);
            DB.AddParameter("@StaffPermission", mThisStaff.StaffPermission);

            //execute query
            return DB.Execute("sproc_tblStaff_Insert");


        }

        public void Update()
        {
            //updates record to the db based on a values of mThisStaff
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffDepartment", mThisStaff.StaffDepartment);
            DB.AddParameter("@StaffStatus", mThisStaff.StaffStatus);
            DB.AddParameter("@StaffPermission", mThisStaff.StaffPermission);

            //execute proc
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes record 
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parameters for sproc
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByDepartment(string StaffDepartment)
        {
            //filters code based on full or partial department
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send the dep param to db
            DB.AddParameter("@StaffDepartment", StaffDepartment);
            //execute the sproc
            DB.Execute("sproc_tblStaff_FilterByDepartment");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on data table in param DB
            //var for index
            Int32 Index = 0;
            // var to store record count
            Int32 RecordCount = 0;
            //get count of records
            RecordCount = DB.Count;
            //clear priv array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank address object
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
    }
}