namespace LibraryTrackingApp.Domain.Entities.Library;

public class LibraryBranchMember
{
    public Guid MemberId { get; set; }
    public Guid LibraryBranchId { get; set; }

    public Member Member { get; set; }
    public LibraryBranch LibraryBranch { get; set; }
}
