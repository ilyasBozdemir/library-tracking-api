namespace LibraryTrackingApp.Domain.Entities.Library;

//kullanımdan kaldırılcak.
public class BookStockOLD : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public int Quantity { get; set; }

    public virtual BookCatalog Book { get; set; }
}
