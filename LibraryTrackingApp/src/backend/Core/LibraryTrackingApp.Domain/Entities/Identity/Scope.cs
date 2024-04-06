namespace LibraryTrackingApp.Domain.Entities.Identity;

/// <summary>
/// Sistemde tanımlanan izinleri temsil eden sınıf.
/// Her izin, sistemdeki belirli bir aksiyona erişimi tanımlar.
/// </summary>
public class Scope : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }

    public ICollection<RoleScope> RoleScopes { get; set; }
}
