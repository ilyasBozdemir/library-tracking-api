using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
{
    public string UsernameOrEmail { get; set; }
    public string Password { get; set; }
}
