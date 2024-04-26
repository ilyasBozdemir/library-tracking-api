using LibraryTrackingApp.Domain.Entities.Identity;

namespace LibraryTrackingApp.Domain.Entities.Library;

/*   
      MembershipDat, BirthDate
   
   unix seconds olarak saklanacaktır sonra ki güncellemede.
 */

public class Member : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid UserId { get; set; }
    public DateTime MembershipDate { get; set; } // Üyelik Tarihi
    public GenderType Gender { get; set; } 
    public string Occupation { get; set; } //Meslek
    public MemberType MemberType { get; set; } //Meslek
    
    public int NumberOfLateReturns { get; set; } // Geciken iade sayısı
    public int MaxLateReturnsAllowed { get; set; } // Maksimum geciken iade sayısı izni
    public bool HasPenalty { get; set; } // Ceza durumu
    public int PenaltyDurationInDays { get; set; } // Ceza süresi (gün cinsinden)
    public bool IsExtensionAllowed { get; set; } // Uzatma izni
    public int ExtensionDurationInDays { get; set; } // Uzatma süresi (gün cinsinden)

    public Guid BorrowId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public AppUser User { get; set; }


    public virtual ICollection<LibraryBranch> LibraryBranches { get; set; }
    public virtual ICollection<BorrowBook> Borrows { get; set; }
}
