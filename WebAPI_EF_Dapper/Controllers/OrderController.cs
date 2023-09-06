global using DapperAndEFcore.Service.EFcore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_EF_Dapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService) 
        {
            this.orderService = orderService;
        }
        [HttpGet]
        public IActionResult GetById(int id) 
        {
            var obj = orderService.GetOrderById(id);
            return Ok(obj);
        }
        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            return orderService.GetAllOrders();
        }
        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            if (order != null) 
            {
                orderService.AddOrder(order);
                return Ok(order);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            if (order != null)
            {
                orderService.UpdateOrder(order);
            }
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            if(id!=null)
            {
                orderService.RemoveOrder(id);
            }
            return Ok();
        }
    }
}
