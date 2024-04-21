
using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;

public class CreateJwtConfigurationCommandRequest : IRequest<CreateJwtConfigurationCommandResponse>
{
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public int AccessTokenExpirationMinutes { get; set; }
}
