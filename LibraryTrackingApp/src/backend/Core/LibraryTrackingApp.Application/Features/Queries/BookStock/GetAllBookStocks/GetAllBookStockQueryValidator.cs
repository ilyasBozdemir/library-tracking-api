namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetAllBookStocks;

public class GetAllBookStockQueryValidator : AbstractValidator<GetAllBookStockQueryRequest>
{
    public GetAllBookStockQueryValidator()
    {
        RuleFor(x => x.BookId).NotEmpty().WithMessage("Kitap ID boş olamaz.");
    }
}
