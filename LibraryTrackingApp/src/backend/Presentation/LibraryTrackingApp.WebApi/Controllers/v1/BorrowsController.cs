using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class BorrowsController : CustomBaseController
{
    public BorrowsController(IMediator mediator) : base(mediator)
    {
    }
}
