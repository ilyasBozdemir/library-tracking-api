using LibraryTrackingApp.Application.Features.Commands.BookStock.CreateBookStock;
using LibraryTrackingApp.Application.Features.Commands.BookStock.UpdateBookStock;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-stocks")]
public class BookStocksController : BaseController
{
    public BookStocksController(IMediator mediator) : base(mediator) {}

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookStockCommandRequest request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }



    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateBookCommandRequest request)
    {
        request.Id = id;
        var response = await _mediator.Send(request);
        return Ok(response);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var request = new DeleteBookCommandRequest { Id = id };
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks([FromBody] GetAllBooksQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            return Ok(response.Data);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBook([FromRoute] Guid id)
    {
        var query = new GetBookQueryRequest { BookId = id };
        var response = await _mediator.Send(query);

        if (response != null && response.Data != null)
        {
            return Ok(response.Data);
        }
        else
        {
            return NotFound();
        }
    }
}
