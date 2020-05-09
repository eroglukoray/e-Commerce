using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using eCommerce.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers
{

  
    public class SimpleProductController : ControllerBase
    {
        List<Products> products = new List<Products>();

        public SimpleProductController() { }

        public SimpleProductController(List<Products> products)
        {
            this.products = products;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return products;
        }

        public async Task<IEnumerable<Products>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }


    }
}