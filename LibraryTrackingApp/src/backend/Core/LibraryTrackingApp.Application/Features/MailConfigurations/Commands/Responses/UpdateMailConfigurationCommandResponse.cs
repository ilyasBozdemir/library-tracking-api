using LibraryTrackingApp.Application.Shared.Wrappers.Results;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;

public class UpdateMailConfigurationCommandResponse : CommandResult
{
    public Guid Id { get; set; }
}
