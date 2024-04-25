using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/staffs")]
public class StaffsController : CustomBaseController
{
    public StaffsController(IMediator mediator) : base(mediator)
    {
    }
}
