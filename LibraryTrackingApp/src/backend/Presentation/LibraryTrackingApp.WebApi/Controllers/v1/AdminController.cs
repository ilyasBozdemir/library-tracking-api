namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class AdminController : BaseController
{
    public AdminController(IMediator mediator) : base(mediator)
    {
    }
}