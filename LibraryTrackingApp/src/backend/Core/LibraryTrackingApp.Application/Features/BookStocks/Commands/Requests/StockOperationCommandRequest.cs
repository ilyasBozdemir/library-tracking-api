using LibraryTrackingApp.Application.Features.BookStocks.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookStocks.Commands.Requests;

public class StockOperationCommandRequest : IRequest<StockOperationCommandResponse>
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }
    public StockOperationType OperationType { get; set; }
}