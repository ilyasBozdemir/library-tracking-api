using LibraryTrackingApp.Domain.Entities.Identity;

namespace LibraryTrackingApp.Domain.Entities.Library;

public class Staff : BaseEntity<Guid>
{
    public Guid UserId { get; set; } 
    public string Phone { get; set; }
    public string Address { get; set; } 
    public DateTime EmploymentDate { get; set; }
    public decimal Salary { get; set; } 
    public bool IsFullTime { get; set; }

    public virtual LibraryBranch LibraryBranch { get; set; }
    public AppUser User { get; set; }
}
