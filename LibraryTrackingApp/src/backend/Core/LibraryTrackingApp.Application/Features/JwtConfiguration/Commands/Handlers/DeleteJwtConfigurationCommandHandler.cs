using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Handlers;

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
