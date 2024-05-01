namespace LibraryTrackingApp.Domain.Entities.Library;

public class Edition : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; } // Baskı ID'si
    public Guid WorkInventoryId { get; set; } // Baskının hangi esere ait olduğu
    public Guid PublisherId { get; set; } // Baskının yayıncısının kimliği
    public int EditionNumber { get; set; } // Baskı numarası (örneğin, 1. Baskı, 2. Baskı gibi)
    public DateTime PublicationDate { get; set; } // Baskının yayımlanma tarihi
    public string Notes { get; set; } // Ek notlar veya açıklamalar

    public ICollection<WorkInventory> WorkInventories { get;set; }
    public WorkPublisher Publisher { get; set; } // Baskının yayıncısı
}
