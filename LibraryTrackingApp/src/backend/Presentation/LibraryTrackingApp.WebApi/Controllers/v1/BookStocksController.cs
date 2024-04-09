using LibraryTrackingApp.Application.Features.Commands.StockOperation;
using LibraryTrackingApp.Application.Features.Events.BookStock;
using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-stocks")]
public class BookStocksController : BaseController
{
    public BookStocksController(IMediator mediator) : base(mediator) {}


    [HttpPost("increase")]
    public async Task<IActionResult> IncreaseStock(Guid bookId, int quantity)
    {
        var response = await _mediator.Send(new StockOperationCommandRequest()
        {
            Quantity = quantity,
            OperationType = StockOperationType.Increase,
            BookId = bookId
        });

        await _mediator.Publish(new StockOperationEvent()
        {
            Errors = response.Errors,
            IsSuccessful = response.Success,
            BookId = bookId,
            Quantity = quantity,
            OperationType= StockOperationType.Increase,
        });

        return Ok(response);
    }

    [HttpPost("decrease")]
    public async Task<IActionResult> DecreaseStock(Guid bookId, int quantity)
    {
        var response = await _mediator.Send(new StockOperationCommandRequest()
        {
            Quantity = quantity,
            OperationType = StockOperationType.Decrease,
            BookId = bookId
        });
        await _mediator.Publish(new StockOperationEvent()
        {
            Errors = response.Errors,
            IsSuccessful = response.Success,
            BookId = bookId,
            Quantity = quantity,
            OperationType = StockOperationType.Decrease,
        });
        return Ok(response);
    }

    [HttpGet("{bookId}")]
    public async Task<IActionResult> GetBookStockInfo(Guid bookId)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBookStocks()
    {
        return Ok();
    }

}
