using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class CouponManager : ICouponService
    {
        private ICouponDAL _couponDAL;
        public CouponManager(ICouponDAL couponDAL)
        {
            _couponDAL = couponDAL;
        }

        public void createCoupon(Coupons coupon)
        {
            _couponDAL.Add(coupon);
        }

        public Coupons getCouponInfo(int Id)
        {
           return _couponDAL.Get(c => c.Id == Id);
        }
    }
}
