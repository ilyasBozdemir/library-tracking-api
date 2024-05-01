using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Commands.Requests;

public class CreateBookGenreCommandRequest : IRequest<CreateBookGenreCommandResponse>
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
}
