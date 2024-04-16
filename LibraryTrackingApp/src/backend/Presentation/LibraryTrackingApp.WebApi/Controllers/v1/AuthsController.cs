using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/// <summary>
/// Yönetici işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/admin")]
public class AuthsController : CustomBaseController
{
    public AuthsController(IMediator mediator) : base(mediator)
    {
    }

    //[HttpGet]
    //public async Task<IActionResult> Index()
    //{
    //    return Ok();
    //}
}
      

