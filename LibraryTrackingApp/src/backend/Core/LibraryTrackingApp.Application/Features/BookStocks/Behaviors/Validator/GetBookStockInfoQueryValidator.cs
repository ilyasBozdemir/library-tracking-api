using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.BookStocks.Behaviors.Validator;

public class GetBookStockInfoQueryValidator : AbstractValidator<GetBookStockInfoQueryRequest>
{
    public GetBookStockInfoQueryValidator()
    {
        RuleFor(x => x.BookId).NotEmpty().WithMessage("Kitap ID boş olamaz.");
    }
}
