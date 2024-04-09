namespace LibraryTrackingApp.Application.Features.Commands.BookStock.UpdateBookStock;

public class UpdateBookStockCommandRequest : IRequest<UpdateBookStockCommandResponse>
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; }

}
