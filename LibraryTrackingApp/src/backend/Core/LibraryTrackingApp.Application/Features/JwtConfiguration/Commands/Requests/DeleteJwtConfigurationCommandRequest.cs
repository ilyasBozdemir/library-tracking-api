using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;

public class DeleteJwtConfigurationCommandRequest : IRequest<DeleteJwtConfigurationCommandResponse>
{
    public Guid JwtSettingsId { get; set; }
}

