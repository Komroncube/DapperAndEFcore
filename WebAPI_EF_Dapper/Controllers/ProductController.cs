using DapperAndEFcore.Models;
using DapperAndEFcore.Service.EFcore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_EF_Dapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService productService;
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = this.productService.GetAllProducts();
            return products;
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(product!=null)
            {
                productService.AddProduct(product);
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var obj = new Product();
            if (id!=null)
            {
                obj = productService.GetProductById(id);
            }
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            if (product != null) 
            {
                productService.UpdateProduct(product);
            }
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            if(id!=null)
            {
                productService.DeleteProduct(id);
            }
            return Ok();
        }
    }
}
