namespace LibraryTrackingApp.Domain.Entities.Identity;

public class RoleScope : BaseEntity<Guid>
{
    public AppRole Role { get; set; } // nav property

    public Guid RoleId { get; set; }
    public Guid ScopeId { get; set; }
    public Scope Scope { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }

}
