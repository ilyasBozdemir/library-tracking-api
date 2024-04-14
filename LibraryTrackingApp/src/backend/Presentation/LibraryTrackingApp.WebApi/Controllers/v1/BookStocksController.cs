using LibraryTrackingApp.Application.Features.Commands.StockOperation;
using LibraryTrackingApp.Application.Features.Events.BookStock;
using LibraryTrackingApp.Application.Features.Queries.BookStock.GetAllBookStocks;
using LibraryTrackingApp.Application.Features.Queries.BookStock.GetBookStock;
using LibraryTrackingApp.Domain.Enums;
using LibraryTrackingApp.Infrastructure.Mvc;

namespace LibraryTrackingApp.WebApi.Controllers.v1;

// mediator notification kısmı daha düzene oturtulcaktır.


/// <summary>
/// Kitap stoklarını yönetmek için Controller.
/// </summary>
[ApiController]
[ApiVersion(ApiVersions.V1)]
[Route($"api/v{ApiVersions.V1}/book-stocks")]
public class BookStocksController : CustomBaseController
{
    public BookStocksController(IMediator mediator)
        : base(mediator) { }

    /// <summary>
    /// Belirli bir kitabın stok miktarını artırır.
    /// </summary>
    /// <param name="bookId">Stoğu artırılacak kitabın ID'si.</param>
    /// <param name="quantity">Artırılacak miktar.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost("increase")]
    public async Task<IActionResult> IncreaseStock(Guid bookId, int quantity)
    {
        var response = await _mediator.Send(
            new StockOperationCommandRequest()
            {
                Quantity = quantity,
                OperationType = StockOperationType.Increase,
                BookId = bookId
            }
        );

        await _mediator.Publish(
            new StockOperationEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                BookId = bookId,
                Quantity = quantity,
                OperationType = StockOperationType.Increase,
            }
        );

        return new JsonResult(new { data = response.Data })
        {
            StatusCode = response.StatusCode
        };
    }

    /// <summary>
    /// Belirli bir kitabın stok miktarını azaltır.
    /// </summary>
    /// <param name="bookId">Stoğu azaltılacak kitabın ID'si.</param>
    /// <param name="quantity">Azaltılacak miktar.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpPost("decrease")]
    public async Task<IActionResult> DecreaseStock(Guid bookId, int quantity)
    {
        var response = await _mediator.Send(
            new StockOperationCommandRequest()
            {
                Quantity = quantity,
                OperationType = StockOperationType.Decrease,
                BookId = bookId
            }
        );
        await _mediator.Publish(
            new StockOperationEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                BookId = bookId,
                Quantity = quantity,
                OperationType = StockOperationType.Decrease,
            }
        );
        return new JsonResult(new { data = response.Data })
        {
            StatusCode = response.StatusCode
        };
    }

    /// <summary>
    /// Belirli bir kitabın stok bilgisini alır.
    /// </summary>
    /// <param name="bookId">Stoğu alınacak kitabın ID'si.</param>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet("get/{bookId}")]
    public async Task<IActionResult> GetBookStockInfo(Guid bookId)
    {
        var response = await _mediator.Send(new GetBookStockInfoQueryRequest() { BookId = bookId });
        await _mediator.Publish(
            new StockOperationEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                BookId = bookId,
                OperationType = StockOperationType.Decrease,
            }
        );
        return new JsonResult(new { data = response.Data })
        {
            StatusCode = response.StatusCode
        };
    }

    /// <summary>
    /// Tüm kitap stoklarını alır.
    /// </summary>
    /// <returns>İşlemin sonucunu temsil eden ActionResult.</returns>
    [HttpGet]
    public async Task<IActionResult> GetAllBookStocks()
    {
        var response = await _mediator.Send(new GetAllBookStockQueryRequest());

        await _mediator.Publish(
            new StockOperationEvent()
            {
                Errors = response.Errors,
                IsSuccessful = response.Success,
                OperationType = StockOperationType.Decrease,
            }
        );
        return new JsonResult(new { data = response.Data })
        {
            StatusCode = response.StatusCode
        };
    }
}
