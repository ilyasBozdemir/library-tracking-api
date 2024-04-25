using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-returns")]
public class BookReturnsController : CustomBaseController
{
    public BookReturnsController(IMediator mediator) : base(mediator)
    {
    }
}
