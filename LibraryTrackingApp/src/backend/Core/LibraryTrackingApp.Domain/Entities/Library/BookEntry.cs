namespace LibraryTrackingApp.Domain.Entities.Library;


//bookstock tablosu kalkıcaktır. stokları teker teker aynı kitapta da verilen numaralar ile ayırarak burda da bunu girerek
// yapılcaktır stok adedi bu şekilde olucaktır.
public class BookEntry : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookNumber { get; set; }
    public BookStatus BookStatus { get; set; }
    public BookFormat BookFormat { get; set; }
    public BookLanguage BookLanguage { get; set; }
    public bool IsAvailable { get; set; }

    public DateTime EntryDate { get; set; }
    public DateTime LastModified { get; set; }

    public Book Book { get; set; }
}
