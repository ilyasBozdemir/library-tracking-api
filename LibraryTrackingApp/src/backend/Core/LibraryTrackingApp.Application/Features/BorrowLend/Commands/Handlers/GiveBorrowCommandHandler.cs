using System.Net;
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

            var inventoryBookReadRepository =
        _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkInventory>();


            var inventoryBook = await inventoryBookReadRepository.GetSingleAsync(b => b.Id == request.WorkInventoryId);



            var existingMember = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Member>()
                .ExistsAsync(b => b.Id == request.MemberId);

            var existingStaff = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Staff>()
                .ExistsAsync(b => b.Id == request.LenderId);
            //burası bir sonraki güncellemde çalısan veya yönetici şube sahibinin id'sine de eşitse de diye 
            // kontrolü yapılcak.

            List<string> invalidEntries = new List<string>();

            if (inventoryBook == null)
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


            var givenBookWriteRepository =
                _unitOfWork.GetWriteRepository<Domain.Entities.Library.BorrowLend>();

            var givenBookReadRepository =
             _unitOfWork.GetReadRepository<Domain.Entities.Library.BorrowLend>();




            var givenBook = _mapper.Map<Domain.Entities.Library.BorrowLend>(request);

            givenBook.WorkCatalogId = inventoryBook.WorkCatalogId ?? System.Guid.Empty;// empty gelmez zaten,
            givenBook.WorkInventoryId = request.WorkInventoryId;
            givenBook.MemberId= request.MemberId;

            givenBook.StaffLenderId = request.LenderId;

            var borrowedBook = await givenBookReadRepository.GetSingleAsync(
              b => b.WorkInventoryId == request.WorkInventoryId
          );

            if (borrowedBook==null)
            {
                givenBook.BorrowDate = DateTime.Now;
                givenBook.BorrowStatus = BorrowStatus.Borrowed;

                var givenBookResult = await givenBookWriteRepository.AddAsync(givenBook);
                return new()
                {
                    Success = true,
                    StatusCode = (int)HttpStatusCode.OK,
                    StateMessages = new[] { "Kitap Başarıyla Ödünç Verildi." }
                };
            }


            if (borrowedBook.BorrowStatus is BorrowStatus.Returned or BorrowStatus.DelayedReturn)
            {
                givenBook.BorrowDate = DateTime.Now;
                givenBook.BorrowStatus = BorrowStatus.Borrowed;

                var givenBookResult = await givenBookWriteRepository.AddAsync(givenBook);
            }

            // Kitap ödünç verme işlemi
            return borrowedBook.BorrowStatus switch
            {
                BorrowStatus.Returned or BorrowStatus.DelayedReturn => 
                new ()
                {
                    Success = true,
                    StatusCode = (int)HttpStatusCode.OK,
                    StateMessages = new[] { "Kitap Başarıyla Ödünç Verildi." }
                },
                BorrowStatus.Borrowed => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.Conflict,
                    StateMessages = new[] { "Kitap zaten ödünç verilmiş durumda." }
                },
                BorrowStatus.Losted => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    StateMessages = new[] { "Kitap şu an kayıp edilmiş durumda." }
                },
                BorrowStatus.Cancelled => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    StateMessages = new[] { "Kitap ödünç alma işlemi iptal edilmiş durumda." }
                },
                BorrowStatus.Expired => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    StateMessages = new[] { "Kitap ödünç alma süresi dolduğu için ödünç verilemez." }
                },
                BorrowStatus.Damaged => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    StateMessages = new[] { "Kitap hasarlı olduğu için ödünç verilemez." }
                },
                BorrowStatus.OnHold => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    StateMessages = new[] { "Kitap askıya alındığı için ödünç verilemez." }
                },

                _ => new()
                {
                    Success = false,
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    StateMessages = new[] { "Belirsiz ödünç durumu." }
                }
            };

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
