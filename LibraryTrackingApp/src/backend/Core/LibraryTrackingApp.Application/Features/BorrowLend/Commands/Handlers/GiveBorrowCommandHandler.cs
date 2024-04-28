using System.Net;
using LibraryTrackingApp.Application.Features.BookStocks.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.BorrowLend.Commands.Handlers;

/*
 *
 *
 * request'ten gelen kitap,üye,çalışan id'leri al kontrol et.
 * kayıtlar yanlış ise geriye ilgili kayıt için hata mesajı ile dön 400 404 ile
 * kayıtlar dogru ise kitabın stok miktarına bak
 * stokta varsa ve aktifse kitap stok'tan bir azalt ve BorrowLend entity olustur
 * ve  veritabanına ekle
 *
 *
 *
 */

public class GiveBorrowCommandHandler
    : IRequestHandler<GiveBorrowCommandRequest, GiveBorrowCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public GiveBorrowCommandHandler(
        IUnitOfWork<Guid> unitOfWork,
        IMapper mapper,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<GiveBorrowCommandResponse> Handle(
        GiveBorrowCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var existingBook = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.BorrowLend>()
                .ExistsAsync(b => b.BookId == request.BookId);

            var existingMember = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Member>()
                .ExistsAsync(b => b.Id == request.MemberId);

            var existingStaff = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Staff>()
                .ExistsAsync(b => b.Id == request.LenderId);

            if (!existingBook || !existingMember || !existingStaff)
            {
                return new GiveBorrowCommandResponse
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    StateMessages = new [] { "Bazı girişler geçersiz veya eksik." }
                };
            }
            else
            {
                var stockDecreaseResponse = await _mediator.Send(
                    new StockOperationCommandRequest
                    {
                        BookId = request.BookId,
                        OperationType = StockOperationType.Decrease,
                        Quantity = 1,
                    }
                );

                if (stockDecreaseResponse.Success)
                {

                    var givenBookWriteRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.BorrowLend>();


                    var givenBook = _mapper.Map<Domain.Entities.Library.BorrowLend>(request);

                    givenBook.IsLate = givenBook.IsLate = givenBook.ReturnDate > givenBook.DueDate;
                    givenBook.BorrowStatus = BorrowStatus.Borrowed;

                    if (givenBook.ReturnDate.HasValue && givenBook.ReturnDate > givenBook.DueDate)
                    {
                        givenBook.LateDurationInDays = (int?)(givenBook.ReturnDate - givenBook.DueDate)?.TotalDays;
                    }
                    else
                    {
                        givenBook.LateDurationInDays = null;
                    }



                    var givenBookResult = await givenBookWriteRepository.AddAsync(givenBook);


                    if (givenBookResult)
                    {
                        return new GiveBorrowCommandResponse
                        {
                            StatusCode = (int)HttpStatusCode.OK,
                            Success = true,
                            StateMessages = new[] { "Kitap Başarıyla Ödünç Verildi." }
                        };
                    }
                    else
                    {
                        return new GiveBorrowCommandResponse
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Success = true,
                            StateMessages = new[] { "Kitap Ödünç Verilirken Hata Oluştu." }
                        };
                    }

                   
                }
                else
                {
                    return new GiveBorrowCommandResponse
                    {
                        StatusCode = stockDecreaseResponse.StatusCode,
                        Success = stockDecreaseResponse.Success,
                        StateMessages = stockDecreaseResponse.StateMessages
                    };
                }
            }
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new [] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
