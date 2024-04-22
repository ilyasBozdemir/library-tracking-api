using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Handlers;

public class CreateJwtConfigurationCommandHandler : IRequestHandler<CreateJwtConfigurationCommandRequest, CreateJwtConfigurationCommandResponse>
{
    public Task<CreateJwtConfigurationCommandResponse> Handle(CreateJwtConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}