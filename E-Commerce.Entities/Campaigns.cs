using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCommerce.Entities
{
    public class Campaigns:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DiscountTypeId { get; set; }
        public int DiscountRate { get; set; }
        public int AmountLimit { get; set; }

    }
}
