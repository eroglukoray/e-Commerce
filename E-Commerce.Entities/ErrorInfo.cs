using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Entities
{
    public class ErrorInfo
    {
        public string Meassage { get; set; }
        public decimal? AmountInCart { get; set; }
        public decimal? PriceInCart { get; set; }
    }
}
