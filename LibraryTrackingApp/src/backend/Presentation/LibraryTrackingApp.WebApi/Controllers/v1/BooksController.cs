namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class BooksController : BaseController
{
    public BooksController(IMediator mediator) : base(mediator)
    {
    }
}
