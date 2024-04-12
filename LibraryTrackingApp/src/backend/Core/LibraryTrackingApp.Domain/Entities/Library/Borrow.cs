namespace LibraryTrackingApp.Domain.Entities.Library;

// Borrow entity
public class Borrow : BaseEntity<Guid>
{
    public Guid Id { get; set; } // borç Id
    public Guid BookId { get; set; } //kitap id
    public Guid MemberId { get; set; } // Ödünç alan üyenin ID'si
    public Guid LenderId { get; set; } // Ödünç veren personelin ID'si
    public DateTime BorrowDate { get; set; } // Ödünç alma tarihi
    public DateTime DueDate { get; set; } // bitiş tarihi
    public BorrowStatus BorrowStatus { get; set; } // Ödünç alma işlemi durumu
    public bool HasFee { get; set; } // ücretli mi

    public TimeSpan TimeElapsedSinceBorrowDate => DateTime.Now - BorrowDate; // geçen süre

    // Ödünç alınan kitaba olan ilişki
    public virtual Book Book { get; set; }
    public virtual Return Return { get; set; }
    public virtual Member Member { get; set; }
    public virtual Staff Lender { get; set; }
}
