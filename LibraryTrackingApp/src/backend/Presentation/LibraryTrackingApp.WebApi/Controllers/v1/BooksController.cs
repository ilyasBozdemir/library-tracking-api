using LibraryTrackingApp.Application.Features.Events.Book;
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
                Errors = response.Errors,
                IsSuccessful = response.Success,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Create
            }
        );
        return Ok(response);
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
                Errors = response.Errors,
                IsSuccessful = response.Success,
                EntityId = id.ToString(),
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Update
            }
        );
        return Ok(response);
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
                Errors = response.Errors,
                IsSuccessful = response.Success,
                EntityId = IdOrISBN,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Delete
            }
        );
        return Ok(response);
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
                    Errors = response.Errors,
                    IsSuccessful = response.Success,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .Get
                }
            );
            return Ok(response.Data);
        }
        else
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Errors,
                    IsSuccessful = false,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .Get
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
                    Errors = response.Errors,
                    IsSuccessful = response.Success,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .GetAll
                }
            );
            return Ok(response.Data);
        }
        else
        {
            await _mediator.Publish(
                new BookCommandEvent()
                {
                    Errors = response.Errors,
                    IsSuccessful = false,
                    RequestNotificationType = LibraryTrackingApp
                        .Domain
                        .Enums
                        .RequestNotificationType
                        .GetAll
                }
            );
            return NotFound();
        }
    }
}
