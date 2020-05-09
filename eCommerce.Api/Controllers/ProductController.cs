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
    public class ProductController : ControllerBase
    {
        IProductService _producService;

        public ProductController(IProductService producService)
        {
            _producService = producService;
        }

        [HttpGet]
        public  IEnumerable<Products> GetValues()

        {
             var productInfo =  _producService.getProducts();
             return productInfo;
        }


        [HttpPost]
        [Route("GetProductById")]
        public ActionResult GetProductById(int productId)
        {
            var product = _producService.getProductById(productId);
            return Ok(product);
        }


        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Products product)
        {
            _producService.createProduct(product);

            return Ok(product);

        }   

    }
}