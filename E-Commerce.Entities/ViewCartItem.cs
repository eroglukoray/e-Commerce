using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Entities
{
    public class ViewCartItem
    {
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? DiscountedTotalPrice { get; set; }

        public decimal? TotalPriceInCart { get; set; }
        public string  ErrorInfo { get; set; }

    }
}
