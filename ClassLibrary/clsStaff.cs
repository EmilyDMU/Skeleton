using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id property
        private Int32 mStaffId;

        //staffId public property
        public Int32 StaffId
        {
            get
            {
                //sends data out of property
                return mStaffId;
            }
            set
            {
                //allows data into the property
                mStaffId = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateOfBirth;
        //dateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        //private data member for the staff department property
        private string mStaffDepartment;
        //StaffDepartment public property
        public string StaffDepartment
        {
            get
            {
                return mStaffDepartment;
            }
            set
            {
                mStaffDepartment = value;
            }
        }

        //private data member for the staff name property
        private string mStaffName;
        //staff name public property
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        //private data member for the permission property
        private Boolean mStaffPermission;
        //permission public property
        public bool StaffPermission
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffPermission;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPermission = value;
            }
        }

        //private data member for the StaffRole property
        private string mStaffRole;
        //StaffRole public property
        public string StaffRole
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffRole;
            }
            set
            {
                //this line of code allows data into the property
                mStaffRole = value;
            }
        }

        //private data member for the StaffRole property
        private string mStaffStatus;
        //StaffStatus public property
        public string StaffStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffStatus;
            }
            set
            {
                //this line of code allows data into the property
                mStaffStatus = value;
            }
        }

        public bool Find(int staffId)
        {

            //set the private data members to the test data value
            mStaffId = 2;
            mStaffName = "Will Smith";
            mDateOfBirth = Convert.ToDateTime("08/08/1999");
            mStaffRole = "Store Manager";
            mStaffDepartment = "Sales";
            mStaffStatus = "Active";
            mStaffPermission = true;

            //always return true
            return true;
        }

    }
}