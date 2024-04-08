using LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;
using LibraryTrackingApp.Application.Features.Commands.Book.DeleteBook;
using LibraryTrackingApp.Application.Features.Commands.Book.UpdateBook;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class BooksController : BaseController
{
    public BooksController(IMediator mediator) : base(mediator)
    {

    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateBookCommandRequest request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateBookCommandRequest request)
    {
        request.Id = id;
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var request = new DeleteBookCommandRequest { Id = id };
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}
