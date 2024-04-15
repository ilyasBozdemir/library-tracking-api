using LibraryTrackingApp.Application.Features.Books.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.Books.Commands.Requests;

public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
{
    public string IdOrISBN { get; set; }
}
