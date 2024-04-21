using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;

public class DeleteMailConfigurationCommandRequest : IRequest<DeleteMailConfigurationCommandResponse>
{
    public Guid Id { get; set; }
}
