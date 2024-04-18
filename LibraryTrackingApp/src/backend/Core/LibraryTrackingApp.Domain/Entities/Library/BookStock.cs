namespace LibraryTrackingApp.Domain.Entities.Library;

public class BookStock : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public int Quantity { get; set; }

    public virtual Book Book { get; set; }
}
