namespace LibraryTrackingApp.Application.DataTransferObjects;

public record CreateAuthorDTO : BaseAuditableDTO<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
}
