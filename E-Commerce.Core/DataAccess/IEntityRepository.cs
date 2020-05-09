using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace eCommerce.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {   
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T Entity);
        void Update(T Entity);
   
    }
}
