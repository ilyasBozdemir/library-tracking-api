using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;

namespace LibraryTrackingApp.Application.Features.BookStocks.Behaviors.Validator;

public class GetAllBookStockQueryValidator : AbstractValidator<GetAllBookStockQueryRequest>
{
    public GetAllBookStockQueryValidator()
    {
        RuleFor(x => x.BookId).NotEmpty().WithMessage("Kitap ID boş olamaz.");
    }
}
