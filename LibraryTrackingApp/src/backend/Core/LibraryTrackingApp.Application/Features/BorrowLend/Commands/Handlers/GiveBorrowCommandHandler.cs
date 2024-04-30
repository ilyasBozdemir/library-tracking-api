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

    /*
     *
     * Burda aslında library kısmını kiracı başına veritabanı yapılırdı.
     * istek atılan header içinde daha sonrasında library id de verilir header'dan da o alınır.
     * güncellemek isteyen kullanıcının böylece yetkisi kontrol edilir.
     *
     */

    /*
     *
     * ve de IUnitOfWork içinde BeginTransactionAsync, RollbackAsync, CommitAsync ve SaveAsync
     * bunlar da kullanılcaktır. BeginTransactionAsync kısmında birtakım hata oldugu için su anlık askıya aldım.
     * bunlar da kulllanılarak hata olunca rollback yapılcak.
     *
     */


    /*
     *
     * NOT: stok durumlarını işe ona göre de ,
     * hata mesajlarını response mesajlarını  ayarla
     *
     *
     */

    //  seed data ile olusan   bookid, memberid,lenderid gibi dataları alıp bu handleri test edebilirsiniz.

    public async Task<GiveBorrowCommandResponse> Handle(
        GiveBorrowCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var existingBook = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.WorkCatalog>()
                .ExistsAsync(b => b.Id == request.BookId);

            var existingMember = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Member>()
                .ExistsAsync(b => b.Id == request.MemberId);

            var existingStaff = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Staff>()
                .ExistsAsync(b => b.Id == request.LenderId);


            List<string> invalidEntries = new List<string>();

            if (!existingBook)
                invalidEntries.Add("Kitap");
           

            if (!existingMember)
                invalidEntries.Add("Üye");
            

            if (!existingStaff)
                invalidEntries.Add("Personel");


            if (invalidEntries.Any())
            {
                string errorMessage = $"Geçersiz veya eksik girişler: {string.Join(", ", invalidEntries)}.";

                return new()
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    StateMessages = new[] { errorMessage }
                };
            }

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
                var givenBookWriteRepository =
                    _unitOfWork.GetWriteRepository<Domain.Entities.Library.BorrowLend>();

                var givenBook = _mapper.Map<Domain.Entities.Library.BorrowLend>(request);

                givenBook.BorrowDate = DateTime.Now;

                givenBook.IsLate = givenBook.IsLate = givenBook.ReturnDate > givenBook.DueDate;
                givenBook.BorrowStatus = BorrowStatus.Borrowed;

                var givenBookResult = await givenBookWriteRepository.AddAsync(givenBook);

                if (givenBookResult)
                {
                    return new()
                    {
                        StatusCode = (int)HttpStatusCode.OK,
                        Success = true,
                        StateMessages = new[] { "Kitap Başarıyla Ödünç Verildi." }
                    };
                }
                else
                {
                    return new()
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest,
                        Success = true,
                        StateMessages = new[] { "Kitap Ödünç Verilirken Hata Oluştu." }
                    };
                }
            }
            else
            {
                return new()
                {
                    StatusCode = stockDecreaseResponse.StatusCode,
                    Success = stockDecreaseResponse.Success,
                    StateMessages = stockDecreaseResponse.StateMessages
                };
            }
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
