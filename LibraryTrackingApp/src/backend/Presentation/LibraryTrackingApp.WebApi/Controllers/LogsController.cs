namespace LibraryTrackingApp.WebApi.Controllers;


[ApiController]
[Route("api/logs")]
[ApiVersion(ApiVersions.V1)]
public class LogsController : ControllerBase
{
    [HttpGet("ErrorLogs")]
    public IActionResult GetErrorLogs()
    {
        // Hata loglarını döndürür.
        List<string> errorLogs = new List<string>
            {
                "Error log entry 1",
                "Error log entry 2",
                "Error log entry 3"
            };
        return Ok(errorLogs);
    }

    [HttpGet("InfoLogs")]
    public IActionResult GetInfoLogs()
    {
        // Bilgi loglarını döndürür.
        List<string> infoLogs = new List<string>
            {
                "Info log entry 1",
                "Info log entry 2",
                "Info log entry 3"
            };
        return Ok(infoLogs);
    }

    [HttpGet("RequestLogs")]
    public IActionResult GetRequestLogs()
    {
        // İstek loglarını döndürür.
        List<string> requestLogs = new List<string>
            {
                "Request log entry 1",
                "Request log entry 2",
                "Request log entry 3"
            };
        return Ok(requestLogs);
    }

    [HttpGet("SecurityLogs")]
    public IActionResult GetSecurityLogs()
    {
        // Güvenlik loglarını döndürür.
        List<string> securityLogs = new List<string>
            {
                "Security log entry 1",
                "Security log entry 2",
                "Security log entry 3"
            };
        return Ok(securityLogs);
    }

    [HttpGet("PerformanceLogs")]
    public IActionResult GetPerformanceLogs()
    {
        // Performans loglarını döndürür.
        List<string> performanceLogs = new List<string>
            {
                "Performance log entry 1",
                "Performance log entry 2",
                "Performance log entry 3"
            };
        return Ok(performanceLogs);
    }

    [HttpGet("AuditLogs")]
    public IActionResult GetAuditLogs()
    {
        // Denetim loglarını döndürür.
        List<string> auditLogs = new List<string>
            {
                "Audit log entry 1",
                "Audit log entry 2",
                "Audit log entry 3"
            };
        return Ok(auditLogs);
    }

    [HttpGet("UserFootprints")]
    public IActionResult GetUserFootprints()
    {
        // Kullanıcı izlerini döndürür.
        List<string> userFootprints = new List<string>
            {
                "User footprint 1",
                "User footprint 2",
                "User footprint 3"
            };
        return Ok(userFootprints);
    }

}
