using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Handlers;

public class GetBookStockInfoQueryHandler : IRequestHandler<GetBookStockInfoQueryRequest, GetBookStockInfoQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;

    public GetBookStockInfoQueryHandler(IUnitOfWork<Guid> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Task<GetBookStockInfoQueryResponse> Handle(GetBookStockInfoQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
