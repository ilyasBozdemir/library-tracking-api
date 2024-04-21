using LibraryTrackingApp.Application.Features.Books.Commands.Requests;
using LibraryTrackingApp.Application.Features.Books.Events;
using LibraryTrackingApp.Application.Features.Books.Queries.Requests;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Kitapları yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class BooksController : CustomBaseController
{
    public BooksController(IMediator mediator)
        : base(mediator) { }

    /// <summary>
    /// Yeni bir kitap oluşturur.
    /// </summary>
    /// <param name="request">Kitap bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BookCommandEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Created
            }
        );



        var responseValue = new
        {
            IsSucces = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue)
        {
            StatusCode = response.StatusCode
        };
    }



    /// <summary>
    /// Mevcut bir kitabı günceller.
    /// </summary>
    /// <param name="id">Güncellenecek kitabın ID'si.</param>
    /// <param name="request">Güncellenmiş kitap bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateBookCommandRequest request
    )
    {
        request.Id = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookCommandEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                EntityId = id.ToString(),
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Updated
            }
        );



        var responseValue = new
        {
            IsSucces = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue)
        {
            StatusCode = response.StatusCode
        };
    }



    /// <summary>
    /// Bir kitabı ID veya ISBN ile siler.
    /// </summary>
    /// <param name="IdOrISBN">Silinecek kitabın ID'si veya ISBN'i.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpDelete("{IdOrISBN}")]
    public async Task<IActionResult> Delete([FromRoute] string IdOrISBN)
    {
        var request = new DeleteBookCommandRequest { IdOrISBN = IdOrISBN };
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookCommandEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                EntityId = IdOrISBN,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Deleted
            }
        );



        var responseValue = new
        {
            IsSucces = response.Success,
            StatusCode = response.StatusCode,
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue)
        {
            StatusCode = response.StatusCode
        };
    }



    /// <summary>
    /// Verilen kitabı ödünç almak için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="bookId">Ödünç alınacak kitabın ID'si.</param>
    /// <param name="memberId">Ödünç alan üyenin ID'si.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("borrow/{bookId}")]
    public async Task<IActionResult> BorrowBook([FromRoute] Guid bookId, [FromRoute] Guid memberId)
    {
        return Ok();
    }


    /// <summary>
    /// Belirli bir kitabı iade etmek için istemciden gelen isteği işler.
    /// </summary>
    /// <param name="bookId">İade edilecek kitabın ID'si.</param>
    /// <returns>
    /// 200 OK cevabı, işlem başarılı ise;
    /// 404 Not Found cevabı, kitap bulunamadığı durumda;
    /// 400 Bad Request cevabı, geçersiz kitap işlemi durumunda;
    /// 500 Internal Server Error cevabı, bir hata oluştuğunda.
    /// </returns>
    [HttpPost("return/{bookId}")]
    public async Task<IActionResult> ReturnBook([FromRoute] Guid bookId)
    {
        return Ok();
    }



    /// <summary>
    /// Bir kitabı ID ile alır.
    /// </summary>
    /// <param name="id">Alınacak kitabın ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBook([FromRoute] Guid id)
    {
        var query = new GetBookQueryRequest { BookId = id };
        var response = await _mediator.Send(query);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Success ? null : response.StateMessages,
                    IsSuccessful = response.Success,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .FetchedSingle
                }
            );




            var responseValue = new
            {
                IsSucces = response.Success,
                StatusCode = response.StatusCode,
                Messages = response.StateMessages.ToArray(),
                Data = response.Data,
            };

            return new JsonResult(responseValue)
            {
                StatusCode = response.StatusCode
            };
        }
        else
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Success ? null : response.StateMessages,
                    IsSuccessful = false,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .FetchedSingle
                }
            );
            return NotFound();
        }
    }




    /// <summary>
    /// Tüm kitapları alır.
    /// </summary>
    /// <param name="request">Kitapları filtrelemek için kriterleri içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllBooks([FromBody] GetAllBooksQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Success ? null : response.StateMessages,
                    IsSuccessful = response.Success,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .FetchedAll
                }
            );



            var responseValue = new
            {
                IsSucces = response.Success,
                StatusCode = response.StatusCode,
                Messages = response.StateMessages.ToArray(),
                Data = response.Data,
            };

            return new JsonResult(responseValue)
            {
                StatusCode = response.StatusCode
            };
        }
        else
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Success ? null : response.StateMessages,
                    IsSuccessful = false,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .FetchedAll
                }
            );
            return NotFound();
        }
    }
}
