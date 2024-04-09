namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetBookStock;

public class GetBookStockInfoQueryRequest : IRequest<GetBookStockInfoQueryResponse>
{
    public Guid BookId { get; set; }
}
