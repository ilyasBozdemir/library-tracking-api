namespace LibraryTrackingApp.Domain.Entities.Library;

public class Return : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid LoanId { get; set; } // borç id
    public DateTime ReturnDate { get; set; } // iade tarihi
    public bool IsLate { get; set; } // Geciken iade mi?
    public BookStatus BookStatus { get; set; } // Durumu
    public int PenaltyDurationInDays { get; set; } // Uygulanan ceza süresi (gün cinsinden)
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // İade edilen ödünçe olan ilişki
    public virtual Borrow Borrow { get; set; }
}
