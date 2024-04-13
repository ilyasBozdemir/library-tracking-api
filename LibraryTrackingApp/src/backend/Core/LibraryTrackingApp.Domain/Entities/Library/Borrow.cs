namespace LibraryTrackingApp.Domain.Entities.Library;


public class Borrow : BaseEntity<Guid>,IAuditable<Guid>
{
    public Guid Id { get; set; } 
    public Guid BookId { get; set; } 
    public Guid MemberId { get; set; } 
    public Guid LenderId { get; set; } 
    public DateTime BorrowDate { get; set; } 
    public DateTime DueDate { get; set; }
    public BorrowStatus BorrowStatus { get; set; }
    public bool HasFee { get; set; } 

    public TimeSpan TimeElapsedSinceBorrowDate => DateTime.Now - BorrowDate;

    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }


    public  Book Book { get; set; }
    public  Return Return { get; set; }
    public  Member Member { get; set; }
    public  Staff Lender { get; set; }
}
