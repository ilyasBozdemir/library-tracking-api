namespace LibraryTrackingApp.Domain.Entities.Library;


public class Book : BaseEntity<Guid>
{
    public string Title { get; set; } // başlık
    public string Author { get; set; } // yazar
    public string ISBN { get; set; } //isbn
    public int PageCount { get; set; } //sayfa sayısı
    public string Publisher { get; set; } // yayıncı
    public DateTime PublicationDate { get; set; } //yayın tarihi
    public BookStatus Status { get; set; } // Kitap durumu
    public bool IsDamaged { get; set; } // Hasar durumu
    public int StockCount { get; set; } // Stok durumu
}