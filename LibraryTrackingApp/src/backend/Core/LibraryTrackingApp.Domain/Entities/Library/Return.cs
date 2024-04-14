namespace LibraryTrackingApp.Domain.Entities.Library;

public class Return : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid BorrowId { get; set; } 
    public DateTime ReturnDate { get; set; } 
    public bool IsLate { get; set; } 
    public BookStatus BookStatus { get; set; } 
    public int PenaltyDurationInDays { get; set; } 
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }


    public virtual Borrow Borrow { get; set; }
}
