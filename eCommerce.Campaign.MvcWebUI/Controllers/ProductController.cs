using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Business.Abstract;
using eCommerce.Campaign.MvcWebUI.Models;
using eCommerce.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Campaign.MvcWebUI.Controllers
{

    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("GetProduct/{productId}")]
        public ActionResult GetProduct(int productId)
        {

            var productInfo = _productService.getProductById(productId);

            return View(productInfo);
        }

        [Route("GetProduct")]
        public ActionResult GetProduct()
        {
            var productInfo = _productService.getProducts();
            ProductViewModel model = new ProductViewModel
            {
                product = productInfo
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult AddProduct(Products product)
        {
            _productService.createProduct(product);
            TempData.Add("message", "Product was successfully added");

            return RedirectToAction("GetProduct");
        }
    }
}