using eCommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.DataAccess.Concrete.EntityFramework
{
    public class CommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= .; Initial Catalog=CommerceDB; Trusted_Connection=true");//EntityFrameworkCore support all db 
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<CartProducts> CartProducts { get; set; }

        //   public DbSet<VW_Print> VW_Print { get; set; }


    }
}
