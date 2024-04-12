using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Domain.Entities.Identity;
 
public class AppUser : IdentityUser<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }
    public virtual Staff Staff { get; set; }
    public ICollection<AppRole> AppRoles { get; set; }

}