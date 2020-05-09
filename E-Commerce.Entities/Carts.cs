using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;
using eCommerce.Core;

namespace eCommerce.Entities
{
    public class Carts : IEntity
    {
        [Key]
        public int Id { get; set; }
        //public List<Products> ProductList { get; set; }
        public int Amount { get; set; }
        public decimal? TotalPrice { get; set; }
    }

    //public class ProductList
    //{
    //    public List<Products> Product { get; set; }
    //}
}