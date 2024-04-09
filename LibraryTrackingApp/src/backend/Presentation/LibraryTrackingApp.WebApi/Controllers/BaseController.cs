namespace LibraryTrackingApp.WebApi.Controllers;


[ApiController]
public class BaseController : ControllerBase
{
    protected readonly IMediator _mediator;
    public BaseController(IMediator mediator)
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
