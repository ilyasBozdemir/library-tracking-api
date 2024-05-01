using LibraryTrackingApp.Application.Features.WorkInventories.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.WorkInventories.Commands.Requests;

public class DeleteBookCommandRequest : IRequest<DeleteBookCommandResponse>
{
    public string IdOrISBN { get; set; }
}
