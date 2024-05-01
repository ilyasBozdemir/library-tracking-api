using System.Net;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Handlers;

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


    // hata durumlarında geri almak için RollbackAsync olayları da yapılcaktır daha.
    public async Task<TakeBorrowCommandResponse> Handle(
        TakeBorrowCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var givenBookWriteRepository =
                _unitOfWork.GetWriteRepository<Domain.Entities.Library.BorrowLend>();

            var givenBookReadRepository =
                _unitOfWork.GetReadRepository<Domain.Entities.Library.BorrowLend>();

            var borrowedBook = await givenBookReadRepository.GetSingleAsync(
                b => b.WorkInventoryId == request.WorkInventoryId
            );

            if (borrowedBook == null)
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new[] { "Ödünç Kitap Bulunamadı." }
                };

            if (borrowedBook.BorrowStatus == BorrowStatus.Returned || borrowedBook.BorrowStatus == BorrowStatus.DelayedReturn)
                return new()
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    StateMessages = new[] { "Kitap zaten iade edilmiş durumda." }
                };

            //

            borrowedBook.ReturnDate = DateTime.Now;

            borrowedBook.BorrowStatus = BorrowStatus.Returned;

            if (borrowedBook.ReturnDate.HasValue && borrowedBook.ReturnDate > borrowedBook.DueDate)
            {
                borrowedBook.LateDurationInDays = (int?)
                    (borrowedBook.ReturnDate - borrowedBook.DueDate)?.TotalDays;

                borrowedBook.BorrowStatus = BorrowStatus.DelayedReturn;
            }
            else
            {
                borrowedBook.LateDurationInDays = 0;
            }

            var givenBookResult = await givenBookWriteRepository.UpdateAsync(borrowedBook);

            return new()
            {
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
                StateMessages = new[] { "Kitap İade Alındı." }
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
