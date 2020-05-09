using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCommerce.Entities
{
    public class Deliveries:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public double CostPerDelivery { get; set; }
        public double CostPerProduct { get; set; }
        public double FixedCost { get; set; }

    }
}
