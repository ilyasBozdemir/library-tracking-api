namespace LibraryTrackingApp.Domain.Entities.Library;


/*   
   public DateTime BorrowDate { get; set; }
   public DateTime DueDate { get; set; }
   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */

public class BorrowLend : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid WorkCatalogId { get; set; }
    public Guid? WorkInventoryId { get; set; }
    public Guid MemberId { get; set; }
    public Guid StaffLenderId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; } 
    public DateTime? ReturnDate { get; set; }
    public BorrowStatus BorrowStatus { get; set; }
    
    public bool HasFee { get; set; }
    public decimal FeeAmount { get; set; }
  
    public bool? IsLate { get; set; }
    public int? LateDurationInDays { get; set; }


    public WorkInventory? WorkInventory { get; set; }
    public WorkCatalog WorkCatalog { get; set; }
    public Member Member { get; set; }
    public Staff StaffLender { get; set; }
}
