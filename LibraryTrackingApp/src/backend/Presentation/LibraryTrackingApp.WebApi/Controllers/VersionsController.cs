using LibraryTrackingApp.Infrastructure.Configuration.ApiDocs;
using LibraryTrackingApp.Infrastructure.Mvc;
using LibraryTrackingApp.Infrastructure.Repositories;

namespace LibraryTrackingApp.WebApi.Controllers;


// test asamasında..
[ApiController]
[Route("api/versions")]
[ApiVersion(ApiVersions.V1)]
public class VersionsController : CustomBaseController
{
    private readonly VersionConfig _versionConfig;

    public VersionsController(IMediator mediator) : base(mediator)
    {
       
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok($"Current API version: {ApiVersions.Current}");
    }

    [HttpGet("{version}")]
    public IActionResult Get(string version)
    {

        string documentationLink = $"https://api.example.com/docs/{version}";

        string changelogUrl = string.Format(AppConstant.changelogUrlTemplate, AppConstant.repositoryOwner, AppConstant.repositoryName, ApiVersions.Current);


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

