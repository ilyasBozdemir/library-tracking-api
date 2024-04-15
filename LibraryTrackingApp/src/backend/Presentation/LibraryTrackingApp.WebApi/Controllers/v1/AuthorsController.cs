using LibraryTrackingApp.Application.Features.Authors.Commands.Requests;
using LibraryTrackingApp.Application.Features.Authors.Events;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;


/// <summary>
/// Yazar işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/authors")]
public class AuthorsController : CustomBaseController
{
    public AuthorsController(IMediator mediator) : base(mediator)
    {

    }


    /// <summary>
    /// Yeni bir yazar oluşturur.
    /// </summary>
    /// <param name="request">Yazar bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAuthorCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(
            new AuthorCommandEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Create
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
    /// Mevcut bir yazarı günceller.
    /// </summary>
    /// <param name="id">Güncellenecek yazarın ID'si.</param>
    /// <param name="request">Güncellenmiş yazar bilgilerini içeren istek nesnesi.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateAuthorCommandRequest request
    )
    {
        request.UpdatedId = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(
            new AuthorCommandEvent()
            {
                Errors = response.Success ? null : response.StateMessages,
                IsSuccessful = response.Success,
                EntityId = id.ToString(),
                RequestNotificationType = LibraryTrackingApp
                    .Domain
                    .Enums
                    .RequestNotificationType
                    .Update
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
}
      

