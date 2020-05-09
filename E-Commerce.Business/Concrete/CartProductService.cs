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
    public class CartProductManager : ICartProductService
    {
        private ICartProductDAL _cartProductDAL;

        public void createCartProducts(CartProducts cartProducts)
        {
            _cartProductDAL.Add(cartProducts);
        }

        public List<CartProducts> getCartProducts()
        {
            return _cartProductDAL.GetList();
        }

        public CartProducts getCartProductsById(int cartId)
        {
            return _cartProductDAL.Get(x => x.CartId == cartId);
        }
    }
}
