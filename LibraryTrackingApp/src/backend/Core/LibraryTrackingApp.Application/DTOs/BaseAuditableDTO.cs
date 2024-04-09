namespace LibraryTrackingApp.Application.DTOs;

public record BaseAuditableDTO
{
    public Guid Id { get; set; }
    public Guid CreatedById { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    protected BaseAuditableDTO()
    {
        CreatedDate = DateTime.Now;
        LastModifiedDate = DateTime.Now;
    }
}
