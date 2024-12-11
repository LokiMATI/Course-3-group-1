using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Core;
using Store.Models.Entity;

namespace Store.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class BuyerController : ControllerBase
    {
        IBuyerManager _buyerManager;
        public BuyerController(IBuyerManager buyerManager) 
        { 
            _buyerManager = buyerManager;
        }

        [HttpGet]
        public List<BuyerEntity> GetAll() => _buyerManager.GetAll();

        [HttpPost]
        public IActionResult Add([FromBody]BuyerEntity entity)
        {
            _buyerManager.Add(entity);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Guid Id)
        {
            _buyerManager.Remove(Id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody]BuyerEntity entity)
        {
            _buyerManager.Update(entity);
            return Ok();
        }
    }
}
