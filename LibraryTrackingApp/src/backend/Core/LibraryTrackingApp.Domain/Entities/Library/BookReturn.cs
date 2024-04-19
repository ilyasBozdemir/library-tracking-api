namespace LibraryTrackingApp.Domain.Entities.Library;

/*   
       public DateTime ReturnDate { get; set; }

   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */
public class BookReturn : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid BorrowId { get; set; }
    public DateTime ReturnDate { get; set; }
    public bool IsLate { get; set; }
    public BookStatus BookStatus { get; set; }
    public int PenaltyDurationInDays { get; set; }

    public virtual BorrowBook Borrow { get; set; }
}
