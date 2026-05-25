using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    //[ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<ProductDto> Get(int id)
        {
            return Ok(new ProductDto
            {
                Id = id,
                Price = 1999
            });
        }
    }
}
