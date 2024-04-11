using LibraryTrackingApp.Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using LibraryTrackingApp.Application.Features.Results;

namespace LibraryTrackingApp.Infrastructure.Mvc;


[ApiVersion(ApiVersions.V1)]
[ApiController]
public class CustomBaseController : ControllerBase
{
    protected readonly IMediator _mediator;
    public CustomBaseController(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected async Task<IActionResult> HandleCommand<T>(IRequest<CommandResult<T>> request)//testing
    {
        var result = await _mediator.Send(request);

        return new JsonResult(new { data = result.Data })
        {
            StatusCode = result.StatusCode
        };
    }

    protected async Task<IActionResult> HandleQuery<T>(IRequest<QueryResult<T>> request)//testing
    {
        var result = await _mediator.Send(request);

        return new JsonResult(new { data = result.Data })
        {
            StatusCode = result.StatusCode
        };
    }
}