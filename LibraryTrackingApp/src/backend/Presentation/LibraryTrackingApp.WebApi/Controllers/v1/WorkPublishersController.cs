using LibraryTrackingApp.Infrastructure.Mvc;
using LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkPublishers.Queries.Requests;
using LibraryTrackingApp.Application.Features.WorkPublishers.Events;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Eser yayınevi işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/work-publishers")]
public class WorkPublishersController : CustomBaseController
{
    public WorkPublishersController(IMediator mediator) : base(mediator)
    {
    }


    /// <summary>
    /// Yeni bir eser için yayınevi oluşturur.
    /// </summary>
    /// <param name="request">yayınevi bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookPublisherCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new BookPublisherEvent()
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
    /// Mevcut bir eser yayınevini günceller.
    /// </summary>
    /// <param name="id">Güncellenecek yayıneviün ID'si.</param>
    /// <param name="request">Güncellenmiş yazar bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateBookPublisherCommandRequest request
    )
    {
        request.UpdatedId = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookPublisherEvent()
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
    /// Bir eserin yayınevini ID ile siler.
    /// </summary>
    /// <param name="Id">Silinecek yayıneviün ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] string Id)
    {
        var request = new DeleteBookPublisherCommandRequest { Id = Id };
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new BookPublisherEvent()
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
    /// Bir yayınevini ID ile alır.
    /// </summary>
    /// <param name="id">Alınacak yayınevin ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBookPublisher([FromRoute] Guid id)
    {
        var query = new GetBookPublisherQueryRequest { BookPublisherId = id };
        var response = await _mediator.Send(query);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookPublisherEvent()
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
                new BookPublisherEvent()
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
    /// Tüm yayınevileri alır.
    /// </summary>
    /// <param name="request">yayınevleri filtrelemek için kriterleri içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllBookPublishers([FromQuery] GetAllBookPublishersQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new BookPublisherEvent()
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
                new BookPublisherEvent()
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
