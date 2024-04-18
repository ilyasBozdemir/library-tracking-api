namespace LibraryTrackingApp.Domain.Entities.Library;

public class LibraryTransaction : BaseEntity<Guid>, IAuditable<Guid>
{
    public DateTime TransactionDate { get; set; }
    public TransactionType TransactionType { get; set; }
    public string Details { get; set; }
    public Guid LibraryBranchId { get; set; }


    public virtual LibraryBranch LibraryBranch { get; set; }
}