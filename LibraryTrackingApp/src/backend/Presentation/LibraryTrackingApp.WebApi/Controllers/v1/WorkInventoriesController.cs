using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/work-inventories")]

public class WorkInventoriesController : CustomBaseController
{
    public WorkInventoriesController(IMediator mediator) : base(mediator)
    {
    }

}
