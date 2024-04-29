using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;


namespace LibraryTrackingApp.Application.Features.BorrowLend.Behaviors.Validator;


public class RenewBorrowCommandRequestValidator : AbstractValidator<RenewBorrowCommandRequest>
{
    public RenewBorrowCommandRequestValidator()
    {
        RuleFor(x => x.BorrowId).NotEmpty().WithMessage("BorrowId boş olamaz.");
        RuleFor(x => x.RenewalDurationInDays).NotEmpty().GreaterThan(0).WithMessage("Yenileme süresi boş olamaz ve 0'dan büyük olmalıdır.");
    }
}