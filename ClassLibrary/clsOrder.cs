using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderStatus { get; set; }
        public float TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int StaffId { get; set; }
        public int CustomerId { get; set; }
    }
}