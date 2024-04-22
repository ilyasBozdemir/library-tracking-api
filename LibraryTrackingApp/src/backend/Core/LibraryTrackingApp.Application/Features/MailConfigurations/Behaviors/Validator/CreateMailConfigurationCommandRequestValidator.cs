using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Behaviors.Validator;

public class CreateMailConfigurationCommandRequestValidator : AbstractValidator<CreateMailConfigurationCommandRequest>
{
    public CreateMailConfigurationCommandRequestValidator()
    {
        RuleFor(x => x.Owner).NotEmpty();
        RuleFor(x => x.SmtpServer).NotEmpty();
        RuleFor(x => x.Port).GreaterThan(0);
        RuleFor(x => x.SenderEmail).NotEmpty().EmailAddress();
        RuleFor(x => x.SenderName).NotEmpty();
        RuleFor(x => x.Username).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
