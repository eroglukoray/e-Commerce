﻿using eCommerce.Core.DataAccess;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Categories>
    {
    }
}