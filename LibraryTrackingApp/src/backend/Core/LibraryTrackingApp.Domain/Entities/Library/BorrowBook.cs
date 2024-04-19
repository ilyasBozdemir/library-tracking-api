namespace LibraryTrackingApp.Domain.Entities.Library;


/*   
   public DateTime BorrowDate { get; set; }
   public DateTime DueDate { get; set; }
   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */

public class BorrowBook : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LenderId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public BorrowStatus BorrowStatus { get; set; }
    public bool HasFee { get; set; }
    public decimal FeeAmount { get; set; }
    public TimeSpan TimeElapsedSinceBorrowDate => DateTime.Now - BorrowDate;




    public Book Book { get; set; }
    public BookReturn Return { get; set; }
    public Member Member { get; set; }
    public Staff Lender { get; set; }
}
