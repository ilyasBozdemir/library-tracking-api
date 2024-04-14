using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/// <summary>
/// Yönetici işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/admin")]
public class LogoController : CustomBaseController
{
    public LogoController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet("api/logo")]
    public IActionResult GetLogo()
    {
        try
        {
            string logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");

            byte[] logoBytes = System.IO.File.ReadAllBytes(logoPath);


            return File(logoBytes, "image/png");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal Server Error: {ex.Message}");
        }
    }
}


