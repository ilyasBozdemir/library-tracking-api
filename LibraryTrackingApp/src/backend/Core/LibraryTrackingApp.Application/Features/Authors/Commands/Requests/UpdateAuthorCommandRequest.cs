using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Requests;

public class UpdateAuthorCommandRequest : IRequest<UpdateAuthorCommandResponse>
{
    public Guid UpdatedId { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
}
