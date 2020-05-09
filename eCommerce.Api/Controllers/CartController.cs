using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Business.Abstract;
using eCommerce.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ICartService _cartService;
        IProductService _productService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        [Route("applyCoupon")]
        public ViewCartItem applyCoupon([FromBody]Coupons coupon)
        {
            return _cartService.applyCoupon(coupon);
        }
        [HttpPost]
        [Route("applyDiscounts")]
        public ViewCartItem applyDiscounts([FromBody]List<Campaigns> campaigns)

        {
            return _cartService.applyDiscounts(campaigns);
        }

        [HttpPost]
        [Route("Create")]
        public Carts Create(Carts cart, int productId)
        {

            return _cartService.addItem(cart, productId);
        }

        [HttpGet]
        [Route("CampaignDiscount")]
        public decimal getCampaignDiscount()
        {
            return _cartService.getCampaignDiscount();
        }
        [HttpGet]
        [Route("CouponDiscount")]
        public decimal CouponDiscount()
        {
            return _cartService.getCouponDiscount();
        }
        [HttpGet]
        [Route("DeliveryCost")]
        public decimal DeliveryCost()
        {
            return _cartService.getDeliveryCost();
        }

        [HttpGet]
        [Route("TotalAmountAfterDiscount")]
        public decimal TotalAmountAfterDiscount()
        {
            return _cartService.getTotalAmountAfterDiscount();
        }


    }
}