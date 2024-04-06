using LibraryTrackingApp.Domain.Enums;

namespace LibraryTrackingApp.Domain.Entities.Library;

// Loan entity
public class Loan : BaseEntity<Guid>
{
    public Guid Id { get; set; } // borç Id
    public Guid BookId { get; set; } //kitap id
    public DateTime BorrowDate { get; set; } //Ödünç Alma Tarihi
    public DateTime DueDate { get; set; } // bitiş tarihi
    public BookStatus BookStatus { get; set; } // Durumu
    public bool HasFee { get; set; } // ücretli mi

    public TimeSpan TimeElapsedSinceBorrowDate => DateTime.Now - BorrowDate; // geçen süre
}
