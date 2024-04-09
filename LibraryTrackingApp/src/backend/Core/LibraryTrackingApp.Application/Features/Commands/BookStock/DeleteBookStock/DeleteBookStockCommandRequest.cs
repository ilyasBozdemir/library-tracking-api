namespace LibraryTrackingApp.Application.Features.Commands.BookStock.DeleteBookStock;

public class DeleteBookStockCommandRequest : IRequest<DeleteBookStockCommandResponse>
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }

}
