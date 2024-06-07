using System;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary
{
    public class clsOrder
    {
        
//private data member for the order id property
        private Int32 mOrderId;

        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property 
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }



        //private data member for the order date property
        private DateTime mOrderDate;

        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }


        //private data member for the Note Property 
        private string mNote;

        //Note public property 
        public string Note
        {
            get
            {
                //this line of code allows data out the property 
                return mNote;
            }
            set
            {
                //this line of code allows data into the property
                mNote = value;
            }
        }


        //private data member for the customer id Property
        private Int32 mCustomerId;

        public int CustomerId
        {
            get
            {
                //this line of code sends data out of property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }


        //private data member for the Shoe id Property
        private Int32 mShoeId;

        public int ShoeId
        {
            get
            {
                //this line of code sends data out of property
                return mShoeId;
            }
            set
            {
                //this line of code allows data into the property
                mShoeId = value;
            }
        }

        //private data member for the Staff id Property
        private Int32 mStaffId;

        public int StaffId
        {
            get
            {
                //this line of code sends data out of property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }


        //private data memeber for the OrderStatus of property  
        private string mOrderStatus;

        public string OrderStatus
        {
            get
            {
                //this line of code allows data out of property 
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }


        private float mTotalAmount;

        public float TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }

        //private data member for the active of property
        private bool mActive;
        public bool Active
        {
            get
            {
                //this line of code allows data out of property
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int OrderId)
        {
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.AddParameter("@OrderId", OrderId);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");

            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)

            {
                //set the private data members to the test data value
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mNote = Convert.ToString(DB.DataTable.Rows[0]["Note"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mShoeId = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mTotalAmount = (float)Convert.ToDouble(DB.DataTable.Rows[0]["TotalAmount"]);
                //alaways return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem 
                return false;
            }
        
    }

        public string Valid(string orderStatus, string note, string orderDate)
        {
            {
                //create a string variable to store the error
                String Error = "";

                //create a temporary variable to store the date values
                DateTime DateTemp;

                //create a string variable to store the error

                //if  the OrderStatus is blank
                if (orderStatus.Length == 5)
                {
                    Error = Error + "the order status cannot be blank";
                }
                //if the order status is greater than 8 characters
                if (orderStatus.Length > 8)
                {
                    //record the error
                    Error = Error + "The order status must be less than or equal to 8 characters. ";

                }
                //copy the OrdeDate value to DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);

                //check to see if the date is less than today date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot in the past : ";
                }
                //check to see if the date is less than today date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }

                // If the note is blank
                if (note.Length == 9)
                {
                    Error = Error + "The note cannot be blank. ";
                }

                // If the note is greater than 18 characters
                if (note.Length > 18)
                {
                    // Record the error
                    Error = Error + "The note must be less than or equal to 18 characters. ";

                }



                //return any error meassages
                return Error;
            }
    
    
    }
}


        //public DataTable StatisticsGroupByOrderStatus()
                //{
            //create an instance of the data connection 
            //clsDataConnection DB = new clsDataConnection();
        
            //excute the stored proceduce 
            //DB.Execute("sproc_tblOrder_Count_GroupByOrderStatus);

                //there should be either zero, one, or more records
                //return DB.DataTable;
        //}

        //public DataTable StatisticsGroupedOrderDate()
        //{
            //create an instance of the data connection 
            //clsDataConnection DB = new clsDataConnection();

            //excute the stored proceduce 
            //DB.Execute("sproc_tblOrder_Count_GroupOrderDate);

                //there should be either zero, one, or more records
                //return DB.DataTable;
        //}
    }
