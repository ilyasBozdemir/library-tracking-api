namespace LibraryTrackingApp.Domain.Entities.Library;

public class WorkTag : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<WorkCatalog> Books { get; set; }
}
