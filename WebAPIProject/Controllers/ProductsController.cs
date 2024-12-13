using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIProject.Controllers
{
    [ApiController] // Bu attribute, controller'ın bir API controller olduğunu belirtir
    [Route("api/[controller]")] // URL'yi `api/products` olarak tanımlar
    public class ProductsController : ControllerBase // ControllerBase sınıfından türetilmeli
    {
        [HttpGet] // GET istekleri için bu metodu belirler
        public List<Product> Get()
        {
            return new List<Product>
            {
                new Product{ProductId = 1, ProductName = "elma"},
                new Product{ProductId = 2, ProductName = "armut"},
            };
        }
    }
}