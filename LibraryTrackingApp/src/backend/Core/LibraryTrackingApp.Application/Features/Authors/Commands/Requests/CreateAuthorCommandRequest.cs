using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Requests;

public class CreateAuthorCommandRequest : IRequest<CreateAuthorCommandResponse>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
    public string Website { get; set; }
}
