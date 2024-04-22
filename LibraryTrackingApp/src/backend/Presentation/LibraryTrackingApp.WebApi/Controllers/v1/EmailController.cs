using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/email")]
public class EmailController : CustomBaseController
{
    public EmailController(IMediator mediator) : base(mediator)
    {
    }



    //[HttpPost("send")]
    //public async Task<IActionResult> SendMail(SendEmailCommandRequest request)
    //{
    //    SendEmailCommandResponse commandResponse = await _mediator.Send(request);

    //    return new JsonResult(new { data = commandResponse.Data })
    //    {
    //        StatusCode = commandResponse.StatusCode
    //    };
    //}
}
