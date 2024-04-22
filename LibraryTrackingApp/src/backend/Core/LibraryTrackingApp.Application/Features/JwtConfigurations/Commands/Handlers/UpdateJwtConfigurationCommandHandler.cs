using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Handlers;

public class UpdateJwtConfigurationCommandHandler : IRequestHandler<UpdateJwtConfigurationCommandRequest, UpdateJwtConfigurationCommandResponse>
{
    public Task<UpdateJwtConfigurationCommandResponse> Handle(UpdateJwtConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
