using LibraryTrackingApp.Application.Features.BookGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookGenres.Commands.Requests;

public class DeleteBookGenreCommandRequest : IRequest<DeleteBookGenreCommandResponse>
{
    public string Id { get; set; }
}