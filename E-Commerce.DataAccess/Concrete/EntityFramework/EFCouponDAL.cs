﻿using eCommerce.Core.DataAccess.EntityFramework;
using eCommerce.DataAccess.Abstract;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.DataAccess.Concrete.EntityFramework
{
    public class EFCouponDAL: EFEntityRepositoryBase<Coupons, CommerceContext>,ICouponDAL
    {
    }
}
