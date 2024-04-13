using LibraryTrackingApp.Domain.Entities.Identity;

namespace LibraryTrackingApp.Domain.Entities.Library;

public class Staff : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid UserId { get; set; } 
    public string Phone { get; set; }
    public string Address { get; set; } 
    public DateTime EmploymentDate { get; set; }
    public decimal Salary { get; set; } 
    public bool IsFullTime { get; set; }
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    public Guid LibraryBranchId { get; set; }
    public  LibraryBranch LibraryBranch { get; set; }
    public AppUser User { get; set; }
}
