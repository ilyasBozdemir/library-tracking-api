namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetAllBookStocks;

public class GetAllBookStockQueryRequest : IRequest<GetAllBookStockQueryResponse>
{
    public Guid BookId { get; set; }
}
