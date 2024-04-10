using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers;


[ApiController]
[Route("api/health-checks")]
[ApiVersion(ApiVersions.V1)]

public class HealthChecksController : ControllerBase
{
    [HttpGet("")]
    public IActionResult CheckHealth()
    {
        return Ok("API is up and running.");
    }
}