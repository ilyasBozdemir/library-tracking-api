using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Requests;

public class DeleteJwtConfigurationCommandRequest : IRequest<DeleteJwtConfigurationCommandResponse>
{
    public Guid JwtSettingsId { get; set; }
}

