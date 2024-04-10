using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers;

[ApiController]
[Route("api/versions")]
[ApiVersion(ApiVersions.V1)]
public class VersionsController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok($"Current API version: {ApiVersions.Current}");
    }

    [HttpGet("{version}")]
    public IActionResult Get(string version)
    {
        // API sürümüne ilişkin belgeleme bağlantısı
        string documentationLink = $"https://api.example.com/docs/{version}";

        // API sürümüne ilişkin değişiklik günlüğü
        string changelog = "https://api.example.com/changelog";

        // API sürümünün destek bilgileri
        string supportInformation = $"API Version {version} is supported until {DateTime.UtcNow.AddYears(2):yyyy-MM-dd}";

        // İlgili bilgileri JSON olarak döndürme
        var response = new
        {
            DocumentationLink = documentationLink,
            Changelog = changelog,
            SupportInformation = supportInformation
        };

        return Ok(response);
    }


    [HttpGet("api-docs")]
    public IActionResult APIDocumentation()// örnek bu
    {
        var documentationLinks = new Dictionary<string, string>
            {
                { "CustomersAPI", "/api/v1/customers/docs" },
                { "OrdersAPI", "/api/v1/orders/docs" },
                { "InvoicesAPI", "/api/v1/invoices/docs" }
            };

        return Ok(documentationLinks);
    }
}

