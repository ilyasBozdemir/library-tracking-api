using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.BookStocks.Events;

public class StockOperationEvent : BaseEvent
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }
    public StockOperationType OperationType { get; set; }
}

