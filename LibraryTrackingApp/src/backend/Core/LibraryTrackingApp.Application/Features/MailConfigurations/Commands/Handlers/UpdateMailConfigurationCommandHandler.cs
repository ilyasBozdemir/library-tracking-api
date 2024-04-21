using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Handlers;

public class UpdateMailConfigurationCommandHandler : IRequestHandler<UpdateMailConfigurationCommandRequest, UpdateMailConfigurationCommandResponse>
{
    public async Task<UpdateMailConfigurationCommandResponse> Handle(UpdateMailConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

