using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/// <summary>
/// Yönetici işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/static")]
public class StaticsController : CustomBaseController
{
    public StaticsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet("css/{fileName}")]
    public IActionResult GetCss(string fileName)
    {
        // CSS dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "css", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "text/css") : NotFound();

    }

    [HttpGet("js/{fileName}")]
    public IActionResult GetJavaScript(string fileName)
    {
        // JS dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "js", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "text/javascript") : NotFound();

    }

    [HttpGet("images/{fileName}")]
    public IActionResult GetImage(string fileName)
    {
        // Resim dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "image/jpeg") : NotFound();

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

    [HttpGet("fonts/{fileName}")]
    public IActionResult GetFont(string fileName)
    {
        // Font dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "fonts", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "application/font") : NotFound();

    }

    [HttpGet("videos/{fileName}")]
    public IActionResult GetVideo(string fileName)
    {
        // Video dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "videos", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "video/mp4") : NotFound();
    }

    [HttpGet("audio/{fileName}")]
    public IActionResult GetAudio(string fileName)
    {
        // Ses dosyasını döndür
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "audio", fileName);

        return (System.IO.File.Exists(filePath)) ? PhysicalFile(filePath, "audio/mpeg") : NotFound();

    }
}
      

