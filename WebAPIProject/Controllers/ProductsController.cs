using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIProject.Controllers
{
    [ApiController] // Bu attribute, controller'ın bir API controller olduğunu belirtir
    [Route("api/[controller]")] // URL'yi `api/products` olarak tanımlar
    public class ProductsController : ControllerBase // ControllerBase sınıfından türetilmeli
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("getall")] // GET istekleri için bu metodu belirler
        public IActionResult GetAll()
        {
                var result = _productService.GetAll();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}