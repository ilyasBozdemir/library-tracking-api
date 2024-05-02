namespace LibraryTrackingApp.Application.DataTransferObjects;

public record AuthorDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }
    public string Website { get; set; }
}
