using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/favorite-lists")]
public class FavoriteListsController : CustomBaseController
{
    public FavoriteListsController(IMediator mediator) : base(mediator)
    {
    }
}
