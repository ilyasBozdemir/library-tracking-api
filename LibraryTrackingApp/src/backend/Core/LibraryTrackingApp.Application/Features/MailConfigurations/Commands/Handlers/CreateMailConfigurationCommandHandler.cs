using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Handlers;

public class CreateMailConfigurationCommandHandler : IRequestHandler<CreateMailConfigurationCommandRequest, CreateMailConfigurationCommandResponse>
{

    public async Task<CreateMailConfigurationCommandResponse> Handle(CreateMailConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
