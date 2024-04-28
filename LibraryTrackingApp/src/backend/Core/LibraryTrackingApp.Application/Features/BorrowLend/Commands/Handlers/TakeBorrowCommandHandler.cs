using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Handlers;

/*
 *
 *
 *
 *
 *
 *
 */

public class TakeBorrowCommandHandler
    : IRequestHandler<TakeBorrowCommandRequest, TakeBorrowCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public TakeBorrowCommandHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<TakeBorrowCommandResponse> Handle(
        TakeBorrowCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: " }
            };
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
