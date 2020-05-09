using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class DeliveryManager : IDeliveryService
    {
        private ICartDAL _cartDAL;
        private IProductDAL _productDAL;
        private ICategoryDAL _categoryDAL;
        private IDeliveryDAL _deliveryDAL;
        private ICartProductDAL _cartProductDAL;


        public DeliveryManager(
            IDeliveryDAL deliveryDAL,
            ICartDAL cartDAL,
            IProductDAL productDAL,
            ICategoryDAL categoryDAL,
            ICartProductDAL cartProductDAL
            )
        {
            _cartDAL = cartDAL;
            _productDAL = productDAL;     
            _categoryDAL = categoryDAL;
            _deliveryDAL = deliveryDAL;
            _cartProductDAL = cartProductDAL;

        }

        public DeliveryInfo calculateFor(CartProducts carts)
        {
            List<Carts> cartItems = new List<Carts>();
            List<Products> productItems = new List<Products>();
            List<Categories> categoryItems = new List<Categories>();
            List<CartProducts> cartProductItems = new List<CartProducts>();


            double costForDelivery = 5.99;//anlaşmalı kargo teslimatı birim fiyatı
            double fixedCost = 2.99;// sabit fiyat
            double calculatedDeliveryCost = 0.0;

            cartProductItems = _cartProductDAL.GetList();
            cartItems = _cartDAL.GetList();
            productItems = _productDAL.GetList();
            categoryItems = _categoryDAL.GetList();

            var itemsInCart = //sepetteki ürünler ve kategorileri
                                    from CartProduct in cartProductItems
                                    join Cart in cartItems on CartProduct.CartId equals Cart.Id
                                    join Product in productItems on CartProduct.ProductId equals Product.Id
                              

            select new {Cart.Id, CartProduct.ProductId, Product.CategoryId, Product.Price};

            var thisCartItem = itemsInCart.Where(x=>x.Id == carts.CartId).ToList();// bu sepetteki ürünlerin

            var numberOfProduct = itemsInCart.Where(x => x.Id == carts.CartId).ToList().Distinct().Select(p=>p.ProductId).Count();// sepette kaç farklı ürün var 
            var numberOfDelivery = itemsInCart.Where(x => x.ProductId == carts.ProductId).ToList().Distinct().Select(c => c.CategoryId).Count();// sepette kaç farklı ürün kategorisi var 
        
            
            for (int i = 0; i < numberOfProduct; i++)
            {
                var costPerProduct = itemsInCart.Where(x => x.ProductId == carts.ProductId).ToList().Distinct().Select(p => p.Price).FirstOrDefault();// sepetteki her bir ürünün birim fiyatı
                calculatedDeliveryCost = (costForDelivery * numberOfDelivery) + (Convert.ToDouble(costPerProduct) * numberOfProduct) + fixedCost;// teslimat tutarının hesaplanması

                Deliveries delivery = new Deliveries()
                {
                    CartId = itemsInCart.Select(c => c.Id).FirstOrDefault(),
                    CostPerDelivery = costForDelivery,
                    CostPerProduct = Convert.ToDouble(costPerProduct),
                    FixedCost = fixedCost
                };

                _deliveryDAL.Add(delivery); // teslimatın eklenmesi
            }
            DeliveryInfo deliveryInfo = new DeliveryInfo()
            {
                Info = "Kargo Teslimat Tutarı",
                Price = calculatedDeliveryCost
            };

            return deliveryInfo;     
        }

        
        public void createDelivery(Deliveries deliveries)
        {
            _deliveryDAL.Add(deliveries);
        }

        public List<Deliveries> getDeliveries()
        {
           return _deliveryDAL.GetList();
        }

        public Deliveries getDeliveryByCartId(int cartId)
        {
            return _deliveryDAL.Get(x => x.CartId == cartId);
        }
    }
}
