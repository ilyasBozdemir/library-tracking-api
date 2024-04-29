using LibraryTrackingApp.Application.Features.BookInventories.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookInventories.Commands.Requests;

public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
{
    public string IdOrISBN { get; set; }
}
