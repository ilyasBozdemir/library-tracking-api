namespace LibraryTrackingApp.Application.Features.Commands.Book.DeleteBook;

public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
{
    public string IdOrISBN { get; set; } 
}
