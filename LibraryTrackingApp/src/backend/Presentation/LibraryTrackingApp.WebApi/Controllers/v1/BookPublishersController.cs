using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-publishers")]
public class BookPublishersController : CustomBaseController   
{
    public BookPublishersController(IMediator mediator) : base(mediator)
    {
    }
}
