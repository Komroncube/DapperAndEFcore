using DapperAndEFcore.Service.EFcore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_EF_Dapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        private readonly ProductOrderService productorderService;

        public ProductOrderController(ProductOrderService productOrderService)
        {
            this.productorderService = productOrderService;
        }
        [HttpGet]
        public IActionResult GetById() 
        {
            return Ok();
        }
    }
}
