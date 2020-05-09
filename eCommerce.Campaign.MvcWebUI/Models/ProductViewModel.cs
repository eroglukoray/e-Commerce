using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Campaign.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Products> product { get; internal set; }
    }
}
