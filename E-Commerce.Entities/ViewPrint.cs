using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Entities
{
    public class ViewPrint
    {
        public string CategoryName { get; set; }
        public string  ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
    }
}
