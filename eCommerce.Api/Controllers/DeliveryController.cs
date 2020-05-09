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
    public class DeliveryController : ControllerBase
    {
       
        IDeliveryService _deliveryService;

        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        [HttpPost]
        [Route("calculateDelivery")]
        public DeliveryInfo calculateDelivery([FromBody]CartProducts cartProducts)
        {
            return _deliveryService.calculateFor(cartProducts);
        }
    }
}