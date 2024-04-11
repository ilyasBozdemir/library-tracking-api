namespace LibraryTrackingApp.Domain.Entities.Library;

public class LibraryTransaction : BaseEntity<Guid>
{
    public DateTime TransactionDate { get; set; }
    public string TransactionType { get; set; }
    public string Details { get; set; }
    public Guid LibraryBranchId { get; set; } 

    public virtual LibraryBranch LibraryBranch { get; set; }
}