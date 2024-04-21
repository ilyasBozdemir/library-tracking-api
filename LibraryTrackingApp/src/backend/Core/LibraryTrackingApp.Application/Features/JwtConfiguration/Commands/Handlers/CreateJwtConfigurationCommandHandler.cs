using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Handlers;

public class CreateJwtConfigurationCommandHandler : IRequestHandler<CreateJwtConfigurationCommandRequest, CreateJwtConfigurationCommandResponse>
{
    public Task<CreateJwtConfigurationCommandResponse> Handle(CreateJwtConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}