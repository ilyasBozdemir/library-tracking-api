using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Events;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

/// <summary>
/// Kütüphane şubeleriyle ilgili işlemleri yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/libraries")]
public class LibraryBranchesController : CustomBaseController
{
    public LibraryBranchesController(IMediator mediator)
        : base(mediator) { }

    /// <summary>
    /// Yeni bir kütüphane şubesi oluşturur.
    /// </summary>
    /// <param name="request">Kütüphane şubelerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateLibraryBranchCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new LibraryBranchCommandEvent()
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

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

    /// <summary>
    /// Mevcut bir kütüphane şubesini günceller.
    /// </summary>
    /// <param name="id">Güncellenecek yazarın ID'si.</param>
    /// <param name="request">Güncellenmiş yazar bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateLibraryBranchCommandRequest request
    )
    {
        request.UpdatedId = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new LibraryBranchCommandEvent()
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

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

    /// <summary>
    /// Bir kütüphane şubesini ID ile siler.
    /// </summary>
    /// <param name="Id">Silinecek yazarın ID'si veya ISBN'i.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] string Id)
    {
        var request = new DeleteLibraryBranchCommandRequest { Id = Id };
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new LibraryBranchCommandEvent()
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

        return new JsonResult(responseValue) { StatusCode = response.StatusCode };
    }

    /// <summary>
    /// Bir kütüphane şubesini ID ile alır.
    /// </summary>
    /// <param name="id">Alınacak yazarın ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetLibraryBranch([FromRoute] Guid id)
    {
        var query = new GetLibraryBranchQueryRequest { LibraryBranchId = id };
        var response = await _mediator.Send(query);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new LibraryBranchCommandEvent()
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

            return new JsonResult(responseValue) { StatusCode = response.StatusCode };
        }
        else
        {
            await _mediator.Publish(
                new LibraryBranchCommandEvent()
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
    /// Tüm kütüphane şubelerini alır.
    /// </summary>
    /// <param name="request">Yazarları filtrelemek için kriterleri içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllGetLibraryBranches([FromQuery] GetAllLibraryBranchesQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(
                new LibraryBranchCommandEvent()
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

            return new JsonResult(responseValue) { StatusCode = response.StatusCode };
        }
        else
        {
            await _mediator.Publish(
                new LibraryBranchCommandEvent()
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
