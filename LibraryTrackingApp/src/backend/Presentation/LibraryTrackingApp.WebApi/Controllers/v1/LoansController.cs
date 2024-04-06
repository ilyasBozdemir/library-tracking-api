namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class LoansController : BaseController
{
    public LoansController(IMediator mediator) : base(mediator)
    {
    }
}
