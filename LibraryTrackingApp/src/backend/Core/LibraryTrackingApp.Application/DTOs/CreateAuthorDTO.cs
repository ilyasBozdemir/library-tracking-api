namespace LibraryTrackingApp.Application.DTOs;

public record CreateAuthorDTO : BaseAuditableDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
}
