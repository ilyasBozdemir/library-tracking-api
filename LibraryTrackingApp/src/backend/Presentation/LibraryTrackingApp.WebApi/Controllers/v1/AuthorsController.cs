using LibraryTrackingApp.Application.Features.Commands.Author;
using LibraryTrackingApp.Application.Features.Events.Author;
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
            Messages = response.StateMessages.ToArray(),
            Data = response.Data,
        };

        return new JsonResult(responseValue)
        {
            StatusCode = response.StatusCode
        };
    }
}
      

