using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Handlers;

public class DeleteMailConfigurationCommandHandler : IRequestHandler<DeleteMailConfigurationCommandRequest, DeleteMailConfigurationCommandResponse>
{
    public async Task<DeleteMailConfigurationCommandResponse> Handle(DeleteMailConfigurationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
