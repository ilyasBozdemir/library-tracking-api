using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;
using LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Requests;
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
    /// Kullanıcı oluşturma isteği alır ve işler.
    /// </summary>
    /// <param name="request">Oluşturulacak kullanıcının bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlem sonucunu ve gerekirse ek bilgileri içeren JSON yanıtı.</returns>

    [HttpPost("create-user")]
    [AllowAnonymous]
    public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
    {
        CreateUserCommandResponse response = await _mediator.Send(request);

        var responseValue = new
        {
            IsSuccess = response.Success,
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
    public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
    {
        LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }



    // hata veriyor burası buraya gelmeden düzeltilcektir

    /// <summary>
    /// Verilen e-posta adresinin veritabanında var olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="query">Kontrol edilecek e-posta adresi veya username alır.</param>
    /// <returns>E-posta adresi zaten varsa true, yoksa false döner.</returns>
    [HttpPost("check-user-existence")]
    [AllowAnonymous]

    public async Task<IActionResult> CheckUserExistence( CheckUserExistenceQueryRequest request)
    {
        var response = await _mediator.Send(request);
        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            StatusResult = response.StatusResult,
        };

        return new JsonResult(responseValue)
        {
            StatusCode = response.StatusCode
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
