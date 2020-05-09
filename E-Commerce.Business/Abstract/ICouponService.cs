using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface ICouponService
    {
        Coupons getCouponInfo(int Id);
        void createCoupon(Coupons coupon);

    }
}
