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
    public VersionsController(IMediator mediator) : base(mediator)
    {
        _versionRepository = new ();
    }

    [HttpGet("")]
    public IActionResult GetAllVersion()
    {
        var supportedVersions = _versionRepository.GetSupportedVersions();

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
        var supportedVersions = _versionRepository.GetSupportedVersions();

        if (!version.StartsWith("v"))
            version = "v" + version;

        var apiversions = SwaggerHelper.GetAllVersions(LayerName.WebAPI);


        var  requestedApiVersion = apiversions.FirstOrDefault(apiversion => apiversion.Version == version);



        if (supportedVersions.ContainsKey(version))
        {
            DateTime supportEndDate = supportedVersions[version];
            var request = HttpContext.Request;
            _baseUrl = $"{request.Scheme}://{request.Host}";

            string swaggerJsonUri = _baseUrl;


            swaggerJsonUri += string.Format(AppConstant.swaggerUrlTemplate, version); 

            string changelogUrl = string.Format(AppConstant.changelogUrlTemplate, AppConstant.repositoryOwner, AppConstant.repositoryName, ApiVersions.Current);
            string supportInformation = $"API Sürümü {version} {supportEndDate:yyyy-MM-dd}e kadar desteklenir.";
      
            var response = new
            {
                Title = requestedApiVersion.OpenApiInfo.Title,
                Version = requestedApiVersion.OpenApiInfo.Version,
                SwaggerJsonUri = swaggerJsonUri,
                Changelog = changelogUrl,
                SupportInformation = supportInformation
            };

            return Ok(response);
        }
        else
        {
            return NotFound($"API Version {version} is not supported.");
        }
    }


    [HttpGet("api-docs")]
    public IActionResult APIDocumentation()// örnek bu
    {
        var request = HttpContext.Request;
        _baseUrl = $"{request.Scheme}://{request.Host}";

        string swaggerJsonUri = _baseUrl;


        swaggerJsonUri += string.Format(AppConstant.swaggerUrlTemplate, ApiVersions.Current);

        var documentationLinks = new Dictionary<string, string>
            {
                { "WebAPI", swaggerJsonUri },
            };

  

        return Ok(documentationLinks);
    }

}

