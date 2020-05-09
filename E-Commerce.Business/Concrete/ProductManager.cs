using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.DataAccess.Concrete.EntityFramework;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDal)
        {
            _productDAL = productDal;
        }

        public void createProduct(Products product)
        {
            _productDAL.Add(product);
        }

        public Products getProductById(int productId)
        {
            return _productDAL.Get(p=> p.Id == productId);
        }

        public List<Products> getProducts()
        {
            return _productDAL.GetList();
        }
    }
}
