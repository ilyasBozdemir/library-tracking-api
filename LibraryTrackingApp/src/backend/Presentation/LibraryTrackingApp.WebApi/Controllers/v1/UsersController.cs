using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Kullanıcı işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/users")]
public class UsersController : CustomBaseController
{
    public UsersController(IMediator mediator)
        : base(mediator) { }

  //Register
  //getprofile




}
