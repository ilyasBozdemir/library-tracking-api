using LibraryTrackingApp.Application.Features.BookGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookGenres.Commands.Requests;

public class CreateBookGenreCommandRequest : IRequest<CreateBookGenreCommandResponse>
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
}
