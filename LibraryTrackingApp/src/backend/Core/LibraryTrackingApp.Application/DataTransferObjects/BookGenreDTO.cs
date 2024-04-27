namespace LibraryTrackingApp.Application.DataTransferObjects;

public record BookGenreDTO: BaseAuditableDTO<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } 
}
