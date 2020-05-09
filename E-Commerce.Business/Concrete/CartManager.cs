using eCommerce.Business.Abstract;
using eCommerce.DataAccess.Abstract;
using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartDAL _cartDAL;
        private IProductDAL _productDAL;
        private ICouponDAL _couponDAL;
        private ICampaignDAL _campaignDAL;
        private ICategoryDAL _categoryDAL;
        private IDeliveryDAL _deliveryDAL;
        private ICartProductDAL _cartProductDAL;
        public CartManager
            (
            ICartDAL cartDAL,
            IProductDAL productDAL,
            ICouponDAL couponDAL,
            ICampaignDAL campaignDAL,
            ICategoryDAL categoryDAL,
            IDeliveryDAL deliveryDAL,
            ICartProductDAL cartProductDAL
            )
        {
            _cartDAL = cartDAL;
            _productDAL = productDAL;
            _couponDAL = couponDAL;
            _campaignDAL = campaignDAL;
            _categoryDAL = categoryDAL;
            _deliveryDAL = deliveryDAL;
            _cartProductDAL = cartProductDAL;
        }

        public Carts addItem(Carts cart, int productId)
        {
            decimal productPrice = _productDAL.Get(x => x.Id == productId).Price;
            int lastCartItemId = 0;
            int isExist = _cartDAL.GetList().Where(x => x.Id == cart.Id).Count();
           
            Carts cartItem = new Carts();

            if ( isExist==0)
            {

                cartItem.Amount = cart.Amount;
                cartItem.TotalPrice = productPrice * cart.Amount;
                
                _cartDAL.Add(cartItem);
                lastCartItemId = _cartDAL.GetList().OrderByDescending(x => x.Id).ToList().FirstOrDefault().Id;
            }
            else
            {
                var thisCartItem = _cartDAL.GetList().OrderByDescending(x => x.Id).ToList().FirstOrDefault();

                cartItem.Id = cart.Id;
                cartItem.Amount = thisCartItem.Amount + cart.Amount;
                cartItem.TotalPrice = (productPrice * (thisCartItem.Amount + cart.Amount));
           
                _cartDAL.Update(cartItem);
                lastCartItemId = cart.Id;

            }
            if (_cartProductDAL.GetList(x => x.CartId == lastCartItemId && x.ProductId == productId).Count() < 1)
            {
                CartProducts cartProduct = new CartProducts()
                {
                    CartId = lastCartItemId,
                    ProductId = productId
                };
                _cartProductDAL.Add(cartProduct);
            }
            else
            {
                int lastCartId = _cartDAL.GetList().Where(x => x.Id == lastCartItemId).FirstOrDefault().Id;
                CartProducts cartProduct = new CartProducts()
                {   
                    Id= lastCartItemId,
                    CartId = lastCartItemId,
                    ProductId = productId
                };
                _cartProductDAL.Update(cartProduct);
            }
            return cartItem;
        }

        public ViewCartItem applyCoupon(Coupons coupon)
        {
            List<Carts> cartItems = new List<Carts>();
            List<Products> productItems = new List<Products>();
            List<CartProducts> cartProductItems = new List<CartProducts>();

            cartProductItems = _cartProductDAL.GetList();
            cartItems = _cartDAL.GetList();
            productItems = _productDAL.GetList();

            ViewCartItem viewCartItem = new ViewCartItem();
            decimal _totalPrice = 0;

            var cartProducts = //sepetteki toplam tutar
                        from CartProduct in cartProductItems
                        join Cart in cartItems on CartProduct.CartId equals Cart.Id
                        join Product in productItems on CartProduct.ProductId equals Product.Id
                        select new { Cart.TotalPrice, CartProduct.ProductId, CartProduct.CartId, ProductName = Product.Title, UnitPrice= Product.Price };


            foreach (var item in cartProducts.ToList())
            {
                _totalPrice = Convert.ToDecimal(item.TotalPrice);

                //sepetteki tutar kupondaki limite eşit veya fazla ise 
                if (coupon.Price <= _totalPrice)
                {
                    if (_couponDAL.GetList(x => x.DiscountRate == coupon.DiscountRate && x.DiscountTypeId == coupon.DiscountTypeId && x.Price == coupon.Price).Count == 0)

                        _couponDAL.Add(coupon);//kupon eklendi

                    //sepetteki ürün
                    var discountedProduct = _productDAL.Get(x => x.Id == item.ProductId);

                    if (coupon.DiscountTypeId == (int)EnumDiscountTypes.Rate)//Convert.ToInt32(discountTypeItems.Where(a => a.Title == "Rate").Select(x => x.Id).ToList()))
                    {
                        //kuponun oran bazında indirimli halinin sepet tutarına yansıtılmış hali
                        var discountedPriceForRate = _totalPrice - (_totalPrice * coupon.DiscountRate) / 100;
                        discountedProduct.Price = discountedPriceForRate;
                    }

                    else if (coupon.DiscountTypeId == (int)EnumDiscountTypes.Amount)//Convert.ToInt32(discountTypeItems.Where(a => a.Title == "Amount").Select(x => x.Id).ToList()))
                    {
                        //kuponun miktar bazında indirimli halinin sepet tutarına yansıtılmış hali
                        var discountedPriceForAmount = _totalPrice - coupon.DiscountRate;
                        discountedProduct.Price = discountedPriceForAmount;
                    }

                    cartItems = _cartDAL.GetList(x => x.Id == item.CartId).ToList();
                    // indirim sepetteki ürünlere yansıtıldı.
                    foreach (var cartItem in cartItems)
                    {
                        cartItem.Id = discountedProduct.Id;
                        cartItem.TotalPrice = discountedProduct.Price;
                        _cartDAL.Update(cartItem);
                    }
                    viewCartItem.Amount = cartItems.FirstOrDefault().Amount;
                    viewCartItem.CartId = cartItems.FirstOrDefault().Id;
                    viewCartItem.DiscountedTotalPrice = cartItems.FirstOrDefault().TotalPrice;
                    viewCartItem.ProductName = cartProducts.FirstOrDefault().ProductName;
                    viewCartItem.TotalPrice = cartItems.FirstOrDefault().Amount * cartProducts.FirstOrDefault().UnitPrice;
                    viewCartItem.UnitPrice = cartProducts.FirstOrDefault().UnitPrice;
                    viewCartItem.TotalPriceInCart = discountedProduct.Price;
                }
                else
                {
                    viewCartItem.TotalPriceInCart = _totalPrice;
                    viewCartItem.ErrorInfo = "Sepetteki toplam tutar, kupon limitinden az! Sepete en az "+ (coupon.Price- _totalPrice).ToString() +"TL"+" tutarında daha ürün eklemelisiniz !";       
              
                }
            }

            return viewCartItem;
        }

        public ViewCartItem applyDiscounts(List<Campaigns> campaigns)
        {
            List<Carts> cartItems = new List<Carts>();
            List<Products> productItems = new List<Products>();
            List<Categories> categoryItems = new List<Categories>();
            List<CartProducts> cartProductItems = new List<CartProducts>();


            ViewCartItem viewCartItem = new ViewCartItem();

            cartProductItems = _cartProductDAL.GetList();
            cartItems = _cartDAL.GetList();
            categoryItems = _categoryDAL.GetList();
            productItems = _productDAL.GetList();
            // discountTypeItems = _discountType.GetList();

            var totalPriceInCart = //sepetteki toplam tutar
                           from CartProduct in cartProductItems
                           join Cart in cartItems on CartProduct.CartId equals Cart.Id
                           join Product in productItems on CartProduct.ProductId equals Product.Id

                           select new { TotalPrice = Cart.TotalPrice, Product.CategoryId ,ProductName= Product.Title, UnitPrice= Product.Price,Amount= Cart.Amount};

            var totalAmountInCart = //sepetteki toplam adet
                          from CartProduct in cartProductItems
                          join Cart in cartItems on CartProduct.CartId equals Cart.Id
                          join Product in productItems on CartProduct.ProductId equals Product.Id

                          select new { TotalAmount = Cart.Amount, Product.CategoryId, ProductId= Product.Id, ProductName = Product.Title, CartId = Cart.Id, UnitPrice = Product.Price, Amount = Cart.Amount };

            // tanımlanacak kampanyalar içinden sepetteki ürünlerde geçerliliğinin kontrolü
            foreach (var campaignCategory in campaigns)
            {
                //kampanyalı kategorinin toplam tutar limiti
                var totalPricebyCampaignCategory = totalPriceInCart.Where(c => c.CategoryId == campaignCategory.CategoryId).Select(p => p.TotalPrice).ToList().FirstOrDefault();
              

                //kampanyalı kategorinin miktar limiti
                var totalAmountbyCampaignCategory = totalAmountInCart.Where(c => c.CategoryId == campaignCategory.CategoryId).Select(a => a.TotalAmount).ToList().FirstOrDefault();
            

                //sepette kampanyalı kategori varsa ve kampanya miktar koşulu sağlanıyorsa indirim uygulanacak
                if (totalAmountbyCampaignCategory >= campaignCategory.AmountLimit)
                {
                    int isExist = _campaignDAL.GetList().Where(x => x.Id ==campaignCategory.CategoryId ).Count();
                    
                    if (isExist < 1)
                    {
                        _campaignDAL.Add(campaignCategory);// kampanya eklendi
                      
                    }

                    var discountedProducts = totalAmountInCart.Where(x => x.CategoryId == campaignCategory.CategoryId);

                    foreach (var item in discountedProducts)
                    {
                        var discountedInCartId = _cartProductDAL.Get(x => x.ProductId == item.ProductId).CartId;
                        var updatedCartItem = _cartDAL.Get(x => x.Id == discountedInCartId);

                        if (campaignCategory.DiscountTypeId == (int)EnumDiscountTypes.Rate)//Convert.ToInt32(discountTypeItems.Where(a => a.Title == "Rate").Select(x => x.Id).ToList()))
                        {
                            //kampanyanın oran bazında indirimli halinin sepet tutarına yansıtılmış hali
                            var discountedPriceForRate = totalPricebyCampaignCategory - (totalPricebyCampaignCategory * campaignCategory.DiscountRate) / 100;
                            updatedCartItem.TotalPrice = discountedPriceForRate;
                        }
                        else if (campaignCategory.DiscountTypeId == (int)EnumDiscountTypes.Amount) //Convert.ToInt32(discountTypeItems.Where(a => a.Title == "Amount").Select(x => x.Id).ToList()))
                        {
                            //kampanyanın miktar bazında indirimli halinin sepet tutarına yansıtılmış hali
                            var discountedPriceForAmount = totalPricebyCampaignCategory - campaignCategory.DiscountRate;
                            updatedCartItem.TotalPrice = discountedPriceForAmount;
                        }
                        _cartDAL.Update(updatedCartItem);
                        viewCartItem.TotalPriceInCart = updatedCartItem.TotalPrice;
                        viewCartItem.DiscountedTotalPrice = updatedCartItem.TotalPrice;
                        viewCartItem.Amount = item.TotalAmount;
                        viewCartItem.CartId = item.CartId;
                        viewCartItem.ProductName = item.ProductName;
                        viewCartItem.TotalPrice = item.TotalAmount * item.UnitPrice;
                        viewCartItem.UnitPrice = totalPriceInCart.FirstOrDefault().UnitPrice;
                    }
                }
                else
                {
                    viewCartItem.TotalPriceInCart = totalPriceInCart.FirstOrDefault().TotalPrice;
                    viewCartItem.ErrorInfo = "Sepette kampanyalı olan kategorilere ait yeterli veya hiç ürün yok !";
                    //sepette kampanyalı kategoriye ait ürün yok!
                }
              
            }
            return viewCartItem;
        }

        public decimal getCampaignDiscount()
        {
            return Convert.ToDecimal(_campaignDAL.GetList().FirstOrDefault().DiscountRate);
        }

        public decimal getCouponDiscount()
        {
            return Convert.ToDecimal(_couponDAL.GetList().FirstOrDefault().DiscountRate);
        }

        public decimal getDeliveryCost()
        {
            return Convert.ToDecimal(_deliveryDAL.GetList().FirstOrDefault().CostPerDelivery);
        }

        public int getTotalAmountAfterDiscount()
        {
            List<Carts> cartItems = new List<Carts>();
            List<Products> productItems = new List<Products>();
            List<Categories> categoryItems = new List<Categories>();

            cartItems = _cartDAL.GetList();
            categoryItems = _categoryDAL.GetList();
            productItems = _productDAL.GetList();

            var totalAmountInCart = //sepetteki toplam miktar
                from Cart in cartItems


                select new { totalAmount = Cart.Amount };

            var _totalAmountInCart = totalAmountInCart.FirstOrDefault().totalAmount;

            return _totalAmountInCart;
        }


    }
}
