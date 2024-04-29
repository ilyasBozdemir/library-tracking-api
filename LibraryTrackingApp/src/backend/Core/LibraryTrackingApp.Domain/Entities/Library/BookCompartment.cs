namespace LibraryTrackingApp.Domain.Entities.Library;

public class BookCompartment : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}