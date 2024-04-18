namespace LibraryTrackingApp.Domain.Entities.Library;

public class BookTag : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}
