namespace LibraryTrackingApp.Domain.Entities.Library;

public class BookGenre : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<BookCatalog> Books { get; set; }
}
