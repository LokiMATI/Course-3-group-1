using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Core;
using Store.Models.Entity;

namespace Store.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        IOrderManager _orderManager;
        public OrderController(IOrderManager orederManager) 
        { 
            _orderManager = orederManager;
        }

        [HttpGet]
        public List<OrderEntity> GetAll() => _orderManager.GetAll();

        [HttpPost]
        public IActionResult Add([FromBody] OrderEntity entity)
        {
            _orderManager.Add(entity);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Guid Id)
        {
            _orderManager.Remove(Id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] OrderEntity entity)
        {
            _orderManager.Update(entity);
            return Ok();
        }
    }
}
