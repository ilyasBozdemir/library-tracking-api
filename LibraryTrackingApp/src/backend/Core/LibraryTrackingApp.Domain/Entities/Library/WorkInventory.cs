namespace LibraryTrackingApp.Domain.Entities.Library;


public class WorkInventory : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid? WorkCatalogId { get; set; }
    public Guid? BorrowLendId { get; set; }
    public Guid EditionId { get; set; } // Eserin türü
    public Guid? ShelfId { get; set; }
    public Guid? WorkCompartmentId { get; set; }
    public string BookNumber { get; set; }
    public WorkStatus BookStatus { get; set; }
    public bool IsAvailable { get; set; }
    public string? Donor { get; set; } // Bağışçı


    public BookStockTransactionType BookStockTransactionType { get; set; }

    public string? Description { get; set; }
    public string? Notes { get; set; } 

    public Shelf Shelf { get; set; }
    public WorkCatalog WorkCatalog { get; set; }

    public ICollection<Edition> Editions { get; set; } // Baskılar

    public virtual ICollection<BorrowLend>? BorrowLends { get; set; }

    public virtual WorkCompartment WorkCompartment { get; set; }
}
