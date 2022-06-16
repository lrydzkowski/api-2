using Microsoft.AspNetCore.Mvc;

namespace Api2.WebApi.Controllers;

[ApiController]
public class AppController : ControllerBase
{
    [HttpGet]
    [Route("app")]
    public IActionResult GetAppInfo()
    {
        return Ok(new { Version = "1.0.0-preview.1", Name = "Api2" });
    }
}
