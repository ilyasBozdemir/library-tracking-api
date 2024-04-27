using LibraryTrackingApp.Application.Features.BookGenres.Commands.Requests;
using LibraryTrackingApp.Application.Features.BookGenres.Events;
using LibraryTrackingApp.Infrastructure.Mvc;
using LibraryTrackingApp.Application.Features.BookGenres.Queries.Requests;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/// <summary>
/// Kitap Tür işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-genres")]
public class BookGenresController : CustomBaseController
{
    public BookGenresController(IMediator mediator) : base(mediator)
    {
    }


    /// <summary>
    /// Yeni bir kitap için tür oluşturur.
    /// </summary>
    /// <param name="request">Tür bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookGenreCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BookGenreEvent()
            {
                Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
            IsSuccess = response.Success,
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
    /// Mevcut bir kitap türünü günceller.
    /// </summary>
    /// <param name="id">Güncellenecek türün ID'si.</param>
    /// <param name="request">Güncellenmiş yazar bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateBookGenreCommandRequest request
    )
    {
        request.UpdatedId = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookGenreEvent()
            {
                Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
            IsSuccess = response.Success,
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
    /// Bir kitabın türümü ID ile siler.
    /// </summary>
    /// <param name="Id">Silinecek türün ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] string Id)
    {
        var request = new DeleteBookGenreCommandRequest { Id = Id };
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookGenreEvent()
            {
                Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
                IsSuccessful = response.Success,
                EntityId = Id,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Deleted
            }
        );



        var responseValue = new
        {
            IsSuccess = response.Success,
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
    /// Bir türü ID ile alır.
    /// </summary>
    /// <param name="id">Alınacak türün ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBookGenre([FromRoute] Guid id)
    {
        var query = new GetBookGenreQueryRequest { BookGenreId = id };
        var response = await _mediator.Send(query);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookGenreEvent()
                {
                    Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
                IsSuccess = response.Success,
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
                new BookGenreEvent()
                {
                    Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
    /// Tüm türleri alır.
    /// </summary>
    /// <param name="request">Türleri filtrelemek için kriterleri içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllBookGenres([FromQuery] GetAllBookGenresQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookGenreEvent()
                {
                    Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
                IsSuccess = response.Success,
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
                new BookGenreEvent()
                {
                    Errors = response.Success ? Array.Empty<string>() : response.StateMessages,
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
