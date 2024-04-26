using LibraryTrackingApp.Domain.Entities.Library;

namespace LibraryTrackingApp.Domain.Entities.Identity;


public class AppUser : IdentityUser<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public string Address { get; set; }
    public DateTime? BirthDate { get; set; }
    public GenderType Gender { get; set; }
    public byte[] ProfilePicture { get; set; }

    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }


    public Guid LastModifiedById { get; set; }
    public Guid IsDeletedById { get; set; }
    public Guid CreatedById { get; set; }
    public long CreatedDateUnix { get; set; }
    public long? LastModifiedDateUnix { get; set; }
    public long? DeletedDateUnix { get; set; }

    public bool IsDeleted { get; set; }


    public virtual Staff Staff { get; set; }
    public virtual Member Member { get; set; }
    public ICollection<AppRole> AppRoles { get; set; }

}