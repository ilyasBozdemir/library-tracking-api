namespace LibraryTrackingApp.Application.DataTransferObjects;

public record CreateBookGenreDTO  : BaseAuditableDTO<Guid>
{
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;
}
