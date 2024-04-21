using LibraryTrackingApp.Application.Shared.Wrappers.Results;

namespace LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;

public class LoginUserCommandResponse : CommandResult
{
  public TokenDTO Token { get; set; }

}