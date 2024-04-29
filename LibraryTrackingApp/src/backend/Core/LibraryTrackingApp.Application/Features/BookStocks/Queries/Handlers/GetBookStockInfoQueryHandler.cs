using LibraryTrackingApp.Application.Features.BookStocks.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookStocks.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BookStocks.Queries.Handlers;

public class GetBookStockInfoQueryHandler : IRequestHandler<GetBookStockInfoQueryRequest, GetBookStockInfoQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public GetBookStockInfoQueryHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }
    public async Task<GetBookStockInfoQueryResponse> Handle(GetBookStockInfoQueryRequest request, CancellationToken cancellationToken)
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
