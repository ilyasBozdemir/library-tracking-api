namespace LibraryTrackingApp.Application.Features.Commands.Book;

public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
{
    public string IdOrISBN { get; set; }
}
