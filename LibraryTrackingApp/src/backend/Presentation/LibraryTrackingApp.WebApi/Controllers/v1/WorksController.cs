using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkInventories.Events;
using LibraryTrackingApp.Application.Features.WorkInventories.Queries.Requests;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Kitapları yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/works")]
public class WorksController : CustomBaseController
{
    public WorksController(IMediator mediator)
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
