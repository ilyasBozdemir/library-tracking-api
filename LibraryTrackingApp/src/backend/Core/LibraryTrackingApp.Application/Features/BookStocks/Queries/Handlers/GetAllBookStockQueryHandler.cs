using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Handlers;

public class GetAllBookStocksQueryHandler : IRequestHandler<GetAllBookStockQueryRequest, GetAllBookStockQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public GetAllBookStocksQueryHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }
    public async Task<GetAllBookStockQueryResponse> Handle(GetAllBookStockQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            return new() { };
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new[] { $"Bir hata oluştu: {ex.Message}" }

            };
        }
    }
}
