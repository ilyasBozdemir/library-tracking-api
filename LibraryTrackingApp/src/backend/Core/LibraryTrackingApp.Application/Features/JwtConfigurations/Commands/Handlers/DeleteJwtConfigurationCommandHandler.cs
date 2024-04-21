using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Commands.Handlers;

public class DeleteJwtConfigurationCommandHandler : IRequestHandler<DeleteJwtConfigurationCommandRequest, DeleteJwtConfigurationCommandResponse>
{
    public async Task<DeleteJwtConfigurationCommandResponse> Handle(DeleteJwtConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        //yazılcaktır daha sonra
        return new DeleteJwtConfigurationCommandResponse()
        {
            Data = request.JwtSettingsId
        };
    }
}
