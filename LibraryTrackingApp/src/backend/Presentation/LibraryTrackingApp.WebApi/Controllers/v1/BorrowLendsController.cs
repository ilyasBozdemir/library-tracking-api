using LibraryTrackingApp.Application.Features.BorrowLend.Commands.Requests;
using LibraryTrackingApp.Application.Features.BorrowLend.Events;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/*
 
daha saglıklı kitap takibi için,
bookstock entity'si kaldırılcaktır.
yerine bookentry gelicektir.
 
ve fiş girer gibi tek tek kayıt girilcektir.

 */

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/borrow-lends")]
public class BorrowLendsController : CustomBaseController
{
    public BorrowLendsController(IMediator mediator)
        : base(mediator) { }

    /// <summary>
    /// Verilen kitabı ödünç almak için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="request">Ödünç alınacak kitabın request nesnesi.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("give")]
    public async Task<IActionResult> GiveBook([FromBody] GiveBorrowCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BorrowLendEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                BorrowLendType = LibraryTrackingApp.Domain.Enums.BorrowLendType.Given
            }
        );

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

    /// <summary>
    /// Belirli bir kitabı iade etmek için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="request">İade edilecek kitabın request nesnesi.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("take")]
    public async Task<IActionResult> TakeBook([FromBody] TakeBorrowCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BorrowLendEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                BorrowLendType = LibraryTrackingApp.Domain.Enums.BorrowLendType.Taken
            }
        );

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }


    /// <summary>
    /// Kitabın ödünç süresini uzatmak için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="request">Ödünç süresi uzatılacak kitabın request nesnesi.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("renew")]
    public async Task<IActionResult> RenewBook([FromBody] RenewBorrowCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BorrowLendEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                BorrowLendType = LibraryTrackingApp.Domain.Enums.BorrowLendType.Renewed
            }
        );

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }



    /// <summary>
    /// Hasarlı kitap durumunu bildirmek için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="request">Hasarlı kitabın request nesnesi.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("report-damage")]
    public async Task<IActionResult> ReportDamage([FromBody] ReportDamageBookCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BorrowLendEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                BorrowLendType = LibraryTrackingApp.Domain.Enums.BorrowLendType.Damaged
            }
        );

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }


    /// <summary>
    /// Kayıp kitap durumunu bildirmek için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="request">Kayıp kitabın request nesnesi.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("report-loss")]
    public async Task<IActionResult> ReportLoss([FromBody] ReportLossBookCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BorrowLendEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                BorrowLendType = LibraryTrackingApp.Domain.Enums.BorrowLendType.Lost
            }
        );

        var responseValue = new
        {
            IsSuccess = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

    /// <summary>
    /// Belirli bir ödünç işlemi ID'sine göre ödünç işleminin detaylarını getirir.
    /// </summary>
    /// <param name="borrowId">Ödünç işlemi ID'si.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, ödünç işlemi bulunamadığı durumda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpGet("borrow/{borrowId}")]
    public async Task<IActionResult> GetBorrowById(Guid borrowId)
    {
        //eklencek daha
        return Ok();
    }

    /// <summary>
    /// Tüm ödünç işlemlerini sayfalama ile getirir.
    /// </summary>
    /// <param name="pageIndex">Sayfa indeksi.</param>
    /// <param name="pageSize">Sayfa boyutu.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpGet("borrows")]
    public async Task<IActionResult> GetAllBorrows()
    {
        //eklencek daha
        return Ok();
    }
}
