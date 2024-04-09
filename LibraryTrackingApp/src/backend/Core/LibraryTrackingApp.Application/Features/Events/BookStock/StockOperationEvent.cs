using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.Events.BookStock;

public class StockOperationEvent : BaseEvent
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }
    public StockOperationType OperationType { get; set; }
}

