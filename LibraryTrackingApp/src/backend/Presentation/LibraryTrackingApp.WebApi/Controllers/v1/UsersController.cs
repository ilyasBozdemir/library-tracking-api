using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;
using LibraryTrackingApp.Infrastructure.Mvc;
using Microsoft.AspNetCore.Authorization;

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

    [HttpPost("create-user")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateUser(CreateUserCommandRequest registerUserCommandRequest)
    {
        CreateUserCommandResponse response = await _mediator.Send(registerUserCommandRequest);

        var responseValue = new
        {
            IsSucces = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

}
