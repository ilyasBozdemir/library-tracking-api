using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-tags")]
public class WorkTagsControllers : CustomBaseController
{
    public WorkTagsControllers(IMediator mediator) : base(mediator)
    {
    }
}
