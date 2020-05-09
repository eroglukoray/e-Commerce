using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCommerce.Entities
{
    public class Categories:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
