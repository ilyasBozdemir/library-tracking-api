using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers;

[ApiController]
[Route("api/diagnose")]
[ApiVersion(ApiVersions.V1)]

public class DiagnoseController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Diagnose()
    {
        // API'nin sağlığını daha ayrıntılı bir şekilde kontrol etmek için bir sağlık kontrolü endpoint'i.
        // Bu endpoint, veritabanı bağlantısı, servis durumu vb. gibi daha spesifik bileşenlerin durumunu kontrol edebilir.
        // Örneğin, veritabanına bir sorgu yaparak veritabanı bağlantısını kontrol edebiliriz.
        // API'nin genel sağlığını belirten bir yanıt döndürülür.
        if (IsDatabaseConnected())
        {
            return Ok("API is healthy.");
        }
        else
        {
            return StatusCode(503, "API is not healthy. Database connection failed.");
        }
    }

    private bool IsDatabaseConnected()
    {
        // Burada gerçek bir veritabanı bağlantısı kontrolü yapılabilir.
        // Örneğin, bir test sorgusu çalıştırarak veritabanına erişimin kontrol edilmesi sağlanabilir.
        // Bu örnek uygulamada sadece varsayılan olarak her zaman bağlı olduğunu farz ediyoruz.
        return true;
    }
}
