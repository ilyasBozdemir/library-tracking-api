using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Commands.Requests;

public class DeleteBookGenreCommandRequest : IRequest<DeleteBookGenreCommandResponse>
{
    public string Id { get; set; }
}