using Microsoft.AspNetCore.Mvc;

namespace Company.Project.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController(ILogger<ItemController> logger) : ControllerBase
{
    private readonly ILogger<ItemController> _logger = logger;

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogTrace(DateTime.Now + " " + HttpContext.GetEndpoint());

        return Ok();
    }
}
