using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Handlers;

public class UpdateJwtConfigurationCommandHandler : IRequestHandler<UpdateJwtConfigurationCommandRequest, UpdateJwtConfigurationCommandResponse>
{
    public Task<UpdateJwtConfigurationCommandResponse> Handle(UpdateJwtConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
