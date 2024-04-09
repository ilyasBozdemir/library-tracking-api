
namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetAllBookStocks;

public class GetAllBookStocksQueryHandler : IRequestHandler<GetAllBookStockQueryRequest, GetAllBookStockQueryResponse>
{
    public Task<GetAllBookStockQueryResponse> Handle(GetAllBookStockQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
