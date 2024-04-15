using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;

public class GetAllBookStockQueryRequest : IRequest<GetAllBookStockQueryResponse>
{
    public Guid BookId { get; set; }
}
