using LibraryTrackingApp.Application.Features.Events.Book;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/books")]
public class BooksController : BaseController
{
    public BooksController(IMediator mediator) : base(mediator) {}



    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookCommandRequest request)
    {
        var response = await _mediator.Send(request);
        await _mediator.Publish(new BookCommandEvent()
        {
            Errors = response.Errors,
            IsSuccessful = response.Success,
            RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.Create
        });
        return Ok(response);
    }



    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateBookCommandRequest request)
    {
        request.Id = id;
        var response = await _mediator.Send(request);

        await _mediator.Publish(new BookCommandEvent()
        {
            Errors = response.Errors,
            IsSuccessful = response.Success,
            EntityId = id.ToString(),
            RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.Update
        });
        return Ok(response);
    }



    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var request = new DeleteBookCommandRequest { Id = id };
        var response = await _mediator.Send(request);

        await _mediator.Publish(new BookCommandEvent()
        {
            Errors = response.Errors,
            IsSuccessful = response.Success,
            EntityId = id.ToString(),
            RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.Delete
        });
        return Ok(response);
    }



    [HttpGet]
    public async Task<IActionResult> GetAllBooks([FromBody] GetAllBooksQueryRequest request)
    {
        var response = await _mediator.Send(request);

        if (response != null && response.Data != null)
        {
            await _mediator.Publish(new BookCommandEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.GetAll

            });
            return Ok(response.Data);
        }
        else
        {
            await _mediator.Publish(new BookCommandEvent()
            {
                Errors = response.Errors,
                IsSuccessful = false,
                RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.GetAll

            });
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
            await _mediator.Publish(new BookCommandEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.Get

            });
            return Ok(response.Data);
        }
        else
        {
            await _mediator.Publish(new BookCommandEvent()
            {
                Errors = response.Errors,
                IsSuccessful = false,
                RequestNotificationType = LibraryTrackingApp.Domain.Enums.RequestNotificationType.Get
            });
            return NotFound();
        }
    }
}
