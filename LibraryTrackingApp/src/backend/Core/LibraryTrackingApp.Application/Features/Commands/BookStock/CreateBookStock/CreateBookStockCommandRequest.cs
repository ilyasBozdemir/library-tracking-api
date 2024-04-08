namespace LibraryTrackingApp.Application.Features.Commands.BookStock.CreateBookStock;

public class CreateBookStockCommandRequest: IRequest<CreateBookStockCommandResponse>
{
    public Guid BookId { get; set; }
    public int Quantity { get; set; } 

}
