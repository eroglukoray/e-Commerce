using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Business.Abstract
{
    public interface ICartProductService
    {
        List<CartProducts> getCartProducts();
        CartProducts getCartProductsById(int cartId);
        void createCartProducts(CartProducts cartProducts);
       
    }
}
