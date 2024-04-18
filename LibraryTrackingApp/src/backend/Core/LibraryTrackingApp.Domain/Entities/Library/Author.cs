using LibraryTrackingApp.Domain.Interfaces;

namespace LibraryTrackingApp.Domain.Entities.Library;

public class Author : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public string Biography { get; set; }

    public ICollection<Book> Books { get; set; }
}
