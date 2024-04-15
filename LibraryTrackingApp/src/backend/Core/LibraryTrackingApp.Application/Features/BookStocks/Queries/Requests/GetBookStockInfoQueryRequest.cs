using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;

public class GetBookStockInfoQueryRequest : IRequest<GetBookStockInfoQueryResponse>
{
    public Guid BookId { get; set; }
}
