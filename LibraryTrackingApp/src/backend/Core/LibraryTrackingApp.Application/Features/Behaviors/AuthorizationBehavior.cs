using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace LibraryTrackingApp.Application.Features.Behaviors;

public class AuthorizationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationBehavior(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService ?? throw new ArgumentNullException(nameof(authorizationService));
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {


        //var authorizeAttributes = Attribute.GetCustomAttributes(typeof(TRequest), typeof(AuthorizeAttribute));

        //if (authorizeAttributes.Any())
        //{
        //    // Eğer isteğe [Authorize] özniteliği uygulanmışsa, yetkilendirme işlemi yap
        //    var authorizationResult = await _authorizationService.AuthorizeAsync(new ClaimsPrincipal(), request, "PolicyNameHere");

        //    if (!authorizationResult.Succeeded)
        //    {
        //        // Yetkilendirme başarısız oldu, istisna fırlat
        //        throw new UnauthorizedAccessException("Authorization failed");
        //    }
        //}



        // İsteği işleme devam et
        return await next();
    }
}
