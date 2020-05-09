using eCommerce.Api.Controllers;
using eCommerce.Business.Abstract;
using eCommerce.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace eCommerce.Test
{
    [TestClass]
    public class TestSimpleProductController
    {

        IProductService _producService;

        public TestSimpleProductController(IProductService producService)
        {
            _producService = producService;
        }
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new SimpleProductController(testProducts);

            var result = controller.GetAllProducts() as List<Products>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {

            var testProducts = GetTestProducts();
            var controller = new SimpleProductController(testProducts);
            var result = await controller.GetAllProductsAsync() as List<Products>;
          
            Assert.AreEqual(testProducts.Count, result.Count);
        }

      

        private List<Products> GetTestProducts()
        {
            var testProducts = new List<Products>();

            testProducts.Add(new Products { Id = 1, Title = "Apple", CategoryId=1, Price = 5 });
            testProducts.Add(new Products { Id = 2, Title = "Almond", CategoryId = 1, Price = 70 });
            testProducts.Add(new Products { Id = 3, Title = "IPhone8", CategoryId = 2, Price = 4699 });


            return testProducts;
        }
    }
}
