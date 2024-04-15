namespace LibraryTrackingApp.Application.Features.Commands.Author;

public class CreateAuthorCommandRequest: IRequest<CreateAuthorCommandResponse>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
}
