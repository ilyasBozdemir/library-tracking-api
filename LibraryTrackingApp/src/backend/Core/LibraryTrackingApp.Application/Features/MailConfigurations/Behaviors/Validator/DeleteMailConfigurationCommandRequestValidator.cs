
using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Behaviors.Validator;

public class DeleteMailConfigurationCommandRequestValidator : AbstractValidator<DeleteMailConfigurationCommandRequest>
{
    public DeleteMailConfigurationCommandRequestValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}