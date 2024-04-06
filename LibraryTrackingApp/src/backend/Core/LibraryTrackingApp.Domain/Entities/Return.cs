using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.Domain.Entities;

public class Return : BaseEntity<Guid>
{
    public Guid LoanId { get; set; } // borç id
    public DateTime ReturnDate { get; set; } // iade tarihi
    public bool IsLate { get; set; } // Geciken iade mi?
    public BookStatus BookStatus { get; set; } // Durumu
    public int PenaltyDurationInDays { get; set; } // Uygulanan ceza süresi (gün cinsinden)
}
