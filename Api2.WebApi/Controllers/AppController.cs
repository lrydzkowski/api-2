using Microsoft.AspNetCore.Mvc;

namespace Api2.WebApi.Controllers;

[ApiController]
public class AppController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public IActionResult GetAppInfo()
    {
        return Ok(new { Version = "1.0.0-preview.3", Name = "Api2" });
    }
}
