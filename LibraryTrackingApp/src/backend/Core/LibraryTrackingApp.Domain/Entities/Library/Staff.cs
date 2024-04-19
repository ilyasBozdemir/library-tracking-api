using LibraryTrackingApp.Domain.Entities.Identity;

namespace LibraryTrackingApp.Domain.Entities.Library;
/*   
      public DateTime EmploymentDate { get; set; }


   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */
public class Staff : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid UserId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateTime EmploymentDate { get; set; }
    public decimal Salary { get; set; }
    public bool IsFullTime { get; set; }

    public LibraryBranch LibraryBranch { get; set; }
    public AppUser User { get; set; }
}
