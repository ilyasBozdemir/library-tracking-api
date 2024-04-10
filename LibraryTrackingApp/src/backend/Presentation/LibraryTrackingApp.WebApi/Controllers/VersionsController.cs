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
    
        string documentationLink = $"https://api.example.com/docs/{version}";

        
        string changelogUrl = $"https://raw.githubusercontent.com/{AppConstant.repositoryOwner}/{AppConstant.repositoryName}/main/docs/{ApiVersions.Current}.0.0/CHANGELOG.md";

       
        string supportInformation = $"API Version {version} is supported until {DateTime.UtcNow.AddYears(2):yyyy-MM-dd}";

        var response = new
        {
            DocumentationLink = documentationLink,
            Changelog = changelogUrl,
            SupportInformation = supportInformation
        };

        return Ok(response);
    }


    [HttpGet("api-docs")]
    public IActionResult APIDocumentation()// örnek bu
    {
        var documentationLinks = new Dictionary<string, string>
            {
                { "WebAPI", "/api/v1/customers/docs" },
            };

        return Ok(documentationLinks);
    }
}

