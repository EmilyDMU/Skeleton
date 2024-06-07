using System;
using System.Data;

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

        public bool Find(int StaffId)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for staff id to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should either be 1 or 0)
            if (DB.Count == 1)
            {
                //copy data from dbto the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mStaffDepartment = Convert.ToString(DB.DataTable.Rows[0]["StaffDepartment"]);
                mStaffStatus = Convert.ToString(DB.DataTable.Rows[0]["StaffStatus"]);
                mStaffPermission = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffPermission"]);
                //return everything that worked okay
                return true;
            }
            //if no record found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string staffName, string dateOfBirth, string staffRole, string staffDepartment, string staffStatus)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if staff name is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error += "The staff name may not be blank : ";
            }
            // if staff name is greater than 50 characters
            if (staffName.Length > 50)
            {
                Error += "The staff name must be less than 50 characters : ";
            }

            try
            {
                //copy dateOfBirth value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp < DateTime.Now.Date)
                {
                    //record error
                    Error += "The date cannot be in the past : ";
                }
                //check to see if date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record error
                    Error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record error
                Error += "The date was not a valid date : ";
            }

            // Validation for staffRole
            // if staff role is blank
            if (staffRole.Length == 0)
            {
                //record the error
                Error += "The staff role may not be blank : ";
            }
            // if staff role is greater than 50 characters
            if (staffRole.Length > 50)
            {
                Error += "The staff role must be less than 50 characters : ";
            }

            // Validation for staffDepartment
            // if staff department is blank
            if (staffDepartment.Length == 0)
            {
                //record the error
                Error += "The staff department may not be blank : ";
            }
            // if staff department is greater than 50 characters
            if (staffDepartment.Length > 50)
            {
                Error += "The staff department must be less than 50 characters : ";
            }

            // Validation for staffStatus
            // if staff status is blank
            if (staffStatus.Length == 0)
            {
                //record the error
                Error += "The staff status may not be blank : ";
            }
            // if staff status is greater than 50 characters
            if (staffStatus.Length > 50)
            {
                Error += "The staff status must be less than 50 characters : ";
            }

            //return error
            return Error;
        }



        /*** STATS grouped by status method ***/
        public DataTable StatisticsGroupedByStatus()
        {
            //create new instance of db
            clsDataConnection DB = new clsDataConnection();

            //execute sproc
            DB.Execute("sproc_tblStaff_Count_GroupByStatus");
            //should be zero or more records
            return DB.DataTable;
        }

        /*** STATS grouped by date of birth method ***/
        public DataTable StatisticsGroupedByDateOfBirth()
        {
            //create new instance of db
            clsDataConnection DB = new clsDataConnection();

            //execute sproc
            DB.Execute("sproc_tblStaff_Count_GroupByDateOfBirth");
            //should be zero or more records
            return DB.DataTable;
        }
    }
}