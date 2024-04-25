using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/branch-hours")]
public class BranchHoursController : CustomBaseController
{
    public BranchHoursController(IMediator mediator) : base(mediator)
    {
    }
}
