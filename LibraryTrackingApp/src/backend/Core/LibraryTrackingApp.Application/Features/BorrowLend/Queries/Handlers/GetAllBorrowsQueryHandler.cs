using LibraryTrackingApp.Application.Features.BorrowLend.Queries.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Queries.Handlers;

public class GetAllBorrowsQueryHandler : IRequestHandler<GetAllBorrowsQueryRequest, GetAllBorrowsQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public GetAllBorrowsQueryHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<GetAllBorrowsQueryResponse> Handle(GetAllBorrowsQueryRequest request, CancellationToken cancellationToken)
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