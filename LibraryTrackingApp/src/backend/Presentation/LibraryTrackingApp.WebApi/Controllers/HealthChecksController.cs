using LibraryTrackingApp.Infrastructure.Mvc;
namespace LibraryTrackingApp.WebApi.Controllers;


[ApiController]
[Route("api/health-checks")]
[ApiVersion(ApiVersions.V1)]
public class HealthChecksController : CustomBaseController
{
    public HealthChecksController(IMediator mediator) : base(mediator)
    {
    }


    [HttpGet("health-url")]
    public IActionResult GetHealthCheckUrl()
    {
        var healthCheckUrl = "https://localhost:7115/health";
        return Ok(healthCheckUrl);
    }

    [HttpGet("health-ui-url")]
    public IActionResult GetHealthCheckUIUrl()
    {
        var healthCheckUIUrl = "https://localhost:7115/health-ui";
        return Ok(healthCheckUIUrl);
    }
}