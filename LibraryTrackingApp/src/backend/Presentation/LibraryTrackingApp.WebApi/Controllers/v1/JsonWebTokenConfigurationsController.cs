using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Commands.Responses;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Responses;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

//handler kısmının içleri dolucaktır.

/// <summary>
/// JWT işlemlerini yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/jwt-tokens")]
public class JsonWebTokenConfigurationsController : CustomBaseController
{
    public JsonWebTokenConfigurationsController(IMediator mediator)
        : base(mediator) { }


    [HttpPost("jwt-configs")]
    public async Task<IActionResult> CreateJwtConfigs(CreateJwtConfigurationCommandRequest request)
    {
        CreateJwtConfigurationCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpDelete("jwt-configs")]
    public async Task<IActionResult> DeleteJwtConfigs([FromBody] DeleteJwtConfigurationCommandRequest request)
    {
        DeleteJwtConfigurationCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpPut("jwt-configs/{Id}")]
    public async Task<IActionResult> UpdateJwtConfigs([FromRoute] Guid Id, [FromBody] UpdateJwtConfigurationCommandRequest request)
    {
        request.Id = Id;
        UpdateJwtConfigurationCommandResponse commandResponse = await _mediator.Send(request);
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpGet("jwt-configs/{id}")]
    public async Task<IActionResult> GetJwtConfigs([FromRoute] Guid Id, [FromBody] GetJwtConfigurationByIdQueryRequest request)
    {
        GetJwtConfigurationByIdQueryResponse commandResponse = await _mediator.Send(request);
        return new JsonResult(new { data = commandResponse })
        {
            StatusCode = 200
        };
    }

    [HttpGet("jwt-configs")]
    public async Task<IActionResult> ListJwtConfigs([FromQuery] GetListJwtConfigurationsQueryRequest query)
    {
        GetListJwtConfigurationsQueryResponse commandResponse = await _mediator.Send(query);
        return new JsonResult(new { data = commandResponse })
        {
            StatusCode = 200
        };
    }



}
