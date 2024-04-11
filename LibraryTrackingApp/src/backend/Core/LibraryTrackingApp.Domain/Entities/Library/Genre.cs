namespace LibraryTrackingApp.Domain.Entities.Library;

public class Genre : BaseEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;

    public virtual Book Book { get; set; }
}
