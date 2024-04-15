using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Handlers;

public class GetAllBookStocksQueryHandler : IRequestHandler<GetAllBookStockQueryRequest, GetAllBookStockQueryResponse>
{
    public Task<GetAllBookStockQueryResponse> Handle(GetAllBookStockQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
