namespace LibraryTrackingApp.Application.Features.Commands.StockOperation;

public class StockOperationCommandRequest : IRequest<StockOperationResponse>
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }
    public StockOperationType OperationType { get; set; }
}