using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface ICartService
    {
   //Command
        Carts addItem(Carts cart, int productId);
        ViewCartItem applyDiscounts(List<Campaigns> campaigns);
        ViewCartItem applyCoupon(Coupons coupon);
   
   //Query
        int getTotalAmountAfterDiscount();
        decimal getCouponDiscount();
        decimal getCampaignDiscount();
        decimal getDeliveryCost();
      
    }
}
