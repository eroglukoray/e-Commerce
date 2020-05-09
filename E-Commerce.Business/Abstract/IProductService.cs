using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Products> getProducts();
        Products getProductById(int productId);
        void createProduct(Products product);
       
    }
}
