using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-borrows")]
public class BorrowBooksController : CustomBaseController
{
    public BorrowBooksController(IMediator mediator) : base(mediator)
    {
    }
}
