using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Handlers;

public class ReportDamageBookCommandHandler
    : IRequestHandler<ReportDamageBookCommandRequest, ReportDamageBookCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public ReportDamageBookCommandHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<ReportDamageBookCommandResponse> Handle(
        ReportDamageBookCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        var response = new ReportDamageBookCommandResponse
        {
            StatusCode = 200,
            Success = true,
            StateMessages = new string[] { "Hasar raporu başarıyla oluşturuldu." }
        };

        return response;
    }
}
