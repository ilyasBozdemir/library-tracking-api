namespace LibraryTrackingApp.Domain.Entities.Library;


public class BookStock : BaseEntity<Guid>
{
    public Guid BookId { get; set; } // Kitap ID
    public int Quantity { get; set; } // Stok miktarı
}
