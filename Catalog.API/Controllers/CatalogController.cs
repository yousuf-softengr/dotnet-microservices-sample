using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
            new { Id = 1, Name = "Laptop", Price = 1200 },
            new { Id = 2, Name = "Mouse", Price = 20 }
        });
        }
    }
}
