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
        public int OrderId { get; set; }
        public int ShoeId { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
    }
}