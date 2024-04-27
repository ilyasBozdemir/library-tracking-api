using LibraryTrackingApp.Application.Features.BookGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookGenres.Commands.Requests;

public class UpdateBookGenreCommandRequest : IRequest<UpdateBookGenreCommandResponse>
{
    public Guid UpdatedId { get; set; }

    public string Name { get; set; }
    public bool IsActive { get; set; }
}