namespace LibraryTrackingApp.Domain.Entities.Library;

public class Tag : BaseEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}
