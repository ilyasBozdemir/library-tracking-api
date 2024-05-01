using LibraryTrackingApp.Application.Features.WorkGenres.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.WorkGenres.Commands.Requests;

public class UpdateBookGenreCommandRequest : IRequest<UpdateBookGenreCommandResponse>
{
    public Guid UpdatedId { get; set; }

    public string Name { get; set; }
    public bool IsActive { get; set; }
}