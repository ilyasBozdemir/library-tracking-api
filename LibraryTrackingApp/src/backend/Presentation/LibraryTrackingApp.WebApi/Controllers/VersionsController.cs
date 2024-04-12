using LibraryTrackingApp.Infrastructure.Enums;
using LibraryTrackingApp.Infrastructure.Helpers;
using LibraryTrackingApp.Infrastructure.Mvc;
using LibraryTrackingApp.Infrastructure.Repositories;

namespace LibraryTrackingApp.WebApi.Controllers;

[ApiController]
[Route("api/versions")]
[ApiVersion(ApiVersions.V1)]
public class VersionsController : CustomBaseController
{
    private readonly VersionRepository _versionRepository;
    private string _baseUrl;

    public VersionsController(IMediator mediator)
        : base(mediator)
    {
        _versionRepository = new();
    }

    [HttpGet("all-versions")]
    public IActionResult GetAllVersion()
    {
        var supportedVersions = _versionRepository.GetSupportedVersions(DateTime.Now);

        var response = new
        {
            CurrentVersion = $"Current API version: {ApiVersions.Current}",
            SupportedVersions = supportedVersions
        };
        return Ok(response);
    }

    [HttpGet("{version}")]
    public IActionResult Get(string version)
    {
        var supportedVersions = _versionRepository.GetSupportedVersions(DateTime.Now);

        if (!version.StartsWith("v"))
            version = "v" + version;

        var apiversions = SwaggerHelper.GetAllVersions(LayerName.WebAPI);

        var requestedApiVersion = apiversions.FirstOrDefault(
            apiversion => apiversion.Version == version
        );

        var versionInfo = _versionRepository.GetVersionInfo(version);
        return Ok(versionInfo);
    }

    [HttpGet("api-docs")]
    public IActionResult APIDocumentation()
    {
        var request = HttpContext.Request;
        _baseUrl = string.Format(AppConstant.baseUrlTemplate, request.Scheme, request.Host);

        string swaggerJsonUri = _baseUrl + string.Format(AppConstant.swaggerUrlTemplate, $"v{ApiVersions.Current}");
       
        var allVersions = SwaggerHelper.GetAllVersions(LayerName.WebAPI);

        var requestedApiVersion = allVersions.FirstOrDefault(
            apiversion => apiversion.Version == $"v{ApiVersions.Current}"
        );

        string changelogUrl = string.Format(
               AppConstant.changelogUrlTemplate,
               AppConstant.repositoryOwner,
               AppConstant.repositoryName,
              $"v{ApiVersions.Current}"
           );

        foreach (var versionInfo in allVersions)
        {
            Console.WriteLine($"Version: {versionInfo.Version}");
        }


        var documentationLinks = new
        {
            Title = requestedApiVersion.OpenApiInfo.Title,
            SwaggerJsonUri = new 
            {
                WebAPI = swaggerJsonUri,
            },
            ChangelogUri = changelogUrl

        };

        return Ok(documentationLinks);
    }
}
