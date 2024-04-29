using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;


namespace LibraryTrackingApp.Application.Features.BorrowLend.Behaviors.Validator;

public class ReportDamageBookCommandRequestValidator : AbstractValidator<ReportDamageBookCommandRequest>
{
    public ReportDamageBookCommandRequestValidator()
    {
        RuleFor(x => x.BorrowId).NotEmpty().WithMessage("BorrowId boş olamaz.");
        RuleFor(x => x.DamageDescription).NotEmpty().WithMessage("Hasar açıklaması boş olamaz.");
    }
}