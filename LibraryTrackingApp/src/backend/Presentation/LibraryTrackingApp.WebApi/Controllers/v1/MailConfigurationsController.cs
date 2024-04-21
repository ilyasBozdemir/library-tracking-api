using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Commands.Responses;
using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Responses;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/mail-configs")]
public class MailConfigurationsController : CustomBaseController
{
    public MailConfigurationsController(IMediator mediator)
        : base(mediator) { }

    [HttpPost("create-mail-configs")]
    public async Task<IActionResult> CreateMailConfigs([FromBody] CreateMailConfigurationCommandRequest request)
    {

        CreateMailConfigurationCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };

    }

    [HttpDelete("mail-configs/{id}")]
    public async Task<IActionResult> DeleteMailConfigs([FromRoute] Guid Id, [FromBody] DeleteMailConfigurationCommandRequest request)
    {
        DeleteMailConfigurationCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpPut("mail-configs/{Id}")]
    public async Task<IActionResult> UpdateMailConfigs([FromRoute] Guid Id, [FromBody] UpdateMailConfigurationCommandRequest request)
    {
        request.Id = Id;
        UpdateMailConfigurationCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpGet("mail-configs/{id}")]
    public async Task<IActionResult> GetMailConfigs([FromRoute] Guid Id, [FromBody] GetMailConfigurationByIdQueryRequest request)
    {
        request.Id = Id;
        GetMailConfigurationByIdQueryResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpGet("mail-configs")]// [FromQuery] ==> mail-configs?Page=1&PageSize=10
    public async Task<IActionResult> ListMailConfigs([FromQuery] GetListMailConfigurationsQueryRequest request)
    {
        GetListMailConfigurationsQueryResponse commandResponse = await _mediator.Send(request);
        return new JsonResult(new { data = commandResponse })
        {
            StatusCode = commandResponse.StatusCode
        };
    }
}
