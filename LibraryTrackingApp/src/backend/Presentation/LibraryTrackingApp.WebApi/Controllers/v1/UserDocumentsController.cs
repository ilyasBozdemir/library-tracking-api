using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/user-documents")]
public class UserDocumentsController : CustomBaseController
{
    public UserDocumentsController(IMediator mediator) : base(mediator)
    {
    }

    /*

    [HttpPost("{userId}")]
    public async Task<IActionResult> CreateUserDocument([FromRoute] Guid userId, [FromBody] CreateUserDocumentCommandRequest request)
    {
        request.Id = userId;
        CreateUserDocumentCommandResponse commandResponse = await _mediator.Send(request);
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpPut("{userId}/{documentId}")]
    public async Task<IActionResult> UpdateUserDocument([FromRoute] Guid userId, [FromRoute] Guid documentId, [FromBody] UpdateUserDocumentCommandRequest request)
    {
        request.Id = userId;
        request.DocumentId = documentId;

        UpdateUserDocumentCommandResponse commandResponse = await _mediator.Send(request);

        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpDelete("{userId}/{documentId}")]
    public async Task<IActionResult> DeleteUserDocument([FromRoute] Guid userId, [FromRoute] Guid documentId)
    {
        DeleteUserDocumentCommandResponse commandResponse = await _mediator.Send(new DeleteUserDocumentCommandRequest { Id = userId, DocumentId = documentId });
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpPost("{userId}/{documentId}/share")]
    public async Task<IActionResult> ShareUserDocument([FromRoute] Guid userId, [FromRoute] Guid documentId, [FromBody] ShareUserDocumentCommandRequest request)
    {
        request.Id = userId;
        request.DocumentId = documentId;
        ShareUserDocumentCommandResponse commandResponse = await _mediator.Send(request);
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }


    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUserDocuments([FromRoute] Guid userId)
    {
        GetUserDocumentsQueryResponse commandResponse = await _mediator.Send(new GetUserDocumentsQueryRequest { Id = userId });
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpGet("{userId}/{documentId}")]
    public async Task<IActionResult> GetUserDocument([FromRoute] Guid userId, [FromRoute] Guid documentId)
    {

        GetDocumentByIdQueryResponse commandResponse = await _mediator.Send(new GetDocumentByIdQueryRequest { Id = userId, DocumentId = documentId });
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    
    [HttpGet("{userId}/{documentId}/details")]
    public async Task<IActionResult> GetDocumentDetails([FromRoute] Guid userId, [FromRoute] Guid documentId)
    {
        GetDocumentDetailsQueryResponse commandResponse = await _mediator.Send(new GetDocumentDetailsQueryRequest { UserId = userId, DocumentId = documentId });
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }

    [HttpGet("{userId}/type/{documentType}")]
    public async Task<IActionResult> GetUserDocumentsByType([FromRoute] Guid userId, [FromRoute] string documentType)
    {
        GetUserDocumentsByTypeQueryResponse commandResponse = await _mediator.Send(new GetUserDocumentsByTypeQueryRequest { UserId = userId, DocumentType = documentType });
        return new JsonResult(new { data = commandResponse.Data })
        {
            StatusCode = commandResponse.StatusCode
        };
    }



    */

}
