using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;
using LibraryTrackingApp.Infrastructure.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Yönetici işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/auths")]
public class AuthsController : CustomBaseController
{
    public AuthsController(IMediator mediator)
        : base(mediator) { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("create-user")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
    {
        CreateUserCommandResponse response = await _mediator.Send(request);

        var responseValue = new
        {
            IsSucces = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }


    /// <summary>
    /// Kullanıcıyı kimlik doğrulaması için HTTP POST isteğini işler.
    /// </summary>
    /// <param name="loginUserCommandRequest">Kullanıcı kimlik bilgilerini içeren giriş kullanıcı komut isteği.</param>
    /// <returns>
    /// Başarılı ise kimlik doğrulama belirteciyle birlikte JSON sonucu döndürür,
    /// ilgili durum kodunu içerir.
    /// </returns>

    [HttpPost("login")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
    {
        LoginUserCommandResponse commandResponse = await _mediator.Send(loginUserCommandRequest);

        return new JsonResult(new { data = commandResponse.Token })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

   



    //refresh token login 
    //logout
    //two factor enable
    //reset password
    //forgot password
    //confirm contact
    //roles
    //permissions
    //user roles- permissions
    //assign-role
    //aissgn-permission
    //set-account-state
    //

}
