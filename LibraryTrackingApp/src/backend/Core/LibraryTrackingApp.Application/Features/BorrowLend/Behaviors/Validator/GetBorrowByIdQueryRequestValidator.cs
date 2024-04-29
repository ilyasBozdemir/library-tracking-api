using LibraryTrackingApp.Application.Features.BorrowLend.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Behaviors.Validator;


public class GetBorrowByIdQueryRequestValidator : AbstractValidator<GetBorrowByIdQueryRequest>
{
    public GetBorrowByIdQueryRequestValidator()
    {
        RuleFor(x => x.BorrowId).NotEmpty().WithMessage("BorrowId Boş Olamaz");
    }
}
