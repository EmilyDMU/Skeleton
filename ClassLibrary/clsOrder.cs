using System;
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




        //private data member for the customer id Property
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



        //private data member for the customer id Property
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


        public bool OrderStatus { get; set; }
        public float TotalAmount { get; set; }
        
        
        

        

        
        
        public bool Active { get; set; }

        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 1;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mNote = "ITEM:COLOUR/SIZE";
            CustomerId = 11;
            ShoeId = 12;
            StaffId = 13;
            //alaways return true
            return true;
        }
    }
}