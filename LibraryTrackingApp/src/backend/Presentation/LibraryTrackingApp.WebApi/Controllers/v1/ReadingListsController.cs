using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/reading-lists")]
public class ReadingListsController : CustomBaseController
{
    public ReadingListsController(IMediator mediator) : base(mediator)
    {
    }
}
