using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-genres")]
public class BookGenresController : CustomBaseController
{
    public BookGenresController(IMediator mediator) : base(mediator)
    {
    }
}
