using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;

public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
{

    public string Username { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string TelNumber { get; set; }
    public string Email { get; set; }

    public string Password { get; set; }
}