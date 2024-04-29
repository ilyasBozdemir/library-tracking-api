namespace LibraryTrackingApp.Domain.Entities.Library;


//bookstock tablosu kalkıcaktır. stokları teker teker aynı kitapta da verilen numaralar ile ayırarak burda da bunu girerek
// yapılcaktır stok adedi bu şekilde olucaktır.
public class BookInventory : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid BorrowLendId { get; set; }

    public Guid? BookCompartmentId { get; set; }
    public string BookNumber { get; set; }
    public BookStatus BookStatus { get; set; }
    public bool IsAvailable { get; set; }

    public long TransactionDateUnix { get; set; } 
    public BookStockTransactionType BookStockTransactionType { get; set; }

    public string Description { get; set; }
    public string Notes { get; set; } 

    public BookCatalog Book { get; set; }
    public virtual ICollection<BorrowLend> BorrowLends { get; set; }

    public virtual BookCompartment BookCompartment { get; set; }
}
