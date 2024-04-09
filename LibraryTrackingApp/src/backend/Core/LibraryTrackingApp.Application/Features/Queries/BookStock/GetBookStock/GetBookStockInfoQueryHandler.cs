
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Queries.BookStock.GetBookStock;

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
