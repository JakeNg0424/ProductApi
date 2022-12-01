using Microsoft.AspNetCore.Mvc;
using ProductsApi.Business;

namespace ProductsApi.Controllers;

[Controller]
[Route("/api[controller]")]
public class ProductsController : ControllerBase
{
    private IBusiness Business { get; set; }

    public ProductsController(IBusiness business)
    {
        Business = business;
    }

    [HttpGet]
    [Route("top")]
    public IActionResult GetTop()
    {
        var result = Business.GetTopThreeProductsWith(3, 4);
        return Ok(result);
    }
}