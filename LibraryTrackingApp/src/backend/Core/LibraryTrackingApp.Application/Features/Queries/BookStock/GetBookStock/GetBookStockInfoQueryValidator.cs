namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetBookStock;

public class GetBookStockInfoQueryValidator : AbstractValidator<GetBookStockInfoQueryRequest>
{
    public GetBookStockInfoQueryValidator()
    {
        RuleFor(x => x.BookId).NotEmpty().WithMessage("Kitap ID boş olamaz.");
    }
}
