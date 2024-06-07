using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        clsOrder TestItem = new clsOrder();

        //set its properties
        //TestItem.Active = true;
            //TestItem.OrderId = 1;
            //TestItem.CustomerId = 2;
            //TestItem.ShoeId = 3;
            //TestItem.StaffId = 4;
            //TestItem.OrderStatus = "Pending";
            //TestItem.OrderDate = DateTime.Now;
            //TestItem.Note = "ITEM:COLOUR/SIZE";
            //TestItem.TotalAmount = 1.5f;
            //add the test data to the test list
            //mOrderList.Add(TestItem);

            //re initalise the object for some new data
            //TestItem = new clsOrder();

        //set its properties
        //TestItem.Active = true;
            //TestItem.OrderId = 2;
            //TestItem.CustomerId = 4;
            //TestItem.ShoeId = 6;
            //TestItem.StaffId = 8;
            //TestItem.OrderStatus = "Dispatch";
            //TestItem.OrderDate = DateTime.Now;
            //TestItem.Note = "ITEM:COLOUR/SIZE";
            //TestItem.TotalAmount = 1.5f;

            //add the item to the test list 
            //mOrderList.Add(TestItem);

        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();


        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //mOrderList = value;
            }
        }

        public clsOrder ThisOrder { get; set; }
    }
}