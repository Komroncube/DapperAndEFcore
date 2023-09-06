using DapperAndEFcore.Models;
using DapperAndEFcore.Service.EFcore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_EF_Dapper.Controllers
{
    [Route("api/[controller]")]
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
    }
}
