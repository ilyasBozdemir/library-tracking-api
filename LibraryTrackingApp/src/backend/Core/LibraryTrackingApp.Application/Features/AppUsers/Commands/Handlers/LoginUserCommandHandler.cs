using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.Services;

namespace LibraryTrackingApp.Application.Features.AppUsers.Commands.Handlers;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
    readonly IAuthService _authService;
    public LoginUserCommandHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        var token = await _authService.LoginAsync(request.UsernameOrEmail, request.Password, 900);

        return new LoginUserCommandResponse()
        {
            Token = token,
            Success = true,
            StatusCode = 200
        };
    }
}
