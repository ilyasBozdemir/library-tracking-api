using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Handlers;

public class RenewBorrowCommandHandler
    : IRequestHandler<RenewBorrowCommandRequest, RenewBorrowCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public RenewBorrowCommandHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }

    //yazılcak daha burası

    public async Task<RenewBorrowCommandResponse> Handle(
        RenewBorrowCommandRequest request,
        CancellationToken cancellationToken
    )
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
