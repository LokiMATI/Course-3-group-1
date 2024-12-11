using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Core;
using Store.Models.Entity;

namespace Store.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        IProductManager _productManager;
        public ProductController(IProductManager productManager) 
        { 
            _productManager = productManager;
        }

        [HttpGet]
        public List<ProductEntity> GetAll() => _productManager.GetAll();

        [HttpPost]
        public IActionResult Add([FromBody] ProductEntity entity)
        {
            _productManager.Add(entity);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Guid Id)
        {
            _productManager.Remove(Id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody]ProductEntity entity)
        {
            _productManager.Update(entity);
            return Ok();
        }
    }
}
